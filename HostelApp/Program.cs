using System;
using System.Collections.Generic;
using HostelApp.Classes;
using HostelApp.Classes.Login;
using HostelApp.Database;

namespace HostelApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ControlaLogin el = new ControlaLogin();
            el.CriaTela();
        }
    }
}