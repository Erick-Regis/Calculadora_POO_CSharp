using System;

namespace Calculadora
{
    // Validar se o usuário digitou um número válido para a operação
    class Validador
    {
        public static int Opcao()
        {
            int opcao;
            while (!int.TryParse(Console.ReadLine(), out opcao) || opcao < 1 || opcao > 5)
            {
                Console.Write("Erro! Por favor digite um número de 1 a 5: ");
            }
            return opcao;
        }
        public static float Operacoes(string mensagem)
        {
            float operacao;
            Console.Write(mensagem);

            while (!float.TryParse(Console.ReadLine(), out operacao))
            {
                Console.Write("Erro! Por favor digite um número: ");
            }
            return operacao;
        }
    }
}
