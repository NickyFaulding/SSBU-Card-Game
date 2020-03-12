using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComponentProgrammingAssignment
{
    public class Stats
    {
        int attack;
        int defence;
        int speed;
        int health = 100;

        public int Attack
        {
            get { return attack; }
            set { attack = value; }
        }
        public int Defence
        {
            get{ return defence; }
            set { defence = value; }
        }
        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }
        public int Health
        {
            get { return health; }
            set { health = value; }
        }

        public void IncreaseAttack(int value)
        {
            attack += value;
        }
        public void DecreaseAttack(int value)
        {
            attack -= value;
        }
        public void IncreaseDefence(int value)
        {
            defence += value;
        }
        public void DecreaseDefence(int value)
        {
            defence -= value;
        }
        public void IncreaseSpeed(int value)
        {
            speed += value;
        }
        public void DecreaseSpeed(int value)
        {
            speed -= value;
        }
    }
}