namespace Aula3.WebApp.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string? NomeCompleto { get; set; }
        public string? NomeSocial { get; set; }
        public string? CPFCNPJ { get; set; }
        public string? CEP { get; set; }
        public string? Logradouro { get; set; }
        public string? Numero { get; set; }
        public string? Complemento { get; set; }
        public string? Bairro { get; set; }
        public string? Cidade { get; set; }
        public string? UnidadeFederacao { get; set; }
    }
}
