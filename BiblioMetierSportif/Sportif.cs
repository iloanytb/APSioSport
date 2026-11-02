using System;

namespace BiblioMetierSportif
{
    public class Sportif
    {
        private int id;
        private string nom;
        private string prenom;
        private DateTime dateNais;
        private string rue;
        private string cp;
        private string ville;

        //Constructeur
        public Sportif(int id, string nom, string prenom, DateTime dateNais, string rue, string cp, string ville)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.dateNais = dateNais;
            this.rue = rue;
            this.cp = cp;
            this.ville = ville;
        }
        public Sportif(string nom, string prenom, DateTime dateNais, string rue, string cp, string ville)
        {
            this.id = 0;
            this.nom = nom;
            this.prenom = prenom;
            this.dateNais = dateNais;
            this.rue = rue;
            this.cp = cp;
            this.ville = ville;
        }
        //Getters and Setters
        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Rue { get => rue; set => rue = value; }
        public string Cp { get => cp; set => cp = value; }
        public string Ville { get => ville; set => ville = value; }
        public DateTime DateNais { get => dateNais; set => dateNais = value; }
    }
}
