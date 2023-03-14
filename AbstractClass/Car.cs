using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    internal class Car : Vehicle
    {
        public int wheels = 4;
        int maxSpeed = 300;
        public override string Go()
        {
            string message = "The car is moving!";
            return message;        
        }
        public override string Trick()
        {
            string message = "The car is revving the engine and sounds amazing!";
            return message;
        }
    }
}
