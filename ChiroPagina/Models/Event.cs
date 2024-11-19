namespace ChiroPagina.Models
{
	public class Event
	{

		public int EventId { get; set; }
		public string EventTitle { get; set; } = string.Empty;
		public string ShortDescription { get; set; }
		public string LongDescription { get; set; }
		public DateOnly EventDate { get; set; }
		
	}
}
