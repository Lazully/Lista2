//Faça um programa que leia um número n e mostre na tela os n primeiros números pares e depois
//os n primeiros números ímpares.

using System;

namespace Lista2Ex2
{
    class Ex2
    {
        static void Main(string[] args)
        {
            int n, seguintePar = 0, seguinteImpar = 0;

            Console.WriteLine($"====== Mostra Seguintes Par e Impar ======");

            Console.WriteLine($"{Environment.NewLine}Digite um número: ");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = n; i < (n + n); i++)
            {
                if (n % 2 == 0)
                {
                    seguintePar = n;
                    seguintePar +=2;
                }
                else
                {
                    if (n % 2 == 1)
                    {
                        seguinteImpar = n;
                        seguinteImpar +=2;
                    }
                }
                Console.WriteLine($"{Environment.NewLine}Primeiros números pares: {seguintePar}");
                Console.WriteLine($"{Environment.NewLine}Primeiros números ímpares: {seguinteImpar}");
            }
        }
    }
}
