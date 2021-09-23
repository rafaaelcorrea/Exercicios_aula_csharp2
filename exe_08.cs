using System;

namespace Exercicios_aula2
{
    class Program
    {
        static void Main(string[] args)
        {
           // VARIÁVEIS INICIAIS 

            Console.WriteLine("Digite o primeiro lado: ");
            string primeiroLado = Console.ReadLine();
            Console.WriteLine("Digite o segundo lado: ");
            string segundoLado = Console.ReadLine();
            Console.WriteLine("Digite o terceiro lado: ");
            string terceiroLado = Console.ReadLine();
            Console.WriteLine("");

            // VARIÁVEIS PARA SEREM USADAS NO MÉTODO DA CONVERSÃO DO TRYPARSE 

            double l1 = 0;
            double l2 = 0;
            double l3 = 0;

            // MÉTODO TRYPARSE 
            if (double.TryParse(primeiroLado, out l1) && double.TryParse(segundoLado, out l2) && double.TryParse(terceiroLado, out l3))
            {
                if ((l1 == l2) && (l1 == l3) && (l2 == l1) && (l2 == l3) && (l3 == l1) && (l3 == l2))
                {
                    Console.WriteLine("Triângulo Equilátero: três lados iguais");
                }
                else if (((l1 == l2) && (l1 != l3)) || ((l2 == l1) && (l2 != l3)) || ((l3 == l1) && (l3 != l2)))


                {
                    Console.WriteLine("Triângulo Isósceles: quaisquer dois lados iguais");
                }
                else if ((l1 != l2) && (l1 != l3) && (l2 != l1) && (l2 != l3) && (l3 != l1) && (l3 != l2))
                {
                    Console.WriteLine("Triângulo Escaleno: três lados diferentes;");
                }
                else
                {
                    Console.WriteLine("Numero Invalido");
                }

            } 


        }
    }
}