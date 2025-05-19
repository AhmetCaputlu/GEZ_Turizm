using System.Diagnostics;
using System.Runtime.ConstrainedExecution;
using System.Threading.Tasks;
using BusinessLogic.DTOs.WebUser;
using BusinessLogic.Services.Abstracts;
using BusinessLogic.Services.Abstracts.WebUsers;
using DataAccess.Entities.Enums;
using DataAccess.Entities.FilterModels.WebUsers;
using DataAccess.Entities.Models.WebUsers;
using Microsoft.AspNetCore.Mvc;
using Presentation_MVC.Models;

namespace Presentation_MVC.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}
        private readonly IWebUserProfileService _service;
        public HomeController(IWebUserProfileService webUserProfileService)
        {
            _service = webUserProfileService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public async Task<IActionResult> Test(WebUserProfileViewModel filterModel)
        {
            var filter = await _service.GetDynamicFilteredEntities(filterModel.Filter);
            
            var vm = new WebUserProfileViewModel
            {
                Filter = filterModel.Filter,
                List = filter
            };

            return View(vm);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
