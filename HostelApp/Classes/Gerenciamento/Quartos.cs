using System;
using HostelApp.Database;

namespace HostelApp.Classes.Gerenciamento
{
    public class Quartos
    {
        private int _id;
        private string _descricao;
        private double _preco;
        private bool _status; 
        public Quartos()
        {
        }

        public Quartos(int id, string descricao, double preco, bool status)
        {
            this._id = id;
            this._descricao = descricao;
            this._preco = preco;
            this._status = status;
        }

        public int Id
        {
            get => _id;
            set => _id = value;
        }

        public string Descricao
        {
            get => _descricao;
            set => _descricao = value;
        }

        public double Preco
        {
            get => _preco;
            set => _preco = value;
        }

        public bool Status
        {
            get => _status;
            set => _status = value;
        }

        public Quartos BuscaQuarto(int id)
        {
            Administrador admin = new Administrador();
            return (Quartos) admin.getQuartos[id];
        }

    }
}