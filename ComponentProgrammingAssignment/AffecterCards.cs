using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComponentProgrammingAssignment
{
    public class AffecterCards
    {
        Hero affectedHero;

        public AffecterCards(Hero whichHero)
        {
            affectedHero = whichHero;
        }

        public void RandomAffect()
        {

        }

        public void RED()
        {
            //cause big damage
        }

        public void GREEN()
        {
            //cause healing effect
        }

        public void YELLOW()
        {
            //Fight
        }

        public void BLUE()
        {
            //cause speed boost
        }
    }
}