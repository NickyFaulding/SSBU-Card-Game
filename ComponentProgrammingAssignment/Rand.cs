using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComponentProgrammingAssignment
{
    static class Rand
    {
        static Random r = new Random();

        public static int Next(int min, int max)
        {
            return r.Next(min, max);
        }

        public static int Next(int max)
        {
            return r.Next(max);
        }
    }
}