using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAluno_Funcionario_POO
{
    internal class Aluno : Pessoa
    {
        String Ra;
        String Matricula;


        public Aluno(string nome, String nasc, string cpf, string ra, String matricula)
            : base(nome, nasc, cpf)
        {

            Ra = ra;
            Matricula = matricula;
        }
        public Aluno()
        {

        }
        public void setRa()
        {
            Console.WriteLine("Digite o número do Ra: ");
            this.Ra = Console.ReadLine();
        }

        public void setMatricula()
        {
            Console.WriteLine("Digite o número da Matricula: ");
            this.Matricula = Console.ReadLine();
        }

        public void getRa()
        {
            Console.WriteLine("Ra: " + this.Ra);
        }
        public void getMatricula()
        {
            Console.WriteLine("Matrícula: "+ this.Matricula);
        }

        public override string ToString()
        {
            return "RA: " + Ra + "\n Data de Matrícula: " + Matricula;
        }

        public void cadastraAluno()
        {
            setNome();
            setNasc();
            setCpf();
            setRa();
            setMatricula();
        }
        public void imprimeAluno()
        {
            getNome();
            getCpf();
            getNasc();
            getRa();
            getMatricula();
        }

    }
}



