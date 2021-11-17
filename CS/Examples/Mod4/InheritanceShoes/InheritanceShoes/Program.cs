using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceShoes
{
    public class Shoes
    {
        protected string material;
        protected bool hasLaces;
        protected bool hasCushion;
        protected string color;
        protected string brand;

        static void Main(string[] args)
        {
        }
    }
    public class Athletic : Shoes
    {


    }
    public class Baseball : Athletic
    {
        public string spikes;

    }
    public class Running : Athletic
    {
        public string type;

    }
}
