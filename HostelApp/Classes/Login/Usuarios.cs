using System;
using HostelApp.Classes.Gerenciamento;
using HostelApp.Database;

namespace HostelApp.Classes
{
    public class Usuarios
    {
        private string _usuario;
        private string _senha;

        public Usuarios()
        {
        }

        public Usuarios(string usuario, string senha)
        {
            _usuario = usuario;
            _senha = senha;
        }

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

        public bool CheckUser(string usuario, string nome)
        {
            string aux;
            for (int i = 0; i < EasyCSV.LeCSV(nome).Count; i++)
            {
                aux = EasyCSV.LeCSV(nome)[i];
                if (aux.Substring(0, aux.IndexOf(",", StringComparison.Ordinal)) == usuario)
                {
                    return true;
                }
            }

            return false;
        }

        public bool LoginUser(string usuario, string senha, string nome)
        {
            string aux;
            string[] temp;
            
            for (int i = 0; i < EasyCSV.LeCSV(nome).Count; i++)
            {
                aux = EasyCSV.LeCSV(nome)[i];
                temp = aux.Split(",");
                temp[1] = temp[1].Replace(" ", String.Empty);
                if (temp[0].Equals(usuario) && temp[1].Equals(senha))
                {
                    return true;
                }

            }

            return false;
        }

        public void IniciaSistema(Usuarios us, Administrador a)
        {
            Console.Clear();
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
                        if (c.CriaReserva(us, a))
                        {
                            Console.WriteLine("Reserva criada com sucesso.");
                            break;
                        }

                        if (!c.CriaReserva(us, a))
                        {
                            Console.WriteLine("Falha na criação de reserva.");
                        }

                        break;
                    case 2:
                        c.AreaStaff(a);
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