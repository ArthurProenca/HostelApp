using System;
using System.Collections.Generic;
using System.Linq;
using HostelApp.Classes.Gerenciamento;
using HostelApp.Database;

namespace HostelApp.Classes
{
    public class Usuarios
    {
        private string _usuario;
        private string _senha;

        public string Usuario
        {
            get => _usuario;
            set => _usuario = value;
        }

        public string Senha
        {
            get => _senha;
            set => _senha = value;
        }

        public bool CheckUser(string usuario)
        {
            string aux;
            for (int i = 0; i < EasyCSV.LeCSV().Count; i++)
            {
                aux = EasyCSV.LeCSV()[i];
                if (aux.Substring(0,aux.IndexOf(",", StringComparison.Ordinal)) == usuario)
                {
                    return true;
                }
            }

            return false;
        }

        public bool LoginUser(string usuario, string senha)
        {
            string aux;
            for (int i = 0; i < EasyCSV.LeCSV().Count; i++)
            {
                aux = EasyCSV.LeCSV()[i];
                if (aux.Substring(0,aux.IndexOf(",", StringComparison.Ordinal)) == usuario && aux.Substring(0,aux.LastIndexOf(",", StringComparison.Ordinal)) == senha)
                {
                    return true;
                }
            }

            return false;
        }

        public void IniciaSistema()
        {
            int aux = 0;
            Controlador c = new Controlador();

            while (aux != 1)
            {
                Console.WriteLine("Bem vindo(a) ao sistema de controle." +
                                  "\n Menu:" +
                                  "\n 1 - Criar reserva" +
                                  "\n 2 - Área da Staff" +
                                  "\n 3 - Logout");
                var opt = Convert.ToInt64(Console.ReadLine());

                switch (opt)
                {
                    case 1:
                        if (c.CriaReserva())
                        {
                            Console.WriteLine("Reserva criada com sucesso.");
                            break;
                        }

                        if (!c.CriaReserva())
                        {
                            Console.WriteLine("Falha na criação de reserva.");
                        }

                        break;
                    case 2:
                        c.AreaStaff();
                        break;
                    case 3:
                        aux = 1;
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }

                Console.Clear();
            }
        }
    }
}