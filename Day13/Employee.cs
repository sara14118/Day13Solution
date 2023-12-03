using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Day13
{
    internal class Employee : People
    {

        string Role;
        int WorkingHours;
        double Wage;
        public Employee(string Name, int Age, int SNN, string Address, string Role, int WorkingHours,double Wage ):base(Name, Age, SNN, Address)
        { 

            this.Role = Role;
            this.WorkingHours = WorkingHours;
            this.Wage = Wage;
        }

        public override string ToString()
        {
            return base.ToString() + $"your position is :{this.Role},";
        }

    }
}
