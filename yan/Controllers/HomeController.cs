﻿using Microsoft.AspNetCore.Mvc;
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
            ViewData["UnexpectedInController"] = "main page's title";
            return View();
        }

        public IActionResult JobsList()
        {
            
            ViewData["Message"] = "f";
            ViewData["UnexpectedInController"] = "zzzz";
            return View();
        }
        [HttpPost]
        public ActionResult<string> TestPost([FromBody] CurrencyModel model)
        {
            Dictionary<string, decimal> rates = new Dictionary<string, decimal>()
            {
                {"ruble", 1},
                {"dollar", 75},
                {"euro", 90.4m}
            };
            decimal result = (model.Amount / rates[model.CurrencyIn]) * rates[model.CurrencyOut];
            return Ok(string.Format("converting {0} to {1}. {2} {0} = {3} {1}", model.CurrencyIn, model.CurrencyOut, model.Amount, result));
            
        }

        public string TestBink(CurrencyModel model)
        {
            Dictionary<string, decimal> rates = new Dictionary<string, decimal>()
            {
                {"ruble", 1},
                {"dollar", 75},
                {"euro", 90.4m}
            };
            decimal result = (model.Amount / rates[model.CurrencyIn]) * rates[model.CurrencyOut];
            return string.Format("converting {0} to {1}. {2} {0} = {3} {1}", model.CurrencyIn, model.CurrencyOut, model.Amount, result);
            //var result = value * value;
            //var viewModel = new ResultViewModel(result);
            //return View(viewModel);

        }

        public IActionResult CurrencyConvertForm()
        {
            return View();
        }

        public IActionResult UserForm()
        {
            return View();
        }

        public IActionResult CurrencyConvertResult(CurrencyModel model)
        {
            return View(model);
        }


        public ViewResult CDPStats()
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
