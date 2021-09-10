using System;

namespace HostelApp.Classes
{
    public class Pessoa
    {
        private string nome;
        private Usuarios usuario;

        public Pessoa()
        {
        }

        public Pessoa(string nome, Usuarios usuario)
        {
            this.nome = nome;
            this.usuario = usuario;
        }
        
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