using System;

namespace ArrayBiDim
{
    class Program
    {
        static async void Main(string[] args)
        {
            Console.WriteLine("Escreva a dimensão horizontal de um array bidimensional de floats: ");
            int linhas = Console.ReadLine();

            Console.WriteLine("Escreva a dimensão vertical do array: ");
            int colunas = Console.ReadLine();

            float [ , ] matrix = new float [linhas, colunas];

            for(int i=0 ; i<matrix.GetLength(0); i++)
            {
                for(int j=0 ; j<matrix.GetLength(1); i++)
                {
                    Console.WriteLine($"Qual o número para a posição [{i},{j}]");
                    float valor = Console.ReadLine();
                    matrix [i,j] = valor;
                }
            }

        }
    }
}
