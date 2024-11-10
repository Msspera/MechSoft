using Microsoft.EntityFrameworkCore;
using MechSoft.Models;

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

        public DbSet<Financeiro> Financeiros { get; set; }
        public DbSet<Peca> Pecas { get; set; }
	    public DbSet<Atendimento> Atendimentos { get; set; } 
		




    }
}
