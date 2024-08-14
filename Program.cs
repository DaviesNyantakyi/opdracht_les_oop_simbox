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

                        Console.Write($"Geef get telefoonnummer van SIM kaart {simBox.AantalSimKaarten + 1} in: ");
                        inputTelfoon = Console.ReadLine();
                        if (simBox.simKaart1 == null)
                        {
                            simBox.simKaart1 = new SimKaart(telefoonnummer: inputTelfoon, createDatum: DateTime.Now);
                            Console.WriteLine("Druk op een toets om verder te gaan");
                            Console.ReadLine(); 
                        }
                        else if (simBox.simKaart2 == null)
                        {

                            simBox.simKaart2 = new SimKaart(telefoonnummer: inputTelfoon, createDatum: DateTime.Now);
                            Console.WriteLine("Druk op een toets om verder te gaan");
                            Console.ReadLine();
                        }
                        else  
                        {

                            simBox.simkaart3 = new SimKaart(telefoonnummer: inputTelfoon, createDatum: DateTime.Now);
                            Console.WriteLine("Druk op een toets om verder te gaan");
                            Console.ReadLine();
                        }
                        
                        Console.Clear();
                        break;
                    case 2:
                        Console.WriteLine("dit is nummer2");
                        break;
                    case 3:
                        Console.WriteLine("dit is nummer3");
                        break;
                    case 4:
                        Console.WriteLine("dit is nummer4");
                        break;
                }

            } while(userInput != 4);
            





        }

    }
}