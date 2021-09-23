using System;

namespace listaexecircios01
{
    class Program
    {
        static void Main(string[] args)
        {
         //Variáveis dos dados
         double percentual=0;
             double valoralmento =0;
            double valorAlmentado=0;
             //Buscando o salário
             Console.WriteLine("Qual o salário do funcionário?");
            int salario = Convert.ToInt32(Console.ReadLine());

//Fazendo as ecessões e salvando nas variáveis ja iniciadas
         if (salario <= 2800) {
            percentual=1.20;
            valorAlmentado= salario*1.20;
            valoralmento= (salario*1.20)-salario;
         }


if (salario > 2800 && salario < 7000) {
            percentual=1.15;
            valorAlmentado= salario*1.15;
            valoralmento= (salario*1.15)-salario;
         }

if (salario < 15000 && salario > 15000) {
            percentual=1.10;
            valorAlmentado= salario*1.10;
            valoralmento= (salario*1.10)-salario;    

} else  {
             percentual=1.5;
            valorAlmentado= salario*1.5;
            valoralmento= (salario*1.5)-salario;        
}
         //Exibindo pro usuário
         Console.WriteLine("O percentual vai ser de "+percentual+", A quantidade do almento vai ser de "+valoralmento+" Reais, e o valor total vai ser de "+valorAlmentado+" reais.");
        }
    }
}