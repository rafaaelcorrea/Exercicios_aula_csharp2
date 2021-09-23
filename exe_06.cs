using System;

namespace listaexecircios01
{
    class Program
    {
        static void Main(string[] args)
        {
//string iniciada com valor null, que vai receber os dias e o texto de dia inválido
string dia=null;
            
            //Pegando o número do usuário
            Console.WriteLine("Digite um número para saber o dia:");
            int nun= Convert.ToInt32(Console.ReadLine());

//definindo a resposta
            if(nun == 1){
dia="Domingo";
            }
            else if(nun == 2){
dia="Segunda Feira";
            }
else if(nun == 3){
dia="Terça Feira";
            }
else if(nun == 4){
dia="Quarta feira";
            }
else if(nun == 5){
dia="Quinta Feira";
            }
else if(nun == 6){
dia="Sexta Feira";
            }
else if(nun == 7){
dia="Sábado";
            }
else
{
    dia="inválido.";
}

//Retornando a resposta da string com um texto
Console.WriteLine("o dia é " + dia);
        }
    }
}
