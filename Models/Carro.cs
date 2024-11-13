using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MechSoft.Models
{
	[Table("Carros")]
	public class Carro
	{
		[Key]
		public int Id { get; set; }

		[Required, StringLength(7)]
		[Display(Name = "Placa")]
		public string Placa { get; set; }

		[Required]
		[StringLength(60)]
		public string Modelo { get; set; }

		[Required]
		[StringLength(50)]
		public string Marca { get; set; }

		[StringLength(30)]
		public string Cor { get; set; }

		[Required]
		public int Quilometragem { get; set; }



		public int UltimaRevisao { get; set; } //TODO ajustar para ao criar, se for nulo, setar para a kmetragem atual

		//TODO ajustar para ao criar, se for nulo, setar para uma quantia padrão
		public int PeriodicidadeRevisao { get; set; } // quantidade em km entre cada revisão

		[NotMapped]
		public int ProximaRevisao => this.UltimaRevisao + this.PeriodicidadeRevisao;

		[NotMapped]
		// Denota se o carro está com a Revisão em dia
		public bool RevisaoRegular => this.UltimaRevisao< this.ProximaRevisao;



		public int UltimaTrocaOleo { get; set; } //TODO ajustar para ao criar, se for nulo, setar para a kmetragem atual

		//TODO ajustar para ao criar, se for nulo, setar para uma quantia padrão
		public int PeriodicidadeTrocaOleo  { get; set; } // Quantidade em km entre cada troca de óleo

		[NotMapped]
		public int ProximaTrocaOleo => this.UltimaTrocaOleo + this.PeriodicidadeTrocaOleo;

		[NotMapped]
		// Denota se o carro está com a Troca de Óleo tem dia
		public bool TrocaOleoRegular => this.UltimaTrocaOleo < this.ProximaTrocaOleo;

		[InverseProperty("Carro")]
		public List<Atendimento> Atendimentos { get; set; }
	}
}
