using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosPOO.Herança.Animal
{
    internal class Cachorro : Animal
    {
        public void Latir()
        {
            Console.WriteLine($"{NomeAnimal}: Au au");
        }
    }
}
