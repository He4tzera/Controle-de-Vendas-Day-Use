using System.ComponentModel.DataAnnotations;

namespace Controle.Models
{
    public class DayuseModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Por favor insira o nome do cliente")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Por favor insira a data de venda")]
        public string DataVenda { get; set; }

        [Required(ErrorMessage = "Por favor insira o telefone do cliente")]
        public string Telefone { get; set; }

        [Required(ErrorMessage ="Por favor insira o numero da pulseira")]
        public int Pulseira { get; set; }

        public bool Aluno { get; set; }

        [Required(ErrorMessage = "Por favor insira o valor cobrado")]
        public double Preco {  get; set; }

    

    }
}
