using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioMetierSportif
{
    public class Utilisateur
    {
            int id;
            string login;
            string psw;
            public int Id { get => id; set => id = value; }
            public string Login { get => login; set => login = value; }
            public string Psw { get => psw; set => psw = value; }
        public Utilisateur(int id, string login, string psw)
        {
            this.id = id;
            this.login = login;
            this.psw = psw;
        }
        public Utilisateur(string login, string psw)
        {
            this.id = 0;
            this.login = login;
            this.psw = psw;
        }
        public Utilisateur(string login)
        {
            this.id = 0;
            this.login = login;
            this.psw = "";
        }
    }
}
