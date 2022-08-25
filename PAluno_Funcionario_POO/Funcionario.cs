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

        public Funcionario(string pis, float salario, string setor)
            : base(nome, nasc, cpf)
        {
            Pis = pis;
            Salario = salario;
            Setor = setor;
        }
        void setPis()
        {
            this.Pis = Console.ReadLine();
        }
        void setSalario()
        {
            this.Salario = float.Parse(Console.ReadLine());
        }
        void setSetor()
        {
            this.Setor = Console.ReadLine();
        }
        void getPis()
        {
            Console.WriteLine(this.Pis);
        }
        void getSalario()
        {
            Console.WriteLine(this.Salario);
        }
        void getSetor()
        {
            Console.WriteLine(this.Setor);
        }
        public override string ToString()
        {
            return "PIS: " + Pis + "\n Salário: " + Salario + "Setor: " + Setor;
        }
    }
}



