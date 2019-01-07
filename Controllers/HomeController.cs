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

namespace KR.Controllers
{
    public class HomeController : Controller
    {
        private KRContext _dbContext;
        public HomeController(KRContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IActionResult> Type()
        {
            var types = await _dbContext.Set<ProblemType>()
                                        .ToArrayAsync();
            return View(types);
        }

        // [HttpGet]
        // [Route("problem")]
        // public async Task<IActionResult> Problem()
        // {
        //     var problems = await _dbContext.Set<Problem>()
        //                                 .AsNoTracking()
        //                                 .ToArrayAsync();
        //     var result = new ProblemVm() { Problems = problems };
        //     return View(result);
        // }

        // [HttpGet]
        // [Route("info/{problemId:int}")]
        // public async Task<IActionResult> Info(int problemId)
        // {
        //     var messages = await _dbContext.Set<Comment>()
        //                              .Where(x => x.ProblemId == problemId)
        //                              .Select(x => new CommentVm
        //                              {
        //                                  Text = x.Text,
        //                                  Sender = x.Sender.FirstName + " " + x.Sender.LastName,
        //                                  Date = (DateTime)x.Date
        //                              })
        //                              .ToArrayAsync();
        //     // var resuprofitlt = new MessageVm()
        //     // {
        //     //     Messages = messages.Select(x => x.Text).ToArray(),
        //     //     Senders = messages.Select(x => x.From.FirstName + x.From.LastName).ToArray()
        //     // };
        //     return View(messages);
        // }


        [HttpGet]
        public IActionResult AddProblem()
        {
            return View();
        }


        // [HttpPost]
        // public async Task AddProblem(Problem problem)
        // {
        //     problem.CreationDate = DateTime.Now;
        //     _dbContext.Set<Problem>().Add(problem);
        //     await _dbContext.SaveChangesAsync();
        //     return;
        // }

        // [HttpDelete]
        // [Route("{problemId:int}")]
        // public async Task<IActionResult> DeleteProblem(int problemId)
        // {
        //     var problem = await _dbContext.Set<Problem>()
        //                             .Where(x => x.Id == problemId)
        //                             .FirstOrDefaultAsync();
        //     _dbContext.Set<Problem>().Remove(problem);
        //     await _dbContext.SaveChangesAsync();
        //     return View();
        // }

        // [HttpPut]
        // [Route("{problemId:int}")]
        // public async Task<IActionResult> DeleteProblem(Problem problem)
        // {
        //     var problemNew = await _dbContext.Set<Problem>()
        //                             .Where(x => x.Id == problem.Id)
        //                             .FirstOrDefaultAsync();
        //     problemNew.Title = problem.Title;
        //     problem.Status = problem.Status;
        //     _dbContext.Set<Problem>().Update(problem);
        //     await _dbContext.SaveChangesAsync();
        //     return View();
        // }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


    }
}
