using System;
using bibliotecamat;

class matriz1
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
        

        int menor = int.MaxValue;

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                if (matriz[i, j] < menor)
                {
                    menor = matriz[i, j];
                }
            }
        }

        Console.WriteLine($"O menor valor da matriz é: {menor}");
    }
}
