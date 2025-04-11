using BusinessLogic.Services.Abstracts;
using DataAccess.Entities.Models.Products;
using DataAccess.Entities.Models.WebUsers;
using Microsoft.AspNetCore.Mvc;

namespace WEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly IService<WebUserAccount> _service;

        public TestController(IService<WebUserAccount> service)
        {
            _service = service;
        }

        [HttpGet("get/{id}")]
        public async Task<ActionResult> Index(int id)
        {
            return Ok(await _service.GetByIdAsync(id));
        }
        [HttpGet("all")]
        public ActionResult pr()
        {
            return Ok(_service.GetAllEntities());
        }
    }
}
