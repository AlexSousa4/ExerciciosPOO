using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace ExerciciosPOO.Encapsulamento
{
    internal class ContadorDeVisitas
    {
        private int Visitas { get; set; }



        public void RegistrarVisitas()
        {
            Visitas++;
        }

        public int ObterTotal()
        {
            return Visitas;
        }
    }
}
