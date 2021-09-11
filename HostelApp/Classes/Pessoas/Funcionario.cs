namespace HostelApp.Classes
{
    public class Funcionario : Pessoa
    {
        private string _matricula;
        private int _id;
        public Funcionario()
        {
        }

        public Funcionario(string nome, string matricula, int id) : base (nome)
        {
            this._matricula = matricula;
            this._id = id;
        }

        public int Id
        {
            get => _id;
            set => _id = value;
        }

        public string Matricula
        {
            get => _matricula;
            set => _matricula = value;
        }
    }
}