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

using ExerciciosPOO;
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