
using ChiroPagina.Data;

namespace ChiroPagina.Models.Repository_s
{
	public class EventRepository : IEventRepository
	{

		private readonly ChiroPaginaDbContext _chiroPaginaDbContext;

        public EventRepository(ChiroPaginaDbContext chiroPaginaDbContext)
        {
			_chiroPaginaDbContext = chiroPaginaDbContext;
        }


        public IEnumerable<Event> GetAllEvents
		{
			get
			{
				return _chiroPaginaDbContext.Events;
			}
		}

		public Event? GetEventById(int id)
		{
			return _chiroPaginaDbContext.Events.FirstOrDefault(e => e.EventId == id);
		}

		public IEnumerable<Event> GetEventsOfTheMonth
		{
			get
			{
				return _chiroPaginaDbContext.Events.Where(e => e.EventDate.Month == DateTime.Now.Month);
			}
			
		}
	}
}
