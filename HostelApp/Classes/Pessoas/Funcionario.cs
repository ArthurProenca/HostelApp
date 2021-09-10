namespace HostelApp.Classes
{
    public class Funcionario : Pessoa
    {
        private string matricula;

        public Funcionario()
        {
        }

        public Funcionario(string nome, Usuarios us, string matricula) : base (nome, us)
        {
            this.matricula = matricula;
        }

        public string Matricula
        {
            get => matricula;
            set => matricula = value;
        }
    }
}