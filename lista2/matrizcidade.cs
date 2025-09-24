using System;
using bibliotecamat;
class matrizcidade

{
    static int menorindeicezona(int[,] matrizindice)
    {
        int contador = 0;
        int valordacoluna = 0;
        int menorvalorcoluna = 0;
        int linhas = matrizindice.GetLength(0);
        int colunas = matrizindice.GetLength(1);
        for (int i = 0; i < linhas; i++)
        {
            menorvalorcoluna += matrizindice[i, 0];
            
        }
        for (int j = 1; j < colunas; j++)
        {
            valordacoluna = 0;
            for (int i = 0; i < linhas; i++)
            {
                valordacoluna += matrizindice[i, j];
            }// fim for i
            if (menorvalorcoluna >= valordacoluna)
            {
                menorvalorcoluna = valordacoluna;
                contador = j;
            }
            else
            {

            }
        }// fim for j
            Console.WriteLine($"A zona com menor índice contem {menorvalorcoluna} pessoas, sendo o barirro {contador+1}");
        return menorvalorcoluna;
    }
    static int maiorindece(int[,] matrizpopulacao)
    {
        int contador = 0;
        int linhas = matrizpopulacao.GetLength(0);
        int colunas = matrizpopulacao.GetLength(1);
        int maiorvalor = 0;
        int valordalinha = 0;
        for (int i = 0; i < linhas; i++)//percprre linha
        {
            valordalinha = 0;
            for (int j = 0; j < colunas; j++)//percorre coluna
            {
                valordalinha += matrizpopulacao[i, j];
            }// fim for j

            if (valordalinha > maiorvalor)
            {
                maiorvalor = valordalinha;
                contador = i;
            }
            else
            {
                Console.Write("");

            }
        }// fim for i
        Console.WriteLine($"O maior bairro contem {maiorvalor} pessoas sendo o bairro {contador+1}");
        return maiorvalor;
    }
    static int somadaszonas(int[,] colunamatriz)

    {
        int valordacoluna = 0;
        int linhas = colunamatriz.GetLength(0);
        int colunas = colunamatriz.GetLength(1);
        for (int j = 0; j < colunas; j++)
        {
            valordacoluna = 0;
            for (int i = 0; i < linhas; i++)
            {
                valordacoluna += colunamatriz[i, j];
            }// fim for j
            Console.WriteLine($"O valor de pessoas da zona {j + 1} é: {valordacoluna}");
        }// fim for i
        return valordacoluna;
    }
    static int somadosbairros(int[,] linhamatriz)

    {
        int valordalinha = 0;
        int linhas = linhamatriz.GetLength(0);
        int colunas = linhamatriz.GetLength(1);
        for (int i = 0; i < linhas; i++)
        {
            valordalinha = 0;
            for (int j = 0; j < colunas; j++)
            {
                valordalinha += linhamatriz[i, j];
            }// fim for j
            Console.WriteLine($"O valaor de pessoas do bairro {i + 1} é: {valordalinha}");
        }// fim for i
        return valordalinha;
    }
    static int somatoriadacidade(int[,] matriz)
    {
        int linhas = matriz.GetLength(0);
        int colunas = matriz.GetLength(1);
        int valorfinal = 0;
        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                valorfinal += matriz[i, j];
            }// fim for j

        }// fim for i
        return valorfinal;
    }
    static void Main()
    {
        int linhas, colunas;
        Console.WriteLine("Digite o tamanho da matriz, com as linhas e depois colunas:");
        linhas = int.Parse(Console.ReadLine());
        colunas = int.Parse(Console.ReadLine());
        int[,] cidade = new int[linhas, colunas];
        biblioteca.geraMatriz(cidade);
        Console.WriteLine("Mapa populacional!");
        biblioteca.mostraMatriz(cidade);
        int somamatriz = somatoriadacidade(cidade);
        Console.WriteLine("------SOMA DA POPULAÇÃO------");
        Console.WriteLine($"Valor total das pessoas na cidade é {somamatriz}.");
        Console.Write("");
        Console.WriteLine("------SOMA  DE BAIRROS------");
        int somabairro = somadosbairros(cidade);
        Console.Write("");
        Console.WriteLine("------SOMA  DE ZONAS------");
        int somazona = somadaszonas(cidade);
        Console.WriteLine("");
        Console.WriteLine("------SOMA  DE MAIOR ÍNDECE------");
        int maispopuloso = maiorindece(cidade);
        Console.WriteLine("------SOMA  DE MENOR ÍNDECE------");
        Console.Write("");
        int maiorzona = menorindeicezona(cidade);
    }

}


 //(a) Calcular o total de pessoas em toda a cidade.(feito)
//(b) Calcular o total de pessoas por linha (por bairro).(feito)
//(c) Calcular o total de pessoas por coluna (zonas da cidade - sul, suldeste, norte, etc).
//(d) Determinar o bairro mais populoso.
//(e) Determinar a zona menos populosa.