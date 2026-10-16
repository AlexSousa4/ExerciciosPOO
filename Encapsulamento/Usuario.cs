using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosPOO.Encapsulamento
{
    internal class Usuario
    {
        /*
         * ### Exercício 3: Usuário

        Crie a classe `Usuario` com:

        - Propriedade pública `Login`.
        - Campo `private string senha`.
        - Um **construtor** que recebe login e senha.
        - Método público `ConferirSenha(string tentativa)`: **retorna** `true` se a tentativa for igual à senha.
        - Método público `TrocarSenha(string senhaAtual, string novaSenha)`: só troca se a senha atual estiver correta. Mostra "Senha alterada!" ou "Senha atual incorreta.".
         */

        public string Login { get; set; }

        private string Senha;

        public Usuario(string login, string senha)
        {
            Login = login;
            Senha = senha;
        }

        public bool ConferirSenha(string Tentativa)
        {
            if (Tentativa == Senha)
            {
                return true;
            }
            else return false;
        }

        public void TrocarSenha(string senhaAtual, string novaSenha)
        {
            if (senhaAtual == Senha)
            {
                Console.WriteLine("Senha Alterada!");
            }
            else Console.WriteLine("Senha Atual Incorreta!");
        }
    }
}
