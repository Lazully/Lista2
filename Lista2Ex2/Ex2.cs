//Faça um programa que leia um número n e mostre na tela os n primeiros números pares e depois
//os n primeiros números ímpares.

using System;

namespace Ex2
{
    class Ex2
    {
        static void Main(string[] args)
        {
            int n, seguintePar = 0, seguinteImpar = 1;

            Console.WriteLine($"====== Mostra Seguintes Par e Impar ======");

            Console.WriteLine($"{Environment.NewLine}Digite um número: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{Environment.NewLine}------------------------------------{Environment.NewLine}");

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{Environment.NewLine}Par: {seguintePar}");
                seguintePar += 2;
            }
            Console.WriteLine($"{Environment.NewLine}------------------------------------{Environment.NewLine}");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{Environment.NewLine}Ímpar: {seguinteImpar}");
                seguinteImpar += 2;
            }
        }
    }
}
