using Microsoft.AspNetCore.Mvc;
using Services.User;

namespace Shopping_Card_Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public Dtos.Models.User.Retrieve.OutputDto GetAllUsers() {
            return _userService.Retrieve();
        }

        [HttpPost]
        public async Task<Dtos.Models.User.Create.OutputDto> Create(Dtos.Models.User.Create.Api.InputDto iModel)
        {
            return await _userService.Create(new Dtos.Models.User.Create.Service.InputDto
            {
                Email = iModel.Email,
                Password = iModel.Password,     
                CreationDateTimeUtc = DateTime.UtcNow
            });
        }
    }
}
