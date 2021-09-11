using System;

namespace HostelApp.Classes
{
    public class Pessoa
    {
        private string _nome;

        public Pessoa()
        {
        }

        public Pessoa(string nome)
        {
            this._nome = nome;
        }
        
        public string Nome
        {
            get => _nome;
            set => _nome = value;
        }
    }
}