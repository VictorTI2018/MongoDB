using Application.Presenters.User;
using Application.Request.User;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController(IUserPresenter userPresenter) : ControllerBase
    {
        private readonly IUserPresenter _userPresenter = userPresenter;

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] UserCreateOrUpdateRequest request)
        {
            var result = await _userPresenter.SaveAsync(request);
            if (!result.Status)
                return BadRequest(result);

            return Ok(result);
        }
    }
}
