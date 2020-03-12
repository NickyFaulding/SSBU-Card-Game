using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComponentProgrammingAssignment
{
    public class Bosses
    {
        List<Boss> bosses = new List<Boss>();

        Boss ghosts;
        Boss andross;
        Boss claptrap;
        Boss ghirahim;
        Boss waluigi;
        Boss rathalos;
        Boss nightmare;//megaboss?

        public Bosses()
        {
            SetBossNames();
            SetBossStats();
            SetBossImages();
            AddBossesToList();
        }

        public void SetBossNames()
        {
            ghosts = new Boss("Ghosts");
            andross = new Boss("Andross");
            claptrap = new Boss("Claptrap");
            ghirahim = new Boss("Ghirahim");
            waluigi = new Boss("Waluigi");
            rathalos = new Boss("Rathalos");
            nightmare = new Boss("Nightmare");
        }

        public void SetBossStats()
        {
            ghosts.SetStats(Rand.Next(10, 20), Rand.Next(10, 20), Rand.Next(10, 20), Rand.Next(150, 300));
            andross.SetStats(Rand.Next(10, 20), Rand.Next(10, 20), Rand.Next(10, 20), Rand.Next(150, 300));
            claptrap.SetStats(Rand.Next(10, 20), Rand.Next(10, 20), Rand.Next(10, 20), Rand.Next(150, 300));
            ghirahim.SetStats(Rand.Next(10, 20), Rand.Next(10, 20), Rand.Next(10, 20), Rand.Next(150, 300));
            waluigi.SetStats(Rand.Next(10, 20), Rand.Next(10, 20), Rand.Next(10, 20), Rand.Next(150, 300));
            rathalos.SetStats(Rand.Next(10, 20), Rand.Next(10, 20), Rand.Next(10, 20), Rand.Next(150, 300));
            nightmare.SetStats(Rand.Next(10, 20), Rand.Next(10, 20), Rand.Next(10, 20), Rand.Next(150, 300));
        }

        public void AddBossesToList()
        {
            bosses.Add(ghosts);
            bosses.Add(andross);
            bosses.Add(claptrap);
            bosses.Add(ghirahim);
            bosses.Add(waluigi);
            bosses.Add(rathalos);
            bosses.Add(nightmare);
        }

        public void SetBossImages()
        {
            ghosts.SetImage("ghosts.png");
            andross.SetImage("andross.png");
            claptrap.SetImage("claptrap.png");
            ghirahim.SetImage("ghirahim.png");
            waluigi.SetImage("waluigi.png");
            rathalos.SetImage("rathalos.png");
            nightmare.SetImage("nightmare.png");
        }

        public Boss DrawRandomBoss()
        {
            int randomBossNum;
            randomBossNum = Rand.Next(bosses.Count);
            Boss randomBoss = bosses[randomBossNum];

            bosses.RemoveAt(randomBossNum);

            return randomBoss;
        }
    }
}