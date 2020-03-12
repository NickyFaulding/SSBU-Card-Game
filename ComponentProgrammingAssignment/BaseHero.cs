using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComponentProgrammingAssignment
{
    public class BaseHero
    {
        private Stats stats; //composition

        public BaseHero()
        {
            stats = new Stats();
        }

        public void SetStats(int attack, int defence, int speed)
        {
            stats.Attack = attack;
            stats.Defence = defence;
            stats.Speed = speed;
        }

        public int GetAttack()
        {
            return stats.Attack;
        }
        public int GetDefence()
        {
            return stats.Defence;
        }
        public int GetSpeed()
        {
            return stats.Speed;
        }
        public int GetHealth()
        {
            return stats.Health;
        }
    }
}