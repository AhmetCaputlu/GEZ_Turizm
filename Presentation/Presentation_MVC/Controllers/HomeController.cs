using System.Diagnostics;
using BusinessLogic.DTOs.Companies.PartnerCompanies;
using BusinessLogic.DTOs.Regions;
using BusinessLogic.OperationResult;
using BusinessLogic.Services.Abstracts;
using BusinessLogic.Services.CompanyS;
using DataAccess.Entities.FilterModels.Companies;
using DataAccess.Entities.FilterModels.Regions;
using DataAccess.Entities.Models.Regions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Presentation_MVC.Models;

namespace Presentation_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITransactionService _service;
        private readonly IPartnerCompanyService _pcservice;
        public HomeController(ITransactionService service, IPartnerCompanyService pcservice)
        {
            _service = service;
            _pcservice = pcservice;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Test(CancellationToken token)
        {
            var partnerCompaniesResult = await _pcservice.GetAllActives(new ResultDTO<PartnerCompanyResponseDTO, PartnerCompanyFilterModel>(), token);
            if (partnerCompaniesResult.List.Any())
            {
                ViewBag.PartnerCompanies = new SelectList(partnerCompaniesResult.List, "Id", "CompanyName");
            }
            return View(new TransactionRequestDTO());
        }

        [HttpPost]
        public async Task<IActionResult> Test(TransactionRequestDTO requestDTO, CancellationToken token)
        {
            if (!ModelState.IsValid)
            {
                var partnerCompaniesResult = await _pcservice.GetAllActives(new ResultDTO<PartnerCompanyResponseDTO, PartnerCompanyFilterModel>(), token);
                ViewBag.PartnerCompanies = new SelectList(partnerCompaniesResult.List, "Id", "CompanyName");

                return View(requestDTO); // ✅ DTO'yu geri döndürüyoruz
            }

            await _service.CreateAsync(requestDTO, token);
            return RedirectToAction("Index");
        }
    }
}
