using System;

namespace Exercicios_aula2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            Console.WriteLine("Digite a primeira nota do aluno: ");
            int  primeiraNota = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota do aluno: ");
            int segundaNota = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            
    
                double mediaDeNotas = ( primeiraNota + segundaNota) / 2;

                if (mediaDeNotas >= 9 && mediaDeNotas <= 10) {

                    Console.WriteLine("Aprovado!");
                    Console.WriteLine("Conceito A aplicado!");

                } else if (mediaDeNotas >= 7.5 && mediaDeNotas <= 9) {

                    Console.WriteLine("APROVADO");
                    Console.WriteLine("Conceito B aplicado!");

                } else if (mediaDeNotas >= 6  && mediaDeNotas <= 7.5 ) {

                    Console.WriteLine("APROVADO");
                    Console.WriteLine("Conceito C aplicado!");

                } else if (mediaDeNotas == 4 && mediaDeNotas < 6) {

                    Console.WriteLine("REPROVADO");
                    Console.WriteLine("Conceito D aplicado!");

                } else if (mediaDeNotas ==  0 && mediaDeNotas < 4 ) {

                    Console.WriteLine("REROVADO");
                    Console.WriteLine("Conceito E aplicado!");
                }

            

        }

    }  
}
