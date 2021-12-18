using System.ComponentModel.DataAnnotations;

namespace Aula3.WebApp.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Nome completo")]
        public string? NomeCompleto { get; set; }

        [Display(Name = "Nome social")]
        public string? NomeSocial { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Documento")]
        public string? CPFCNPJ { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public string? CEP { get; set; }

        public string? Logradouro { get; set; }

        public string? Numero { get; set; }

        public string? Complemento { get; set; }

        public string? Bairro { get; set; }

        public string? Cidade { get; set; }

        [Display(Name = "Estado")]
        public string? UnidadeFederacao { get; set; }
    }
}