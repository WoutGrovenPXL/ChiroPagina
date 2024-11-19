namespace ChiroPagina.Models.Repository_s
{
	public interface IEventRepository
	{

		public IEnumerable<Event> GetAllEvents { get; }
		public IEnumerable<Event> GetEventsOfTheMonth { get; }
		public Event? GetEventById(int id);

	}
}
