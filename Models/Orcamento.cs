using System.ComponentModel.DataAnnotations;

namespace AppWeb.Models
{
    public class Orcamento
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Informe o nome do Cliente")]
        public string Cliente { get; set; }

        [Required(ErrorMessage = "Informe um Veículo")]
        public string Veiculo { get; set; }

        public string? Placa { get; set; }

        public string? Chassi { get; set; }

        public List<Produto>? Produtos { get; set; } = [];

        public DateTime DataCriacao { get; set; }
    }
}
