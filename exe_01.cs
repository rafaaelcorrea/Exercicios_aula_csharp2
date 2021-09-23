using System;

namespace listaexecircios01
{
    class Program
    {
        static void Main(string[] args)
        {
            //fazendo a captura das notas
            Console.WriteLine("Digite a primeira nota.");
            int nota01 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota.");
            int nota02 = Convert.ToInt32(Console.ReadLine());

//calculando a média e exibindo pro usuário
         double media= (nota01 + nota02) /2;
            if(media >= 7){
Console.WriteLine("A sua média é: "+media+". parabenz! foi aprovado.");
            }
            else
            {
                Console.WriteLine("A sua média é: "+media+". infelismente foi reprovado.");
            }
            if(media = 10){
                Console.WriteLine("A sua média é: "+media+". Muito estudioso, continui assin!");
            }
        }
    }
}
