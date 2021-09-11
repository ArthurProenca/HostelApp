using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using HostelApp.Classes.Gerenciamento;
using HostelApp.Database;

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

        public void setQuartos()
        {
            string aux;
            string[] temp;

            for (int i = 0; i < EasyCSV.LeCSV("quartos.csv").Count; i++)
            {
                aux = EasyCSV.LeCSV("quartos.csv")[i];
                temp = aux.Split(",");
                temp[1] = temp[1].Replace(" ", String.Empty);
                temp[2] = temp[2].Replace(" ", String.Empty);
                temp[3] = temp[3].Replace(" ", String.Empty);

                Quartos.Add(new Quartos(Convert.ToInt32(temp[0]), temp[1], Convert.ToDouble(temp[2]),
                    Convert.ToBoolean(temp[3])));
            }
        }

        public void setFuncionarios()
        {
            string aux;
            string[] temp;
            for (int i = 0; i < EasyCSV.LeCSV("staff.csv").Count; i++)
            {
                aux = EasyCSV.LeCSV("staff.csv")[i];
                temp = aux.Split(",");
                temp[1] = temp[1].Replace(" ", String.Empty);
                temp[2] = temp[2].Replace(" ", String.Empty);
                Funcionarios.Add(new Funcionario(temp[0], temp[1], Convert.ToInt32(temp[2])));
            }
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
            int id = Quartos.Count + 1;
            EasyCSV.InsereCSV(id + ", " + descricao + ", " + preco + ", " + "false", "quartos.csv");
            Quartos.Add(new Quartos(Quartos.Count + 1, descricao, preco, false));
        }

        public void CriaFuncionario()
        {
            Console.WriteLine("Digite o nome do funcionário: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite a matrícula do funcionário: ");
            string matricula = Console.ReadLine();

            EasyCSV.InsereCSV(nome + ", " + matricula + ", " + Convert.ToInt32(Funcionarios.Count + 1), "staff.csv");

            Funcionarios.Add(new Funcionario(nome, matricula, Funcionarios.Count + 1));
        }

        public bool CheckFuncionario(string matricula)
        {
            string aux;
            string[] temp;

            for (int i = 0; i < EasyCSV.LeCSV("staff.csv").Count; i++)
            {
                aux = EasyCSV.LeCSV("staff.csv")[i];
                temp = aux.Split(",");
                temp[1] = temp[1].Replace(" ", String.Empty);
                if (temp[1].Equals(matricula))
                {
                    return true;
                }
            }

            return false;
        }

        public void DeletaQuarto(int id)
        {
            List<string> aux = EasyCSV.LeCSV("quartos.csv");
            string[] temp;
            if (id <= EasyCSV.LeCSV("quartos.csv").Count)
            {
                aux.RemoveAt(id);
                EasyCSV.CriaCSV("quartos.csv");
                for (int i = 0; i < aux.Count; i++)
                {
                    temp = aux[i].Split(",");
                    temp[1] = temp[1].Replace(" ", String.Empty);
                    temp[2] = temp[2].Replace(" ", String.Empty);
                    temp[3] = temp[3].Replace(" ", String.Empty);
                    EasyCSV.InsereCSV((temp[0] + ", " + temp[1] + ", " + temp[2] + ", " + temp[3]), "quartos.csv");
                }

                setQuartos();
            }
            else
            {
                Console.WriteLine("Não é possível remover esse quarto.");
            }
        }

        public void DeletaFuncionarios(int id)
        {
            List<string> aux = EasyCSV.LeCSV("staff.csv");
            string[] temp;
            if (id <= EasyCSV.LeCSV("staff.csv").Count)
            {
                Console.WriteLine(aux[0]);
                aux.RemoveAt(id);
                EasyCSV.CriaCSV("staff.csv");
                for (int i = 0; i < aux.Count; i++)
                {
                    temp = aux[i].Split(",");
                    temp[1] = temp[1].Replace(" ", String.Empty);
                    temp[2] = temp[2].Replace(" ", String.Empty);
                    EasyCSV.InsereCSV((temp[0] + ", " + temp[1] + ", " + temp[2]), "staff.csv");
                }

                setFuncionarios();
            }
            else
            {
                Console.WriteLine("Não é possível remover esse funcionário.");
            }
        }

    }
}