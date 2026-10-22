using System;
using System.Threading;
using TjuvOchPolis;

class Program
{
    static void Main()
    { 
        // skapar lista med personer -----------------------------------------------------------------------------------------------------------------------------
        List<Personer> stad = new List<Personer>();

        stad.Add(new Polis("Klang", Random.Shared.Next(1, 97), Random.Shared.Next(1, 26), Random.Shared.Next(-1, 2), Random.Shared.Next(-1, 2), ""));
        stad.Add(new Polis("Lasse", Random.Shared.Next(1, 97), Random.Shared.Next(1, 26), Random.Shared.Next(-1, 2), Random.Shared.Next(-1, 2), ""));
        stad.Add(new Polis("Bengt", Random.Shared.Next(1, 97), Random.Shared.Next(1, 26), Random.Shared.Next(-1, 2), Random.Shared.Next(-1, 2), ""));
        stad.Add(new Polis("Kling", Random.Shared.Next(1, 97), Random.Shared.Next(1, 26), Random.Shared.Next(-1, 2), Random.Shared.Next(-1, 2), ""));

        stad.Add(new Medborgare("Lindström", Random.Shared.Next(1, 97), Random.Shared.Next(1, 26), Random.Shared.Next(-1, 2), Random.Shared.Next(-1, 2), ""));
        stad.Add(new Medborgare("Pettersson", Random.Shared.Next(1, 97), Random.Shared.Next(1, 26), Random.Shared.Next(-1, 2), Random.Shared.Next(-1, 2), ""));
        stad.Add(new Medborgare("Lundström", Random.Shared.Next(1, 97), Random.Shared.Next(1, 26), Random.Shared.Next(-1, 2), Random.Shared.Next(-1, 2), ""));
        stad.Add(new Medborgare("Andersson", Random.Shared.Next(1, 97), Random.Shared.Next(1, 26), Random.Shared.Next(-1, 2), Random.Shared.Next(-1, 2), ""));


        stad.Add(new Tjuv("Karlsson", Random.Shared.Next(1, 97), Random.Shared.Next(1, 26), Random.Shared.Next(-1, 2), Random.Shared.Next(-1, 2), ""));
        stad.Add(new Tjuv("Larsson", Random.Shared.Next(1, 97), Random.Shared.Next(1, 26), Random.Shared.Next(-1, 2), Random.Shared.Next(-1, 2), ""));
        stad.Add(new Tjuv("Svansson", Random.Shared.Next(1, 97), Random.Shared.Next(1, 26), Random.Shared.Next(-1, 2), Random.Shared.Next(-1, 2), ""));
        stad.Add(new Tjuv("Kalle", Random.Shared.Next(1, 97), Random.Shared.Next(1, 26), Random.Shared.Next(-1, 2), Random.Shared.Next(-1, 2), ""));



        // --------------------------------------------------------------------------------------------------------------------------------------------------------


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


        // rörelse+print loop
        while (true)
        {
            foreach (Personer person in stad)

            {
                //recordar nuvarande plats som gammal plats för ta bort/sudda ut med " " tom text [rad 125].
                int oldX = person.PlatsX;
                int oldY = person.PlatsY;
                {
                    
                    //personer rör sig x+y baserat på deras random directionX+Y
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


                    //delay mellan rörelse
                    Thread.Sleep(75);
                }

            }
        }

    }
}
