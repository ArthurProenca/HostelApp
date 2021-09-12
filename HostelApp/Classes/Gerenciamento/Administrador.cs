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
        private List<Quartos> Quartos;
        private List<Funcionario> Funcionarios;
        private List<Usuarios> Usuarios;
        private List<Reservas> Reservas;

        public List<Quartos> getQuartos => Quartos;

        public List<Funcionario> getFuncionarios => Funcionarios;

        public List<Reservas> getReservas => Reservas;

        public List<Usuarios> getUsuarios => Usuarios;

        public string Titulo
        {
            get => _titulo;
            set => _titulo = value;
        }

        public Administrador()
        {
        }

        public Administrador(List<Quartos> quartos, List<Funcionario> funcionarios, List<Usuarios> usuarios,
            List<Reservas> reservas)
        {
            Quartos = quartos;
            Funcionarios = funcionarios;
            Usuarios = usuarios;
            Reservas = reservas;
        }

        public List<Quartos> setQuartos()
        {
            string aux;
            string[] temp;
            List<Quartos> x = new List<Quartos>();
            for (int i = 0; i < EasyCSV.LeCSV("quartos.csv").Count; i++)
            {
                aux = EasyCSV.LeCSV("quartos.csv")[i];
                temp = aux.Split(",");
                temp[1] = temp[1].Replace(" ", String.Empty);
                temp[2] = temp[2].Replace(" ", String.Empty);
                temp[3] = temp[3].Replace(" ", String.Empty);

                x.Add(new Quartos(Convert.ToInt32(temp[0]), temp[1], Convert.ToDouble(temp[2]),
                    Convert.ToBoolean(temp[3])));
            }

            Quartos = new List<Quartos>(x);
            return Quartos;
        }

        public List<Funcionario> setFuncionarios()
        {
            string aux;
            string[] temp;
            List<Funcionario> x = new List<Funcionario>();
            for (int i = 0; i < EasyCSV.LeCSV("staff.csv").Count; i++)
            {
                aux = EasyCSV.LeCSV("staff.csv")[i];
                temp = aux.Split(",");
                temp[1] = temp[1].Replace(" ", String.Empty);
                temp[2] = temp[2].Replace(" ", String.Empty);
                x.Add(new Funcionario(temp[0], temp[1], Convert.ToInt32(temp[2])));
            }

            Funcionarios = new List<Funcionario>(x);
            return Funcionarios;
        }

        public List<Usuarios> setUsuarios()
        {
            string aux;
            string[] temp;
            List<Usuarios> x = new List<Usuarios>();
            for (int i = 0; i < EasyCSV.LeCSV("users.csv").Count; i++)
            {
                //arthur, 123
                aux = EasyCSV.LeCSV("users.csv")[i];
                temp = aux.Split(",");
                temp[1] = temp[1].Replace(" ", String.Empty);
                x.Add(new Usuarios(temp[0], temp[1]));
            }

            Usuarios = new List<Usuarios>(x);
            return Usuarios;
        }

        public List<Reservas> setReservas()
        {
            string aux;
            string[] temp;
            List<Reservas> x = new List<Reservas>();
            for (int i = 0; i < EasyCSV.LeCSV("reservas.csv").Count; i++)
            {
                aux = EasyCSV.LeCSV("reservas.csv")[i];
                temp = aux.Split(",");
                temp[1] = temp[1].Replace(" ", String.Empty);
                temp[2] = temp[2].Replace(" ", String.Empty);
                temp[3] = temp[3].Replace(" ", String.Empty);
                temp[4] = temp[4].Replace(" ", String.Empty);
                temp[5] = temp[5].Replace(" ", String.Empty);
                //id + ", " + id + ", " + dataEntrada + ", " + dataSaida + ", " + us.Usuario + ", " + us.Senha
                x.Add(new Reservas(Convert.ToInt32(temp[0]), Convert.ToInt32(temp[1]), temp[2], temp[3], temp[4],
                    temp[5]));
            }

            Reservas = new List<Reservas>(x);
            return Reservas;
        }

        public void Administracao(Administrador a)
        {
            int opt = 0;
            while (opt != 5)
            {
                Console.WriteLine("\n 1 - Criar Quarto" +
                                  "\n 2 - Cadastro de Funcionário" +
                                  "\n 3 - Deletar Quarto" +
                                  "\n 4 - Deletar Funcionário" +
                                  "\n 5 - Listar Reservas" +
                                  "\n 6 - Listar Quartos" +
                                  "\n 7 - Sair");

                opt = Convert.ToInt32(Console.ReadLine());
                switch (opt)
                {
                    case 1:
                        CriaQuarto(a);
                        break;
                    case 2:
                        CriaFuncionario(a);
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
                        ListaReservas(a);
                        break;
                    case 6:
                        ListaQuartos(a);
                        break;
                    case 7:
                        opt = 5;
                        break;
                }
            }
        }

        public void ListaReservas(Administrador a)
        {
            for (int i = 0; i < a.getReservas.Count; i++)
            {
                Console.WriteLine(a.getReservas[i].Id + " " + a.getReservas[i].NQuarto + " " + a.getReservas[i].DataEntrada + " " + a.getReservas[i].DataSaida);
            }
        }

        public void ListaQuartos(Administrador a)
        {
            for (int i = 0; i < a.getQuartos.Count; i++)
            {
                Console.WriteLine(a.getQuartos[i].Id + " " + a.getQuartos[i].Descricao + " " + a.getQuartos[i].Status);
            }
        }

        public void CriaQuarto(Administrador a)
        {
            List<Quartos> x = new List<Quartos>();
            Console.WriteLine("Digite a descrição do quarto: ");
            string descricao = Console.ReadLine();
            Console.WriteLine("Digite o preço do quarto: ");
            double preco = Convert.ToDouble(Console.ReadLine());
            int id = Quartos.Count + 1;
            EasyCSV.InsereCSV(id + ", " + descricao + ", " + preco + ", " + "false", "quartos.csv");
            
            a.setQuartos.a(new Quartos(Quartos.Count + 1, descricao, preco, false));
        }

        public void CriaFuncionario(Administrador a)
        {
            Console.WriteLine("Digite o nome do funcionário: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite a matrícula do funcionário: ");
            string matricula = Console.ReadLine();

            EasyCSV.InsereCSV(nome + ", " + matricula + ", " + Convert.ToInt32(Funcionarios.Count + 1), "staff.csv");

            a.Funcionarios.Add(new Funcionario(nome, matricula, Funcionarios.Count + 1));
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