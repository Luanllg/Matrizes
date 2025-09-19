using System;
using  bibliotecamat;
class matriz8
{
    static int raiosdomesmolocal(int[,] matriz)
    {
        int linhas = matriz.GetLength(0);
        int colunas = matriz.GetLength(1);
        int contador = 0;
        for (int i = 0; i < linhas; i++)
            {
            for (int j = 0; j < colunas; j++)
            {
                if (matriz[i, j] > 1)
                {
                    contador++;
                }
            }
        }
     return contador;
    }
    static void Main()
    {
        int x, y, numerosderaios;
        int linhas, colunas;
        Console.WriteLine("Qual a quantiade de linhas e colunas?");
        linhas = int.Parse(Console.ReadLine());
        colunas = int.Parse(Console.ReadLine());
        int[,] mapa = new int[linhas, colunas];
        biblioteca.mostraMatriz(mapa);
        Console.Write("Quantos raios caíram? ");
        numerosderaios = int.Parse(Console.ReadLine());
        for (int i = 0; i < numerosderaios; i++)
        {
            Console.WriteLine("Digite a cordenada em que eses raios cairam:");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            mapa[x, y]++;

        }
        int raiosdemesmplocal = raiosdomesmolocal(mapa);
        biblioteca.mostraMatriz(mapa);
        Console.WriteLine($"O número de ocorrencias de raio de mesmo local foram :{raiosdemesmplocal}"); 
    }
}