using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
       public abstract class Primerak
    {
        protected string naziv;
        protected int god;

        public Primerak(string naziv, int god)
        {
            if (naziv.Equals(string.Empty))
                throw new Exception("Nema naziv!");
            else if (god < 1990 || god > 2019) //tekuca godina je 2019
                throw new Exception("Neispravna godina!");
            this.naziv = naziv;
            this.god = god;
        }

        public bool StarijiOd(Primerak p)
        {
            return god < p.god;
        }
        public bool MladjiOd(Primerak p)
        {
            return god > p.god;
        }

        public abstract string Info();
    }

    public class Knjiga : Primerak
    {
        private string autor;

        public Knjiga(string naziv, string autor, int god) : base(naziv, god)
        {
            if (autor.Equals(string.Empty)) throw new Exception("Nema autora!");
            this.autor = autor;
        }

        public override string Info()
        {
            string s = naziv + "-" + autor;
            s += ", god: " + god;
            return s;
        }
    }

    public class Casopis : Primerak
    {
        private int mesec;

        public Casopis(string naziv, int god, int mesec) : base(naziv, god)
        {
            if (mesec < 1 || mesec > 12)
                throw new Exception("Neispravan mesec!");
            this.mesec = mesec;
        }

        public override string Info()
        {
            return naziv + ", god: " + god + ", mesec: " + mesec;
        }
    }

}
