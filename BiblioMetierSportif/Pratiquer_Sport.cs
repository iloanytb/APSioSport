using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace BiblioMetierSportif
{
    public class Pratiquer_Sport
    {
        int idSport;
        int idSportif;
        string nivExp;

        //Constructeur
        public Pratiquer_Sport(int idSport, int idSportif, string nivExp)
        {
            this.idSport = idSport;
            this.idSportif = idSportif;
            this.nivExp = nivExp;
        }
        public Pratiquer_Sport(int idSport, int idSportif)
        {
            this.idSport = idSport;
            this.idSportif = idSportif;
            this.nivExp = "";
        }

        //Getters/Setters
        public int IdSport { get => idSport; set => idSport = value; }
        public int IdSportif { get => idSportif; set => idSportif = value; }
        public string NivExp { get => nivExp; set => nivExp = value; }
    }
}
