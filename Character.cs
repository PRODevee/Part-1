using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roguelike_POE
{
    internal class Character : Tile
    {
        protected int hp;
        protected int maxHp;
        protected int damage;
        protected string[] direction = 
        {
            "North",
            "South",
            "East",
            "West"
        };
        protected enum movement
        {
            No_movement,
            Up,
            Down,
            Left,
            Right
        }

        public int Hp{
            get{ return hp; }
            set { hp = value; }
        }

        public int MaxHp{
            get{ return maxHp; }
            set { maxHp = value; }
        }

        public int Damage{
            get{ return Damage; }
            set{ damage = value; }
        }

        public Character(int x, int y, string symbol) : base(x, y)
        {
            
        }

        public virtual void Attack(Character target){ target.hp -= damage; }

        public bool IsDead(){ if (hp <= 0) { return true; } else { return false; }}

        public virtual bool CheckRange(Character target)
        {
            if ( DistanceTo(target) == 1 )
            {
                return true;
            }else
            {
                return false;
            }
        }

        private int DistanceTo(Character target)
        {
            int distancex = this.x - target.x;
            int distancey = this.y - target.y;
            
            if (distancex == 1 || distancex == -1){
                return 1;
            } else if (distancey == 1 || distancey == -1){
                return 1;
            }
            return 0;
        }

        public void Move(movement move)
        {
            move = movement.No_movement;
            switch (move)
            {
                case move.up:
                    y += 1;
                    break;
                case move.down:
                    y -= 1;
                    break;
                case move.right:
                    x += 1;
                    break;
                case move.left:
                    x -= 1;
                    break;
            }           
        }

        public abstract movement ReturnMove(movement move = 0)
        {
            switch (direction)
            {
                case direction[1]:
                    return (movement)move + 1;
                    break;
                case direction[2]:
                    return (movement)move + 2;
                    break;
                case direction[3]:
                    return (movement)move + 3;
                    break;
                case direction[4]:
                    return (movement)move + 4;
                    break;
            }
            
        }

        public abstract override string ToString()
        {

        }
    }
