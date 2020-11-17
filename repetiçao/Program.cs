using System;

namespace repetiçao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("deseja a tabuada de qual numero?: ");
            int resposta=int.Parse(Console.ReadLine());
             int resultado;
             for (int contador = 10; contador > 0; contador--)
             {
                 resultado= resposta * contador;
                 Console.WriteLine($"{resposta} x {contador} = {resultado}");
             }
        }
    }
}
