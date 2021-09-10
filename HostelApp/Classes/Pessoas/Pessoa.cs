using System;

namespace HostelApp.Classes
{
    public class Pessoa
    {
        public Pessoa()
        {
        }

        public Pessoa(string nome, Usuarios usuario)
        {
            this.nome = nome;
            this.usuario = usuario;
        }

        private string nome;
        private Usuarios usuario;

        public string Nome
        {
            get => nome;
            set => nome = value;
        }

        public Usuarios Usuario
        {
            get => usuario;
            set => usuario = value;
        }
    }
}