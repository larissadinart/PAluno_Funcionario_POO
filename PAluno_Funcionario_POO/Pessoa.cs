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

        public void getNome()
        {
            Console.WriteLine(this.Nome);
        }
        public void getNasc()
        {
            Console.WriteLine(this.Nasc);
        }
        public void getCpf()
        {
            Console.WriteLine(this.Cpf);
        }

        public override string ToString()
        {
            return "Nome: " + Nome + "\n Data de nascimento: " + Nasc + "Cpf: " + Cpf;
        }




    }
}


