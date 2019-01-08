using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using KR.Models;
using System.Data;
using KR.Models.Database;
using KR.Models.ViewModel;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;

namespace KR.Controllers
{
    public class HomeController : Controller
    {
        private KRContext _dbContext;
        public HomeController(KRContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IActionResult> Index()
        {
            var types = await _dbContext.Set<ProblemType>()
                                        .AsNoTracking()
                                        .ToArrayAsync();
            return View(types);
        }


        [HttpGet]
        [Route("{typeId:int}")]
        public async Task<IActionResult> Problem(int typeId)
        {
            try
            {
                ViewBag.TypeId = typeId;
                var typeIdParam = new SqlParameter("@typeIdParam", typeId);
                var query = @"
                            SELECT PROBLEM.*
                            FROM
                            PROBLEM_TYPE
                            JOIN PROBLEM on PROBLEM_TYPE.Id = PROBLEM.TypeId
                            where PROBLEM_TYPE.Id = @typeIdParam
                            ORDER BY PROBLEM.CreationDate DESC";
                var problems = await _dbContext.Set<Problem>()
                                                .FromSql(query, typeIdParam)
                                                .AsNoTracking()
                                                .ToArrayAsync();
                return View(problems);

            }
            catch
            {
                return RedirectToAction("Index");
            }
        }


        [HttpPost]
        [Route("problem")]
        public async Task<IActionResult> AddProblem(Problem problem)
        {
            try
            {
                problem.CreationDate = DateTime.Now;
                _dbContext.Set<Problem>().Add(problem);
                await _dbContext.SaveChangesAsync();
                return RedirectToAction("Problem", new { typeId = problem.TypeId });
            }
            catch
            {
                return RedirectToAction("Index");
            }
        }


        [HttpPost]
        [Route("deleteproblem")]
        public async Task<IActionResult> DeleteProblem(Problem problem)
        {
            try
            {
                _dbContext.Set<Problem>().Remove(problem);
                await _dbContext.SaveChangesAsync();
                return RedirectToAction("Problem", new { typeId = problem.TypeId });
            }
            catch
            {
                return RedirectToAction("Index");
            }
        }



        [HttpPost]
        [Route("updateproblem")]
        public async Task<IActionResult> UpdateProblem(ProblemVm problemVm)
        {
            try
            {
                var problem = await _dbContext.Set<Problem>()
                                              .Where(x => x.Id == problemVm.Id)
                                              .FirstOrDefaultAsync();
                if (!string.IsNullOrWhiteSpace(problemVm.Status))
                {
                    problem.Status = problemVm.Status;
                }
                if (!string.IsNullOrWhiteSpace(problemVm.Title))
                {
                    problem.Title = problemVm.Title;
                }
                await _dbContext.SaveChangesAsync();
                return RedirectToAction("Problem", new { typeId = problem.TypeId });
            }
            catch
            {
                return RedirectToAction("Index");
            }
        }

        [HttpGet]
        [Route("info/{problemId:int}")]
        public async Task<IActionResult> Info(int problemId)
        {
            try
            {
                var problem = await _dbContext.Set<Problem>()
                                        .Where(x => x.Id == problemId)
                                        .FirstOrDefaultAsync();
                ViewBag.ProblemTitle = problem.Title;
                ViewBag.ProblemId = problemId;
                ViewBag.TypeId = problem.TypeId;
                var problemIdParam = new SqlParameter("@problemIdParam", problemId);
                var query = @"
                            SELECT 
                                COMMENT.Id,
                                Text,
                                Date,
                                PROBLEM.Title as ProblemTitle,
                                ProblemId,
                                SenderId, 
                                (SENDER.FirstName +' ' +SENDER.LastName) as SenderName
                            FROM PROBLEM
                            LEFT JOIN COMMENT on COMMENT.ProblemId = PROBLEM.Id
                            JOIN SENDER on SENDER.Id = COMMENT.SenderId
                            where PROBLEM.Id = @problemIdParam";
                var comments = await _dbContext.Set<CommentVm>()
                                                .FromSql(query, problemIdParam)
                                                .AsNoTracking()
                                                .ToArrayAsync();
                return View("Comment", comments);
            }
            catch
            {
                return RedirectToAction("Index");
            }
        }


        [HttpPost]
        [Route("comment")]
        public async Task<IActionResult> AddComment(Comment comment)
        {
            try
            {
                comment.Date = DateTime.Now;
                _dbContext.Add(comment);
                await _dbContext.SaveChangesAsync();
                return new EmptyResult();
            }
            catch
            {
                return RedirectToAction("Index");
            }
        }

        [HttpDelete]
        [Route("delete/{commentId:int}")]
        public async Task<IActionResult> DeleteComment(int commentId)
        {
            try
            {
                var comment = await _dbContext.Set<Comment>()
                                        .Where(x => x.Id == commentId)
                                        .FirstOrDefaultAsync();
                _dbContext.Set<Comment>().Remove(comment);
                await _dbContext.SaveChangesAsync();
                return View();
            }
            catch
            {
                return RedirectToAction("Index");
            }
        }


        [HttpPut]
        [Route("comment")]
        public async Task<IActionResult> EditComment(Comment comment)
        {
            try
            {
                var commentNew = await _dbContext.Set<Comment>()
                                       .Where(x => x.Id == comment.Id)
                                       .FirstOrDefaultAsync();
                commentNew.Text = comment.Text;
                await _dbContext.SaveChangesAsync();
                return View();
            }
            catch
            {
                return RedirectToAction("Index");
            }
        }

        [HttpGet]
        [Route("sender/{commentId:int}")]
        public async Task<IActionResult> GetSender(int commentId)
        {
            try
            {
                var commentIdParam = new SqlParameter("@commentIdParam", commentId);
                var query = @"
                            SELECT SENDER.*
                            FROM COMMENT
                            RIGHT JOIN SENDER on SENDER.Id = COMMENT.SenderId
                            where COMMENT.Id=@commentIdParam";
                var result = await _dbContext.Set<Sender>()
                                             .FromSql(query, commentIdParam)
                                             .ToArrayAsync();
                return View();
            }
            catch
            {
                return RedirectToAction("Index");
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


    }
}
