using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roguelike_POE
{
    internal class Enemy : Character
    {
        protected Random ran = new Random();

        public Enemy(int x, int y, int damage, int hp, int maxHp)//symbol
        {
            Character character = new Character(this.x, this.Y, "");
            this.damage = damage;
            this.hp = hp;
            this.maxHp = maxHp;
        }


    }
}
