using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComponentProgrammingAssignment
{
    public class Heros
    {
        List<Hero> heros = new List<Hero>();

        Hero samus;
        Hero mario;
        Hero pikachu;
        Hero ganon;
        Hero donkeyKong;
        Hero link;
        Hero yoshi;
        Hero kirby;
        Hero fox;
        Hero jigglypuff;
        Hero toonLink;

        public Heros()
        {
            SetHeroNames();
            SetHeroStats();
            SetHeroImages();
            AddHerosToList();            
        }

        public void SetHeroNames()
        {
            samus = new Hero("Samus");
            mario = new Hero("Mario");
            pikachu = new Hero("Pikachu");
            ganon = new Hero("Ganon");
            donkeyKong = new Hero("Donkey Kong");
            link = new Hero("Link");
            yoshi = new Hero("Yoshi");
            kirby = new Hero("Kirby");
            fox = new Hero("Fox");
            jigglypuff = new Hero("Jigglypuff");
            toonLink = new Hero("Toon Link");
        }

        public void SetHeroStats()
        {
            //Attack//Defence//Speed//
            samus.SetStats(7, 7, 5);
            mario.SetStats(5, 5, 6);
            pikachu.SetStats(8, 4, 8);
            ganon.SetStats(8, 8, 3);
            donkeyKong.SetStats(8, 7, 4);
            link.SetStats(7, 7, 6);
            yoshi.SetStats(5, 8, 7);
            kirby.SetStats(6, 6, 5);
            fox.SetStats(7, 5, 6);
            jigglypuff.SetStats(4, 4, 4);
            toonLink.SetStats(7, 7, 8);
        }

        public void AddHerosToList()
        {
            heros.Add(samus);
            heros.Add(mario);
            heros.Add(pikachu);
            heros.Add(ganon);
            heros.Add(donkeyKong);
            heros.Add(link);
            heros.Add(yoshi);
            heros.Add(kirby);
            heros.Add(fox);
            heros.Add(jigglypuff);
            heros.Add(toonLink);
        }

        public void SetHeroImages()
        {
            samus.SetImage("samus.png");
            mario.SetImage("mario.png");
            pikachu.SetImage("pikachu.png");
            ganon.SetImage("ganon.png");
            donkeyKong.SetImage("donkeykong.png");
            link.SetImage("link.png");
            yoshi.SetImage("yoshi.png");
            kirby.SetImage("kirby.png");
            fox.SetImage("fox.png");
            jigglypuff.SetImage("jigglypuff.png");
            toonLink.SetImage("toonlink.png");
        }

        public Hero DrawRandomHero()
        {
            int randomHeroNum;

            randomHeroNum = Rand.Next(heros.Count);
            Hero randomHero = heros[randomHeroNum];

            heros.RemoveAt(randomHeroNum);

            return randomHero;
        }
    }
}