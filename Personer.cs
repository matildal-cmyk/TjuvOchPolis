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

        
        public Personer( string name,int platsX,int platsY)
        {
            Name = name;
            PlatsX = platsX;
            PlatsY = platsY;
            
            
        }
        public virtual void Move()
        {

        }

    }
    class Tjuv : Personer
    {
        public string Stöldgods { get; set; }
        public Tjuv(string shortName, string name,int platsX, int platsY, ConsoleColor foregroundColor,string stöldgods) : base (shortName, name,platsX,platsY,foregroundColor) 
        {
            Stöldgods = stöldgods;
        }
        public override void Move()
        {
        }
    }
    class Polis:Personer
    {
        public string Beslagtaget { get; set; }
        public Polis(string shortName, string name, int platsX,int platsY, ConsoleColor foregroundColor,string beslagtaget) : base(shortName, name,platsX,platsY,foregroundColor)
        {
            Beslagtaget = beslagtaget;
        }

    }
    class Medborgare:Personer
    {
        public string Tillhörigheter { get; set; }
        public Medborgare(string shortName, string name, int platsX,int platsY, ConsoleColor foregroundColor,string tillhörigheter) : base(shortName, name,platsX,platsY,foregroundColor)
        {
            Tillhörigheter = tillhörigheter;
        }
    }
}
