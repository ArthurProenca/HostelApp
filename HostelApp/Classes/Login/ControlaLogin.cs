using System;
using HostelApp.Database;

namespace HostelApp.Classes.Login
{
    public class ControlaLogin
    {
        public static void Cadastro(int index)
        {
            Usuarios us = new Usuarios();
            Pessoa p = new Pessoa();
            string usuario, senha;


            Console.WriteLine("Digite o nome de usuário: ");
            usuario = Console.ReadLine();
            Console.WriteLine("Digite a senha de usuário: ");
            senha = Console.ReadLine();

            switch (index)
            {
                case 1: //Cadastro.
                    if (us.CheckUser(usuario, "users.csv"))
                    {
                        Console.WriteLine("Usuário já existe.");
                        break;
                    }

                    us.Usuario = usuario;
                    us.Senha = senha;
                    
                    EasyCSV.InsereCSV(usuario + ", " + senha, "users.csv");
                    
                    us.IniciaSistema();
                    break;

                case 0: //Login.
                    if (us.LoginUser(usuario, senha, "users.csv"))
                    {
                        us.IniciaSistema();
                        break;
                    }

                    Console.WriteLine("Usuário não existe.");
                    break;
            }
        }

        public void CriaTela()
        {
            Console.WriteLine("Olá, seja bem vindo(a) ao sistema de cadastro do HostelApp.");
            Console.WriteLine("Menu:\n" +
                              "\n1 - Cadastro:" +
                              "\n2 - Login" +
                              "\n3 - Sair" +
                              "\nDigite sua opção abaixo:");

            var opt = Convert.ToInt64(Console.ReadLine());

            switch (opt)
            {
                case 1:
                    Cadastro(1);
                    break;
                case 2:
                    Cadastro(0);
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
    }
}