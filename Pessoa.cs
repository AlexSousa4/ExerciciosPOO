using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosPOO
{
    public class Pessoa
    {
        /*
            Exercício 1: Pessoa

            Crie a classe `Pessoa` com:

            - Atributos: `Nome` e `Idade`.
            - Método `Apresentar()`, que mostra uma frase de apresentação.

            Crie **dois objetos** diferentes e chame `Apresentar()` em cada um.

            **Saída esperada:**

            ```
            Olá, meu nome é Ana e tenho 25 anos.
            Olá, meu nome é Bruno e tenho 31 anos.
            ```

        */
        public string Nome;
        public int Idade;


        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos.\n");
        }
    }
}
