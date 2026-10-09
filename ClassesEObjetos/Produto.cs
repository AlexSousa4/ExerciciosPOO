namespace ExerciciosPOO.ClassesEObjetos
{
    public class Produto
    {
        /*
         * ### 📦 Exercício 6: Produto

        Crie a classe `Produto` com:

        - Atributos: `Nome`, `Preco` e `Estoque`.
        - Um **construtor** que recebe os três valores.
        - Método `AdicionarEstoque(int quantidade)`.
        - Método `RemoverEstoque(int quantidade)`: não pode deixar o estoque negativo. Se a quantidade for maior que o estoque, mostra uma mensagem e não remove nada.
        - Método `ExibirDetalhes()`.

        Teste: criar "Mouse sem Fio" (R$ 89,90, estoque 10), exibir, remover 3, tentar remover 20, adicionar 5 e exibir de novo.
 */

        public string Nome;
        public double Preco;
        public int Estoque;

        public Produto(string Nome, double Preco, int Estoque)
        {
            this.Nome = Nome;
            this.Preco = Preco;
            this.Estoque = Estoque;
        }

        public int AdicionarEstoque(int quantidade)
        {
            return Estoque = +quantidade;
        }

        public int RemoverEstoque(int quantidade)
        {
            if (quantidade > Estoque)
            {
                Console.WriteLine("Não é possivel remover um item com quantidade maior que o estoque");
                return Estoque;
            }
            else
            {
                return Estoque -= quantidade;
            }
        }

        public void ExibirDetalhes()
        {
            Console.WriteLine($"{Nome} | R$ {Preco} | Estoque: {Estoque}");
        }
    }
}
