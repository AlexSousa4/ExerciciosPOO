using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosPOO.ClassesEMetodos
{
    public class Estacionamento
    {

        /*
         * #### 🅿️ Exercício 5: Estacionamento

        Crie a classe `Ticket` com:

        - Atributos: `Placa` (texto) e `Horas` (inteiro).
        - Um **construtor** que recebe os dois valores.

        **Regra de preço:** a 1ª hora custa **R$ 10,00** e cada hora a mais custa **R$ 5,00**.
        *
        CalcularValor()	double	Retorna o valor a pagar, seguindo a regra de preço.
        EmitirTicket()	void	Mostra: Placa {Placa} | {Horas}h | R$ {valor}. Use o CalcularValor() aqui dentro.
         */
        public string Placa;
        public int Horas;

        public Estacionamento(string placa, int horas)
        {
            Placa = placa;
            Horas = horas;
        }

        public double CalcularValor()
        {
            if (Horas <= 1)
            {
                return 10;
            }

            return 10 + (Horas - 1) * 5;
        }

        public void EmitirTicket()
        {
            Console.WriteLine($"Placa {Placa} | {Horas}h | R$ {CalcularValor():F2}");
        }

    }
}
