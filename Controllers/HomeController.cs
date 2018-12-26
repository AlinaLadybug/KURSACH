using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LAB9.Models;
using LAB9.Models.DataBase;
using System.Data;
using LAB9.Models.ViewModels;

namespace LAB9.Controllers
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

        [Route("crop")]
        public IActionResult About()
        {
            var crops = _dbContext.Set<Crop>()
                                 .ToArray();
            var result = new CropVm() { Crops = crops };
            return View(result);
        }

        [Route("profit/{cropId:int}")]
        public IActionResult Profit(int cropId)
        {
            var cropName = _dbContext.Set<Crop>()
                                     .Where(x => x.CropId == cropId)
                                     .Select(x => x.Name)
                                     .FirstOrDefault();
            var cost = _dbContext.Set<Roadmap>()
                                    .Where(x => x.CropId == cropId)
                                    .Select(x => x.Sum)
                                    .FirstOrDefault();
            var profit = _dbContext.Set<Invoice>()
                                    .Where(x => x.CropId == cropId)
                                    .Select(x => x.Sum)
                                    .FirstOrDefault();
            var totalProfit = profit - cost;
            var result = new ProfitVm()
            {
                CropName = cropName,
                TotalProfit = totalProfit
            };
            return View(result);
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
