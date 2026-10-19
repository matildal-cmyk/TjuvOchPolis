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
        public Tjuv(string name,int platsX, int platsY, string stöldgods) : base (name,platsX,platsY) 
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
        public Polis( string name, int platsX,int platsY,string beslagtaget) : base( name,platsX,platsY)
        {
            Beslagtaget = beslagtaget;
        }

    }
    class Medborgare:Personer
    {
        public string Tillhörigheter { get; set; }
        public Medborgare(string name, int platsX,int platsY, string tillhörigheter) : base(name,platsX,platsY)
        {
            Tillhörigheter = tillhörigheter;
        }
    }
}
