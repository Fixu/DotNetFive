using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DotNetFive.Models;
using DotNetFive.ViewModels;
using Humanizer;
using Microsoft.Extensions.Options;

namespace DotNetFive.Controllers
{
    public class HomeController : Controller
    {
        private Content contents = null;
        public HomeController(IOptions<Content> option)
        {
            contents = option.Value;
        }
        public IActionResult Index()
        {
            //return View();
            //var contents = new List<Content>();
            //for (int i = 1; i < 11; i++)
            //{
            //    contents.Add(new Content { Id = i, Title = $"{i}的标题", Contents = $"{i}的内容", Status = 1, Add_Time = DateTime.Now.AddDays(-i) });
            //}
            //return View(new ContentViewModel { Contents = contents });

            return View(new ContentViewModel { Contents = new List<Content> { contents } });
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
