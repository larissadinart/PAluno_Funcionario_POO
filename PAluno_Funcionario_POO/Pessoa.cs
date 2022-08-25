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
        String Nasc;
        String Cpf;
        //método construtor

        public Pessoa(string nome, String nasc, string cpf)
        {
            Nome = nome;
            Nasc = nasc;
            Cpf = cpf;
        }
        public Pessoa()
        {
        }

        public Pessoa(string v1, int v2, string v3)
        {
        }

        public void setNome()
        {
            Console.WriteLine("Digite o nome da pessoa: ");
            this.Nome = Console.ReadLine();
        }
        public void setNasc()
        {
            Console.WriteLine("Digite a data de nascimento da pessoa: ");
            this.Nasc = Console.ReadLine();
        }
        public void setCpf()
        {
            Console.WriteLine("Digite o cpf da pessoa: ");
            this.Cpf = Console.ReadLine();
        }

        public void getNome()
        {
            Console.WriteLine("Nome: "+this.Nome);
        }
        public void getNasc()
        {
            Console.WriteLine("Data de nascimento: "+this.Nasc);
        }
        public void getCpf()
        {
            Console.WriteLine("CPF: "+ this.Cpf);
        }

        public override string ToString()
        {
            return "Nome: " + Nome + "\n Data de nascimento: " + Nasc + "Cpf: " + Cpf; 
        }

        public void cadastraPessoa()
        {
            setNome();
            setNasc();
            setCpf();
        }
        public void imprimePessoa()
        {
            getNome();
            getCpf();
            getNasc();
        }
    }
}


