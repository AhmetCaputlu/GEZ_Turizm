using System.Diagnostics;
using System.Runtime.ConstrainedExecution;
using System.Threading.Tasks;
using BusinessLogic.DTOs.WebUser;
using BusinessLogic.Services.Abstracts;
using DataAccess.Entities.Enums;
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
        private readonly IService<WebUserAccount, WebUserAccountResponseDTO, WebUserAccountRequestDTO> _service;
        public HomeController(IService<WebUserAccount, WebUserAccountResponseDTO, WebUserAccountRequestDTO> service)
        {
            _service = service;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public async Task<IActionResult> Test(int? firstId, int? lastId, DateTime? firstCreatedDate, DateTime? secondCreatedDate,
            DateTime? firstUpdatedDate, DateTime? secondUpdatedDate, DataStatus? status, bool? isUpdated, bool? descending)
        {
            var filter =await _service.GetDynamicFilteredEntities(firstId, lastId, firstCreatedDate, secondCreatedDate, firstUpdatedDate, secondUpdatedDate, status, isUpdated, descending);
            return View(filter);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
