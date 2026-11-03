using _10._21.ArrayListTest;
using System;
using System.Data;
using System.Threading;
using TjuvOchPolis;

class Program
{
    static void Main()
    {
        // skapar lista med personer -----------------------------------------------------------------------------------------------------------------------------
        List<Personer> stad = new List<Personer>();

        stad.Add(new Polis("Klang2", Random.Shared.Next(1, 97), Random.Shared.Next(1, 26), Random.Shared.Next(-1, 2), Random.Shared.Next(-1, 2)));
        stad.Add(new Polis("Lasse2", Random.Shared.Next(1, 97), Random.Shared.Next(1, 26), Random.Shared.Next(-1, 2), Random.Shared.Next(-1, 2)));
        stad.Add(new Polis("Bengt2", Random.Shared.Next(1, 97), Random.Shared.Next(1, 26), Random.Shared.Next(-1, 2), Random.Shared.Next(-1, 2)));
        stad.Add(new Polis("Kling2", Random.Shared.Next(1, 97), Random.Shared.Next(1, 26), Random.Shared.Next(-1, 2), Random.Shared.Next(-1, 2)));
        stad.Add(new Polis("Klang2", Random.Shared.Next(1, 97), Random.Shared.Next(1, 26), Random.Shared.Next(-1, 2), Random.Shared.Next(-1, 2)));
        stad.Add(new Polis("Lasse2", Random.Shared.Next(1, 97), Random.Shared.Next(1, 26), Random.Shared.Next(-1, 2), Random.Shared.Next(-1, 2)));
        stad.Add(new Polis("Bengt2", Random.Shared.Next(1, 97), Random.Shared.Next(1, 26), Random.Shared.Next(-1, 2), Random.Shared.Next(-1, 2)));
        stad.Add(new Polis("Kling2", Random.Shared.Next(1, 97), Random.Shared.Next(1, 26), Random.Shared.Next(-1, 2), Random.Shared.Next(-1, 2)));
        stad.Add(new Polis("Lasse2", Random.Shared.Next(1, 97), Random.Shared.Next(1, 26), Random.Shared.Next(-1, 2), Random.Shared.Next(-1, 2)));
        stad.Add(new Polis("Bengt2", Random.Shared.Next(1, 97), Random.Shared.Next(1, 26), Random.Shared.Next(-1, 2), Random.Shared.Next(-1, 2)));
        stad.Add(new Polis("Kling2", Random.Shared.Next(1, 97), Random.Shared.Next(1, 26), Random.Shared.Next(-1, 2), Random.Shared.Next(-1, 2)));

        //

        stad.Add(new Medborgare("Lindström", Random.Shared.Next(1, 97), Random.Shared.Next(1, 26), Random.Shared.Next(-1, 2), Random.Shared.Next(-1, 2)));
        stad.Add(new Medborgare("Pettersson", Random.Shared.Next(1, 97), Random.Shared.Next(1, 26), Random.Shared.Next(-1, 2), Random.Shared.Next(-1, 2)));
        stad.Add(new Medborgare("Lundström", Random.Shared.Next(1, 97), Random.Shared.Next(1, 26), Random.Shared.Next(-1, 2), Random.Shared.Next(-1, 2)));
        stad.Add(new Medborgare("Andersson", Random.Shared.Next(1, 97), Random.Shared.Next(1, 26), Random.Shared.Next(-1, 2), Random.Shared.Next(-1, 2)));
        stad.Add(new Medborgare("Lindström2", Random.Shared.Next(1, 97), Random.Shared.Next(1, 26), Random.Shared.Next(-1, 2), Random.Shared.Next(-1, 2)));
        stad.Add(new Medborgare("Pettersson2", Random.Shared.Next(1, 97), Random.Shared.Next(1, 26), Random.Shared.Next(-1, 2), Random.Shared.Next(-1, 2)));
        stad.Add(new Medborgare("Lundström2", Random.Shared.Next(1, 97), Random.Shared.Next(1, 26), Random.Shared.Next(-1, 2), Random.Shared.Next(-1, 2)));
        stad.Add(new Medborgare("Andersson2", Random.Shared.Next(1, 97), Random.Shared.Next(1, 26), Random.Shared.Next(-1, 2), Random.Shared.Next(-1, 2)));
        stad.Add(new Medborgare("Pettersson2", Random.Shared.Next(1, 97), Random.Shared.Next(1, 26), Random.Shared.Next(-1, 2), Random.Shared.Next(-1, 2)));
        stad.Add(new Medborgare("Lundström2", Random.Shared.Next(1, 97), Random.Shared.Next(1, 26), Random.Shared.Next(-1, 2), Random.Shared.Next(-1, 2)));
        stad.Add(new Medborgare("Andersson2", Random.Shared.Next(1, 97), Random.Shared.Next(1, 26), Random.Shared.Next(-1, 2), Random.Shared.Next(-1, 2)));

        //

        stad.Add(new Tjuv("Karlsson", Random.Shared.Next(1, 97), Random.Shared.Next(1, 26), Random.Shared.Next(-1, 2), Random.Shared.Next(-1, 2)));
        //stad.Add(new Tjuv("Larsson", Random.Shared.Next(1, 97), Random.Shared.Next(1, 26), Random.Shared.Next(-1, 2), Random.Shared.Next(-1, 2)));
        //stad.Add(new Tjuv("Svansson", Random.Shared.Next(1, 97), Random.Shared.Next(1, 26), Random.Shared.Next(-1, 2), Random.Shared.Next(-1, 2)));
        //stad.Add(new Tjuv("Kalle", Random.Shared.Next(1, 97), Random.Shared.Next(1, 26), Random.Shared.Next(-1, 2), Random.Shared.Next(-1, 2)));
        //stad.Add(new Tjuv("Karlsson2", Random.Shared.Next(1, 97), Random.Shared.Next(1, 26), Random.Shared.Next(-1, 2), Random.Shared.Next(-1, 2)));
        //stad.Add(new Tjuv("Larsson2", Random.Shared.Next(1, 97), Random.Shared.Next(1, 26), Random.Shared.Next(-1, 2), Random.Shared.Next(-1, 2)));
        //stad.Add(new Tjuv("Svansson2", Random.Shared.Next(1, 97), Random.Shared.Next(1, 26), Random.Shared.Next(-1, 2), Random.Shared.Next(-1, 2)));
        //stad.Add(new Tjuv("Kalle2", Random.Shared.Next(1, 97), Random.Shared.Next(1, 26), Random.Shared.Next(-1, 2), Random.Shared.Next(-1, 2)));
        //stad.Add(new Tjuv("Karlsson2", Random.Shared.Next(1, 97), Random.Shared.Next(1, 26), Random.Shared.Next(-1, 2), Random.Shared.Next(-1, 2)));
        //stad.Add(new Tjuv("Larsson2", Random.Shared.Next(1, 97), Random.Shared.Next(1, 26), Random.Shared.Next(-1, 2), Random.Shared.Next(-1, 2)));
        //stad.Add(new Tjuv("Svansson2", Random.Shared.Next(1, 97), Random.Shared.Next(1, 26), Random.Shared.Next(-1, 2), Random.Shared.Next(-1, 2)));
        //stad.Add(new Tjuv("Kalle2", Random.Shared.Next(1, 97), Random.Shared.Next(1, 26), Random.Shared.Next(-1, 2), Random.Shared.Next(-1, 2)));



        // --------------------------------------------------------------------------------------------------------------------------------------------------------



        // intro

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


        Fattighus fattighus = new Fattighus(40, new int[10, 48], 50); //för att det ska bli jämnt
        fattighus.Build();



        // disable muspekarn
        Console.CursorVisible = false;
        //Console.Clear();

        int textradSida = 105;
        //int textradKolumn = 25;

        int rad2 = 61;

        Console.SetCursorPosition(textradSida, 1);
        Console.WriteLine("---TJUVFEED---");
        Console.SetCursorPosition(105, 14);
        Console.WriteLine("---POLISFEED---");
        Console.SetCursorPosition(105, 40);
        Console.WriteLine("---FÅNGEFEED---");
        Console.SetCursorPosition(105, 60);
        Console.WriteLine("---FATTIGHUS---");


        // sätter hastighet på ThreadSleep
        int threadSleepSpeed = 100;

        // 
        while (true)
        {
            //temporär lista för tjuvar som används för ta bort tjuv från stad lista senare
            List<Tjuv> arresteradTjuv = new();
            List<Medborgare> medborgareTillFattighus = new();

            // Hastighet för Threadsleep
            Console.SetCursorPosition(200, 1);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Ändra hastighet: Tryck Tangent [1] för +10 ms, [2] för -10 ms       ");
            Console.SetCursorPosition(200, 2);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Hastighet är: {threadSleepSpeed} ms        ");
            Console.ResetColor();
            Console.SetCursorPosition(200, 3);
            //Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Lägg till tjuv: Tryck Tangent ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[T]       ");
            Console.ResetColor();
            Console.SetCursorPosition(200, 4);
            Console.Write("Lägg till polis: Tryck Tangent ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("[P]       ");
            Console.ResetColor();
            Console.SetCursorPosition(200, 5);
            Console.Write("Lägg till medborgare: Tryck Tangent ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("[M]       ");
            Console.ResetColor();

            //

            // kollar om en key är pressed
            if (Console.KeyAvailable)
            {

                ConsoleKeyInfo keyPress = Console.ReadKey(true);

                //om keypress är 1 = +10 ms på threadsleep
                if (keyPress.KeyChar == '1')

                {
                    threadSleepSpeed += 10;

                }
                else if (keyPress.KeyChar == '2' && threadSleepSpeed > 10) // knapp2 blir -10 ms med failsafe(crashar vid threadsleep 0 och under)
                {
                    threadSleepSpeed -= 10;


                }
                else if (keyPress.KeyChar == 't')
                {
                    // Lägg till tjuv
                    stad.Add(new Tjuv("Ny tjuv", Random.Shared.Next(1, 97), Random.Shared.Next(1, 26), Random.Shared.Next(-1, 2), Random.Shared.Next(-1, 2)));
                }
                else if (keyPress.KeyChar == 'p')
                {
                    // Lägg till polis
                    stad.Add(new Polis("Ny polis", Random.Shared.Next(1, 97), Random.Shared.Next(1, 26), Random.Shared.Next(-1, 2), Random.Shared.Next(-1, 2)));
                }
                else if (keyPress.KeyChar == 'm')
                {
                    // Lägg till medborgare
                    stad.Add(new Medborgare("Ny medborgare", Random.Shared.Next(1, 97), Random.Shared.Next(1, 26), Random.Shared.Next(-1, 2), Random.Shared.Next(-1, 2)));
                }
            }

            //Console.WriteLine($"Speed is: {threadSleepSpeed} ms");

            //loop för kolla x+y position sno/arrestera
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
                                Helper.PolisArrest(tjuv, fängelse, polis);
                                arresteradTjuv.Add(tjuv);
                            }



                        }
                    }
                }
            }







            foreach (Personer person in stad)
            {






                {
                    //recordar nuvarande plats som gammal plats för ta bort/sudda ut med " " tom text.
                    int oldX = person.PlatsX;
                    int oldY = person.PlatsY;
                    {

                        //personer rör sig x+y += baserat på deras random directionX+Y
                        person.PlatsX += person.DirectionX;
                        person.PlatsY += person.DirectionY;


                        //// gå igenom väggen, "teleporteras" till andra sidan                    
                        if (person.PlatsX < 1) person.PlatsX = 96;
                        else if (person.PlatsX > 96) person.PlatsX = 1;
                        if (person.PlatsY < 1) person.PlatsY = 25;
                        else if (person.PlatsY > 25) person.PlatsY = 1;



                        // byter ut gamla X positionen med blank text, kan skriva . eller , för se vart X har gått
                        Console.SetCursorPosition(oldX, oldY);
                        Console.Write(" ");


                        //// fängelse kordinater hörnen
                        //Console.SetCursorPosition(1, 28);
                        //Console.Write("X");
                        //Console.SetCursorPosition(10, 28);
                        //Console.Write("Y");
                        //Console.SetCursorPosition(10, 37);
                        //Console.Write("Z");
                        //Console.SetCursorPosition(1, 37);
                        //Console.Write("V");





                        //skriver ut bokstav med olika färger per person
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


            // skriver ut vilka fångar är i fängelset 
            int rad = 41;
            foreach (Tjuv fånge in fängelse.prisonPlaces)
            {
                Console.SetCursorPosition(105, rad);
                Console.WriteLine($"{fånge.Name}                                        ");
                rad++;









                //recordar nuvarande plats som gammal plats för ta bort/sudda ut med " " tom text.
                int oldX = fånge.PlatsX;
                int oldY = fånge.PlatsY;


                //personer rör sig x+y += baserat på deras random directionX+Y
                int DirectionX = Random.Shared.Next(-1, 2);
                int DirectionY = Random.Shared.Next(-1, 2);

                fånge.DirectionX = DirectionX;
                fånge.DirectionY = DirectionY;

                fånge.PlatsX += fånge.DirectionX;
                fånge.PlatsY += fånge.DirectionY;


                //// gå igenom väggen, "teleporteras" till andra sidan                    
                if (fånge.PlatsX < 1) fånge.PlatsX = 10;
                else if (fånge.PlatsX > 10) fånge.PlatsX = 1;

                if (fånge.PlatsY < 28) fånge.PlatsY = 37;
                else if (fånge.PlatsY > 37) fånge.PlatsY = 28;



                // byter ut gamla X positionen med blank text, kan skriva . eller , för se vart X har gått
                Console.SetCursorPosition(oldX, oldY);
                Console.Write(" ");


                // fängelse kordinater hörnen
                Console.SetCursorPosition(1, 28);
                Console.Write("X");
                Console.SetCursorPosition(10, 28);
                Console.Write("Y");
                Console.SetCursorPosition(10, 37);
                Console.Write("Z");
                Console.SetCursorPosition(1, 37);
                Console.Write("V");



                //skriver ut bokstav med olika färger per person
                if (fånge is Tjuv)

                {

                    Console.SetCursorPosition(fånge.PlatsX, fånge.PlatsY);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("T");
                    Console.ResetColor();

                }

                //stad.Remove(tjuv);
                //break;







            }




            foreach (var medborgare in medborgareTillFattighus)
            {
                stad.Remove(medborgare);
            }

            int rad3 = 61;

            foreach (Medborgare fattigmedborgare in fattighus.fattighusPlaces)
            {
                Console.SetCursorPosition(105, rad3);
                Console.WriteLine($"{fattigmedborgare.Name}                                        ");
                rad3++;

                //recordar nuvarande plats som gammal plats för ta bort/sudda ut med " " tom text.
                int oldX = fattigmedborgare.PlatsX;
                int oldY = fattigmedborgare.PlatsY;


                //personer rör sig x+y += baserat på deras random directionX+Y
                int DirectionX = Random.Shared.Next(-1, 2);
                int DirectionY = Random.Shared.Next(-1, 2);

                fattigmedborgare.DirectionX = DirectionX;
                fattigmedborgare.DirectionY = DirectionY;

                fattigmedborgare.PlatsX += fattigmedborgare.DirectionX;
                fattigmedborgare.PlatsY += fattigmedborgare.DirectionY;


                Console.SetCursorPosition(1, 40);
                Console.Write("Q");
                Console.SetCursorPosition(1, 49);
                Console.Write("Z");
                Console.SetCursorPosition(48, 40);
                Console.Write("V");
                Console.SetCursorPosition(48, 40);
                Console.Write("W");


                //// gå igenom väggen, "teleporteras" till andra sidan                    
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





                //skriver ut bokstav med olika färger per person
                if (fattigmedborgare is Medborgare)

                {

                    Console.SetCursorPosition(fattigmedborgare.PlatsX, fattigmedborgare.PlatsY);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("M");
                    Console.ResetColor();



                    //stad.Remove(tjuv);
                    //break;




                    //}





                }

                //delay mellan rörelse

                //Helper.MedborgareFattighus(medborgare, fattighus);


                //foreach(var )
                //Console.SetCursorPosition(105, rad2);
                //Console.WriteLine($"{medborgare.Name}                                        ");
                //rad2++;











            }
            Thread.Sleep(threadSleepSpeed);
        }
    }
}



