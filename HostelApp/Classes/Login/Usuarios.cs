using System;

namespace HostelApp.Classes
{
    public class Usuarios
    {
        private string _usuario;
        private string _senha;

        public string Usuario
        {
            get => _usuario;
            set => _usuario = value;
        }

        public string Senha
        {
            get => _senha;
            set => _senha = value;
        }

        public bool CheckUser(string usuario)
        {
            return (this._usuario == usuario);
        }

        public bool LoginUser(string usuario, string senha)
        {
            return (this._usuario == usuario && this._senha == senha);
        }

        public void IniciaSistema(Usuarios us)
        {
            Console.WriteLine(us._usuario + us._senha);
        }
    }
}