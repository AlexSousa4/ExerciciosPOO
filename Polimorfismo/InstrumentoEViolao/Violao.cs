using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosPOO.Polimorfismo.InstrumentoEViolao
{
    internal class Violao : Instrumento
    {

        /*
         * ### Exercício 3: Instrumento e Violão (sobrescrita)

        Crie as classes:

        - `Instrumento` (classe pai): método `virtual` `Tocar()`, que mostra "Tocando um instrumento...".
        - `Violao` (filha de `Instrumento`): **sobrescreve** `Tocar()` para mostrar "Violão: plim plim".
         */
        

        public override void Tocar()
        {
            Console.WriteLine("Violão: Plim Plim");
        }
    }
}
