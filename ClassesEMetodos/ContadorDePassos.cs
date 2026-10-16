using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosPOO.ClassesEMetodos
{
    internal class ContadorDePassos
    {
        /*
         * #### 👟 Exercício 6: Contador de Passos

        Crie a classe `Atleta` com:

        - Atributos: `Nome` (texto), `MetaDiaria` (inteiro) e `Passos` (inteiro, começa em 0).
        - Um **construtor** que recebe o nome e a meta diária.
        Caminhar(int passos)	void	Soma os passos ao total.
        BateuMeta()	bool	Retorna true se os passos chegaram na meta.
        CalcularPercentual()	double	Retorna a porcentagem da meta: Passos × 100.0 / MetaDiaria
        ExibirResumo()	void	Mostra os passos e a porcentagem. Depois, usando BateuMeta(), mostra "Meta batida!" ou quantos passos faltam.
         */

        public string Nome;
        public int MetaDiaria;
        public int Passos = 0;

        public ContadorDePassos(string Nome, int MetaDiaria)
        {
            this.Nome = Nome;
            this.MetaDiaria = MetaDiaria;
        }

        public void Caminhar(int Passos)
        {
            Passos++;
        }

    //    public bool BateuMeta()
    //    {
    //        if (Passos == MetaDiaria)
    //        {
    //            return true;
    //        }
    //    }

    //    public double 
    }
}
