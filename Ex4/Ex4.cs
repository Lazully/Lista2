// Faça um programa para exibir a tabuada de 0 a 9.

using System;

namespace Ex4
{
    class Ex4
    {
        static void Main(string[] args)
        {
            int multiplicando, multiplicador, produto; 

            Console.WriteLine("======= Tabuada =======");

            for (multiplicando = 1; multiplicando <= 10; ++multiplicando)
            {
                for(multiplicador = 1; multiplicador <= 10; multiplicador++)
                {
                    produto = multiplicador * multiplicando;
                    Console.WriteLine($"{multiplicador} x {multiplicando} = {produto}");
                }
                Console.WriteLine($"{Environment.NewLine}");
            }

        }
    }
}
