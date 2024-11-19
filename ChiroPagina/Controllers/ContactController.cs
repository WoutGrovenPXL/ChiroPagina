using Microsoft.AspNetCore.Mvc;

namespace ChiroPagina.Controllers
{
	public class ContactController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
