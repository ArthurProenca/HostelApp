using System;

namespace HostelApp.Classes.Gerenciamento
{
    public class Controlador
    {
        
        public bool CriaReserva()
        {
            Quartos q = new Quartos();
            
            if (q.Status)
            {
                Console.WriteLine("Este quarto está ocupado.");
                return false;
            }

            return true;
        }

        public void VerificaReserva()
        {
            
        }

        public void AreaStaff()
        {
            
        }
    }
}