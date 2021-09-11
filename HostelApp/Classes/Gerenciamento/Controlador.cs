﻿using System;

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

        public void AreaStaff()
        {
            Console.WriteLine("Digite sua matricula: ");
            string matricula = Console.ReadLine();

            Administrador admin = new Administrador();
            
            admin.CriaFuncionario();
            
            for (int i = 0; i < admin.getFuncionarios.Count; i++)
            {
                if (admin.getFuncionarios[i].Matricula == matricula)
                {
                    admin.Administracao();
                    break;
                }
            }
        }
    }
}