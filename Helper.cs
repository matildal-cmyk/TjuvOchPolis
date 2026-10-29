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
                Console.SetCursorPosition(105, 2);
                Console.Write($"Tjuven {tjuv.Name} rånade {medborgare.Name} på {itemAttSno}.                                          ");
            }



        }


        public static void PolisArrest(Tjuv tjuv, Prison prison, Polis polis)
        {

            //ArrayList fängelseList = new ArrayList();
            



            //stöldgods loop och lägger till det i lista allaItems så det går att skriva ut allt som blir taget.
            if (tjuv.Stöldgods.Count > 0)
            {
                string allaItems = "";

                for (int i = 0; i < tjuv.Stöldgods.Count; i++)
                {
                    allaItems += tjuv.Stöldgods[i] + ", ";
                }

                //while loop för ta bort item från tjuvlistan - kanske går att ha i samma loop som ovan men vette fan
                while (tjuv.Stöldgods.Count > 0)
                {
                    string namnBeslagtagetItem = tjuv.Stöldgods[0];

                    tjuv.Stöldgods.RemoveAt(0);

                    polis.Beslagtaget.Add(namnBeslagtagetItem);
                    
                    
                }

                prison.prisonPlaces.Add(tjuv);


                //string tjuvTagen = "";

                //for(int i = 0; i > 0; i++)
                //{

                //}



                Console.SetCursorPosition(105, 25);
                Console.WriteLine($"Polisen {polis.Name} arresterade {tjuv.Name} och sitter nu i {prison}");




                Console.SetCursorPosition(105, 29);
                Console.WriteLine($"Polisen {polis.Name} beslagtog stöldgods; {allaItems}tjuven {tjuv.Name} blev arresterad.                                           ");
            }

        }


        public static void PrisonTransfer(Tjuv tjuv, Polis polis, Prison prison)
        {
            //stöldgods loop och lägger till det i lista allaItems så det går att skriva ut allt som blir taget.
            if (tjuv.Stöldgods.Count > 0)
            {


                {



                    //for (int i = 0; i < fängelseList.Count; i++)
                    //{
                    //    string arrayItem = string.Format($"Name is {fängelseList[i]}");
                    //    Console.WriteLine(arrayItem);
                    //}


                }
            }



        }

        public static void printFängelselist(Tjuv tjuv, Polis polis, Prison prison)
        {

            //for (int i = 0; i < prisonPlaces.Count; i++)
            //{
            //    string arrayItem = string.Format($"Name is {fängelseList[i]}");
            //    Console.WriteLine(arrayItem);
            //}

        }

    }

}
