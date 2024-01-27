using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResources.Payroll
{
    public class HourlyEmployee : Employee
    {
        private decimal wage;
        private float hoursWorked;

        public decimal Wage
        {
            get
            {
                return this.wage;
            }

            set
            {/// Exception handling goes here
                this.wage = value; 
            }
        }

        public float HoursWorked
        {
            get 
            { 
                return this.hoursWorked; 
            }

            set
            {/// Exception handling goes here
                this.hoursWorked = value;
            }
        }

        public HourlyEmployee(decimal wage,
                              float hoursWorked,
                              string firstName,
                              string lastName,
                              string socialInsuranceNumber)
            : base(firstName, lastName, socialInsuranceNumber)
        {
            this.wage = wage;
            this.hoursWorked = hoursWorked;
        }

        public override decimal GetPay()
        {
            if (this.hoursWorked > 40)
            {
                decimal regularPay = 40 * this.wage;
                decimal overtimePay = (decimal)(this.hoursWorked - 40) * (this.wage * 1.5M);
                return regularPay + overtimePay;
            }
            return (decimal)this.wage * (decimal)this.hoursWorked;
        }

        public override string ToString()
        {
            return $"Employee: {this.LastName}, {this.FirstName} - {this.SocialInsuranceNumber}" +
                $"\r\n{this.hoursWorked} @ {this.wage} = {this.GetPay():C}";
        }
    }
}
