using System;
using System.Collections.Generic;
using System.Text;

namespace BiblioMetierSportif
{
    public class Sport
    {
        int id;
        string lib;

        public Sport(int id, string lib)
        {
            this.id = id;
            this.lib = lib;
        }
        public Sport(string lib)
        {
            this.lib = lib;
        }

        public int Id { get => id; set => id = value; }
        public string Lib { get => lib; set => lib = value; }
    }
}
