using System;
using System.Collections;
using System.Collections.Generic;

namespace HostelApp.Classes.Gerenciamento
{
    public class Quartos
    {
        private int id;
        private string descricao;
        private double preco;
        private bool status; 
        public Quartos()
        {
        }

        public Quartos(int id, string descricao, double preco, bool status)
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

        public double Preco
        {
            get => preco;
            set => preco = value;
        }

        public bool Status
        {
            get => status;
            set => status = value;
        }

        public Quartos BuscaQuarto(int id)
        {
            Administrador admin = new Administrador();
            return admin.Quartos1[id];
        }

        public void RetornaQuartos()
        {
            Administrador admin = new Administrador();
            
            for (int i = 0; i < admin.Quartos1.Count; i++)
            {
                Console.WriteLine("\nQuarto: " + admin.Quartos1[i]);
            }
            Console.WriteLine();
        }

    }
}