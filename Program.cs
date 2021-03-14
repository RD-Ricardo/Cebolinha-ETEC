using System;

namespace Cebolinha
{
    class Program
    {
        static void Main(string[] args)
        {  
            string frase;
            Console.WriteLine("Cebolinha");
            Console.WriteLine("---------");
            Console.WriteLine("Digite um frase");
            frase =  Console.ReadLine();
            frase = frase.Replace("r" , "l" );
            Console.WriteLine(frase);            

        }
    }
}
