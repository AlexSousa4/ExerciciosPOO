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

using ExerciciosPOO.Abstracao.Formas;
using ExerciciosPOO.Abstracao.FormasPagamento;
using ExerciciosPOO.Abstracao.PatoPeixe;
using ExerciciosPOO.ClassesEMetodos;
using ExerciciosPOO.ClassesEObjetos;
using ExerciciosPOO.Encapsulamento;
using ExerciciosPOO.ExerciciosEmSala;
using ExerciciosPOO.Herança.Animal;
using ExerciciosPOO.Herança.FuncionarioGerente;
using ExerciciosPOO.Herança.Veiculos;
using ExerciciosPOO.Polimorfismo;
using ExerciciosPOO.Polimorfismo.InstrumentoEViolao;

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


RetanguloClassesObjetos retangulo1 = new RetanguloClassesObjetos();

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


ExerciciosPOO.ClassesEObjetos.Aluno aluno1 = new ExerciciosPOO.ClassesEObjetos.Aluno("Carlos", 8, 7);
aluno1.ExibirSituacao();

ExerciciosPOO.ClassesEObjetos.Aluno aluno2 = new ExerciciosPOO.ClassesEObjetos.Aluno("Bia", 5, 5);
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


//LAÇO FOR PARA PREEMCHER AS INFORMAÇÕES MANUALMENTE
//for (int i = 0; i < arrayJogos.Length; i++)
//{
//    Console.WriteLine("Digite o nome do jogo");
//    string nome = Console.ReadLine();
//    Console.WriteLine("Digite a plataforma do jogo");
//    string plataforma = Console.ReadLine();
//    Console.WriteLine("Digite o valor do jogo");
//    double valorJogo = double.Parse(Console.ReadLine());

//    arrayJogos[i] = new Jogo(nome, plataforma, valorJogo);
//}



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

SaudacaoClassesMetodos alex = new SaudacaoClassesMetodos("Alex");

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


Cofrinho cofre = new Cofrinho("Alex");

cofre.Guardar(50);
cofre.Guardar(-10);
cofre.Guardar(30);

if (cofre.Retirar(100))
    Console.WriteLine("Retirada feita!");
else
    Console.WriteLine("Saldo insuficiente.");

if (cofre.Retirar(20))
    Console.WriteLine("Retirada feita!");
else
    Console.WriteLine("Saldo insuficiente.");

Console.WriteLine($"Saldo: R$ {cofre.Saldo:F2}");
Console.WriteLine($"Faltam R$ {cofre.FaltaParaMeta(200):F2} para a meta.");





//EXERCICIOS EM SALA DE AULA

//EXERCICIO 1 LIVRO

ExercicioEmSalaLivro HarryPotter = new("O Prisoneiro de Askaban", "JK Rowling", 350);

HarryPotter.Exibir();


//ENCAPSULAMENTO

/*
 * ### Exercício 1: Contador de Visitas

Crie a classe `ContadorDeVisitas` com:

- Campo `private int visitas` (ninguém de fora pode mexer).
- Método público `RegistrarVisita()`: soma 1 às visitas.
- Método público `ObterTotal()`: **retorna** o total de visitas.
 */

ContadorDeVisitas contador = new ContadorDeVisitas();

contador.RegistrarVisitas();
contador.RegistrarVisitas();
contador.RegistrarVisitas();

Console.WriteLine($"Total de visitas: {contador.ObterTotal()}");




/*
 * ### Exercício 2: Boletim

Crie a classe `Boletim` com:

- Propriedade pública `Aluno`: `public string Aluno { get; set; }`
- Campo `private double nota`.
- Método público `DefinirNota(double valor)`: só aceita notas de 0 a 10. Fora disso, mostra "Nota inválida: {valor}" e não altera a nota.
- Método público `ObterNota()`: **retorna** a nota.
 */

Boletim boletim = new Boletim();
boletim.Aluno = "Alex";

boletim.DefinirNota(8.5);
boletim.DefinirNota(15);

Console.WriteLine($"{boletim.Aluno}: nota {boletim.ObterNota()}");


/*
 * ### Exercício 3: Usuário

Crie a classe `Usuario` com:

- Propriedade pública `Login`.
- Campo `private string senha`.
- Um **construtor** que recebe login e senha.
- Método público `ConferirSenha(string tentativa)`: **retorna** `true` se a tentativa for igual à senha.
- Método público `TrocarSenha(string senhaAtual, string novaSenha)`: só troca se a senha atual estiver correta. Mostra "Senha alterada!" ou "Senha atual incorreta.".
 */

Usuario usuario = new Usuario("ana123", "segredo");

Console.WriteLine(usuario.ConferirSenha("1234"));
Console.WriteLine(usuario.ConferirSenha("segredo"));

usuario.TrocarSenha("errada", "novaSenha");
usuario.TrocarSenha("segredo", "novaSenha");

Console.WriteLine(usuario.ConferirSenha("novaSenha"));


/*
 * ### Exercício 1: Animal e Cachorro

Crie as classes:

- `Animal` (classe pai): propriedade `Nome` e método `Comer()`, que mostra "{Nome} está comendo.".
- `Cachorro` (classe filha de `Animal`): método `Latir()`, que mostra "{Nome}: Au au!".

O `Cachorro` **não** deve declarar `Nome` nem `Comer()`: ele herda do `Animal`.
 */


