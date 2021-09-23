using System;

namespace Exercicios_aula2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número inteiro: ");

            int numero = Convert.ToInt32(Console.ReadLine());

            if (  numero % 2 == 0) {

                
                 Console.WriteLine("Número par ");

            } else {

                 Console.WriteLine("Número ímpar ");
            }



        }
    }
}
