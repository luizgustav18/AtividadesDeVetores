using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Digite um valores para preencher o vetor 1: ");
        int[] vetor1 = new int[10];
        for (int i = 0; i < 10; i++)
        {
            vetor1[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Digite um valores para preencher o vetor 2: ");
        int[] vetor2 = new int[10];
        for (int i = 0; i < 10; i++)
        {
            vetor2[i] = int.Parse(Console.ReadLine());
        }

        int[] vetor3 = new int[10];

        for (int i = 0; i< 10; i++)
        {
            vetor3[i] = vetor1[i] + vetor2[i];
        }
        Console.WriteLine("A soma dos vetores: ");
        for (int i = 0; i< 10; i++)
        {
            Console.WriteLine("Posição: " + i + " Soma:  " + vetor3[i] );
        }
     
    }
}