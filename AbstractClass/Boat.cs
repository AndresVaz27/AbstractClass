using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractClass
{
    internal class Boat : Vehicle
    {
        public int wheels = 0;
        int maxSpeed = 100;
        public override string Go()
        {
            string message = "The Boat is moving!";
        return message;
        }
        public override string Trick()
        {
            string message = "The Boat is racing a dolphin!";
        return message;
        }
    }
}