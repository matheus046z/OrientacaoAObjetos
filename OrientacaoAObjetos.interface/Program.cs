﻿using OrientacaoAObjetos.Dia1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoAObjetos.@interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa(); // p1 é o nome do objeto
            p1.Nome = "Claudio José";
            p1.Idade = 34;
            p1.Mensalidade = 15.78m;
            p1.Socio = true;
            p1.Interesse = "Conhecer Novos Modelos";

            Console.WriteLine($"Nosso grande cliente: {p1.Nome.ToUpper().ToString()}");
            Console.WriteLine(p1.VerificarSociedade() ? "é nosso sócio" : "não é sócio"); // operador ternario
            Console.ReadKey();

        }
    }
}
