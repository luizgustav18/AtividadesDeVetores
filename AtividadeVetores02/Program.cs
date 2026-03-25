using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Digite valores para o vetor: ");
        int[] vetor = new int[15];
        for (int i = 0; i < vetor.Length; i++)
        {
            vetor[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nNúmeros positivos dos vetores: ");
        for (int i = 0; i < vetor.Length; i++)
        {            
            if (vetor[i] >= 0)
            {
                Console.WriteLine(vetor[i]);
            }
        }
    }
}