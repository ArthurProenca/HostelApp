using System;
using System.Collections;

namespace HostelApp.Classes.Gerenciamento
{
    public class Quartos
    {
        private int id;
        private string descricao;
        private float preco;
        private bool status; 
        public Quartos()
        {
        }

        public Quartos(int id, string descricao, float preco, bool status)
        {
            this.id = id;
            this.descricao = descricao;
            this.preco = preco;
            this.status = status;
        }

        public int Id
        {
            get => id;
            set => id = value;
        }

        public string Descricao
        {
            get => descricao;
            set => descricao = value;
        }

        public float Preco
        {
            get => preco;
            set => preco = value;
        }

        public bool Status
        {
            get => status;
            set => status = value;
        }

        public bool BuscaQuarto(int id)
        {
            Administrador admin = new Administrador();
            if (admin.RetornaQuartos().Contains(id))
            {
                return true;
            }
            return false;
        }

    }
}