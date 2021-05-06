using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using proto.Models;

namespace proto.Controllers
{
    public class HomeController : Controller
    {
        private readonly Data.CDPContext _context;

        public HomeController(Data.CDPContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult JobsList()
        {
            
            ViewData["Message"] = "f";

            return View();
        }


        public string TestBind(int value)
        {
            return "testbind" + value.ToString();
            //var result = value * value;
            //var viewModel = new ResultViewModel(result);
            //return View(viewModel);

        }


        public IActionResult CDPStats()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
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
