namespace HostelApp.Classes
{
    public class Administrador : Funcionario
    {
        private string titulo;
        
        public Administrador()
        {
        }

        public Administrador(string nome, Usuarios us, string matricula, string titulo) : base(nome, us, matricula)
        {
            this.titulo = titulo;
        }

    }
}