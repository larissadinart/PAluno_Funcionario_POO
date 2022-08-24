using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAluno_Funcionario_POO

{//atributos da classe-pai pessoa
    internal class Pessoa
    {
        String Nome;
        DateTime Nasc;
        String Cpf;
        //método construtor

        public Pessoa(string nome, DateTime nasc, string cpf)
        {
            Nome = nome;
            Nasc = nasc;
            Cpf = cpf;
        }
    }
}


