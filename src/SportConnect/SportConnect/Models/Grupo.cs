using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CriarGrupo.Models
{

    [Table("Grupos")]
    public class Grupo
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Informe o nome do grupo")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe a descrição do grupo")]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Display(Name = "Número máximo de participantes")]
        public int NumeroMaximoParticipantes { get; set; }

        [Display(Name = "Adicionar lista de espera?")]
        public bool ListaEspera {  get; set; }

        [Required(ErrorMessage = "Informe a modalidade da atividade")]
        public string Modalidade { get; set; }

        [Required(ErrorMessage = "Informe o estado que será realizada a atividade")]
        public string Estado { get; set; }

        [Required(ErrorMessage = "Informe a cidade que será realizada a atividade")]
        public string Cidade { get; set; }

    }
}
