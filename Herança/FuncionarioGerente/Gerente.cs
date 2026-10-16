using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosPOO.Herança.FuncionarioGerente
{
    internal class Gerente : Funcionario
    {
        /*
         * ### Exercício 2: Funcionário e Gerente

        Crie as classes:

        - `Funcionario` (classe pai): propriedades `Nome` e `Salario`, e um **construtor** que recebe as duas.
        - `Gerente` (filha de `Funcionario`): propriedade `Bonus`, construtor que recebe nome, salário e bônus, e o método `SalarioComBonus()`, que **retorna** Salario + Bonus.
         */

                                                                            //SERVE PARA PODER PEGAR O NOME E O SALARIO E MANDA PARA O FUNCIONARIO
        public Gerente(string nomeFuncionario, double salario, double bonus) : base(nomeFuncionario, salario)
        {
            Bonus = bonus;
        }

        public double Bonus { get; set; }

        public double SalarioComBonus()
        {
            double salarioComBonus = Salario + Bonus;

            return salarioComBonus;
        }
    }
}
