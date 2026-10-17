using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosPOO.Polimorfismo
{
    internal class Saudacao
    {

        /*
         * ### Exercício 1: Saudação

        Crie a classe `Saudacao` com **três versões** do método `Cumprimentar`:

        - `Cumprimentar()`: mostra "Olá!".
        - `Cumprimentar(string nome)`: mostra "Olá, {nome}!".
        - `Cumprimentar(string nome, int idade)`: mostra "Olá, {nome}! Você tem {idade} anos.".
         */
        

        public void CumprimentarSaudacao()
        {
            Console.WriteLine("Olá");
        }

        public void CumprimentarSaudacao(string nome)
        {
            Console.WriteLine($"Olá, {nome}" );
        }

        public void CumprimentarSaudacao(string nome, int idade)
        {
            Console.WriteLine($"Olá, {nome}! Você tem {idade} anos.");
        }
    }
}
