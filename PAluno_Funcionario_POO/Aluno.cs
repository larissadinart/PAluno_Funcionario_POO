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
        DateTime Matricula;


        public Aluno(string ra, DateTime matricula)
            : base(nome, nasc, cpf)
        {

            Ra = ra;
            Matricula = matricula;

        }
    }
}
