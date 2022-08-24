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
            :base (nome, nasc, cpf)
        {
            Pis = pis;
            Salario = salario;
            Setor = setor;
        }
    }
}


/*3 - Faça um programa que crie objetos filhos de uma classe pai "Pessoa", essas classes filhas terão nome de "Alunos" e " Funcionários".
A classe pai tem os seguintes atributos: nome, data de nascimento, cpf. A classe Aluno tem os seguintes atributos: RA e data de matricula.
A classe Funcionários tem os seguintes atributos: n do Pis, salário e setor. (criar metodos get, set e tostring). Informar numero de alunos
e funcionarios.*/