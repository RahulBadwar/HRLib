using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLib
{
    public class Trainee : Emp
    {

        public Trainee()
        {

        }

        public Trainee(string name, string add, int days, double rate) : base(name, add)
        {
            NoOfDays = days;
            Rate = rate;
        }
        private int noOfDays;

        public int NoOfDays
        {
            get { return noOfDays; }
            set { noOfDays = value; }
        }

        private double rate;

        public double Rate
        {
            get { return rate; }
            set { rate = value; }
        }


        public override double CalculateSalary()
        {
            return NoOfDays * Rate;
        }
    }
}
