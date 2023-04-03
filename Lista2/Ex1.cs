//Faça um programa que leia vários inteiros positivos e mostre, no final, a soma dos números pares
//e a soma dos números ímpares. O programa para quando entrar um número maior que 1000.

using System;

namespace Lista2
{
    class Ex1
    {
        static void Main(string[] args)
        {
            int contaN, somaPar = 0, somaImpar = 0;

            Console.WriteLine("========= Soma par e impar =========");

            do
            {
                Console.WriteLine($"{Environment.NewLine}Digite um número: ");
                contaN = Convert.ToInt32(Console.ReadLine());

                if (contaN % 2 == 1 && contaN <=1000)
                {
                    somaImpar += contaN;//soma = soma + contaN
                }
                else
                {
                    if (contaN % 2 == 0 && contaN <= 1000)
                    {
                        somaPar += contaN;
                    }
                    else
                    {
                        Console.WriteLine("Número inválido! ");
                    }
                }

                Console.WriteLine($"{Environment.NewLine}Soma dos ímpares: {somaImpar}");
                Console.WriteLine($"Soma dos pares: {somaPar}");

            } while (contaN < 1000);
        }
    }
}
