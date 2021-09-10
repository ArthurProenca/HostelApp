using System;
using System.Collections;
using System.Collections.Generic;
using HostelApp.Classes.Gerenciamento;

namespace HostelApp.Classes
{
    public class Administrador
    {
        private string titulo;
        private List<Quartos> Quartos;
        private List<Funcionario> Funcionarios;

        public Administrador()
        {
        }

        public List<Quartos> Quartos1
        {
            get => Quartos;
            set => Quartos = value;
        }

        public List<Funcionario> Funcionarios1
        {
            get => Funcionarios;
            set => Funcionarios = value;
        }

        public Administrador(string titulo)
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
            Console.WriteLine("Digite a descrição do quarto: ");
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
        
        public int AdicionaQuarto(Quartos q)
        {
            Quartos.Add(q);
            return Quartos.Count;
        }

        public void DeletaQuarto(Quartos q)
        {
            Quartos.Remove(q);
        }

        public int AdicionaFuncionarios(Funcionario f)
        {
            Funcionarios.Add(f);
            return Funcionarios.Count;
        }

        public void DeletaFuncionarios(Funcionario f)
        {
            Funcionarios.Remove(f);
        }

    }
}