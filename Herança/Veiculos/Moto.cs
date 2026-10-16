using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace ExerciciosPOO.Herança.Veiculos
{
    internal class Moto : Veiculo
    {
        /*
* ### xercício 3: Veículo, Carro e Moto

Crie as classes:

- `Veiculo` (classe pai): propriedades `Marca` e `Modelo`, um **construtor** que recebe as duas e o método `Exibir()`, que mostra "{Marca} {Modelo}".
- `Carro` (filha de `Veiculo`): propriedade `Portas`, construtor que recebe marca, modelo e portas, e o método `ExibirPortas()`.
- `Moto` (filha de `Veiculo`): propriedade `Cilindradas`, construtor que recebe marca, modelo e cilindradas, e o método `ExibirCilindradas()`.
*/

        public int Cilindradas { get; set; }

        public Moto(string marca, string modelo, int cilindradas) : base(marca, modelo)
        {
            Cilindradas = cilindradas;
        }

        public void ExibirCilindradas()
        {
            Console.WriteLine("A quantidade de cilindradas é " + Cilindradas);
        }
    }
}
