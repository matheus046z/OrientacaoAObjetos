using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoAObjetos.Dia3
{
    public class Cliente
    {
        public int  Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }

        public Cliente()
        {

        }
        public Cliente (int id)
        {
            Id = id;
        }
        public Cliente (string nome)
        {
            Nome = nome;
        }
        public Cliente(string nome, string cpf)
        {
            Nome = nome;
            CPF = cpf;
        }

        public Cliente(int id, string nome, string cpf)
        {
            Id = id;
            Nome = nome;
            CPF = cpf;
        }

        public static bool ValidarCPF(string cpf)
        {
            // Remove caracteres especiais do CPF
            cpf = new string(cpf.Where(char.IsDigit).ToArray());

            // Verifica se o CPF possui 11 dígitos
            if (cpf.Length != 11)
                return false;

            // Verifica se todos os dígitos do CPF são iguais
            if (cpf.Distinct().Count() == 1)
                return false;

            // Calcula o primeiro dígito verificador
            int soma = 0;
            for (int i = 0; i < 9; i++)
                soma += int.Parse(cpf[i].ToString()) * (10 - i);
            int resto = soma % 11;
            int digitoVerificador1 = resto < 2 ? 0 : 11 - resto;

            // Verifica se o primeiro dígito verificador está correto
            if (int.Parse(cpf[9].ToString()) != digitoVerificador1)
                return false;

            // Calcula o segundo dígito verificador
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(cpf[i].ToString()) * (11 - i);
            resto = soma % 11;
            int digitoVerificador2 = resto < 2 ? 0 : 11 - resto;

            // Verifica se o segundo dígito verificador está correto
            if (int.Parse(cpf[10].ToString()) != digitoVerificador2)
                return false;

            // CPF válido
            return true;
        }

    }
}