using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosPOO.Abstracao.FormasPagamento
{
    internal class Pix : IPagamento
    {
        /*
       * ### Exercício 1: Formas de Pagamento

          Crie:

          - A interface `IPagamento` com o método `void Pagar(double valor);`
          - A classe `Pix`, que implementa `IPagamento` e mostra "Pagamento de R$ {valor} via Pix.".
          - A classe `Cartao`, que implementa `IPagamento` e mostra "Pagamento de R$ {valor} no cartão.".
       */

        public void Pagar(double valor)
        {
            Console.WriteLine($"Pagamento de R$ {valor} via cartão");
        }
    }
}
