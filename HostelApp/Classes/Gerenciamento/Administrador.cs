using System;
using System.Collections.Generic;
using HostelApp.Classes.Gerenciamento;

namespace HostelApp.Classes
{
    public class Administrador
    {
        private string _titulo;
        private List<Quartos> Quartos = new List<Quartos>();
        private List<Funcionario> Funcionarios = new List<Funcionario>();

        public List<Quartos> getQuartos => Quartos;

        public List<Funcionario> getFuncionarios => Funcionarios;

        public string Titulo
        {
            get => _titulo;
            set => _titulo = value;
        }

        public void Administracao()
        {
            Quartos q = new Quartos();
            q.RetornaQuartos();
            int opt = 0;
            while (opt != 5)
            {
                Console.WriteLine("\n 1 - Criar Quarto" +
                                  "\n 2 - Cadastro de Funcionário" +
                                  "\n 3 - Deletar Quarto" +
                                  "\n 4 - Deletar Funcionário" +
                                  "\n 5 - Voltar");

                opt = Convert.ToInt32(Console.ReadLine());
                switch (opt)
                {
                    case 1:
                        CriaQuarto();
                        break;
                    case 2:
                        CriaFuncionario();
                        break;
                    case 3:
                        Console.WriteLine("Digite o ID do quarto a ser removido: ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        DeletaQuarto(id);
                        break;
                    case 4:
                        Console.WriteLine("Digite o ID do funcionário a ser removido: ");
                        id = Convert.ToInt32(Console.ReadLine());
                        DeletaFuncionarios(id);
                        break;
                    case 5:
                        opt = 5;
                        break;
                }
            }
        }

        public void CriaQuarto()
        {
            Console.WriteLine("Digite a descrição do quarto: ");
            string descricao = Console.ReadLine();
            Console.WriteLine("Digite o preço do quarto: ");
            double preco = Convert.ToDouble(Console.ReadLine());

            Quartos.Add(new Quartos(Quartos.Count + 1, descricao, preco, false));
        }

        public void CriaFuncionario()
        {
            Console.WriteLine("Digite o nome do funcionário: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite a matrícula do funcionário: ");
            string matricula = Console.ReadLine();

            Funcionarios.Add(new Funcionario(nome, matricula, Funcionarios.Count + 1));
        }

        public void DeletaQuarto(int id)
        {
            Quartos.RemoveAt(id);
        }

        public void DeletaFuncionarios(int id)
        {
            Funcionarios.RemoveAt(id);
        }

    }
}