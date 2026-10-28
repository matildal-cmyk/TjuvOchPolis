using System;
using System.Collections.Generic;
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
                Console.SetCursorPosition(105, 2);
                Console.Write($"Tjuven {tjuv.Name} rånade {medborgare.Name} på {itemAttSno}.                                          ");
            }



        }


        public static void PolisArrest(Tjuv tjuv, Polis polis)
        {
            //stöldgods loop och lägger till det i lista allaItems så det går att skriva ut allt som blir taget.
            if (tjuv.Stöldgods.Count > 0)
            {
                string allaItems = "";

                for(int i = 0; i < tjuv.Stöldgods.Count; i++)
                {
                    allaItems += tjuv.Stöldgods[i] + ", ";
                }

                //while loop för ta bort item från tjuvlistan - kanske går att ha i samma loop som ovan men vette fan
                while(tjuv.Stöldgods.Count > 0)
                {
                    string namnBeslagtagetItem = tjuv.Stöldgods[0];

                    tjuv.Stöldgods.RemoveAt(0);

                    polis.Beslagtaget.Add(namnBeslagtagetItem);
                }
 



                Console.SetCursorPosition(105, 15);
                Console.WriteLine($"Polisen {polis.Name} beslagtog stöldgods; {allaItems}tjuven {tjuv.Name} blev arresterad.                                           ");
            }



        }

    }
}
