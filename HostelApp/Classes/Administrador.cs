using System.Collections;
using HostelApp.Classes.Gerenciamento;

namespace HostelApp.Classes
{
    public class Administrador
    {
        private string titulo;
        private ArrayList Quartos;
        private ArrayList Funcionarios;
        public Administrador()
        {
        }

        public Administrador(string nome, Usuarios us, string matricula, string titulo)
        {
            this.titulo = titulo;
        }

        public string Titulo
        {
            get => titulo;
            set => titulo = value;
        }

        public ArrayList RetornaQuartos()
        {
            return Quartos;
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
        
        public ArrayList RetornaFuncionarios()
        {
            return Funcionarios;
        }

        public int AdicionaFuncionarios(Funcionario f)
        {
            Funcionarios.Add(f);
            return Funcionarios.Count;
        }

        public void DeletaFuncionarios(Funcionario f)
        {
            Quartos.Remove(f);
        }

    }
}