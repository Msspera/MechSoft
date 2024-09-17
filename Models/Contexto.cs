using Microsoft.EntityFrameworkCore;

namespace MechSoft.Models
{
	public class Contexto : DbContext
	{
		public Contexto(DbContextOptions<Contexto> options) :
			base(options)
		{ }
	}
}
