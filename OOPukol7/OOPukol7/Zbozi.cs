using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPukol7
{
    internal class Zbozi
    {
        protected string nazev;
        protected double cena;
        protected DateTime datumVyr;
        protected int minTrvanl;

        public Zbozi(string nazev,double cena,DateTime datumVyr,int minTrvanl) 
        {
            this.nazev = nazev;
            this.cena = cena;
            this.datumVyr = datumVyr;
            this.minTrvanl= minTrvanl;
        }

        public bool TrvCheck()
        {
            TimeSpan dny = DateTime.Now - datumVyr;
            if(dny.TotalDays > minTrvanl)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public virtual double CenaPlusDPH()
        {
            return (cena + (cena / 100 * 21));
        }

        public override string ToString()
        {
            return "Zbozi: " + nazev + "\nCena: " + Math.Round(CenaPlusDPH(),2) + "Kč" + "\nPrekrocilo minimalni trvanlivost " + (TrvCheck()? "ANO" : "NE");
        }
    }
}
