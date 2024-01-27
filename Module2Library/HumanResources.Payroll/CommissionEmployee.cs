using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResources.Payroll
{
    public class CommissionEmployee : Employee
    {
        private decimal grossSales;
        private float commissionRate;

        public decimal GrossSales
        {
            get
            {
                return this.grossSales;
            }

            set
            {
                this.grossSales = value;
            }
        }

        public float CommissionRate
        {
            get
            {
                return this.commissionRate;
            }

            set
            { 
                this.commissionRate = value; 
            }
        }

        public CommissionEmployee(string firstName,
                                  string lastName, 
                                  string socialInsuranceNumber,
                                  decimal grossSales = 0,
                                  float comissionRate = 0)
            : base(firstName, lastName, socialInsuranceNumber)
        {
            this.grossSales = grossSales;
            this.commissionRate = comissionRate;
        }

        public override decimal GetPay()
        {
            return (decimal)grossSales * (decimal)commissionRate / 100;
        }

        public override string ToString()
        {
            return $"Employee: {this.LastName}, {this.LastName}" +
                $" - {this.SocialInsuranceNumber}\r\nSales: " +
                $"{this.grossSales}\r\nCommission Rate: {this.commissionRate}\r\nEarnings: {this.GetPay():C}";
        }
    }
}
