namespace HostelApp.Classes
{
    public class Funcionario : Pessoa
    {
        private string matricula;
        private int id;
        public Funcionario()
        {
        }

        public Funcionario(string nome, Usuarios us, string matricula, int id) : base (nome, us)
        {
            this.matricula = matricula;
            this.id = id;
        }

        public string Matricula
        {
            get => matricula;
            set => matricula = value;
        }
    }
}