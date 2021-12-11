using System;

namespace Aula2Console
{
    class Pessoa
    {
        public decimal Credito { get; protected set; }


        public void AjustarCredito(decimal valor)
        {
            Credito += valor;
        }
    }

    class Cliente : Pessoa
    {
        public string Apelido { get; set; } = "Apelido";
        //public string Nome
        //{
        //    get { return _Nome; }
        //    set { _Nome = value; }
        //}
        private string _Nome;
        public string Nome { get => _Nome; set => _Nome = value; }

        private string _Sobrenome;
        public string Sobrenome { get => _Sobrenome; set => _Sobrenome = value; }

        private Guid _Id;
        public Guid Id { get => _Id; set => _Id = value; }


        // Construtor
        public Cliente(decimal creditoInicial = 0)
        {
            Credito = creditoInicial;
        }

        public Cliente(string nome, string sobrenome) : this()
        {
            _Nome = nome;
            _Sobrenome = sobrenome;
        }

        public Cliente(
            string nome,
            string sobrenome,
            decimal creditoInicial) : this(creditoInicial)
        {
            _Nome = nome;
            _Sobrenome = sobrenome;
        }

    }
}
