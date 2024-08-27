using simBox;
using simkaart;
using System;



namespace program
{

    class Program
    {
        static void Main(string[] args)
        {

            int userInput;
            SimBox simBox = new SimBox();
            

            do {

                string inputTelfoon;
                Console.WriteLine("*** SIMBOX ***");
                Console.WriteLine("1. Simkaart gegevens ingeven");
                Console.WriteLine("2. Overzicht SIM kaart gegevens");
                Console.WriteLine("3. Aantal geinstalleerde SIM kaarten");
                Console.WriteLine("4. Stop");
                Console.Write("> ");
                userInput = int.Parse(Console.ReadLine());

                switch (userInput)
                {
                    case 1:

                        if(simBox.AantalSimKaarten == 3) 
                        {
                            Console.WriteLine("Maximaal aantal SIM kaarten geinstaleerd");
                        } 
                        else
                        {
                            Console.Write($"Geef het telefoonnummer van SIM kaart {simBox.AantalSimKaarten + 1} in: ");
                            inputTelfoon = Console.ReadLine();
                            SimKaart  simKaart = new SimKaart { Telefoonnummer = inputTelfoon };



                            if (simBox.SimKaart1 == null)
                            {
                                simBox.SimKaart1 = simKaart;
                            }
                            else if (simBox.SimKaart2 == null)
                            {
                                simBox.SimKaart2 = simKaart;
                            }
                            else if (simBox.SimKaart3 == null)
                            {
                                simBox.SimKaart3 = simKaart;
                            }
                        }
                       
                        break;
                    case 2:

                        Console.WriteLine("Overzicht geinstalleerde SIM kaarten:");
                        if(simBox.SimKaart1 != null) Console.WriteLine($"Sim kaart 1: {simBox.SimKaart1.Telefoonnummer} / Facuratie datum: {simBox.SimKaart1.CreateDatum.ToString("dd-MMM-yy H:mm:s")}");
                        if (simBox.SimKaart2 != null) Console.WriteLine($"Sim kaart 2: {simBox.SimKaart2.Telefoonnummer} / Facuratie datum: {simBox.SimKaart2.CreateDatum.ToString("dd-MMM-yy H:mm:s")}");
                        if (simBox.SimKaart3 != null) Console.WriteLine($"Sim kaart 3: {simBox.SimKaart3.Telefoonnummer} / Facuratie datum: {simBox.SimKaart3.CreateDatum.ToString("dd-MMM-yy H:mm:s")}");
                      
                        break;
                    case 3:
                        int simslots = 3;
                        Console.WriteLine($"Aantal geinstalleerde SIM kaarten: {simBox.AantalSimKaarten} (nog {simslots - simBox.AantalSimKaarten} slot(s) vrij)");
                      
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("Ongeldig menu optie");
                        break;

                }

               if(userInput != 4)
                {
                    Console.WriteLine("Druk op een toets om verder te gaan");
                    Console.ReadLine();
                    Console.Clear();
                }
            } while (userInput != 4);
            
        }

    }
}