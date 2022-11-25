using System;

namespace DiagonalMatriz
{
    class Program
    {
        static void Main (string[] args)
        {

            Console.Write("Digite a ordem da matriz: ");
            int n = int.Parse(Console.ReadLine()!);

            //Instancia uma matriz n por n
            int[ , ] mat = new int[n, n];

            //Percorre as linhas da matriz
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Digite a " + (i + 1) + "ª linha da matriz com " + n + " elementos:");
                
                /*Lê a linha, recorta cada valor baseado no espaço em branco,
                e guarda em um vetor*/
                string[] valores = Console.ReadLine()!.Split(' ');

                //Para cada linha, percorre as colunas
                for (int j = 0; j < n; j++)
                {
                    //Percorre vetor e guarda na matriz cada um dos elementos
                    mat[i, j] = int.Parse(valores[j]);
                }
            }
                    
                    Console.WriteLine("Diagonal principal: ");
             for (int j = 0; j < n; j++)
                {
                    Console.Write(mat[j, j] + " ");

                }

             Console.WriteLine();

            //Contador
            int count = 0;

            //Percorre a matriz e vê se o elemento é negativo
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] < 0)
                        count++;
                }
            }
            Console.WriteLine("Números negativos: " + count);
            
        }
    }
}