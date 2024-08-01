using System.ComponentModel.DataAnnotations;

namespace Controle.Models
{
    public class DayuseModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Por Favor Insira o Nome do Cliente")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Por Favor Insira a Data de Venda")]
        public string DataVenda { get; set; }
        [Required(ErrorMessage = "Por Favor Insira o Telefone do Cliente")]
        public string Telefone { get; set; }
        public int Pulseira { get; set; }
        public bool Aluno { get; set; }
        public double Preco {  get; set; }

    

    }
}
