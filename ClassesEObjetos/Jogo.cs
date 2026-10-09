namespace ExerciciosPOO.ClassesEObjetos
{
    public class Jogo
    {
        /*
         * ### 🎮 Desafio 7: Biblioteca de Jogos

        Lembra do Coding Dojo? Agora, em vez de vários arrays separados (nomes, preços...), cada jogo vai ser **um objeto**.

        Crie a classe `Jogo` com:

        - Atributos: `Nome`, `Plataforma` e `Preco`.
        - Um **construtor** que recebe os três valores.
        - Método `Exibir(int numero)`, que mostra uma linha da biblioteca.

        No `Program.cs`:

        1. Crie um array `Jogo[]` com 3 posições e coloque um objeto `Jogo` em cada uma.
        2. Mostre a biblioteca numerada usando um `for`.
        3. Mostre o jogo mais caro.
         */

        public string Nome, Plataforma;
        public double Preco;

        public Jogo(string Nome, string Plataforma, double Preco)
        {
            this.Nome = Nome;
            this.Plataforma = Plataforma;
            this.Preco = Preco;
        }

        public void Exibir(int Numero)
        {
            //1 - God of War (PS5) - R$ 150,00
            Console.WriteLine($"{Numero} - {Nome} ({Plataforma}) - R$ {Preco}");
        }
    }
}
