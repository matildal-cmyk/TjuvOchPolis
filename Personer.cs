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
        public virtual void Move()
        {
           

        }

    }
    class Tjuv : Personer
    {

        public List<string> Stöldgods { get; set; } = new();
        public Tjuv(string name, int platsX, int platsY, int directionX, int directionY) : base(name, platsX, platsY, directionX, directionY)
        {

        }
        public override void Move()
        {
            

        }
    }
    class Polis : Personer
    {
        public List<string> Beslagtaget { get; set; } = new();
        public Polis(string name, int platsX, int platsY, int directionX, int directionY) : base(name, platsX, platsY, directionX, directionY)
        {

        }

    }
    class Medborgare : Personer
    {
        public List<string> Inventory { get; set; } = new();
        public Medborgare(string name, int platsX, int platsY, int directionX, int directionY) : base(name, platsX, platsY, directionX, directionY)
        {
            Inventory.Add("nycklar");
            Inventory.Add("en mobiltelefon");
            Inventory.Add("kontanter");
            Inventory.Add("en klocka");
        }

        public override void Move()
        {

        }


    }
}

