using System.Diagnostics;
using BusinessLogic.DTOs.Regions;
using BusinessLogic.OperationResult;
using BusinessLogic.Services.Abstracts;
using DataAccess.Entities.FilterModels.Regions;
using DataAccess.Entities.Models.Regions;
using Microsoft.AspNetCore.Mvc;
using Presentation_MVC.Models;

namespace Presentation_MVC.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {
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
            return View();
        }

    }
}
