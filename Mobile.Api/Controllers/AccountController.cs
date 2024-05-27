using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mobile.Api.Data.UserService;
using Mobile.Api.Data;
using Mobile.Data;

namespace Mobile.Api.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class AccountController : ControllerBase
	{
		private readonly IClientService service;
		public AccountController(IClientService service)
		{
			this.service = service;
		}

		[HttpPost("register")]
		[AllowAnonymous]
		public async Task<ActionResult<ServiceResponse>> RegisterUserAsync(Registration model)
		{
			if (model is null) return BadRequest("Model is empty");
			var result = await service.RegisterUserAsync(model);
			return Ok(result);
		}

		[HttpPost("Login")]
		[AllowAnonymous]
		public async Task<ActionResult<ServiceResponse>> LoginUserAsync(Login model)
		{
			if (model is null) return BadRequest();
			var result = await service.LoginUserAsync(model);
			return Ok(result);
		}
	}
}
