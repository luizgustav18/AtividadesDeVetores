using System;

class Program
{
    static void Main()
    {
        int[] vetor1 = new int[10];
        int[] vetor2 = new int[10];

        Console.WriteLine("Digite os valores do vetor:");

        for (int i = 0; i < vetor1.Length; i++)
        {
            vetor1[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < vetor1.Length; i++)
        {
            vetor2[i] = vetor1[vetor1.Length - 1 - i];
        }


        Console.WriteLine("Vetor invertido:");

        for (int i = 0; i < vetor2.Length; i++)
        {
            Console.WriteLine(vetor2[i]);
        }
    }
}
