using System;
using System.Collections.Generic;

namespace HostelApp.Classes
{
    public class Reservas : Usuarios
    {
        private int id;
        private string dataEntrada;
        private string dataSaida;
        private int nQuarto;

        public int Id => id;

        public string DataEntrada => dataEntrada;

        public string DataSaida => dataSaida;

        public int NQuarto => nQuarto;

        public Reservas()
        {
        }

        public Reservas(int id, int nQuarto, string dataEntrada, string dataSaida, string nome, string senha) : base(
            nome, senha)
        {
            this.id = id;
            this.nQuarto = nQuarto;
            this.dataEntrada = dataEntrada;
            this.dataSaida = dataSaida;
        }

       

    }

}