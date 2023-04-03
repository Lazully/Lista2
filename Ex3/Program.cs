//Faça um programa que calcula o produto dos números digitados pelo usuário. O programa deve
//permitir que o usuário digite uma quantidade não determinada de números. O programa encerra
//quando o usuário digita o valor zero.


using System;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero, soma = 0;

            Console.WriteLine("========= Produto dos números =========");
            Console.WriteLine("O programa terminará quando '0' for digitado. ");

            do
            {
                Console.WriteLine($"{Environment.NewLine}Digite um número: ");
                numero = Convert.ToDouble(Console.ReadLine());

                soma *= numero;
                Console.WriteLine($"{Environment.NewLine}O produto dos números é: {soma}");

            } while (numero != 0);
        }
    }
}
