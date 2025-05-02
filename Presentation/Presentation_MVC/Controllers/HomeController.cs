using System.Diagnostics;
using BusinessLogic.DTOs.WebUser;
using BusinessLogic.Services.Abstracts;
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
        private readonly IService<WebUserAccount,WebUserAccountResponseDTO,WebUserAccountRequestDTO> _service;
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
        public IActionResult Test()
        {
            var x = _service.GetAllEntities();
            return View(x);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
