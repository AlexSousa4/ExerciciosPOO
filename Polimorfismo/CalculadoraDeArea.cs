using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosPOO.Polimorfismo
{
    internal class CalculadoraDeArea
    {
        /*
         * ### Exercício 2: Calculadora de Área

        Crie a classe `CalculadoraDeArea` com duas versões do método `CalcularArea`:

        - `CalcularArea(double lado)`: **retorna** a área do quadrado (lado × lado).
        - `CalcularArea(double largura, double altura)`: **retorna** a área do retângulo (largura × altura).
         */

        public double CalcularArea(double lado)
        {
            double areaQuadrado = lado * lado;
            return areaQuadrado;
        }

        public double CalcularArea(double largura, double altura)
        {
            double areaRetangulo = largura * altura;
            return areaRetangulo;
        }


    }
}
