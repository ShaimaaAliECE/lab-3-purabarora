using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    internal class Collectable : IDisplayable
    {
        public CollectionBoard Board = new CollectionBoard();
        public String Description { get; set; }

        public virtual void AddMe(List<Collectable> c) 
        {

            Console.WriteLine(Description + " Collected, Congrats!!!!");
        }
        public virtual void Display()
        {
        }
    }
}
