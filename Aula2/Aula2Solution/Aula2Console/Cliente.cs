using System;

namespace Aula2Console
{
    class Cliente
    {
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

        private decimal _Credito;
        public decimal Credito { get => _Credito; set => _Credito = value; }

        public void AjustarCredito(decimal valor)
        {
            _Credito += valor;
        }
    }
}
