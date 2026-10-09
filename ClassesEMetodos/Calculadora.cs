using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosPOO.ClassesEMetodos
{
    public class Calculadora
    {
        /*
         * ### Exercício 2: Calculadora
           Crie a classe `Calculadora` (sem atributos) com os métodos abaixo.
        Somar(int a, int b)	int	Retorna a + b
        Subtrair(int a, int b)	int	Retorna a - b
        MostrarResultado(int valor)	void	Mostra: Resultado: {valor}
         */

        public int Somar(int a, int b)
        {
            int resultado;
            return resultado = a + b;
        }

        public int Subtrair(int a, int b)
        {
            int resultado;
            return resultado = a - b;
        }

        public void MostrarResultado(int valor)
        {
            Console.WriteLine($"Resultado: {valor}");
        }
    }
}
