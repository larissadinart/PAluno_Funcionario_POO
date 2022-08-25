using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAluno_Funcionario_POO
{
    internal class Funcionario : Pessoa
    {
        String Pis;
        float Salario;
        String Setor;

        public Funcionario(string nome, String nasc, string cpf,string pis, float salario, string setor)
            : base(nome, nasc, cpf)
        {
            Pis = pis;
            Salario = salario;
            Setor = setor;
        }
        public Funcionario()
        {

        }
        void setPis()
        {
            Console.WriteLine("Digite o numero do Pis: ");
            this.Pis = Console.ReadLine();
        }
        void setSalario()
        {
            Console.WriteLine("Digite o valor do Salário: ");
            this.Salario = float.Parse(Console.ReadLine());
        }
        void setSetor()
        {
            Console.WriteLine("Digite o Setor: ");
            this.Setor = Console.ReadLine();
        }
        void getPis()
        {
            Console.WriteLine("PIS: "+ this.Pis);
        }
        void getSalario()
        {
            Console.WriteLine("Salário" + this.Salario);
        }

        void getSetor()
        {
            Console.WriteLine("Digite o setor: ");
            Console.WriteLine("Setor" + this.Setor);
        }
        public void cadastraFuncionario()
        {
            setNome();
            setNasc();
            setCpf();
            setPis();
            setSalario();
            setSetor();
        }
        public void imprimeFuncionario()
        {
            getNome();
            getCpf();
            getNasc();
            getPis();
            getSalario();
            getSetor();
        }
 
        public override string ToString()
        {
            return "PIS: " + Pis + "\n Salário: " + Salario + "Setor: " + Setor;
        }
    }
}



