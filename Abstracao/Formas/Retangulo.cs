using ExerciciosPOO.ClassesEObjetos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosPOO.Abstracao.Formas
{
    internal class Retangulo : IForma
    {
        /*
* ### Exercício 2: Formas

Crie:

- A interface `IForma` com o método `double CalcularArea();`
- A classe `Quadrado`, que implementa `IForma`: propriedade `Lado`, um **construtor** que recebe o lado e `CalcularArea()` **retornando** Lado × Lado.
- A classe `Retangulo`, que implementa `IForma`: propriedades `Largura` e `Altura`, um **construtor** que recebe as duas e `CalcularArea()` **retornando** Largura × Altura.
*/

        public double Largura, Altura;

        public Retangulo(double largura, double altura)
        {
            Largura = largura;
            Altura = altura;
        }

        public double CalcularArea()
        {
            double caluloLado = Largura * Altura;
            return caluloLado;
        }
    }
}
