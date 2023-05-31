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
             int opcao;

            do
            {
                Console.WriteLine("MENU");
                Console.WriteLine("1. Exercício 1");
                Console.WriteLine("2. Exercício 2");
                Console.WriteLine("3. Exercício 3");
                Console.WriteLine("4. Sair");
                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Exercicio1();
                        break;
                    case 2:
                        Exercicio2();
                        break;
                    case 3:
                        Exercicio3();
                        break;
                    case 4:
                        Exercicio4();
                        break;
                    case 5:
                        Console.WriteLine("Saindo do programa...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida! Tente novamente.");
                        break;
                }

                Console.WriteLine();
            } while (opcao != 4);
        }

        static void Exercicio1()
        {
            Console.Write("Informe o tamanho do vetor: ");
            int tamanho = int.Parse(Console.ReadLine());

            Random random = new Random();

            int[] vetor = new int[tamanho];

            for (int i = 0; i < tamanho; i++)
            {
                vetor[i] = random.Next(1, 101);
            }

            Console.WriteLine("Vetor:");
            for (int i = 0; i < tamanho; i++)
            {
                Console.WriteLine(vetor[i]);
            }

            int soma = 0;
            for (int i = 0; i < tamanho; i++)
            {
                soma += vetor[i];
            }
            double media = (double)soma / tamanho;

            Console.WriteLine("Média: " + media);

            Console.WriteLine("Executando o exercício 1...");
        }

        static void Exercicio2()
        {
            Console.Write("Informe o tamanho do vetor: ");
            int tamanho1 = int.Parse(Console.ReadLine());

            Random random1 = new Random();

            int[] vetor1 = new int[tamanho1];

            for (int i = 0; i < tamanho1; i++)
            {
                vetor1[i] = random1.Next(1, 101);
            }

            Console.WriteLine("Vetor:");
            for (int i = 0; i < tamanho1; i++)
            {
                Console.WriteLine(vetor1[i]);
            }

            int somaPares = 0;
            int somaImpares = 0;
            for (int i = 0; i < tamanho1; i++)
            {
                if (vetor1[i] % 2 == 0)
                {
                    somaPares += vetor1[i];
                }
                else
                {
                    somaImpares += vetor1[i];
                }
            }

            Console.WriteLine("Soma dos valores pares: " + somaPares);
            Console.WriteLine("Soma dos valores ímpares: " + somaImpares);

            Console.WriteLine("Executando o exercício 2...");
        }

        static void Exercicio3()
        {
            Console.Write("Informe o tamanho do vetor: ");
            int tamanho = int.Parse(Console.ReadLine());

            Random random = new Random();

            int[] vetor = new int[tamanho];

            for (int i = 0; i < tamanho; i++)
            {
                vetor[i] = random.Next(1, 101);
            }

            Console.WriteLine("Vetor de dados da posição 0 para a última:");

            for (int i = 0; i < tamanho; i++)
            {
                Console.WriteLine(vetor[i]);
            }

            Console.WriteLine();

            Console.WriteLine("Vetor de dados da última para a posição 0:");

            for (int i = tamanho - 1; i >= 0; i--)
            {
                Console.WriteLine(vetor[i]);
            }
            Console.WriteLine("Executando o exercício 3...");
        }
        static void Exercicio4()
        {
            Console.Write("Informe o tamanho do vetor: ");
            int tamanho = int.Parse(Console.ReadLine());

            Random random = new Random();

            int[] vetor = new int[tamanho];

            for (int i = 0; i < tamanho; i++)
            {
                vetor[i] = random.Next(1, 101);
            }

            Console.WriteLine("Valores do vetor:");
            for (int i = 0; i < tamanho; i++)
            {
                Console.Write(vetor[i] + " ");
            }
            Console.WriteLine();

            int soma = 0;
            int contador = 0;

            for (int i = 0; i < tamanho; i++)
            {
                if (vetor[i] % 3 == 0 && vetor[i] % 5 == 0)
                {
                    soma += vetor[i];
                    contador++;
                }
            }

            double media = contador > 0 ? (double)soma / contador : 0;

            Console.WriteLine("Média aritmética dos valores divisíveis por 3 e por 5: " + media);

    Console.WriteLine("Executando o exercício 4...");
        }
    }
}
