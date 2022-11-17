using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLib
{
    public class ConfirmEmployee : Emp
    {

        public ConfirmEmployee(string name, string add, int basic, string desingnation) : base(name, add)
        {
            Basic = basic;
            Desingnation = desingnation;
        }

        public ConfirmEmployee()
        {

        }

        private int basic;

        public int Basic
        {
            get { return basic; }
            set { basic = value; }
        }

        private string desingnation;

        public string Desingnation
        {
            get { return desingnation; }
            set { desingnation = value; }
        }

        public sealed override double CalculateSalary()
        {
            if (Basic >= 30000)
            {
                return Basic + 0.3 * Basic + 0.3 * Basic - 0.1 * Basic;
            }
            if (Basic >= 20000)
            {
                return Basic + 0.2 * Basic + 0.2 * Basic - 0.1 * Basic;
            }

            return Basic + 0.1 * Basic + 0.1 * Basic - 0.1 * Basic;

        }

        public override string ToString()
        {
            return base.ToString() + string.Format($"Basic {Basic} Designation {Desingnation}");
        }
    }

}
