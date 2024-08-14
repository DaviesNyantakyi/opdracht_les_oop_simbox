using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using simkaart;

namespace simBox
{
    internal class SimBox
    {
        public SimKaart simKaart1, simKaart2, simkaart3;
        private int aantalSimKaarten = 0;


        public SimBox(SimKaart simKaart1 = null, SimKaart simKaart2 = null, SimKaart simKaart3 = null)
        {

            this.simKaart1 = simKaart1;
            this.simKaart2 = simKaart2;
            this.simkaart3 = simKaart3;


         

        }
        public int AantalSimKaarten
        {
            // Hier kun je alleen het aantal simkaarten opvragen, maar de waarde niet veranderen omdat de setter niet is gedefinieerd.
            get 
            {

                // Elke keer dat het object wordt geïnitialiseerd, controleren we het aantal simkaarten
                if (simKaart1 != null) aantalSimKaarten++;
                if (simKaart2 != null) aantalSimKaarten++;
                if (simkaart3 != null) aantalSimKaarten++;

                return aantalSimKaarten;
            
            }
        }

    }
}
