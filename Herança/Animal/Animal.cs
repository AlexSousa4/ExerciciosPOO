using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosPOO.Herança.Animal
{
    internal class Animal 
    {
        /*
         * ### 🐶 Exercício 1: Animal e Cachorro

        Crie as classes:

        - `Animal` (classe pai): propriedade `Nome` e método `Comer()`, que mostra "{Nome} está comendo.".
        - `Cachorro` (classe filha de `Animal`): método `Latir()`, que mostra "{Nome}: Au au!".

        O `Cachorro` **não** deve declarar `Nome` nem `Comer()`: ele herda do `Animal`.

         */

        public string NomeAnimal { get; set; }

        public void Comer()
        {
            Console.WriteLine($"{NomeAnimal} está comendo.");
        }




    }
}
