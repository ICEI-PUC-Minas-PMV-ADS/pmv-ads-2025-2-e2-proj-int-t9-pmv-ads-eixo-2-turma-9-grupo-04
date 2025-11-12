using CriarGrupo.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportConnect.Models
{
    [Table ("Eventos")]
    public class Evento
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome do evento é obrigatório.")]
        public string  Nome { get; set; }

        [Required(ErrorMessage = "A descrição do evento é obrigatória.")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "A cidade do evento é obrigatória.")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "O bairro do evento é obrigatório.")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "A rua do evento é obrigatória.")]
        public string Rua { get; set; }

        [Required(ErrorMessage = "O número do evento é obrigatório.")]
        public int Numero { get; set; }


        public double? Latitude { get; set; }
        public double? Longitude { get; set; }

        [Display(Name = "Criado por (Id do Usuário)")]
        public int? UsuarioId { get; set; }   // tipo compatível com Usuario.Id (int)

        // 🔹 Navegação (opcional)
        [ForeignKey(nameof(UsuarioId))]
        public Grupo? Usuario { get; set; }

        [Display(Name = "Criado por (Id do Grupo)")]
        public int? GrupoId { get; set; }   // tipo compatível com Usuario.Id (int)

        // 🔹 Navegação (opcional)
        [ForeignKey(nameof(GrupoId))]
        public Grupo? Grupo { get; set; }


    }
}
