using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosPOO.Abstracao.PatoPeixe
{
    internal class Pato : INadador, IVoador
    {
        /*
 * ### Exercício 3: Pato e Peixe (duas interfaces)

Crie:

- A interface `IVoador` com o método `void Voar();`
- A interface `INadador` com o método `void Nadar();`
- A classe `Pato`, que implementa **as duas** interfaces.
- A classe `Peixe`, que implementa só `INadador`.
 */
       public void Voar()
        {
            Console.WriteLine("Pato está voando");
        }

        public void Nadar()
        {
            Console.WriteLine("Pato está voando");
        }
    }
}
