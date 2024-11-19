using ChiroPagina.Models;

namespace ChiroPagina.Data
{
	public class DbInitializer
	{

		public static void Seed(IApplicationBuilder applicationBuilder)
		{
			ChiroPaginaDbContext context = applicationBuilder.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<ChiroPaginaDbContext>();

			if (!context.Events.Any())
			{
				context.AddRange(
				new Event { EventTitle = "24 uur", ShortDescription = "We gaan 24 uur op de chiro blijven", LongDescription = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", EventDate = new DateOnly(2024, 5, 12) },
				new Event { EventTitle = "kamp", ShortDescription = "We gaan op kamp", LongDescription = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", EventDate = new DateOnly(2024, 11, 24) },
				new Event { EventTitle = "Spaghetti", ShortDescription = "We eten spaghetti", LongDescription = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", EventDate = new DateOnly(2024, 11, 15) }
				);
				context.SaveChanges();
			}
		}

	}
}
