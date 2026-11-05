using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using TjuvOchPolis;

namespace _10._21.ArrayListTest
{
    class Helper
    {

        public static void TjuvSno(Tjuv tjuv, Medborgare medborgare)
        {
            // Kollar medborgare inventory count mer än 0 
            if (medborgare.Inventory.Count > 0)
            {
                // snor random item från (0, inventory count) och ger det string namn
                int snoRandomItem = Random.Shared.Next(medborgare.Inventory.Count);
                string itemAttSno = medborgare.Inventory[snoRandomItem];

                //ta bort det slumpmässiga itemet+ger det till tjuven
                medborgare.Inventory.RemoveAt(snoRandomItem);
                tjuv.Stöldgods.Add(itemAttSno);
                


                //skriver ut
                Console.SetCursorPosition(15, 28);
                Console.Write($"Tjuven {tjuv.Name} rånade {medborgare.Name} på {itemAttSno}.                                          ");
                //Thread.Sleep(2000);
            }



        }


        public static void PolisArrest(Tjuv tjuv, Prison prison, Polis polis)
        {

            //ArrayList fängelseList = new ArrayList();

            string allaItems = "";
            int itemCount = tjuv.Stöldgods.Count;
            int prisonTime = itemCount * 10000;
            

            //stöldgods loop och lägger till det i lista allaItems så det går att skriva ut allt som blir taget.
            if (tjuv.Stöldgods.Count > 0)
            {

               

                for (int i = 0; i < tjuv.Stöldgods.Count; i++)
                {
                    allaItems += tjuv.Stöldgods[i] + ", ";

                }

                //while loop för ta bort item från tjuvlistan -kanske går att ha i samma loop som ovan men vette fan
                while (tjuv.Stöldgods.Count > 0)
                {
                    string namnBeslagtagetItem = tjuv.Stöldgods[0];

                    tjuv.Stöldgods.RemoveAt(0);

                    polis.Beslagtaget.Add(namnBeslagtagetItem);

                }


                tjuv.freedomTime = DateTime.Now.AddMilliseconds(prisonTime);

                prison.prisonPlaces.Add(tjuv);




                
                Console.SetCursorPosition(1,52);
                //Console.WriteLine($"Polisen {polis.Name} arresterade tjuven {tjuv.Name}                                 \n Beslagtaget gods: {allaItems}                                       \n {tjuv.Name} blev arresterad i {prisonTime / 1000} sekunder..                                             ");
                Console.WriteLine($"Polisen {polis.Name} arresterade tjuven {tjuv.Name} och sitter {prisonTime / 1000}s i fängelse.                                  \n Beslagtaget gods: {allaItems}                                                      ");
               // Thread.Sleep(2000);
            }

        }


        public static void MedborgareFattighus(Medborgare medborgare, Fattighus fattighus)
        {
            if (medborgare.Inventory.Count == 0)
            {
                fattighus.fattighusPlaces.Add(medborgare);
            }

        }

        //// fängelse kordinater hörnen
        //Console.SetCursorPosition(1, 28);
        //Console.Write("X");
        //Console.SetCursorPosition(10, 28);
        //Console.Write("Y");
        //Console.SetCursorPosition(10, 37);
        //Console.Write("Z");
        //Console.SetCursorPosition(1, 37);
        //Console.Write("V");



        //Fattighus kordinater hörnen
        //Console.SetCursorPosition(1, 40);
        //Console.Write("Q");
        //Console.SetCursorPosition(1, 49);
        //Console.Write("Z");
        //Console.SetCursorPosition(48, 40);
        //Console.Write("V");
        //Console.SetCursorPosition(48, 40);
        //Console.Write("W");

    }

}
