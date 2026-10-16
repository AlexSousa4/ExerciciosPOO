using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosPOO.Herança.FuncionarioGerente
{
    internal class Funcionario
    {
        /*
         * ### Exercício 2: Funcionário e Gerente

        Crie as classes:

        - `Funcionario` (classe pai): propriedades `Nome` e `Salario`, e um **construtor** que recebe as duas.
        - `Gerente` (filha de `Funcionario`): propriedade `Bonus`, construtor que recebe nome, salário e bônus, e o método `SalarioComBonus()`, que **retorna** Salario + Bonus.
         */


        public string NomeFuncionario;
        public double Salario;

        public Funcionario(string nomeFuncionario, double salario)
        {
            NomeFuncionario = nomeFuncionario;
            Salario = salario;
        }

    }
}
