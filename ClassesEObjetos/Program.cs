//CLASSES E OBJETOS
//FUNDAMENTAL

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

using ExerciciosPOO.ClassesEMetodos;
using ExerciciosPOO.ClassesEObjetos;
using System.Net.Http.Headers;

Pessoa pessoa1 = new Pessoa();

pessoa1.Nome = "Ana";
pessoa1.Idade = 25;

pessoa1.Apresentar();


Pessoa pessoa2 = new Pessoa();

pessoa2.Nome = "Bruno";
pessoa2.Idade = 31;

pessoa2.Apresentar();


/*
 * ### 📐 Exercício 2: Retângulo

Crie a classe `Retangulo` com:

- Atributos: `Largura` e `Altura` (números com casas decimais).
- Método `CalcularArea()`, que **retorna** a área (largura × altura).
- Método `CalcularPerimetro()`, que **retorna** o perímetro (2 × (largura + altura)).

Os métodos não devem usar `Console.WriteLine`: quem mostra o resultado é o `Program.cs`.
*/


Retangulo retangulo1 = new Retangulo();

Console.WriteLine(retangulo1.CalcularArea(5, 3));
Console.WriteLine(retangulo1.CalcularPerimetro(5, 3));




/*
 *  Exercício 3: Lâmpada
 * Crie a classe `Lampada` com:

- Atributo: `Ligada` (`bool`).
- Métodos: `Ligar()`, `Desligar()`, `Alternar()` (se está ligada, desliga; se está desligada, liga) e `ExibirEstado()`.

Crie uma lâmpada e chame, nesta ordem: `ExibirEstado()`, `Ligar()`, `ExibirEstado()`, `Alternar()`, `ExibirEstado()`.
 */


Lampada lampada1 = new Lampada();

lampada1.ExibirEstado();
lampada1.Ligar();

lampada1.ExibirEstado();
lampada1.Alternar();

lampada1.ExibirEstado();

//INTERMEDIARIO


/*
 * ### 🏦 Exercício 4: Conta Bancária

Crie a classe `ContaBancaria` com:

- Atributos: `Titular` (texto) e `Saldo` (número com centavos).
- Método `Depositar(double valor)`: soma o valor ao saldo.
- Método `Sacar(double valor)`: só tira o dinheiro se houver saldo suficiente. Se não houver, mostra uma mensagem e o saldo não muda.
- Método `ExibirSaldo()`.

Teste: depositar 500, sacar 200, tentar sacar 1000 e exibir o saldo.
 */


ContaBancaria contaBancaria1 = new ContaBancaria();

contaBancaria1.Depositar(500);
contaBancaria1.Sacar(200);
contaBancaria1.Sacar(1000);
contaBancaria1.ExibirSaldo();

/*
     * ### 🎓 Exercício 5: Aluno

        Crie a classe `Aluno` com:

        - Atributos: `Nome`, `Nota1` e `Nota2`.
        - Um **construtor** que recebe nome e as duas notas.
        - Método `CalcularMedia()`, que retorna a média das notas.
        - Método `EstaAprovado()`, que retorna `true` se a média for 7 ou mais.
        - Método `ExibirSituacao()`, que usa os dois métodos acima.
     */


Aluno aluno1 = new Aluno("Carlos", 8, 7);
aluno1.ExibirSituacao();

Aluno aluno2 = new Aluno("Bia", 5, 5);
aluno2.ExibirSituacao();


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


Produto mouse = new Produto("Mouse sem Fio", 89.90, 10);
mouse.ExibirDetalhes();
mouse.RemoverEstoque(3);
mouse.RemoverEstoque(20);
mouse.AdicionarEstoque(5);
mouse.ExibirDetalhes();


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
Jogo[] arrayJogos = new Jogo[5];
Jogo godOfWar = new Jogo("God Of War", "Playstation", 235.00);
Jogo liesOfP = new Jogo("Lies Of P", "Playstation", 500.00);
Jogo wolverine = new Jogo("Wolverine", "Playstation", 400.00);
Jogo zelda = new Jogo("Zelda Ocarina Of Time Remake", "Nintendo Switch", 480.00);
Jogo fifa = new Jogo("Fifa", "Xbox", 700.00);

arrayJogos[0] = godOfWar;
arrayJogos[1] = liesOfP;
arrayJogos[2] = wolverine;
arrayJogos[3] = zelda;
arrayJogos[4] = fifa;

double JogoMaisCaro = arrayJogos[0].Preco;
string NomeJogoMaisCaro = arrayJogos[0].Nome;

for (int i = 0; i < arrayJogos.Length; i++)
{
    arrayJogos[i].Exibir(i);
}

for (int i = 0; i < arrayJogos.Length; i++)
{
    if (JogoMaisCaro < arrayJogos[i].Preco)
    {
        JogoMaisCaro = arrayJogos[i].Preco;
        NomeJogoMaisCaro = arrayJogos[i].Nome;
    }
}

Console.WriteLine($"Jogo mais caro é: {NomeJogoMaisCaro} R$ {JogoMaisCaro}");


//CLASSES E OBJETOS
//FUNDAMENTAL

/*
      * ### 👋 Exercício 1: Saudação
     Crie a classe `Pessoa` com o atributo `Nome` e os métodos abaixo.

     Cumprimentar()	void	Mostra: Olá, eu sou {Nome}!
     CumprimentarAlguem(string outraPessoa)	void	Mostra: Olá, {outraPessoa}! Eu sou {Nome}.
     ObterApresentacao()	string	Retorna o texto: Meu nome é {Nome}. (não mostra na tela)
      */

Saudacao alex = new Saudacao
{
    Nome = "Alex"
};

alex.Cumprimentar();

alex.CumprimentarAlguem("Isadora");

string frase = alex.ObterApresentacao();
Console.WriteLine(frase);


/*
* ### Exercício 2: Calculadora
 Crie a classe `Calculadora` (sem atributos) com os métodos abaixo.
Somar(int a, int b)	int	Retorna a + b
Subtrair(int a, int b)	int	Retorna a - b
MostrarResultado(int valor)	void	Mostra: Resultado: {valor}
*/

Calculadora calculo = new Calculadora();


//DUAS MANEIRAS DE REALIZAR A MESMA COISA
int soma = calculo.Somar(10, 5);
calculo.MostrarResultado(soma);

calculo.MostrarResultado(calculo.Subtrair(10, 5));


/*
 * ### Exercício 3: Conversor de Temperatura

Crie a classe `Conversor` (sem atributos) com os métodos abaixo.
CelsiusParaFahrenheit(double celsius)	double	Retorna celsius × 1.8 + 32
EstaQuente(double celsius)	bool	Retorna true se a temperatura informada for 30 ou mais, senão false
 */

Conversor converter = new Conversor();

double f = converter.CelsiusParaFahrenheit(25);
Console.WriteLine($"25°C = {f}°F");

if (converter.EstaQuente(35))
{
    Console.WriteLine("35°C: Está quente!");
}

if (!converter.EstaQuente(18))
{
    Console.WriteLine("18°C: Não está quente.");
}

// INTERMEDIARIO

/*
 * ### Exercício 4: Cofrinho

Crie a classe `Cofrinho` com:

- Atributos: `Dono` (texto) e `Saldo` (número com centavos, começa em 0).
- Um **construtor** que recebe só o `Dono`.
 */

