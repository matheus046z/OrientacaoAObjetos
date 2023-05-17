using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoAObjetos.Dia2
{
    public class Segurado
    {
        public int Id { get; set; }
        public  string Nome { get; set; }
        public string CPF { get; set; } 


        // construtor tambem serve para passar dados
        // O construtor tem o mesmo nome da classe
        // 1o construtor -> default (nao definido, padrao, ja existe, vem da orientação a objeto)
        // 2o construtor -> com parametro
        // 3o construtor -> com sobrecarga (override), dá opções diferenciadas, ex pesquisar id e nome
        // O construtor constroi o objeto na memoria
        // injeção de dependencia
        //garbage collector (gerenciador de memoria interno)
        // é importante criar um construtor vazio, se nao fica obrigatorio sempre passar parametros para o construtor
        public Segurado() // 2o contrutor vazio
        {

        }
        //pesquisar por Id
        public Segurado(int id)
        {
            Id = id;
        }
        // construtor com sobrecarga (Override)
        // cadastrar, insert no banco
        public Segurado(string nome)
        {
            Nome = nome;
        } 
        public Segurado(string nome, string cpf)
        {
            Nome = nome;
            CPF = cpf;
        }

        public string Teste()
        {
            return "Chegou Aqui! E não é Brazlandia!";
        }
    }
}
