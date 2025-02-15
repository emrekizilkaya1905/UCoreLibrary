using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RateLimit.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CategoriesController : ControllerBase
	{
		[HttpGet]
		public IActionResult GetCategory()
		{
			return Ok(new {ID=1,Category="Kirtasiye"});
		}
	}
}
