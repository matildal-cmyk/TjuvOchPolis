using _10._21.ArrayListTest;
using System;
using System.Data;
using System.Globalization;
using System.Threading;
using TjuvOchPolis;

class Program
{
    static void Main()
    {
        // skapar lista med personer -----------------------------------------------------------------------------------------------------------------------------
        List<Personer> stad = new List<Personer>();

        stad.Add(new Polis("Gabriel", Random.Shared.Next(1, 97), Random.Shared.Next(1, 26), Random.Shared.Next(-1, 2), Random.Shared.Next(-1, 2)));
        stad.Add(new Polis("Elliot", Random.Shared.Next(1, 97), Random.Shared.Next(1, 26), Random.Shared.Next(-1, 2), Random.Shared.Next(-1, 2)));
        stad.Add(new Polis("Noel", Random.Shared.Next(1, 97), Random.Shared.Next(1, 26), Random.Shared.Next(-1, 2), Random.Shared.Next(-1, 2)));
        stad.Add(new Polis("Dante", Random.Shared.Next(1, 97), Random.Shared.Next(1, 26), Random.Shared.Next(-1, 2), Random.Shared.Next(-1, 2)));
        stad.Add(new Polis("Julia", Random.Shared.Next(1, 97), Random.Shared.Next(1, 26), Random.Shared.Next(-1, 2), Random.Shared.Next(-1, 2)));
        stad.Add(new Polis("Edith", Random.Shared.Next(1, 97), Random.Shared.Next(1, 26), Random.Shared.Next(-1, 2), Random.Shared.Next(-1, 2)));
        stad.Add(new Polis("Celine", Random.Shared.Next(1, 97), Random.Shared.Next(1, 26), Random.Shared.Next(-1, 2), Random.Shared.Next(-1, 2)));
        stad.Add(new Polis("Ilse", Random.Shared.Next(1, 97), Random.Shared.Next(1, 26), Random.Shared.Next(-1, 2), Random.Shared.Next(-1, 2)));
        stad.Add(new Polis("Nora", Random.Shared.Next(1, 97), Random.Shared.Next(1, 26), Random.Shared.Next(-1, 2), Random.Shared.Next(-1, 2)));
        stad.Add(new Polis("Elton", Random.Shared.Next(1, 97), Random.Shared.Next(1, 26), Random.Shared.Next(-1, 2), Random.Shared.Next(-1, 2)));
        

        //

        stad.Add(new Medborgare("Liam", Random.Shared.Next(1, 97), Random.Shared.Next(1, 26), Random.Shared.Next(-1, 2), Random.Shared.Next(-1, 2)));
        stad.Add(new Medborgare("Hugo", Random.Shared.Next(1, 97), Random.Shared.Next(1, 26), Random.Shared.Next(-1, 2), Random.Shared.Next(-1, 2)));
        stad.Add(new Medborgare("Valter", Random.Shared.Next(1, 97), Random.Shared.Next(1, 26), Random.Shared.Next(-1, 2), Random.Shared.Next(-1, 2)));
        stad.Add(new Medborgare("Vera", Random.Shared.Next(1, 97), Random.Shared.Next(1, 26), Random.Shared.Next(-1, 2), Random.Shared.Next(-1, 2)));
        stad.Add(new Medborgare("Freja", Random.Shared.Next(1, 97), Random.Shared.Next(1, 26), Random.Shared.Next(-1, 2), Random.Shared.Next(-1, 2)));
        stad.Add(new Medborgare("Astrid", Random.Shared.Next(1, 97), Random.Shared.Next(1, 26), Random.Shared.Next(-1, 2), Random.Shared.Next(-1, 2)));
        stad.Add(new Medborgare("Alice", Random.Shared.Next(1, 97), Random.Shared.Next(1, 26), Random.Shared.Next(-1, 2), Random.Shared.Next(-1, 2)));
        stad.Add(new Medborgare("Oliver", Random.Shared.Next(1, 97), Random.Shared.Next(1, 26), Random.Shared.Next(-1, 2), Random.Shared.Next(-1, 2)));
        stad.Add(new Medborgare("William", Random.Shared.Next(1, 97), Random.Shared.Next(1, 26), Random.Shared.Next(-1, 2), Random.Shared.Next(-1, 2)));
        stad.Add(new Medborgare("Alma", Random.Shared.Next(1, 97), Random.Shared.Next(1, 26), Random.Shared.Next(-1, 2), Random.Shared.Next(-1, 2)));
        stad.Add(new Medborgare("Matte", Random.Shared.Next(1, 97), Random.Shared.Next(1, 26), Random.Shared.Next(-1, 2), Random.Shared.Next(-1, 2)));
        stad.Add(new Medborgare("Nellie", Random.Shared.Next(1, 97), Random.Shared.Next(1, 26), Random.Shared.Next(-1, 2), Random.Shared.Next(-1, 2)));
        stad.Add(new Medborgare("Sigge", Random.Shared.Next(1, 97), Random.Shared.Next(1, 26), Random.Shared.Next(-1, 2), Random.Shared.Next(-1, 2)));
        stad.Add(new Medborgare("Josef", Random.Shared.Next(1, 97), Random.Shared.Next(1, 26), Random.Shared.Next(-1, 2), Random.Shared.Next(-1, 2)));
        stad.Add(new Medborgare("Bo", Random.Shared.Next(1, 97), Random.Shared.Next(1, 26), Random.Shared.Next(-1, 2), Random.Shared.Next(-1, 2)));
        stad.Add(new Medborgare("Maria", Random.Shared.Next(1, 97), Random.Shared.Next(1, 26), Random.Shared.Next(-1, 2), Random.Shared.Next(-1, 2)));


        //

        stad.Add(new Tjuv("Ella", Random.Shared.Next(1, 97), Random.Shared.Next(1, 26), Random.Shared.Next(-1, 2), Random.Shared.Next(-1, 2)));
        stad.Add(new Tjuv("Leo", Random.Shared.Next(1, 97), Random.Shared.Next(1, 26), Random.Shared.Next(-1, 2), Random.Shared.Next(-1, 2)));
        stad.Add(new Tjuv("Otto", Random.Shared.Next(1, 97), Random.Shared.Next(1, 26), Random.Shared.Next(-1, 2), Random.Shared.Next(-1, 2)));
        stad.Add(new Tjuv("Ludvig", Random.Shared.Next(1, 97), Random.Shared.Next(1, 26), Random.Shared.Next(-1, 2), Random.Shared.Next(-1, 2)));
        stad.Add(new Tjuv("Frans", Random.Shared.Next(1, 97), Random.Shared.Next(1, 26), Random.Shared.Next(-1, 2), Random.Shared.Next(-1, 2)));
        stad.Add(new Tjuv("Lucas", Random.Shared.Next(1, 97), Random.Shared.Next(1, 26), Random.Shared.Next(-1, 2), Random.Shared.Next(-1, 2)));
        stad.Add(new Tjuv("Selma", Random.Shared.Next(1, 97), Random.Shared.Next(1, 26), Random.Shared.Next(-1, 2), Random.Shared.Next(-1, 2)));
        stad.Add(new Tjuv("Wilma", Random.Shared.Next(1, 97), Random.Shared.Next(1, 26), Random.Shared.Next(-1, 2), Random.Shared.Next(-1, 2)));
        stad.Add(new Tjuv("Agnes", Random.Shared.Next(1, 97), Random.Shared.Next(1, 26), Random.Shared.Next(-1, 2), Random.Shared.Next(-1, 2)));
        stad.Add(new Tjuv("Tage", Random.Shared.Next(1, 97), Random.Shared.Next(1, 26), Random.Shared.Next(-1, 2), Random.Shared.Next(-1, 2)));
        stad.Add(new Tjuv("Björn", Random.Shared.Next(1, 97), Random.Shared.Next(1, 26), Random.Shared.Next(-1, 2), Random.Shared.Next(-1, 2)));
        stad.Add(new Tjuv("Ebba", Random.Shared.Next(1, 97), Random.Shared.Next(1, 26), Random.Shared.Next(-1, 2), Random.Shared.Next(-1, 2)));
        stad.Add(new Tjuv("Clyde", Random.Shared.Next(1, 97), Random.Shared.Next(1, 26), Random.Shared.Next(-1, 2), Random.Shared.Next(-1, 2)));
        stad.Add(new Tjuv("Bonnie", Random.Shared.Next(1, 97), Random.Shared.Next(1, 26), Random.Shared.Next(-1, 2), Random.Shared.Next(-1, 2)));




        // --------------------------------------------------------------------------------------------------------------------------------------------------------



        // intro
        Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("Gör fullscreen och ctrl-scroll down för kontrollera zoom. ");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Tryck [ENTER] för start!");
        Console.ResetColor();
        Console.ReadKey();
        Console.Clear();


        // staden start --------------------------------------------
        Places city = new Places(95, new int[25, 98], 93);
        city.Build();

        Prison fängelse = new Prison(1, new int[10, 10], 10);
        fängelse.Build();


        Fattighus fattighus = new Fattighus(40, new int[10, 48], 50); // för att det ska bli jämnt
        fattighus.Build();



        // disable muspekarn
        Console.CursorVisible = false;
        // Console.Clear();
        
        Console.SetCursorPosition(15, 27);
        Console.WriteLine("---TJUVFEED---");
        Console.SetCursorPosition(1, 51);
        Console.WriteLine("---POLISFEED---");
        Console.SetCursorPosition(105, 1);
        Console.WriteLine("STATUS:");

        bool visaInfo = false;
        int rad4 = 105;
        int rad5 = 20;
        //int rad2 = 61;

        // sätter hastighet på ThreadSleep
        int threadSleepSpeed = 100;

        // start på hela loop
        while (true)
        {
            // temporär lista inom loop
            List<Tjuv> arresteradTjuv = new();
            List<Medborgare> medborgareTillFattighus = new();
            List<Tjuv> frigivnaTjuvar = new();


            // Info lägga till tjuv/polis/medborgare och ändra hastighet, 
            Console.SetCursorPosition(105,8);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Ändra hastighet: Tryck Tangent [1] för +10 ms, [2] för -10 ms       ");
            Console.SetCursorPosition(105, 9);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Hastighet är: {threadSleepSpeed} ms        ");
            Console.ResetColor();
            Console.SetCursorPosition(105, 12);
            Console.Write("Lägg till tjuv: Tryck Tangent ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[T]       ");
            Console.ResetColor();
            Console.SetCursorPosition(105, 13);
            Console.Write("Lägg till polis: Tryck Tangent ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("[P]       ");
            Console.ResetColor();
            Console.SetCursorPosition(105, 14);
            Console.Write("Lägg till medborgare: Tryck Tangent ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("[M]       ");
            Console.ResetColor();
            Console.SetCursorPosition(105, 15);
            Console.WriteLine("Tryck [3] eller [4] för att visa/dölja debuglogg");
           
            //



            // kollar om en key är pressed
            if (Console.KeyAvailable)
            {
                

                ConsoleKeyInfo keyPress = Console.ReadKey(true);

                // om keypress är 1 = +10 ms på threadsleep
                if (keyPress.KeyChar == '1')

                {
                    threadSleepSpeed += 10;

                }
                else if (keyPress.KeyChar == '2' && threadSleepSpeed > 10) // knapp2 blir -10 ms med failsafe
                {
                    threadSleepSpeed -= 10;


                }
                else if (keyPress.KeyChar == 't')
                {
                    // Lägg till tjuv
                    stad.Add(new Tjuv("Ny tjuv", Random.Shared.Next(1, 97), Random.Shared.Next(1, 26), Random.Shared.Next(-1, 2), Random.Shared.Next(-1, 2)));
                    Console.SetCursorPosition(105, 17);
                    Console.WriteLine("Ny tjuv tillagd...                 ");
                    
                }
                else if (keyPress.KeyChar == 'p')
                {
                    // Lägg till polis
                    stad.Add(new Polis("Ny polis", Random.Shared.Next(1, 97), Random.Shared.Next(1, 26), Random.Shared.Next(-1, 2), Random.Shared.Next(-1, 2)));
                    Console.SetCursorPosition(105, 17);
                    Console.WriteLine("Ny polis tillagd...               ");
                    
                }
                else if (keyPress.KeyChar == 'm')
                {
                    // Lägg till medborgare
                    stad.Add(new Medborgare("Ny medborgare", Random.Shared.Next(1, 97), Random.Shared.Next(1, 26), Random.Shared.Next(-1, 2), Random.Shared.Next(-1, 2)));
                    Console.SetCursorPosition(105, 17);
                    Console.WriteLine("Ny medborgare tillagd...            "); 
                    
                }

                // visa debug mode
                else if (keyPress.KeyChar == '3')
                {
                    visaInfo = true;                   
                    
                }
                // gömmer debug
                else if (keyPress.KeyChar == '4')
                {
                    visaInfo = false;
                }


            }






            int rad6 = 20;

            // debug loop
            foreach (Personer person in stad)
            {
                if (rad6 >= 52)
                {
                    break;
                }

                Console.SetCursorPosition(105, rad6);

                if (visaInfo == true)
                {
                    Console.WriteLine(person.GetType().Name + " " + person.Name + ". Rör sig i riktning :" + person.DirectionX + "," + person.DirectionY + ". Koordinater X: " + person.PlatsX + ", och Y: " + person.PlatsY);
                }
                else
                {
                    Console.WriteLine("                                                                                      ");
                }

                rad6++;
            }











            //  kollar tjuv+medborgare koordinater för sno item via helper metod
            foreach (var personTjuv in stad)
            {
                

                if (personTjuv is Tjuv tjuv)
                {
                    
                   

                    foreach (var personMedborgare in stad)
                    {
                        if (personMedborgare is Medborgare medborgare)
                        {

                            if (tjuv.PlatsX == medborgare.PlatsX && tjuv.PlatsY == medborgare.PlatsY)
                            {

                                Helper.TjuvSno(tjuv, medborgare);
                                
                                if (medborgare.Inventory.Count == 0)
                                {
                                    Helper.MedborgareFattighus(medborgare, fattighus);
                                    medborgareTillFattighus.Add(medborgare);
                                }

                            }
                        }
                    }
                   
                }
            }

            // kollar tjuv+polis koordinater för sno item via helper metod
            foreach (var personPolis in stad)
            {
                if (personPolis is Polis polis)
                {
                    foreach (var personTjuv in stad)
                    {
                        if (personTjuv is Tjuv tjuv)
                        {

                            if (polis.PlatsX == tjuv.PlatsX && polis.PlatsY == tjuv.PlatsY)
                            {

                                if (tjuv.Stöldgods.Count > 0)
                                {
                                    Helper.PolisArrest(tjuv, fängelse, polis);
                                    arresteradTjuv.Add(tjuv);
                                }


                            }



                        }
                    }
                }
            }

            








            // riktiga loop
            foreach (Personer person in stad)
            {

                {
                    // recordar nuvarande plats som gammal plats för ta bort/sudda ut med " " tom text.
                    int oldX = person.PlatsX;
                    int oldY = person.PlatsY;
                    {

                        // personer rör sig x+y += baserat på deras random directionX+Y
                        person.PlatsX += person.DirectionX;
                        person.PlatsY += person.DirectionY;


                        // gå igenom väggen, "teleporteras" till andra sidan                    
                        if (person.PlatsX < 1)
                        {
                            person.PlatsX = 96;
                        }
                        else if (person.PlatsX > 96)
                        {
                            person.PlatsX = 1;
                        }

                        if (person.PlatsY < 1)
                        {
                            person.PlatsY = 25;
                        }
                        else if (person.PlatsY > 25)
                        {
                            person.PlatsY = 1;
                        }



                        // byter ut gamla X positionen med blank text, kan skriva . eller , för se vart X har gått
                        Console.SetCursorPosition(oldX, oldY);
                        Console.Write(" ");

                                               

                        // skriver ut bokstav med olika färger per person
                        if (person is Tjuv)

                        {

                            Console.SetCursorPosition(person.PlatsX, person.PlatsY);
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("T");
                            Console.ResetColor();

                        }

                        if (person is Medborgare)

                        {

                            Console.SetCursorPosition(person.PlatsX, person.PlatsY);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("M");
                            Console.ResetColor();

                        }

                        if (person is Polis)

                        {

                            Console.SetCursorPosition(person.PlatsX, person.PlatsY);
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write("P");
                            Console.ResetColor();

                        }


                    }


                }

            }

            // efter loopet och per varje arresteradtjuv = remove tjuv från stad
            foreach (var tjuv in arresteradTjuv)
            {
                stad.Remove(tjuv);
            }



            // loop för hur länge tjuvar ska sitta i fängelset och frigivna tjuvar ska tillbaka till staden

            foreach (Tjuv fånge in fängelse.prisonPlaces)
            {
                if (DateTime.Now >= fånge.freedomTime)
                {
                    stad.Add(fånge);

                    frigivnaTjuvar.Add(fånge);
                }
            }

            // tar bort fånge från prisonPlaces
            foreach (Tjuv fånge in frigivnaTjuvar)
            {
                fängelse.prisonPlaces.Remove(fånge);
            }

            // Utskrift status
            Console.SetCursorPosition(105, 2);
            Console.WriteLine($"{fängelse.prisonPlaces.Count} fångar i fängelset");

            // Fängelseloop för att fångar ska röra sig i fängelset
            foreach (Tjuv fånge in fängelse.prisonPlaces)
            {
                 // recordar nuvarande plats som gammal plats för ta bort/sudda ut med " " tom text.
                int oldX = fånge.PlatsX;
                int oldY = fånge.PlatsY;


                // personer rör sig x+y += baserat på deras random directionX+Y
                int DirectionX = Random.Shared.Next(-1, 2);
                int DirectionY = Random.Shared.Next(-1, 2);

                fånge.DirectionX = DirectionX;
                fånge.DirectionY = DirectionY;

                fånge.PlatsX += fånge.DirectionX;
                fånge.PlatsY += fånge.DirectionY;


                // gå igenom väggen, "teleporteras" till andra sidan                    
                if (fånge.PlatsX < 1)
                {
                    fånge.PlatsX = 10;
                }
                else if (fånge.PlatsX > 10)
                {
                    fånge.PlatsX = 1;
                }

                if (fånge.PlatsY < 28)
                {
                    fånge.PlatsY = 37;
                }
                else if (fånge.PlatsY > 37)
                {
                    fånge.PlatsY = 28;
                }


                // byter ut gamla X positionen med blank text, kan skriva . eller , för se vart X har gått
                Console.SetCursorPosition(oldX, oldY);
                Console.Write(" ");


                // skriver ut bokstav med olika färger per person
                if (fånge is Tjuv)

                {

                    Console.SetCursorPosition(fånge.PlatsX, fånge.PlatsY);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("T");
                    Console.ResetColor();

                }

            }
            // Utskrift status
            int polisCount = stad.OfType<Polis>().Count();
            Console.SetCursorPosition(105, 4);
            Console.WriteLine($"I staden är det {polisCount} antal poliser      ");
            
            int tjuvCount = stad.OfType<Tjuv>().Count();
            Console.SetCursorPosition(105, 5);
            Console.WriteLine($"I staden är det {tjuvCount} antal tjuvar      ");

            int medborgarCount = stad.OfType<Medborgare>().Count();
            Console.SetCursorPosition(105,6);
            Console.WriteLine($"I staden är det {medborgarCount} antal medborgare     ");

            foreach (var medborgare in medborgareTillFattighus)
            {
                stad.Remove(medborgare);
            }

            // int rad3 = 61;

            // Utskrift status
            Console.SetCursorPosition(105, 3);
            Console.WriteLine($"{fattighus.fattighusPlaces.Count} medborgare i fattighuset");


            foreach (Medborgare fattigmedborgare in fattighus.fattighusPlaces)
            {
                // recordar nuvarande plats som gammal plats för ta bort/sudda ut med " " tom text.
                int oldX = fattigmedborgare.PlatsX;
                int oldY = fattigmedborgare.PlatsY;


                // personer rör sig x+y += baserat på deras random directionX+Y
                int DirectionX = Random.Shared.Next(-1, 2);
                int DirectionY = Random.Shared.Next(-1, 2);

                fattigmedborgare.DirectionX = DirectionX;
                fattigmedborgare.DirectionY = DirectionY;

                fattigmedborgare.PlatsX += fattigmedborgare.DirectionX;
                fattigmedborgare.PlatsY += fattigmedborgare.DirectionY;


                // gå igenom väggen, "teleporteras" till andra sidan                    
                if (fattigmedborgare.PlatsX < 1)
                {
                    fattigmedborgare.PlatsX = 48;
                }
                else if (fattigmedborgare.PlatsX > 48)
                {
                    fattigmedborgare.PlatsX = 1;
                }

                if (fattigmedborgare.PlatsY < 40)
                {
                    fattigmedborgare.PlatsY = 49;
                }
                else if (fattigmedborgare.PlatsY > 49)
                {
                    fattigmedborgare.PlatsY = 40;
                }

                // byter ut gamla X positionen med blank text, kan skriva . eller , för se vart X har gått
                Console.SetCursorPosition(oldX, oldY);
                Console.Write(" ");


                // skriver ut bokstav med olika färger per person
                if (fattigmedborgare is Medborgare)

                {

                    Console.SetCursorPosition(fattigmedborgare.PlatsX, fattigmedborgare.PlatsY);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("M");
                    Console.ResetColor();

                }

                

            }
            Thread.Sleep(threadSleepSpeed);
        }
    }
}



