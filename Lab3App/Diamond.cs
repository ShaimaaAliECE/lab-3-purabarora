using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    internal class Diamond : Treasure
    {
        public Diamond(String s, int score) 
        {
            Description = s;
            Board.TotalScore = Board.TotalScore + score;
        }
        public override void Display()
        {
            Console.WriteLine("Diamond" + Description + " is displayed");
        }
    }
}
