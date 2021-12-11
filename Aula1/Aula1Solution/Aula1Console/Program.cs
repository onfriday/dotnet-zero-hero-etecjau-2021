using System;

namespace Aula1Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //ExemploTipoPorValor();

            ExemploTipoPorReferencia();

            Console.ReadKey();


        }

        class TipoReferencia
        {
            public int Codigo { get; set; }
        }

        private static void ExemploTipoPorReferencia()
        {
            Console.WriteLine("Exemplo: Tipo por referência");

            TipoReferencia valorInicial = new TipoReferencia
            {
                Codigo = new Random().Next(5, 30)
            };

            Console.WriteLine($"Valor inicial: {valorInicial.Codigo}");

            ExemploTipoPorReferenciaAlterar(valorInicial);

            Console.WriteLine($"Valor após alteração: {valorInicial.Codigo}");
        }

        private static void ExemploTipoPorReferenciaAlterar(TipoReferencia tipoReferencia)
        {
            tipoReferencia.Codigo += new Random().Next(5, 20);
        }

        private static void ExemploTipoPorValor()
        {
            Console.WriteLine("Exemplo: Tipo por valor");

            int valorInicial = 15;

            Console.WriteLine($"Valor inicial: {valorInicial}");

            var valorFinal = ExemploTipoPorValorAlterarValor(valorInicial);

            Console.WriteLine($"Valor após alteração: {valorInicial}");
            Console.WriteLine($"Valor final: {valorFinal}");
        }

        private static int ExemploTipoPorValorAlterarValor(int valorInicial)
        {
            valorInicial += new Random().Next(5, 20);
            return valorInicial;
        }
    }
}
