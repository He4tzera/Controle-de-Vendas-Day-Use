using System.ComponentModel.DataAnnotations;

namespace Controle.Models
{
    public class DayuseModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Por favor insira o nome do cliente")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Por favor insira a data de venda")]
        public DateTime DataVenda { get; set; }

        [Required(ErrorMessage = "Por favor insira o telefone do cliente")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "Por favor insira o numero da pulseira")]
        public string Pulseira { get; set; }
        [Required(ErrorMessage = "Por favor insira se é aluno")]
        public bool Aluno { get; set; }

        [Required(ErrorMessage = "Por favor insira o valor cobrado")]
        public double Preco { get; set; }

        [Required(ErrorMessage = "Por favor insira a forma de pagamento")]
        public string FormaPagamento { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime EditedAt { get; set; }
       


    public string DataVendaFormatada
        {
            get
            {
                return DataVenda.ToString("dd/MM/yyyy");
            }
        }


    }
}