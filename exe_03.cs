using System;

namespace exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Valor do Produto 01: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Valor do Produto 02: ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Valor do Produto 03: ");
            int z = Convert.ToInt32(Console.ReadLine());

            if (x < y)

            {
                if (x < z)  {
                    
                    Console .WriteLine(" O mais barato  é o Produto 01" + " no valor de " + x + " reais");
                    
                } else {
                    
                    Console .WriteLine(" O mais barato  é o Produto 03" + " no valor de " + z + " reais");
                    
                }
                
                if (x > y)  {


                    Console.WriteLine(" O mais barato  é o Produto 02" +
                         " no valor de " + y + " reais");

                }
                
        }
    }
