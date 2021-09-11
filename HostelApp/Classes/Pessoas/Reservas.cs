namespace HostelApp.Classes
{
    public class Reservas
    {
        private Hospede hospede;
        private string dataEntrada;
        private string dataSaida;

        public Reservas(Hospede hospede, string dataEntrada, string dataSaida)
        {
            this.hospede = hospede;
            this.dataEntrada = dataEntrada;
            this.dataSaida = dataSaida;
        }


        public Hospede Hospede
        {
            get => hospede;
            set => hospede = value;
        }
    }
}