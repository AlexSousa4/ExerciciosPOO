using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosPOO.ClassesEMetodos
{
    public class Conversor
    {
        /*
         * ### Exercício 3: Conversor de Temperatura

        Crie a classe `Conversor` (sem atributos) com os métodos abaixo.
        CelsiusParaFahrenheit(double celsius)	double	Retorna celsius × 1.8 + 32
        EstaQuente(double celsius)	bool	Retorna true se a temperatura informada for 30 ou mais, senão false
         */
    
        public double CelsiusParaFahrenheit(double celsius)
        {
            double resultadoCelsius = celsius * 1.8 + 32;
            return resultadoCelsius;
        }

        public bool EstaQuente(double celsius)
        {
            if (celsius > 30)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
