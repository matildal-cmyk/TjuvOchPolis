using System;
using System.Collections.Generic;
using System.Text;

namespace TjuvOchPolis
{
        public class Places
        {
            public int Roof { get; set; }
            public int[,] Middle { get; set; }
            public int Floor { get; set; }

            public Places(int roof, int[,] middle, int floor)
            {
                Roof = roof;
                Middle = middle;
                Floor = floor;
            }
            public virtual void Build()

            {
                Console.Write("=CITY");
                for (int i = 0; i < Roof; i++)
                {
                    Console.Write("=");
                }
                Console.WriteLine();

                for (int i = 0; i < Middle.GetLength(0); i++)
                {
                    Console.Write("x");
                    for (int j = 0; j < Middle.GetLength(1); j++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("x");
                    Console.WriteLine();
                }
                Console.Write("=STATUS");
                for (int i = 0; i < Floor; i++)
                {
                    Console.Write("=");
                }
                Console.WriteLine();
            }
        }
        class Fattighus : Places
        {
            public Fattighus(int roof, int[,] middle, int floor) : base(roof, middle, floor)
            {

            }
            public override void Build()
            {
                Console.Write("-FATTIGHUS");
                for (int i = 0; i < Roof; i++)
                {
                    Console.Write("-");
                }
                Console.WriteLine();

                for (int i = 0; i < Middle.GetLength(0); i++)
                {
                    Console.Write("|");
                    for (int j = 0; j < Middle.GetLength(1); j++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("|");
                    Console.WriteLine();
                }

                for (int i = 0; i < Floor; i++)
                {
                    Console.Write("-");
                }
                Console.WriteLine();

            }
        }
        class Prison : Places
        {
            public List<Tjuv> prisonPlaces { get; set; } = new();

            public Prison(int roof, int[,] middle, int floor) : base(roof, middle, floor)
            {

            }


            public override void Build()
            {
                Console.Write("-FÄNGELSE");
                for (int i = 0; i < Roof; i++)
                {
                    Console.Write("-");
                }
                Console.WriteLine();

                for (int i = 0; i < Middle.GetLength(0); i++)
                {
                    Console.Write("|");
                    for (int j = 0; j < Middle.GetLength(1); j++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("|");
                    Console.WriteLine();
                }

                for (int i = 0; i < Floor; i++)
                {
                    Console.Write("-");
                }
                Console.WriteLine();




            }
        }
    }

