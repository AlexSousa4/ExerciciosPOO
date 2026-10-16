using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosPOO.Encapsulamento
{
    internal class Boletim
    {
        /*
         * ### Exercício 2: Boletim

            Crie a classe `Boletim` com:

            - Propriedade pública `Aluno`: `public string Aluno { get; set; }`
            - Campo `private double nota`.
            - Método público `DefinirNota(double valor)`: só aceita notas de 0 a 10. Fora disso, mostra "Nota inválida: {valor}" e não altera a nota.
            - Método público `ObterNota()`: **retorna** a nota.
         */

        public string Aluno { get; set; }
        private double Nota;

        public void DefinirNota(double valor)
        {
            if (valor >= 0 && valor <= 10)
            {
                Nota = valor;
            }
            else
            {
                Console.WriteLine($"Nota inválida: {valor}");
            }
        }

        public double ObterNota()
        {
            return Nota;
        }
    }
}
