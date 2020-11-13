using System;

namespace cs
{
    class cs
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------");
             Console.WriteLine("bem-vindo a seletiva de cs");
              Console.WriteLine("-------------------------");
               Console.WriteLine("você gostaria de participar?");
               string resposta= Console.ReadLine();
               if(resposta=="sim"){
                   Console.WriteLine("que legal! agora vamos analisar seu perfil");
                   Console.WriteLine("insira sua media: ");
                   int media = int.Parse(Console.ReadLine());
                   Console.WriteLine("insira suas faltas: ");
                   int faltas =int.Parse(Console.ReadLine());
                   if(media >50 && faltas < 10){
                       Console.WriteLine("seja bem vindo ao time");
                   }
                   else{
                       Console.WriteLine("Que triste, voce nao pode participar!");
                   }
               }
               else{
                   Console.WriteLine("tudo bem, adeus!");
               }
        }
    }
}
