using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPukol7
{
    internal class Produkt : Zbozi
    {
        private bool sleva;

        public Produkt(string nazev, double cena, DateTime datumVyr, int minTrvanl, bool sleva) : base (nazev,cena,datumVyr,minTrvanl)
        {
            this.sleva = sleva;
        }

        public override double CenaPlusDPH()
        {
            
            if(sleva == true&& TrvCheck() == true) 
            {
                return ((cena + (cena / 100 * 21))) - (cena / 100 * 40);
            }
            else
            {
                return (cena + (cena / 100 * 21));
            }
        }
    }
}
