using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosPOO.ExerciciosEmSala
{
    internal class ExercicioEmSalaLivro
    {
        public string Titulo;
        public string Autor;
        public int Paginas;


        public ExercicioEmSalaLivro(string Titulo, string Autor, int Paginas)
        {
            this.Titulo = Titulo;
            this.Autor = Autor;
            this.Paginas = Paginas;
        }

        public void Exibir()
        {
            Console.WriteLine($"Titulo do Livro: {Titulo}");
            Console.WriteLine($"Autor do Livro: {Autor}");
            Console.WriteLine($"Quantidade de paginas do Livro: {Paginas}");
        }
    }
}
