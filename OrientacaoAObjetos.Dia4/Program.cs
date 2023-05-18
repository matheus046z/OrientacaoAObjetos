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
            int soma = 0;

            int[] notas = new int[10]; // cria um vetor de notas indexado a 10 (0 a 9)
            
            for (int i = 0; i < notas.Length; i++)
            {
                Console.Write($"Digite a nota ({i}): ");
                notas[i] = int.Parse(Console.ReadLine());
                soma = soma + notas[i];
            }

            for (int i = 0; i < notas.Length; i++) // notas.Lenght é 10, mas o contador vai até a posiçao 9 pois o array começa em 0
            {
                Console.WriteLine(i + " - Nota: " + notas[i]);
            }

            /*
            Console.WriteLine("Alo Mundo");
            int nota1;
            Console.WriteLine("Digite a nota 1");
            nota1 = int.Parse(Console.ReadLine());
            */
            Console.WriteLine("Lenght: " + notas.Length);
            Console.ReadKey();


        }
    }
}
