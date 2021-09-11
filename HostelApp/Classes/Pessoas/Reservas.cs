namespace HostelApp.Classes
{
    public class Reservas : Usuarios
    {
        private int id;
        private string dataEntrada;
        private string dataSaida;
        private int nQuarto;

        public Reservas(int id, int nQuarto, string dataEntrada, string dataSaida, string nome, string senha) : base(nome, senha)
        {
            this.id = id;
            this.nQuarto = nQuarto;
            this.dataEntrada = dataEntrada;
            this.dataSaida = dataSaida;
        }
        
    }
}