using System;

namespace HostelApp.Classes
{
    public class Hospede : Pessoa
    {
    private int _numeroQuarto;

    public Hospede(string nome, Usuarios us, int numeroQuarto) : base (nome)
    {
        this._numeroQuarto = numeroQuarto;
    }

    public int NumeroQuarto
    {
        get => _numeroQuarto;
        set => _numeroQuarto = value;
    }
    }
}