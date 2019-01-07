using System;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using KR.Models.Database;
using KR.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace KR.Controllers
{
    [Route("api/problem")]
    public class ProblemController : Controller
    {
        private KRContext _dbContext;
        public ProblemController(KRContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        [Route("{typeId:int}")]
        public async Task<IActionResult> Problem(int typeId)
        {
            var typeIdParam = new SqlParameter("@typeIdParam", typeId);
            var query = @"
                            SELECT PROBLEM.*
                            FROM
                            PROBLEM_TYPE
                            JOIN PROBLEM on PROBLEM_TYPE.Id = PROBLEM.TypeId
                            where PROBLEM_TYPE.Id = @typeIdParam";
            var problems = await _dbContext.Set<Problem>()
                                            .FromSql(query, typeIdParam)
                                            .ToArrayAsync();
            return View(problems);
        }


        [HttpGet]
        [Route("info/{problemId:int}")]
        public async Task<IActionResult> Info(int problemId)
        {
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
                                            .ToArrayAsync();
            return View("Comment", comments);
        }

        [HttpPost]
        [Route("add")]
        public async Task<IActionResult> AddProblem(Problem problem)
        {
            problem.CreationDate = DateTime.Now;
            _dbContext.Set<Problem>().Add(problem);
            await _dbContext.SaveChangesAsync();
            var problems = await _dbContext.Set<Problem>()
                                            .ToArrayAsync();
            return View("Problem", problems);
        }
        [HttpDelete]
        [Route("delete/{problemId:int}")]
        public async Task<IActionResult> Delete(int problemId)
        {
            var problem = await _dbContext.Set<Problem>()
                                    .Where(x => x.Id == problemId)
                                    .FirstOrDefaultAsync();
            _dbContext.Set<Problem>().Remove(problem);
            await _dbContext.SaveChangesAsync();
            var problems = await _dbContext.Set<Problem>()
                                           .ToArrayAsync();
            return View("Problem", problems);
        }


        [HttpPut]
        public async Task<IActionResult> Edit(Problem problem)
        {
            var problemNew = await _dbContext.Set<Problem>()
                                   .Where(x => x.Id == problem.Id)
                                   .FirstOrDefaultAsync();
            problemNew.Title = problem.Title;
            problem.Status = problem.Status;
            _dbContext.Set<Problem>().Update(problem);
            await _dbContext.SaveChangesAsync();
            var problems = await _dbContext.Set<Problem>()
                                            .ToArrayAsync();
            return View("Problem", problems);
        }

        [HttpPost]
        public async Task AddComment(Comment comment)
        {
            comment.Date = DateTime.Now;
            _dbContext.Add(comment);
            await _dbContext.SaveChangesAsync();
            return;
        }

        [HttpDelete]
        [Route("delcomment/{commentId:int}")]
        public async Task<IActionResult> DeleteComment(int commentId)
        {
            var comment = await _dbContext.Set<Comment>()
                                    .Where(x => x.Id == commentId)
                                    .FirstOrDefaultAsync();
            _dbContext.Set<Comment>().Remove(comment);
            await _dbContext.SaveChangesAsync();
            return View();
        }


        [HttpPut]
        public async Task<IActionResult> EditComment(Comment comment)
        {
            var commentNew = await _dbContext.Set<Comment>()
                                   .Where(x => x.Id == comment.Id)
                                   .FirstOrDefaultAsync();
            commentNew.Text = comment.Text;
            await _dbContext.SaveChangesAsync();
            return View();
        }

        [HttpGet]
        [Route("sender/{commentId:int}")]
        public async Task<IActionResult> GetSender(int commentId)
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

    }
}
