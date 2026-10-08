using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Xml;

namespace ExerciciosPOO
{
    public class Aluno
    {
        /*
         * ### 🎓 Exercício 5: Aluno

            Crie a classe `Aluno` com:

            - Atributos: `Nome`, `Nota1` e `Nota2`.
            - Um **construtor** que recebe nome e as duas notas.
            - Método `CalcularMedia()`, que retorna a média das notas.
            - Método `EstaAprovado()`, que retorna `true` se a média for 7 ou mais.
            - Método `ExibirSituacao()`, que usa os dois métodos acima.

            **Saída esperada:**

            ```
            Carlos: média 7,5 (Aprovado)
            Bia: média 5,5 (Reprovado)
            ```
            **Dica:** com construtor, o objeto já nasce preenchido: `Aluno a = new Aluno("Carlos", 8, 7)
         */

        public string Nome;        
        public double Nota1, Nota2;
        public double Media;

        public Aluno(string Nome, double Nota1, double Nota2)
        {
        }

        public double CalcularMedia()
        {
            return Media = (Nota1 * Nota2) / 2;
        }

        public bool EstaAprovado()
        {
            if (Media > 7)
            {
                Console.WriteLine("Está aprovado");
                return true;
            }
            else if (Media < 7 && Media > 4)
            {
                Console.WriteLine("Precisa Fazer Recuperação");
                return true;
            }
            else
            {
                Console.WriteLine("Está Reprovado.");
                return false;
            }
        }

        public void ExibirSituacao()
        {
        CalcularMedia();
        EstaAprovado();
        }
    }
}
