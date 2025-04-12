using BusinessLogic.DTOs.BasicDTOs.Models.WebUser;
using BusinessLogic.Services.Abstracts;
using DataAccess.Entities.Models.Products;
using DataAccess.Entities.Models.WebUsers;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace WEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly IService<WebUserAccount, WebUserAccountDTO> _service;
        private readonly IService<WebUserAccount, WebUserAccountEditDTO> _edit;
        public TestController(IService<WebUserAccount, WebUserAccountDTO> service, IService<WebUserAccount, WebUserAccountEditDTO> edit)
        {
            _service = service;
            _edit = edit;
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
        [HttpPut("update")]
        public ActionResult w(WebUserAccountDTO webUserAccountDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            else
            {
                return Ok(_service.Update(webUserAccountDTO));
            }
        }
    }
}
