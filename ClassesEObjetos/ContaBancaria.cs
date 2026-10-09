namespace ExerciciosPOO.ClassesEObjetos
{
    public class ContaBancaria
    {
        /*
         * ### 🏦 Exercício 4: Conta Bancária

            Crie a classe `ContaBancaria` com:

            - Atributos: `Titular` (texto) e `Saldo` (número com centavos).
            - Método `Depositar(double valor)`: soma o valor ao saldo.
            - Método `Sacar(double valor)`: só tira o dinheiro se houver saldo suficiente. Se não houver, mostra uma mensagem e o saldo não muda.
            - Método `ExibirSaldo()`.

            Teste: depositar 500, sacar 200, tentar sacar 1000 e exibir o saldo.
         */

        public string Titular;
        public double Saldo;


        public double Depositar(double Valor)
        {
            return Saldo = Valor + Saldo;
        }

        public double Sacar(double Valor)
        {
            if (Valor < Saldo)
            {
                return Saldo = Saldo - Valor;
            }
            else
            {
                Console.WriteLine("Saldo Insuficiente");
                return Saldo;
            }
        }

        public void ExibirSaldo()
        {
            Console.WriteLine(Saldo);
        }

    }
}
