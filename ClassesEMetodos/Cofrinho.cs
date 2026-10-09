using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosPOO.ClassesEMetodos
{
    public class Cofrinho
    {
        /*
         * ### Exercício 4: Cofrinho

        Crie a classe `Cofrinho` com:

        - Atributos: `Dono` (texto) e `Saldo` (número com centavos, começa em 0).
        - Um **construtor** que recebe só o `Dono`.
        Guardar(double valor)	void	Se o valor for 0 ou negativo, mostra "Valor inválido.". Senão, soma ao saldo e mostra "Guardou R$ X."
        Retirar(double valor)	bool	Se tiver saldo, tira o valor e retorna true. Se não tiver, retorna false e o saldo não muda.
        FaltaParaMeta(double meta)	double	Retorna quanto falta para chegar na meta. Se já chegou, retorna 0.

         */

        public string Dono;
        public double Saldo;

        public void Guardar(double Valor)
        {
            if (Valor <= 0)
            {
                Console.WriteLine("Valor inválido");
            }
            else
            {
                Saldo += Valor;
                Console.WriteLine($"Guardou R$ {Saldo}");
            }
        }
    }
}
