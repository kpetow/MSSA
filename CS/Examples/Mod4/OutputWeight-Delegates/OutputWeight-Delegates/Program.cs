using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutputWeight_Delegates
{
    //public delegate float WeightType(bool unit);

    public class Program
    {
       

        static void Main(string[] args)
        {
            Console.Write("Enter weight: ");
            decimal weight = decimal.Parse(Console.ReadLine());

            Console.Write("Enter unit of measurement: ");
            string unit = Console.ReadLine();

            Patients patient1 = new Patients();
            patient1.getWeight(weight, unit);
        }        
    }

    public static class Hospital
    {

    }

    class Patients
    {
        private decimal weight { get; set; }
        private string unit { get; set; }

        public decimal getWeight(float weight)
        {
            this.weight = 0;
        }
        
    }
}
