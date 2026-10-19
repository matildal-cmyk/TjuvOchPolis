using System;
using System.Threading;
using TjuvOchPolis;

class Program
{
    static void Main()
    {



        List<Personer> list = new List<Personer>();
        
        Polis polis = new Polis("Kling", Random.Shared.Next(1, 25), Random.Shared.Next(1, 98), ConsoleColor.DarkCyan, "smycken");
        Medborgare medborgare = new Medborgare("Fru Larsson", Random.Shared.Next(1, 25), Random.Shared.Next(1, 98), ConsoleColor.DarkYellow, "halsband");
        
        list.Add(polis);
        list.Add(medborgare);
        list.Add(new Tjuv("Karlsson",Random.Shared.Next(1, 25), Random.Shared.Next(1, 98), ConsoleColor.Red, ""));
        list.Add(new Tjuv("Lasse", Random.Shared.Next(1, 25), Random.Shared.Next(1, 98), ConsoleColor.Red, ""));
        list.Add(new Tjuv("Bengt", Random.Shared.Next(1, 25), Random.Shared.Next(1, 98), ConsoleColor.Red, ""));
        list.Add(new Tjuv("Kalle", Random.Shared.Next(1, 25), Random.Shared.Next(1, 98), ConsoleColor.Red, ""));

        
        // startar på random plats
        int x = Random.Shared.Next(0, 100);
        int y = Random.Shared.Next(0, 25);


        // disable muspekarn
        Console.CursorVisible = false;
        Console.Clear();


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


        // staden --------------------------------------------


        while (true)
        {
            // skapar random rörelse som variabel
            Random rand = new Random();

            int oldX = x;
            int oldY = y;

            // går random upp ner höger vänster diagonalt
            x += rand.Next(-1, 2); // går att skriva x += Random.Shared.Next(-1, 2); 
            y += rand.Next(-1, 2); // går att skriva y += Random.Shared.Next(-1, 2); 

            // gå igenom väggen, "teleporteras" till andra sidan
            if (x < 1) x = 96;
            // ai tips om teleportera tillbaka
            else if (x > 96) x = 1;

            // teleport
            if (y < 1) y = 25;
            // ai tips om teleportera tillbaka
            else if (y > 25) y = 1;


            // byter ut gamla X positionen med blank text, kan skriva . eller , för se vart X har gått
            Console.SetCursorPosition(oldX, oldY);
            Console.Write(" ");

            // skriver X som flyttas runt


            //Console.SetCursorPosition(x, y);
            //Console.Write("X");
            Console.SetCursorPosition((Tjuv)Personer).PlatsX, ((Tjuv)Personer).PlatsY);
            Console.Write("X");

            // delay mellan rörelse
            Thread.Sleep(200);


        }
    }
}