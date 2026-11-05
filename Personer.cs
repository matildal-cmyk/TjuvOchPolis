using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace TjuvOchPolis
{
    internal class Personer
    {
        public string Name { get; set; }
        public int PlatsX { get; set; }
        public int PlatsY { get; set; }
        public int DirectionX { get; set; }
        public int DirectionY { get; set; }


        public Personer(string name, int platsX, int platsY, int directionX, int directionY)
        {
            Name = name;
            PlatsX = platsX;
            PlatsY = platsY;
            DirectionX = directionX;
            DirectionY = directionY;


        }
        

    }
    class Tjuv : Personer
    {
        // lista för tjuvens stöldgods+DateTime för kunna ge hur lång fängelsestraff per item stulet
        public DateTime freedomTime { get; set; }
        public List<string> Stöldgods { get; set; } = new();
        public Tjuv(string name, int platsX, int platsY, int directionX, int directionY) : base(name, platsX, platsY, directionX, directionY)
        {

        }
        
    }
    class Polis : Personer
    {
        // lista för polisens beslagtagna items
        public List<string> Beslagtaget { get; set; } = new();
        public Polis(string name, int platsX, int platsY, int directionX, int directionY) : base(name, platsX, platsY, directionX, directionY)
        {

        }

    }
    class Medborgare : Personer
    {
        // lista med items som skapas med varje ny medborgare
        public List<string> Inventory { get; set; } = new();
        public Medborgare(string name, int platsX, int platsY, int directionX, int directionY) : base(name, platsX, platsY, directionX, directionY)
        {
            Inventory.Add("nycklar");
            Inventory.Add("en mobiltelefon");
            Inventory.Add("kontanter");
            Inventory.Add("en klocka");
        }

       


    }
}

