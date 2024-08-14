using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simkaart
{
    internal class SimKaart
    {
        public string telefoonnummer = String.Empty;
        DateTime createDatum = DateTime.Now;


        public SimKaart(string telefoonnummer, DateTime createDatum) {

            this.telefoonnummer = telefoonnummer;
            this.createDatum = createDatum;
        }

        public DateTime CreateDatum
        {
            get { return createDatum;}
        }


    }
}
