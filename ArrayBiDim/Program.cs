using System;

namespace ArrayBiDim
{
    class Program
    {
        static async void Main(string[] args)
        {
            Console.WriteLine("Escreva a dimensão horizontal de um array bidimensional de floats: ");
            string linhas = Console.ReadLine();
            int linhasInt = int.Parse(linhas);

            Console.WriteLine("Escreva a dimensão vertical do array: ");
            string colunas = Console.ReadLine();
            int colunasInt = int.Parse(colunas);

            float [ , ] matrix = new float [linhas, colunas];

            for(int i=0 ; i<matrix.GetLength(0); i++)
            {
                for(int j=0 ; j<matrix.GetLength(1); i++)
                {
                    Console.WriteLine($"Qual o número para a posição [{i},{j}]");
                    string valor = Console.ReadLine();
                    float valorFloat = float.Parse(valor);
                    matrix[i,j]  = valorFloat;
                }
            }

        }
    }
}
