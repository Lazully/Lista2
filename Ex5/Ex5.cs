//Escreva um programa que lê 15 valores reais, encontra o maior e o menor deles e mostra o
//resultados.

using System;

namespace Ex5
{
    class Ex5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("============ Encontra Menor Valor ============");

            MaiorMenor();
        }

        public static void MaiorMenor()
        {
            int maior=Int32.MinValue, menor=Int32.MaxValue, numEntrada;

            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine($"{Environment.NewLine}Digite um número: ");
                numEntrada = Convert.ToInt32(Console.ReadLine());

                if(numEntrada > maior)
                {
                    maior = numEntrada;
                }

                if(numEntrada < menor)
                {
                    menor = numEntrada;
                }
            }
            Console.WriteLine($"{Environment.NewLine}Maior: {maior} {Environment.NewLine}Menor: {menor}");
        }
    }
}
