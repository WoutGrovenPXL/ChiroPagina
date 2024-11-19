using ChiroPagina.Models.Repository_s;
using Microsoft.AspNetCore.Mvc;

namespace ChiroPagina.Controllers
{
	public class EventController : Controller
	{

		private readonly IEventRepository _eventRepository;


        public EventController(IEventRepository eventRepository)
        {
			_eventRepository = eventRepository;
        }


		public IActionResult Events()
		{
			return View(_eventRepository.GetAllEvents);
		}

        public IActionResult Details(int id)
		{
			return View(_eventRepository.GetEventById(id));
		}
	}
}
