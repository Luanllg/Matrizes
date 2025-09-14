using System;
using bibliotecamat;

class matriz2
{
    static void Main()
    {
        Console.WriteLine("Digite o número de linhas da matriz:");
        int linhas = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o número de colunas da matriz:");
        int colunas = int.Parse(Console.ReadLine());

        int[,] matriz = new int[linhas, colunas];

        biblioteca.geraMatriz(matriz);
        Console.WriteLine("Matriz gerada:");
        biblioteca.mostraMatriz(matriz);

        int maior = int.MinValue; // Corrigido

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                if (matriz[i, j] > maior)
                {
                    maior = matriz[i, j];
                }
            }
        }

        Console.WriteLine($"O maior valor da matriz é: {maior}");
    }
}
