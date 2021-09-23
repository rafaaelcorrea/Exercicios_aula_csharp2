using System;

namespace exercicio02
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Primeiro numero");
            int x = Convert.ToInt32 (Console.ReadLine());

            
            Console.WriteLine("Segundo numero");
            int y = Convert.ToInt32 (Console.ReadLine());


            Console.WriteLine("Terceiro numero");
            int z = Convert.ToInt32 (Console.ReadLine());

                        if (x > y)
            {
                if(x > z) Console.WriteLine(" O maior é " + x);

                else Console.WriteLine(" O maior é " + z);
            }  else

            {
                if (y > z) Console.WriteLine(" O maior é " + y);
                else Console.WriteLine(" O maior é " + z);
            }

                if (x < y)
            {
                if(x < z) Console.WriteLine(" O menor é " + x);
                else Console.WriteLine(" O menor é " + z);

            } else

            {

           if (y < z) 

           {
           
                Console.WriteLine(" O menor é " + y);
                else {
                    
                    Console.WriteLine(" O menor é " + z);
            }
