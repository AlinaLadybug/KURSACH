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
        private DataBaseContext _dbContext;
        public HomeController(DataBaseContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            return View();
        }

        [Route("problem")]
        public async Task<IActionResult> About()
        {
            var problems =await _dbContext.Set<Problem>()
                                        .AsNoTracking()
                                        .ToArrayAsync();
            var result = new ProblemVm() { Problems = problems };
            return View(result);
        }

        [Route("info/{problemId:int}")]
        public async Task<IActionResult> Info(int problemId)
        {
            var messages = await _dbContext.Set<Message>()
                                     .Where(x => x.ProblemId == problemId)
                                     .Select(x => new MessageVm
                                     {
                                         Text = x.Text,
                                         Sender = x.From.FirstName + " " + x.From.LastName,
                                         Date = (DateTime)x.Sent
                                     })
                                     .ToArrayAsync();
            // var resuprofitlt = new MessageVm()
            // {
            //     Messages = messages.Select(x => x.Text).ToArray(),
            //     Senders = messages.Select(x => x.From.FirstName + x.From.LastName).ToArray()
            // };
            return View(messages);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


    }
}
