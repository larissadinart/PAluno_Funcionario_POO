using System;

namespace PAluno_Funcionario_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            Aluno a1 = new Aluno();
            Funcionario f1 = new Funcionario();

            p1.cadastraPessoa();
            p1.imprimePessoa();

            a1.cadastraAluno();
            a1.imprimeAluno();

            f1.cadastraFuncionario();
            f1.imprimeFuncionario();

        }
    }
}
