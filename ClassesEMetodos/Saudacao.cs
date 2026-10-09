using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosPOO.ClassesEMetodos
{
    public class Saudacao
    {
        /*
         * ### 👋 Exercício 1: Saudação
        Crie a classe `Pessoa` com o atributo `Nome` e os métodos abaixo.

        Cumprimentar()	void	Mostra: Olá, eu sou {Nome}!
        CumprimentarAlguem(string outraPessoa)	void	Mostra: Olá, {outraPessoa}! Eu sou {Nome}.
        ObterApresentacao()	string	Retorna o texto: Meu nome é {Nome}. (não mostra na tela)
         */

        public string Nome;

        public void Cumprimentar()
        {
            Console.WriteLine($"Olá, eu sou {Nome}");
        }

        public void CumprimentarAlguem(string outraPessoa)
        {
            Console.WriteLine($"Olá {outraPessoa}! Eu sou {Nome}");
        }

        public string ObterApresentacao()
        {
            return $"Meu nome é {Nome}";
        }
    }
}
