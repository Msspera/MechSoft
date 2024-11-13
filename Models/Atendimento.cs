using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MechSoft.Models
{

	public class Atendimento
	{
		[Key]
		public int Id { get; set; }
		[Required]
		public String Etapa { get; set; }
		[Required]
		public String? Categoria { get; set; }

		public int CarroId { get; set; }
		[ForeignKey("CarroId")]
		public Carro Carro { get; set; }

		public int ClienteId { get; set; }
		[ForeignKey("ClienteId")]
		public Cliente Cliente { get; set; }

		[Display(Name = "Briefing Chegada")]
		public String? BriefingChegada { get; set; }

		[Display(Name = "Av. Comp. ao Mecânico")]
		public String? AvariasCompetentesMecanico { get; set; }

		[Display(Name = "Av. Ñ Comp. ao Mecânico")]
		public String? AvariasNaoCompetentesMecanico { get; set; }

		[Display(Name = "Serviços Realizados")]
		public String? ServicosRealizados { get; set; }

		[Display(Name = "Valor Total")]
		public float? ValorTotal { get; set; }

	}

}
