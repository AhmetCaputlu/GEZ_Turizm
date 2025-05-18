using BusinessLogic.DTOs.OperationResult;
using BusinessLogic.Enums;
using BusinessLogic.DTOs.WebUser;
using BusinessLogic.Services.Abstracts.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IUserService _userService;

        public HomeController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPut("update")]
        public async Task<IActionResult> UpdateUser([FromBody] WebUserAccountRequestDTO userDto, CancellationToken token)
        {
            ResultDTO result = await _userService.UpdateUserAsync(userDto, token);

            if (result.ResultType == ResultType.Success)
                return Ok("Kullanıcı başarıyla güncellendi.");

            return BadRequest(result);
        }
        [HttpPost("create")]
        public async Task<IActionResult> CreateUser([FromBody] WebUserAccountRequestDTO userDto,string passWord, CancellationToken token)
        {
            ResultDTO result = await _userService.CreateUserAsync(userDto,passWord, token);

            if (result.ResultType == ResultType.Success)
                return Ok("Kullanıcı başarıyla eklendi.");

            return BadRequest(result);
        }
    }
}
