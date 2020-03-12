using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComponentProgrammingAssignment
{
    public class Boss
    {
        Stats bossStats;
        string image;
        string name;

        public Boss(string bossName)
        {
            name = bossName;
            bossStats = new Stats();
        }
        
        public void SetStats(int attack, int defence, int speed, int health)
        {
            bossStats.Attack = attack;
            bossStats.Defence = defence;
            bossStats.Speed = speed;
            bossStats.Health = health;
        }

        public string GetName()
        {
            return name;
        }

        public void SetImage(string imageLink)
        {
            image = imageLink;
        }

        public string GetImage()
        {
            return image;
        }
    }
}