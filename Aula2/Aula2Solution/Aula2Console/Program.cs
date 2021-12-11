using System;

namespace Aula2Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var evertonSette = new Cliente("Everton", "Sette", 1000);

            Console
                .WriteLine($"Nome completo do cliente: {evertonSette.Nome} {evertonSette.Sobrenome}");
            Console
                .WriteLine($"Limite de crédito: {evertonSette.Credito:N2}");

            evertonSette.AjustarCredito(random.Next());

            Console
               .WriteLine($"Limite de crédito: {evertonSette.Credito:N2}");

            evertonSette.AjustarCredito(-1 * random.Next());

            Console
               .WriteLine($"Limite de crédito: {evertonSette.Credito:N2}");

            evertonSette.AjustarCredito(random.Next());

            Console
               .WriteLine($"Limite de crédito: {evertonSette.Credito:N2}");

            evertonSette.AjustarCredito(-1 * random.Next());

            evertonSette.Credito = 1000;

            Console
               .WriteLine($"Limite de crédito: {evertonSette.Credito:N2}");

            Console.ReadKey();
        }
    }
}
