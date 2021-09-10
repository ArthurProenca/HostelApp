using System;
using HostelApp.Classes.Gerenciamento;

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
            return (this._usuario == usuario);
        }

        public bool LoginUser(string usuario, string senha)
        {
            return (this._usuario == usuario && this._senha == senha);
        }

        public void IniciaSistema(Usuarios us)
        {
            int aux = 0;
            Controlador c = new Controlador();

            while (aux != 1)
            {
                Console.WriteLine("Bem vindo(a) ao sistema de controle." +
                                  "\n Menu:" +
                                  "\n 1 - Criar reserva" +
                                  "\n 2 - Verificar reservas" +
                                  "\n 3 - Área da Staff" +
                                  "\n 4 - Logout");
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
                        c.VerificaReserva();
                        break;
                    case 3:
                        c.AreaStaff();
                        break;
                    case 4:
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