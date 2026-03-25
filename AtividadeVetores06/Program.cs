using System;

class Program
{
    static void Main()
    {
        double[] vetor = new double[10];

        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write("Digite o salário do funcionario " + (i+1) + " : " + "R$");
            vetor[i] = double.Parse(Console.ReadLine());

            vetor[i] = vetor[i] + (vetor[i] * 0.05);
        }

        Console.WriteLine("\nSalários reajustados:\n");

        for (int i = 0; i < vetor.Length; i++)
        {
            Console.WriteLine("Funcionario " + (i + 1) + ": " + vetor[i].ToString("F2"));
        }
    }
}