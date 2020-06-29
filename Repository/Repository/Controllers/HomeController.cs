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
        private readonly ISettingRepositories _settingRepositories;
        public HomeController(ILogger<HomeController> logger, IServiceProvider serviceProvider, ISettingRepositories settingRepositories)
        {
            _logger = logger;
            _serviceProvider = serviceProvider;
            _settingRepositories = settingRepositories;
        }

        public IActionResult Index()
        {
     
            _settingRepositories.UpdateSetting(new Settings
            {
                Name = "Nazwa",
                Value = "Value"
            });
            var Result = _settingRepositories.GetAll();
            return Ok(Result);
        }


    }
}
