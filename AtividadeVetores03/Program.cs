using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite os valores do vetor: ");
        int[] vetor = new int[8];

        for (int i = 0; i < vetor.Length; i++)
        {
            vetor[i] = int.Parse(Console.ReadLine());
        }

        Console.Clear();

        Console.WriteLine("Digite um valor para ver se está no vetor: ");
        int valor = int.Parse(Console.ReadLine());

        int contador = 0;

        for (int i = 0; i < vetor.Length; i++)
        {
            if (vetor[i] == valor)
            {
                Console.WriteLine("O " + valor + " foi encontrado na posição: " + i);
                contador++;
            }
        }

        if (contador == 0)
        {
            Console.WriteLine("Não tem esse número no vetor!");
        }
    }
}
