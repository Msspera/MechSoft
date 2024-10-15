using Microsoft.EntityFrameworkCore;

namespace MechSoft.Models
{
	public class Contexto : DbContext
	{
		public Contexto(DbContextOptions<Contexto> options) :
			base(options)
		{ }

		public DbSet<Cliente> Clientes { get; set; }
		public DbSet<Carro> Carros { get; set; }
		public DbSet<Equipamento> Equipamentos { get; set; }

	}
}
