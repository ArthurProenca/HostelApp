using System;
using System.Collections.Generic;
using HostelApp.Classes;
using HostelApp.Classes.Gerenciamento;
using HostelApp.Classes.Login;

namespace HostelApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ControlaLogin el = new ControlaLogin();
            Administrador admin = new Administrador();

            List<Funcionario> f = admin.setFuncionarios();
            List<Quartos> q = admin.setQuartos();
            List<Usuarios> a = admin.setUsuarios();
            List<Reservas> r = admin.setReservas();

            Administrador aux = new Administrador(q, f, a, r);

            el.CriaTela(aux);
        }
    }
}