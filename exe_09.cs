using System;

namespace Exercicios_aula2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a data desejada: ");

            
            //VARIÁVEIS DE LEITURA INICIAL  
            Console.WriteLine("Digite o Dia:")
            string diaPrimeiro = Console.ReadLine();
            Console.WriteLine("Digite o Mês:");
            string mesPrimeiro = Console.ReadLine();
            Console.WriteLine("Digite o Ano:");
            string anoPrimeiro = Console.ReadLine();
            
            // VARIÁVEIS QUE SERÃO USADAS PARA O MÉTODO TRYPARSE
            int dia = 0;
            int mes = 0;
            int ano = 0;

            // DENTRO DO IF USEI P MÉTODO TRYPARSE PARA CONVERSÃO DOS TIPOS E NOMES DAS VARIÁVEIS 

            if (int.TryParse(diaPrimeiro, out dia) && int.TryParse(mesPrimeiro, out mes) && int.TryParse(anoPrimeiro, out ano))
            {
                if ((dia > 31 && dia <= 0) || (mes > 12 && mes < 1) || (ano <= 0))
                {
                    Console.WriteLine("Data inválida!");

                }
                else
                {

                    Console.WriteLine("Data válida! ");
                }


        }
    }
    }

}

