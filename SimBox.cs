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
      //  private int aantalSimKaarten = 0;
        public SimKaart SimKaart1 { get; set; }
        public SimKaart SimKaart2 { get; set; }
        public SimKaart SimKaart3 { get; set; }


        public int AantalSimKaarten
        {
            // Hier kun je alleen het aantal simkaarten opvragen, maar de waarde niet veranderen omdat de setter niet is gedefinieerd.
            get 
            {

                // Elke keer dat het object wordt geïnitialiseerd, controleren we het aantal simkaarten

                /*   if (SimKaart1 != null)
                   {
                       aantalSimKaarten++;
                   }
                   if  (SimKaart2 != null)
                   {
                       aantalSimKaarten++;
                   }
                   if (SimKaart3 != null)
                   {
                       aantalSimKaarten++;
                   }
                   return aantalSimKaarten;
               */

               
                int aantal = 0;
                if (SimKaart1 != null)
                {
                    aantal++;
                }
                if (SimKaart2 != null)
                {
                    aantal++;
                }
                if (SimKaart3 != null)
                {
                    aantal++;
                }
                return aantal;
            }
        }

    }
}
