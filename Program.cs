using System;

namespace AppTratamentoException
{
    /// <summary>
    /// Exercicio - Utilizando o bloco try catch
    /// Trabalhando com Exception.
    /// </summary>
    class Program
    {
        static void CalcResult (int n1, int n2)
        {
            try
            {
                int resultado = 0;
                resultado = n1 / n2;
                int resto = n1%n2;
                Console.WriteLine("O seu resultado é {0} e o resto é {1}", resultado, resto);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Não é permitido a divisão por zero! Informe outro valor.");   
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Por favor, entre com os números para a divisão: ");
            string[] valores = Console.ReadLine().Split(" ");

            int n1 = int.Parse(valores[0]);
            int n2 = int.Parse(valores[1]);
            CalcResult(n1, n2);
            Console.ReadLine();
        }
    }
}
