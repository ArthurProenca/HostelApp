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

        public void Administracao(Usuarios us)
        {
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
                        CriaFuncionario(us);
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

            Quartos.Add(q);
        }

        public void CriaFuncionario(Usuarios us)
        {
            Console.WriteLine("Digite o nome do funcionário: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite a matrícula do funcionário: ");
            string matricula = Console.ReadLine();


            Funcionario f = new Funcionario(nome, us, matricula, Funcionarios.Count + 1);

            Funcionarios.Add(f);
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