Cachorro Laila = new Cachorro();
Laila.NomeAnimal = "Laila";

Laila.Comer();
Laila.Latir();


/*
* ### Exercício 2: Funcionário e Gerente

Crie as classes:

- `Funcionario` (classe pai): propriedades `Nome` e `Salario`, e um **construtor** que recebe as duas.
- `Gerente` (filha de `Funcionario`): propriedade `Bonus`, construtor que recebe nome, salário e bônus, e o método `SalarioComBonus()`, que **retorna** Salario + Bonus.
*/


Funcionario Alex = new Funcionario("Alex", 3000);
Gerente Isadora = new Gerente("Isadora", 5000, 1500);

Console.WriteLine($"{Alex.NomeFuncionario}: R$ {Alex.Salario:F2}");
Console.WriteLine($"{Isadora.NomeFuncionario}: R$ {Isadora.Salario:F2} + bônus = R$ {Isadora.SalarioComBonus():F2}");


/*
 * ### Exercício 3: Veículo, Carro e Moto

Crie as classes:

- `Veiculo` (classe pai): propriedades `Marca` e `Modelo`, um **construtor** que recebe as duas e o método `Exibir()`, que mostra "{Marca} {Modelo}".
- `Carro` (filha de `Veiculo`): propriedade `Portas`, construtor que recebe marca, modelo e portas, e o método `ExibirPortas()`.
- `Moto` (filha de `Veiculo`): propriedade `Cilindradas`, construtor que recebe marca, modelo e cilindradas, e o método `ExibirCilindradas()`.
 */

Carro carro = new Carro("Fiat", "Uno", 4);
Moto moto = new Moto("Honda", "CG 160", 160);

carro.Exibir();
carro.ExibirPortas();

moto.Exibir();
moto.ExibirCilindradas();


//POLIMORFISMO

/*
* ### Exercício 1: Saudação
Crie a classe `Saudacao` com **três versões** do método `Cumprimentar`:

- `Cumprimentar()`: mostra "Olá!".
- `Cumprimentar(string nome)`: mostra "Olá, {nome}!".
- `Cumprimentar(string nome, int idade)`: mostra "Olá, {nome}! Você tem {idade} anos.".
*/


Saudacao s = new Saudacao();

s.CumprimentarSaudacao();
s.CumprimentarSaudacao("Alex");
s.CumprimentarSaudacao("Isadora", 21);


/*
* ### Exercício 2: Calculadora de Área

Crie a classe `CalculadoraDeArea` com duas versões do método `CalcularArea`:
- `CalcularArea(double lado)`: **retorna** a área do quadrado (lado × lado).
- `CalcularArea(double largura, double altura)`: **retorna** a área do retângulo (largura × altura).
*/

CalculadoraDeArea calc = new CalculadoraDeArea();

Console.WriteLine($"Quadrado: {calc.CalcularArea(4)}");
Console.WriteLine($"Retângulo: {calc.CalcularArea(3, 5)}");


/*
 * ### Exercício 3: Instrumento e Violão (sobrescrita)

Crie as classes:

- `Instrumento` (classe pai): método `virtual` `Tocar()`, que mostra "Tocando um instrumento...".
- `Violao` (filha de `Instrumento`): **sobrescreve** `Tocar()` para mostrar "Violão: plim plim".
 */

Instrumento instrumento = new Instrumento();
Violao violao = new Violao();

instrumento.Tocar();
violao.Tocar();


//ABSTRACAO

/*
 * ### Exercício 1: Formas de Pagamento

Crie:

- A interface `IPagamento` com o método `void Pagar(double valor);`
- A classe `Pix`, que implementa `IPagamento` e mostra "Pagamento de R$ {valor} via Pix.".
- A classe `Cartao`, que implementa `IPagamento` e mostra "Pagamento de R$ {valor} no cartão.".
 */

Pix pix = new Pix();
Cartao cartao = new Cartao();

pix.Pagar(50);
cartao.Pagar(120);



/*
 * ### Exercício 2: Formas

Crie:

- A interface `IForma` com o método `double CalcularArea();`
- A classe `Quadrado`, que implementa `IForma`: propriedade `Lado`, um **construtor** que recebe o lado e `CalcularArea()` **retornando** Lado × Lado.
- A classe `Retangulo`, que implementa `IForma`: propriedades `Largura` e `Altura`, um **construtor** que recebe as duas e `CalcularArea()` **retornando** Largura × Altura.
 */

Quadrado quadrado = new Quadrado(4);
Retangulo retangulo = new Retangulo(3, 5);

Console.WriteLine($"Quadrado: {quadrado.CalcularArea()}");
Console.WriteLine($"Retângulo: {retangulo.CalcularArea()}");


/*
 * ### Exercício 3: Pato e Peixe (duas interfaces)

Crie:

- A interface `IVoador` com o método `void Voar();`
- A interface `INadador` com o método `void Nadar();`
- A classe `Pato`, que implementa **as duas** interfaces.
- A classe `Peixe`, que implementa só `INadador`.
 */

Pato pato = new Pato();
Peixe peixe = new Peixe();

pato.Voar();
pato.Nadar();
peixe.Nadar();
