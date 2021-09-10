using System.Collections;
using HostelApp.Classes.Gerenciamento;

namespace HostelApp.Classes
{
    public class Administrador : Funcionario
    {
        private string titulo;
        private ArrayList Quartos;
        public Administrador()
        {
        }

        public Administrador(string nome, Usuarios us, string matricula, string titulo) : base(nome, us, matricula)
        {
            this.titulo = titulo;
        }

        public string Titulo
        {
            get => titulo;
            set => titulo = value;
        }

        public int AdicionaQuarto(Quartos q)
        {
            Quartos.Add(q);
            return Quartos.Count;
        }

        public void DeletaQuarto(Quartos q)
        {
            Quartos.Remove(q);
        }

    }
}