using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using proto.DIscratch;
using proto.Models;
using proto.ConfigurationExample;
using Microsoft.Extensions.Options;

namespace proto.Controllers
{
    public class POCController : Controller
    {
        private readonly Repository _repository;
        private readonly DataContext _dataContext;
        private readonly ConfigurableContent _configurableContent;

        //so, the whole magic here is this "IOptions" entity. Here, in the controller, it is just a POCO
        //but in Startup.cs, this IOptions is implicitly created by this line:
        //services.Configure<ConfigurableContent>(Configuration.GetSection("ConfigurableContent"))
        //I can also use IOptionsSnapshot - so config will be reloaded automagically
        public POCController(Repository repository, DataContext dataContext, IOptions<ConfigurableContent> options)
        {
            _repository = repository;
            _dataContext = dataContext;
            _configurableContent = options.Value;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ObjectLifetimes()
        {
            var viewModel = new RowContViewModel
            {
                DataContextCount = _dataContext.RowCount,
                RepositoryCount = _repository.RowCount
            };
            return View(viewModel);
        }
        public IActionResult ConfigurationExample()
        {
            ViewData["Width"] = _configurableContent.Width;
            ViewData["WordOnPage"] = _configurableContent.WordOnPage;
            return View();
        }
    }
}
