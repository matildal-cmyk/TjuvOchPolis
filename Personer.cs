using System;
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


        public Personer( string name,int platsX,int platsY, int directionX, int directionY)
        {
            Name = name;
            PlatsX = platsX;
            PlatsY = platsY;
            DirectionX = directionX;
            DirectionY = directionY;


        }
        public virtual void Krasch()
        {

        }

    }
    class Tjuv : Personer
    {
        //public string Stöldgods { get; set; }
        public List <string> Items { get; set; } = new List <string>();
        public Tjuv(string name,int platsX, int platsY, int directionX, int directionY, List <string> stöldgods) : base (name,platsX,platsY, directionX, directionY) 
        {
            Items = stöldgods;
        }
        //public override void Krasch()
        //{
        //    if ((Tjuv)Personer).PlatsX == Polis.PlatsX && Tjuv.PlatsY == Polis.PlatsY)
                   
        //    {

        //    }
        //}
    }
    class Polis:Personer
    {
        //public string Beslagtaget { get; set; }
        public List<string> Items { get; set; } = new List<string>();
        public Polis( string name, int platsX,int platsY,int directionX,int directionY, List<string> beslagtaget) : base( name,platsX,platsY, directionX, directionY)
        {
            Items = beslagtaget;
        }

    }
    class Medborgare:Personer
    {
        //public string Tillhörigheter { get; set; }
        public List<string> Items { get; set; } = new List<string>();
        public Medborgare(string name, int platsX,int platsY, int directionX, int directionY, List<string> tillhörigheter) : base(name,platsX,platsY,directionX, directionY)
        {
            Items = tillhörigheter;
        }
    }
}
