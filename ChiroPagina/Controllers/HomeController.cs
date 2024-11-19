using ChiroPagina.Models;
using ChiroPagina.Models.Repository_s;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ChiroPagina.Controllers
{
	public class HomeController : Controller
	{
		private readonly IEventRepository _eventRepository;

		public HomeController(IEventRepository eventRepository)
		{
			_eventRepository = eventRepository;
		}

		public IActionResult Index()
		{
			return View(_eventRepository.GetEventsOfTheMonth);
		}

	
	}
}
