using System;

namespace HostelApp.Classes.Gerenciamento
{
    public class Controlador
    {
        
        public bool CriaReserva()
        {
            int id;
            Console.WriteLine("Digite o ID do quarto: ");
            id = Console.Read();
            
            VerificaReserva(id);
            if (VerificaReserva(id))
            {
                Console.WriteLine("O quarto " + id + "pode ser reservado.");
                return true;
            }
            return false;
        }

        public bool VerificaReserva(int id)
        {
            Quartos q = new Quartos();

            if (q.Status == true)
            {
                return false;
            }
            return true;
        }

        public void AreaStaff()
        {
            
        }
    }
}