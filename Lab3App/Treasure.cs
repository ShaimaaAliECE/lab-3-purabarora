using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    internal class Treasure : Collectable
    {
        public int Score { get; set; }

        public virtual void UpdateTotalScore(int s)
        {
            Board.TotalScore = Board.TotalScore + s;
            Console.WriteLine("Total Score is updated to: "+ Board.TotalScore);
        }

        public override void AddMe(List<Collectable> c)
        {
            base.AddMe(c);
            if (Score > 0)
            {
                UpdateTotalScore(Score);
            }
            else
            {
                UpdateTotalScore(100);
            }
        }
    }
}
