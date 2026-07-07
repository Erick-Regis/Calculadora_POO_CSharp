using System;

namespace Calculadora
{
    // Classe principal do programa
    class Program
    {
        static void Main()
        {
            ICalculadora calculadora = new Calculadora();
            int selecao = 0;

            while (selecao != 5)
            {
                Console.Clear();


                Console.WriteLine("***CALCULADORA***");
                Console.WriteLine("\n1 - Soma");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão");
                Console.WriteLine("5 - Sair");
                Console.Write("\nEscolha a operação que deseja utilizar: ");
                selecao = Validador.Opcao();

                switch (selecao)
                {
                    case 1:
                        Console.Clear();
                        calculadora.Adicao();
                        break;
                    case 2:
                        Console.Clear();
                        calculadora.Subtracao();
                        break;
                    case 3:
                        Console.Clear();
                        calculadora.Multiplicacao();
                        break;
                    case 4:
                        Console.Clear();
                        calculadora.Divisao();
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("Saindo...");
                        return;
                }

                if (selecao != 5)
                {
                    Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
                    Console.ReadKey();
                }
            }
        }
    }
}
