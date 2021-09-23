using System;

namespace Exercicios_aula2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            Console.WriteLine("Digite o valor da sua hora trabalhada");
            double valorTrabalhado = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de horas trabalhadas no mês");
            double horaTrabalhada = double.Parse(Console.ReadLine());

            Console.WriteLine("");

            double salarioBruto = valorTrabalhado * horaTrabalhada;
            // CÁLCULO DO IR

            double ir5 =  (salarioBruto * 5) / 100;
            double ir10 = (salarioBruto * 10) / 100;
            double ir20 = (salarioBruto * 20) / 100;

            //CÁCULO DO INSS
            double inss = (salarioBruto * 10) / 100;
            // CÁLCULO DO FGTS
            double fgts = (salarioBruto * 11) / 100;
            // CÁLCULO ACIMA 2500
            double acima2500 = (salarioBruto * 20) / 100;

            if (salarioBruto <= 2000 ) 
            {
                Console.WriteLine($"Sálario Bruto {valorTrabalhado} * {horaTrabalhada}: R${salarioBruto}");
                Console.WriteLine(" IR Isento");
                Console.WriteLine($"(-) INSS (10%): R$: {inss}");
                Console.WriteLine($"FGTS (11%) : R$ {fgts}");
                Console.WriteLine($"Total de descontos : R$ {inss}");
                Console.WriteLine($"Salário Liquido : R$ {salarioBruto - inss}");
            }
            
            else if (salarioBruto > 2000 && salarioBruto <= 5000 )
            {
                Console.WriteLine($"Sálario Bruto {valorTrabalhado} * {horaTrabalhada}: R${salarioBruto}");
                Console.WriteLine($"(-) IR (5%) :R$ {ir5} ");
                Console.WriteLine($"(-) INSS (10%): R$: {inss}");
                Console.WriteLine($"FGTS (11%) : R$ {fgts}");
                Console.WriteLine($"Total de descontos : R$ {inss}");
                Console.WriteLine($"Salário Liquido : R$ {(salarioBruto - ir) - inss} ");
            }
            else if ( salarioBruto > 5000  && salarioBruto <= 7500  ) 
            
            {
                Console.WriteLine($"Sálario Bruto {valorTrabalhado} * {horaTrabalhada}: R${salarioBruto}");
                Console.WriteLine($"(-) IR (5%) :R$ {ir10} ");
                Console.WriteLine($"(-) INSS (10%): R$: {inss}");
                Console.WriteLine($"FGTS (11%) : R$ {fgts}");
                Console.WriteLine($"Total de descontos : R$ {inss}");
                Console.WriteLine($"Salário Liquido : R$ {salarioBruto - acima2500} ");

            } else (  salarioBruto > 7500  )  

            {

                Console.WriteLine($"Sálario Bruto {valorTrabalhado} * {horaTrabalhada}: R${salarioBruto}");
                Console.WriteLine($"(-) IR (5%) :R$ {ir20} ");
                Console.WriteLine($"(-) INSS (10%): R$: {inss}");
                Console.WriteLine($"FGTS (11%) : R$ {fgts} ") ;
                Console.WriteLine($"Total de descontos : R$ {inss}");
                Console.WriteLine($"Salário Liquido : R$ {salarioBruto - acima2500} ");   


            }
            

        }

    }  
}
