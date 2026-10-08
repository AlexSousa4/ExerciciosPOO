using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosPOO
{
    public class Lampada
    {
        /*
         * Crie a classe `Lampada` com:

        - Atributo: `Ligada` (`bool`).
        - Métodos: `Ligar()`, `Desligar()`, `Alternar()` (se está ligada, desliga; se está desligada, liga) e `ExibirEstado()`.

        Crie uma lâmpada e chame, nesta ordem: `ExibirEstado()`, `Ligar()`, `ExibirEstado()`, `Alternar()`, `ExibirEstado()`.
         */

        public bool Ligada;


        public void Ligar()
        {
            Ligada = true;
        }

        public void Desligar()
        {
            Ligada = false;
        }

        public void Alternar()
        {
            if (Ligada == true)
            {
                Ligada = false;
            }
            else if (Ligada == false)
            {
                Ligada = true;
            }
        }

        public void ExibirEstado()
        {
            Console.WriteLine(Ligada);
        }

    }
}
