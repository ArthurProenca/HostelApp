using System;

namespace HostelApp.Classes.Gerenciamento
{
    public class Controlador
    {

        public bool CriaReserva()
        {
            int id;
            Console.WriteLine("Digite o ID do quarto: ");
            id = Convert.ToInt32(Console.ReadLine());

            VerificaReserva(id);
            if (VerificaReserva(id))
            {
                Console.WriteLine("O quarto " + id + " pode ser reservado.");
                return true;
            }

            return false;
        }

        public bool VerificaReserva(int id)
        {
            Quartos q = new Quartos();

            if (q.Status)
            {
                return false;
            }

            return true;
        }

        public void AreaStaff(Usuarios us)
        {
            Console.WriteLine("Digite seu nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite sua matricula: ");
            string matricula = Console.ReadLine();

            Funcionario f = new Funcionario(nome, us, matricula); //Crio uma instância, mas não adiciono aos administradores.
            Administrador admin = new Administrador();

            Quartos q = new Quartos();
            q.RetornaQuartos();
        }
    }
}