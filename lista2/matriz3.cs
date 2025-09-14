using System;
using bibliotecamat;

class matriz3
{
    static void Main()
    {
        Console.WriteLine("Digite o número de linhas da matriz:");
        int linhas = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o número de colunas da matriz:");
        int colunas = int.Parse(Console.ReadLine());

        int[,] matriz = new int[linhas, colunas];

        bibliotecamat.biblioteca.geraMatriz(matriz);
        Console.WriteLine("Matriz gerada:");
        bibliotecamat.biblioteca.mostraMatriz(matriz);

        Console.WriteLine("Informe qual elemento deve ser analisado:");
        int elemento = int.Parse(Console.ReadLine());

        
        int contador = 0;
        foreach (int valor in matriz)
        {
            if (valor == elemento)
            {
                contador++;
            }
        }

        Console.WriteLine($"O número {elemento} aparece {contador} vez(es) na matriz.");
    }
}
