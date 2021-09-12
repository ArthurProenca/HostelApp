using System;
using System.Collections.Generic;
using HostelApp.Database;

namespace HostelApp.Classes.Gerenciamento
{
    public class Controlador
    {

        public bool CriaReserva(Usuarios us, Administrador a)
        {
            Console.WriteLine(us.Usuario);
            int id;
            Console.WriteLine("Digite o ID do quarto: ");
            id = Convert.ToInt32(Console.ReadLine());

            if (VerificaReserva(id))
            {
                List<Reservas> x = new List<Reservas>();

                Console.WriteLine("O quarto " + id + " pode ser reservado.");
                Console.WriteLine("Digite a data de entrada: ");
                string dataEntrada = Console.ReadLine();
                Console.WriteLine("Digite a data de saída: ");
                string dataSaida = Console.ReadLine();
                
                a.setReservas().Add(new Reservas(id, id, dataEntrada, dataSaida, us.Usuario, us.Senha));
                
                EasyCSV.InsereCSV(
                    id + ", " + id + ", " + dataEntrada + ", " + dataSaida + ", " + us.Usuario + ", " + us.Senha,
                    "reservas.csv");
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

        public void AreaStaff(Administrador a)
        {
            Console.WriteLine("Digite sua matricula: ");
            string matricula = Console.ReadLine();

            Administrador admin = new Administrador();
            if (admin.CheckFuncionario(matricula))
            {
                admin.Administracao(a);
            }

            Console.WriteLine("Matrícula não consta no sistema.");
        }
    }
}