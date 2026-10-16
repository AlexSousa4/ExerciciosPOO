using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosPOO.ClassesEObjetos
{
    internal class ExercicioEmSalaViagem
    {
        public string Destino;
        public int Dias;
        public double ValorDiaria;


        public ExercicioEmSalaViagem(string Destino, int Dias, double ValorDiaria)
        {
            this.Destino = Destino;
            this.Dias = Dias;
            this.ValorDiaria = ValorDiaria;
        }

        public double CalcularTotal()
        {
            return Dias * ValorDiaria;
        }

        public void Exibir()
        {
            Console.WriteLine("Sua viagem foi " + CalcularTotal());
        }
    }
}
