using HostelApp.Classes;
using HostelApp.Classes.Login;

namespace HostelApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ControlaLogin el = new ControlaLogin();
            Administrador admin = new Administrador();
            
            admin.setFuncionarios();
            admin.setQuartos();
            admin.setUsuarios();
            admin.setReservas();
            
            el.CriaTela();
        }
    }
}