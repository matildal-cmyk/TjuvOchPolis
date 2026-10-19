using System;
using System.Threading;
using TjuvOchPolis;

class Program
{
    static void Main()
    {



        //List<Personer> list = new List<Personer>();

        //Polis polis = new Polis("Kling", Random.Shared.Next(1, 25), Random.Shared.Next(1, 98), ConsoleColor.DarkCyan, "smycken");
        //Medborgare medborgare = new Medborgare("Fru Larsson", Random.Shared.Next(1, 25), Random.Shared.Next(1, 98), ConsoleColor.DarkYellow, "halsband");

        //list.Add(polis);
        //list.Add(medborgare);
        //list.Add(new Tjuv("Karlsson", Random.Shared.Next(1, 25), Random.Shared.Next(1, 98), ConsoleColor.Red, ""));
        //list.Add(new Tjuv("Lasse", Random.Shared.Next(1, 25), Random.Shared.Next(1, 98), ConsoleColor.Red, ""));
        //list.Add(new Tjuv("Bengt", Random.Shared.Next(1, 25), Random.Shared.Next(1, 98), ConsoleColor.Red, ""));
        //list.Add(new Tjuv("Kalle", Random.Shared.Next(1, 25), Random.Shared.Next(1, 98), ConsoleColor.Red, ""));



        List<Personer> stad = new List<Personer>();


        Tjuv tjuv1 = new Tjuv( "Karlsson", Random.Shared.Next(1, 98), Random.Shared.Next(1, 98), "");
        Tjuv tjuv2 = new Tjuv( "Larsson", Random.Shared.Next(1, 98), Random.Shared.Next(1, 98),  "");
        Tjuv tjuv3 = new Tjuv("Svansson", Random.Shared.Next(1, 98), Random.Shared.Next(1, 98), "");



        stad.Add(tjuv1);
        stad.Add(tjuv2);
        stad.Add(tjuv3);

        //foreach (Personer person in stad)
        //{
        //    Console.WriteLine(person.Name);
        //}

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


        while (true)
        {



            foreach (Personer person in stad)

            {

                int oldX = person.PlatsX;
                int oldY = person.PlatsY;




                {


                    if (person is Tjuv)

                    person.PlatsX += Random.Shared.Next(-1, 2);
                    person.PlatsY += Random.Shared.Next(-1, 2);


                     




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
