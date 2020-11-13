using System;

namespace exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, sou um computador que calcula quantos meses, dias, horas e minutos que você viveu");
            Console.WriteLine("gostaria de saber alguma dessas informaçoes?");
            string resposta=  Console.ReadLine();
            if (resposta== "sim"){
                Console.WriteLine("gostaria de saber sobre seus meses dias horas e minutos?");
                string resposta3= Console.ReadLine();
                if(resposta3=="sim"){
                    Console.WriteLine("quantos anos você tem? ");
                    int idade= int.Parse(Console.ReadLine());
                    int meses= idade * 12;
                    int dias= idade *365;
                    int horas= idade * 8760;
                    int minutos= idade * 525600;
                    Console.WriteLine("você tem " + meses + " meses, " + dias + " dias, " + horas + " horas, "+ minutos +" minutos de vida" );
                }
                else{
                     Console.WriteLine("muito obrigado, irei me desligar então");
                     
                }
            }
            else{
                Console.WriteLine("então gostaria de saber apenas quantas semanas?");
                string resposta2=  Console.ReadLine();
               if(resposta2=="sim"){
                   Console.WriteLine("quantos anos você tem?");
                   int idade2= int.Parse(Console.ReadLine());
                   int semanas= idade2 * 52;
                    Console.WriteLine("Você tem " + semanas +" semanas de vida");
                    if(semanas<963){
                        Console.WriteLine("infelizmente, você ainda nao pode dirigir");
                        Console.WriteLine("obrigado por usar meus serviços, irei desligar agora!");
                    }
                    else{
                        Console.WriteLine("parabens! você ja pode dirigir");
                         Console.WriteLine("obrigado por usar meus serviços, irei desligar agora!");
                    }
                
               }
                else
                {
                       Console.WriteLine("muito obrigado, irei me desligar então");
                }
            }
        }
    }
}
