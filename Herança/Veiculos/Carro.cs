using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosPOO.Herança.Veiculos
{
    internal class Carro : Veiculo
    {
        /*
       * ### xercício 3: Veículo, Carro e Moto

      Crie as classes:

      - `Veiculo` (classe pai): propriedades `Marca` e `Modelo`, um **construtor** que recebe as duas e o método `Exibir()`, que mostra "{Marca} {Modelo}".
      - `Carro` (filha de `Veiculo`): propriedade `Portas`, construtor que recebe marca, modelo e portas, e o método `ExibirPortas()`.
      - `Moto` (filha de `Veiculo`): propriedade `Cilindradas`, construtor que recebe marca, modelo e cilindradas, e o método `ExibirCilindradas()`.
       */

        public int Portas { get; set; }
        public Carro(string marca, string modelo, int portas) : base(marca, modelo)
        {
            Portas = portas;
        }


        public void ExibirPortas()
        {
            Console.WriteLine("A quantidade de portas é " + Portas);
        }
    }
}
