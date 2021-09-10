using System;

namespace HostelApp.Classes
{
    public class Hospede : Pessoa
    {
    private int numeroQuarto;

    public Hospede(string nome, Usuarios us, int numeroQuarto) : base (nome, us)
    {
        this.numeroQuarto = numeroQuarto;
    }

    public int NumeroQuarto
    {
        get => numeroQuarto;
        set => numeroQuarto = value;
    }
    }
}