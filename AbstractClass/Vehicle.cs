﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    abstract class Vehicle
    {
        public int speed = 0;
        public abstract string Go();
        public abstract string Trick();
    }
}
