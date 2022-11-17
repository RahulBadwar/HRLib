using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLib
{
    public abstract class Emp
    {


        public Emp()
        {

        }

        public Emp(string name, string add)
        {
            Name = name;
            Address = add;
            Id = count++;

        }

        private static int count = 1000;

        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }


        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string address;

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public abstract double CalculateSalary();

        public override string ToString()
        {
            return string.Format($"Name {Name} City{Address}");
        }
    }
}
