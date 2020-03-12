using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComponentProgrammingAssignment
{
    public class Hero : BaseHero
    {
        private string name;
        private string image;
        public Hero (string _name)
        {
            name = _name;
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