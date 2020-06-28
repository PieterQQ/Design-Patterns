using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Repository.Database;
using Repository.Database.Entities;
using Repository.Models;

namespace Repository.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IServiceProvider _serviceProvider;
        public HomeController(ILogger<HomeController> logger, IServiceProvider serviceProvider)
        {
            _logger = logger;
            _serviceProvider = serviceProvider;
        }

        public IActionResult Index()
        {
            var database=_serviceProvider.GetService(typeof(RepositoryDbContext)) as RepositoryDbContext;
            var repository = new SettingRepositories(database);
            repository.UpdateSetting(new Settings
            {
                Name = "Nazwa",
                Value = "Wartosc"
            });
            var Result = repository.GetAll();
            return Ok(Result);
        }


    }
}
