using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roguelike_POE
{
    internal abstract class Tile
    {
        protected int x;
        protected int y;
        protected enum tileType
        {
            Hero,
            Enemy,
            Gold,
            Weapon
        }

        public int X
        {
            get{ return x; }
            set{ x = value; }
        }

        public int Y {
            get{ return y; }
            set{ y = value; }
        }
        public Tile(int x, int y)//tiletype still pending how to use
        {
            this.x = x;
            this.y = y;
        }
    }
}
