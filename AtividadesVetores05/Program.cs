using System;
using System.Runtime.Serialization;
class Program
{
    static void Main()
    {
        int impares = 0;
        int pares = 0;

        Console.Write("Digite valores para o vetor: ");
        int[] vetor = new int[5];

        int maior = 0;
        int menor = 0;

        for (int i = 0; i < vetor.Length; i++)
        {
            vetor[i] = int.Parse(Console.ReadLine());
            if (vetor[i] % 2 != 0)
            {
                impares++;
            }
            else
            {
                pares++;
            }
            if (maior > 50)
            {
                maior++;
            }
            else if (menor < 7)
            {
                menor++;
            }
        }
        Console.WriteLine("Números impares do vetor: " + impares);
        Console.WriteLine("Números pares do vetor: " + pares);
        Console.WriteLine("Números maoiores que 50 do vetor: " + maior);
        Console.WriteLine("Números menores que 7 do vetor: " + menor);
    }
}