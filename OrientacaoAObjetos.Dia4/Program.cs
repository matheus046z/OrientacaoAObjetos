using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
// teoria dos conjuntos, matrizes e logica aritmetica

namespace OrientacaoAObjetos.Dia4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int soma = 0;

            //int[] notas = new int[10]; // cria um vetor de notas indexado a 10 (0 a 9)

            //for (int i = 0; i < notas.Length; i++)
            //{
            //    Console.Write($"Digite a nota ({i}): ");
            //    notas[i] = int.Parse(Console.ReadLine());
            //    soma = soma + notas[i];
            //}

            //for (int i = 0; i < notas.Length; i++) // notas.Lenght é 10, mas o contador vai até a posiçao 9 pois o array começa em 0
            //{
            //    Console.WriteLine(i + " - Nota: " + notas[i]);
            //}
            //Console.WriteLine("Soma das notas: " + soma);
            //Console.WriteLine("Lenght: " + notas.Length);
            //Console.ReadKey();

            //Console.Clear();

            int[,] matrizQuadrada = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"({i}, {j}):Digite um número: ");
                    matrizQuadrada[i,j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("***Mostrando os dados***");
            foreach (var item in matrizQuadrada)
            {
                Console.Write(item.ToString());
            }

            Console.WriteLine("\n***Mostrando os dados da diagonal principal***");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if(i == j)
                    {
                        Console.Write(matrizQuadrada[i,j]);
                    }
                }
            }

            Console.WriteLine("\n***Mostrando os dados da diagonal secundária***");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i + j == j + 1)
                    {
                        Console.Write(matrizQuadrada[i, j]);
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
