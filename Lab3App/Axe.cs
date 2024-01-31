﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    internal class Axe : Tool
    {
        public Axe(String a) 
        { 
            Description = a;
        }
        public override void Display()
        {
            Console.WriteLine("Axe " + Description + " is displayed");
        }
        public override void DoAction()
        {
            Console.WriteLine("Axe is Used");
        }
    }
}