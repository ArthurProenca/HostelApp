using System;
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

        public void CriaQuarto()
        {
            int id = Quartos.Count + 1;
            Console.WriteLine("Digite a descrição do quarto");
            string descricao = Console.ReadLine();
            Console.WriteLine("Digite o preço do quarto: ");
            double preco = Convert.ToDouble(Console.ReadLine());

            Quartos q = new Quartos(id, descricao, preco, false);

            AdicionaQuarto(q);
        }

        public void CriaFuncionario(Usuarios us)
        {
            Console.WriteLine("Digite o nome do funcionário: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite a matrícula do funcionário: ");
            string matricula = Console.ReadLine();

            Funcionario f = new Funcionario(nome, us, matricula);

            AdicionaFuncionarios(f);
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