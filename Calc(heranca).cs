using System;

namespace Calculadora
{
    // Implementação/Herdando da interface ICalculadora
    class Calculadora : ICalculadora
    {
        public void Adicao()
        {
            Console.WriteLine("*** ADIÇÃO ***");

            float num1 = Validador.Operacoes("\nDigite o primeiro número: ");
            float num2 = Validador.Operacoes("Digite o primeiro número: ");

            Console.WriteLine($"\nO resultado deu: {num1 + num2}");
        }
        public void Subtracao()
        {
            Console.WriteLine("*** SUBTRAÇÃO ***");

            float num1 = Validador.Operacoes("\nDigite o primeiro número: ");
            float num2 = Validador.Operacoes("Digite o primeiro número: ");

            Console.WriteLine($"\nO resultado deu: {num1 - num2}");
        }
        public void Multiplicacao()
        {
            Console.WriteLine("*** MULTIPLICAÇÃO ***");

            float num1 = Validador.Operacoes("\nDigite o primeiro número: ");
            float num2 = Validador.Operacoes("Digite o primeiro número: ");

            Console.WriteLine($"\nO resultado deu: {num1 * num2}");
        }
        public void Divisao()
        {
            Console.WriteLine("*** DIVISÃO ***");

            float num1 = Validador.Operacoes("\nDigite o primeiro número: ");
            float num2 = Validador.Operacoes("Digite o primeiro número: ");

            if (num2 == 0 || num1 == 0)
            {
                Console.WriteLine("Não é possivel fazer divisão por 0");
            }
            else
            {
                Console.WriteLine($"\nO resultado deu: {num1 / num2}");
            }
        }
    }
}
