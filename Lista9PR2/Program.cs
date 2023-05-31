using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista9PR2
{
    internal class Program
    {
        static void ImprimirVetor(int[] vetor, int tamanho)
        {
            for (int i = 0; i < tamanho; i++)
            {
                Console.WriteLine(vetor[i]);
            }
            Console.WriteLine();
        }

        // Função auxiliar para ordenar o vetor em ordem crescente
        static void OrdenarVetorCrescente(int[] vetor, int tamanho)
        {
            for (int i = 0; i < tamanho - 1; i++)
            {
                for (int j = i + 1; j < tamanho; j++)
                {
                    if (vetor[j] < vetor[i])
                    {
                        int temp = vetor[i];
                        vetor[i] = vetor[j];
                        vetor[j] = temp;
                    }
                }
            }
        }

        // Função auxiliar para inverter o vetor
        static void InverterVetor(int[] vetor, int tamanho)
        {
            int i = 0;
            int j = tamanho - 1;
            while (i < j)
            {
                int temp = vetor[i];
                vetor[i] = vetor[j];
                vetor[j] = temp;
                i++;
                j--;
            }
        }
        static void Main(string[] args)


        {

            int Ex;

            Console.WriteLine("========Menu========");
            Console.WriteLine("====Exercício 1=====");
            Console.WriteLine("====Exercício 2=====");
            Console.WriteLine("====Exercício 3=====");
            Console.WriteLine("====Exercício 4=====");

            Ex = int.Parse(Console.ReadLine());

            switch (Ex)
            {
                case 1:
                    Console.Write("Informe o tamanho do vetor: ");
                    int tamanho = int.Parse(Console.ReadLine());

                    // Cria um objeto Random para gerar valores aleatórios
                    Random random = new Random();

                    // Cria o vetor com o tamanho informado pelo usuário
                    int[] vetor = new int[tamanho];

                    // Preenche o vetor com valores aleatórios
                    for (int i = 0; i < tamanho; i++)
                    {
                        // Gera um valor aleatório entre 1 e 100
                        vetor[i] = random.Next(1, 101);
                    }

                    // Imprime o vetor
                    Console.WriteLine("Vetor:");
                    for (int i = 0; i < tamanho; i++)
                    {
                        Console.WriteLine(vetor[i]);
                    }

                    // Calcula a média aritmética dos valores no vetor
                    int soma = 0;
                    for (int i = 0; i < tamanho; i++)
                    {
                        soma += vetor[i];
                    }
                    double media = (double)soma / tamanho;

                    // Imprime a média aritmética
                    Console.WriteLine("Média: " + media);
                    break;
                case 2:
                    Console.Write("Informe o tamanho do vetor: ");
                    int tamanho1 = int.Parse(Console.ReadLine());

                    // Cria um objeto Random para gerar valores aleatórios
                    Random random1 = new Random();

                    // Cria o vetor com o tamanho informado pelo usuário
                    int[] vetor1 = new int[tamanho1];

                    // Preenche o vetor com valores aleatórios
                    for (int i = 0; i < tamanho1; i++)
                    {
                        // Gera um valor aleatório entre 1 e 100
                        vetor1[i] = random1.Next(1, 101);
                    }

                    // Imprime o vetor
                    Console.WriteLine("Vetor:");
                    for (int i = 0; i < tamanho1; i++)
                    {
                        Console.WriteLine(vetor1[i]);
                    }

                    // Calcula a soma dos valores pares e ímpares
                    int somaPares = 0;
                    int somaImpares = 0;
                    for (int i = 0; i < tamanho1; i++)
                    {
                        if (vetor1[i] % 2 == 0) // Verifica se o valor é par
                        {
                            somaPares += vetor1[i];
                        }
                        else
                        {
                            somaImpares += vetor1[i];
                        }
                    }

                    // Imprime a soma dos valores pares e ímpares
                    Console.WriteLine("Soma dos valores pares: " + somaPares);
                    Console.WriteLine("Soma dos valores ímpares: " + somaImpares);
                    break;
                case 3:

                    break;
                case 4:
                    Console.Write("Informe o tamanho do vetor: ");
                    int tamanho = int.Parse(Console.ReadLine());

                    // Cria um objeto Random para gerar valores aleatórios
                    Random random = new Random();

                    // Cria o vetor com o tamanho informado pelo usuário
                    int[] vetor = new int[tamanho];

                    // Preenche o vetor com valores aleatórios
                    for (int i = 0; i < tamanho; i++)
                    {
                        // Gera um valor aleatório entre 1 e 100
                        vetor[i] = random.Next(1, 101);
                    }

                    // Imprime o vetor gerado
                    Console.WriteLine("Vetor original:");
                    ImprimirVetor(vetor, tamanho);

                    // Ordena o vetor em ordem crescente
                    OrdenarVetorCrescente(vetor, tamanho);

                    // Imprime o vetor em ordem crescente
                    Console.WriteLine("Vetor em ordem crescente:");
                    ImprimirVetor(vetor, tamanho);

                    // Inverte o vetor para ordem decrescente
                    InverterVetor(vetor, tamanho);

                    // Imprime o vetor em ordem decrescente
                    Console.WriteLine("Vetor em ordem decrescente:");
                    ImprimirVetor(vetor, tamanho);
            }

            // Função auxiliar para imprimir o vetor
            static void ImprimirVetor(int[] vetor, int tamanho)
            {
                for (int i = 0; i < tamanho; i++)
                {
                    Console.WriteLine(vetor[i]);
                }
                Console.WriteLine();
            }

            // Função auxiliar para ordenar o vetor em ordem crescente
            static void OrdenarVetorCrescente(int[] vetor, int tamanho)
            {
                for (int i = 0; i < tamanho - 1; i++)
                {
                    for (int j = i + 1; j < tamanho; j++)
                    {
                        if (vetor[j] < vetor[i])
                        {
                            int temp = vetor[i];
                            vetor[i] = vetor[j];
                            vetor[j] = temp;
                        }
                    }
                }
            }

            // Função auxiliar para inverter o vetor
            static void InverterVetor(int[] vetor, int tamanho)
            {
                int i = 0;
                int j = tamanho - 1;
                while (i < j)
                {
                    int temp = vetor[i];
                    vetor[i] = vetor[j];
                    vetor[j] = temp;
                    i++;
                    j--;
                }
            }
            break;
        }
    }
}
 
