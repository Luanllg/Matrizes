using System;
namespace bibliotecamat
{
    class biblioteca
    {

        public static void lerMatriz(int[,] matriz)
        {
            int linhas = matriz.GetLength(0);
            int colunas = matriz.GetLength(1);

            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    Console.Write($"Elemento [{i},{j}]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }// fim for j

            }// fim for i
        }
    
       public  static void mostraMatriz(int[,] matriz)
        {
            int linhas = matriz.GetLength(0);
            int colunas = matriz.GetLength(1);
            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    Console.Write($"{matriz[i, j],3}| "); // 3 é o tamanho do espaço que o número ocupará
                }
                Console.WriteLine();
            }

        }
       public static void geraMatriz(int[,] matriz)


        {

            Random random = new Random();
            int linhas = matriz.GetLength(0);
            int colunas = matriz.GetLength(1);

            for (int i = 0; i < linhas; i++)

                for (int j = 0; j < colunas; j++)

                    matriz[i, j] = random.Next(0, 100);
        }




        public static int SomarMatriz(int[,] matriz)
        {
            int linhas = matriz.GetLength(0);
            int colunas = matriz.GetLength(1);
            int soma = 0;

            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    soma += matriz[i, j];
                }
            }

            return soma;
        }
    }
}