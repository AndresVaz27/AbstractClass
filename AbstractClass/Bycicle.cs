using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    internal class Bycicle :Vehicle
    {
        public int wheels = 2;
        int maxSpeed = 50;
        public override string Go()
        {
            string message = "The bycicle is moving!";
            return message;
        }
        public override string Trick()
        {
            string message = "The bycicle is making a wheelie!";
            return message;
        }
    }
}
