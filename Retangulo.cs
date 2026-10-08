using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosPOO
{
    public class Retangulo
    {
        //### 📐 Exercício 2: Retângulo

        //        Crie a classe `Retangulo` com:

        //- Atributos: `Largura` e `Altura` (números com casas decimais).
        //- Método `CalcularArea()`, que** retorna**a área(largura × altura).
        //- Método `CalcularPerimetro()`, que** retorna**o perímetro(2 × (largura + altura)).

        //Os métodos não devem usar `Console.WriteLine`: quem mostra o resultado é o `Program.cs`.

        public double Largura, Altura, Area, Perimetro;
        public double CalcularArea(double Largura, double Altura)
        {
            Area = Largura * Altura;
            return Area;
        }

        public double CalcularPerimetro(double Largura, double Altura)
        {
            Perimetro = 2 * (Largura + Altura);
            return Perimetro;
        }
    }
}
