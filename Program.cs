using _10._21.ArrayListTest;
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
        int textradKolumn = 25;


        Console.SetCursorPosition(textradSida, 1);
        Console.WriteLine("---TJUVFEED---");
        Console.SetCursorPosition(105, 14);
        Console.WriteLine("---POLISFEED---");
        Console.SetCursorPosition(105, 28);
        Console.WriteLine("---FÅNGEFEED---");





        // 
        while (true)
        {

            List<Tjuv> arresteradTjuv = new();



            foreach (Personer person in stad)
            {

                //foreach (Tjuv tjuv in stad) 
                //{
                //    foreach (Polis polis in stad)
                //    {
                //        if (tjuv.PlatsX == polis.PlatsX && tjuv.PlatsY == polis.PlatsY)
                //        {
                //            Console.WriteLine("Polis tar tjuv");
                //        }

                //    }


                //}

                //foreach (var tjuv in stad.OfType<Tjuv>())
                //{
                //    foreach (var polis in stad.OfType<Polis>())
                //    {
                //        if (tjuv.PlatsX == polis.PlatsX && tjuv.PlatsY == polis.PlatsY)
                //        {
                //            Console.WriteLine("Polis tar tjuv");
                //        }
                //    }
                //}


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
                                   

                                    //Helper.PrisonTransfer(tjuv, polis, fängelse);
                                }

                                

                            }
                        }
                    }
                }





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


            foreach (var tjuv in arresteradTjuv)
            {
                stad.Remove(tjuv);
            }

            

            int rad = 21;
            foreach (Tjuv fånge in fängelse.prisonPlaces)
            {
                Console.SetCursorPosition(105, rad);
                Console.WriteLine($"Fångar: {fånge.Name}                                        ");
                rad++;
            }




            //stad.Remove(tjuv);
            //break;



            //delay mellan rörelse
            Thread.Sleep(100);

        }

    }
}