using System;
using System.Runtime.Serialization;
class Program
{
    static void Main()
    {
        int soma = 0;

        Console.Write("Digite valores para o vetor: ");
        int[] vetor = new int[10];
        

        for (int i = 0; i < vetor.Length; i++)
        {
            vetor[i] = int.Parse(Console.ReadLine());
            soma = vetor[i] + soma;
        }
        Console.WriteLine("A soma do vetor: " + soma);
    }
}