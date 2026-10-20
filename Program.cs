using System;
using System.Threading;
using TjuvOchPolis;

class Program
{
    static void Main()
    { 
        List<Personer> stad = new List<Personer>();

        //stad.Add(new Polis("Klang", Random.Shared.Next(1, 25), Random.Shared.Next(1, 95), -1,-1, ""));
        //stad.Add(new Polis("Lasse", Random.Shared.Next(1, 25), Random.Shared.Next(1, 98), -1,0, ""));
        //stad.Add(new Polis("Bengt", Random.Shared.Next(1, 25), Random.Shared.Next(1, 98), Random.Shared.Next(1, 9), ""));
        //stad.Add(new Polis("Kling", Random.Shared.Next(1, 25), Random.Shared.Next(1, 98), Rando,m.Shared.Next(1, 9), ""));

        //stad.Add(new Medborgare("Lindström", Random.Shared.Next(1, 25), Random.Shared.Next(1, 98), Random.Shared.Next(1, 9), ""));
        //stad.Add(new Medborgare("Pettersson", Random.Shared.Next(1, 25), Random.Shared.Next(1, 98), Random.Shared.Next(1, 9), ""));
        //stad.Add(new Medborgare("Lundström", Random.Shared.Next(1, 25), Random.Shared.Next(1, 98), Random.Shared.Next(1, 9), ""));
        //stad.Add(new Medborgare("Andersson", Random.Shared.Next(1, 25), Random.Shared.Next(1, 98), Random.Shared.Next(1, 9), ""));


        stad.Add(new Tjuv("Karlsson", Random.Shared.Next(1, 85), Random.Shared.Next(1, 85), -1,-1, ""));
        stad.Add(new Tjuv("Larsson", Random.Shared.Next(1, 85), Random.Shared.Next(1, 85), -1,0, ""));
        stad.Add(new Tjuv("Svansson", Random.Shared.Next(1, 85), Random.Shared.Next(1, 85), +1,+1, ""));
        stad.Add(new Tjuv("Kalle", Random.Shared.Next(1, 85), Random.Shared.Next(1, 85), +1,0, ""));






        //foreach (Personer person in stad)
        //{
        //    Console.WriteLine(person.ShortName);
        //}






        //startar på random plats



        // disable muspekarn
        Console.CursorVisible = false;
        //Console.Clear();
        Console.SetWindowSize(125, 125);
        Console.SetBufferSize(125, 125);


        // staden --------------------------------------------
        Console.Write("=CITY");
        for (int tak = 0; tak <= 95; tak++)
        {
            Console.Write("=");
        }
        Console.WriteLine();

        //Rita upp "staden"
        string[,] city = new string[25, 98];//100-2 för x
        for (int i = 0; i <= city.GetLength(0); i++)
        {
            Console.Write("x");
            for (int j = 0; j <= city.GetLength(1); j++)
            {
                Console.Write(" ");
            }
            Console.Write("x");
            Console.WriteLine();
        }
        Console.Write("=STATUS");
        for (int g = 0; g <= 93; g++)
        {
            Console.Write("=");
        }
        Console.WriteLine();


        //int x = Random.Shared.Next(0, 70);
        //int y = Random.Shared.Next(0, 15);

        // staden --------------------------------------------





        //foreach (Personer person in stad)
        //{
        //    Console.WriteLine("direction stuff: " + person.Directions);
        //}




        while (true)
        {
            foreach (Personer person in stad)

            {
                int oldX = person.PlatsX;
                int oldY = person.PlatsY;
                {
                    if (person is Tjuv)
                    {
                        person.PlatsX += person.DirectionX;
                        person.PlatsY += person.DirectionY;
                    }

                    //// gå igenom väggen, "teleporteras" till andra sidan
                    if (person.PlatsX < 1) person.PlatsX = 96;
                    //// ai tips om teleportera tillbaka
                    else if (person.PlatsX > 96) person.PlatsX = 1;

                    //// teleport
                    if (person.PlatsY < 1) person.PlatsY = 25;
                    //// ai tips om teleportera tillbaka
                    else if (person.PlatsY > 25) person.PlatsY = 1;


                    // byter ut gamla X positionen med blank text, kan skriva . eller , för se vart X har gått
                    Console.SetCursorPosition(oldX, oldY);
                    Console.Write(" ");

                    // skriver X som flyttas runt


                    //Console.SetCursorPosition(x, y);
                    //Console.Write("X");
                    Console.SetCursorPosition(person.PlatsX, person.PlatsY);
                    //Console.Write(person.ShortName);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("T");
                    Console.ResetColor();

                    //delay mellan rörelse
                    Thread.Sleep(100);
                }

            }
        }

    }
}
