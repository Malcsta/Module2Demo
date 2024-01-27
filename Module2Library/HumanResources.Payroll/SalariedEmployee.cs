using System;

namespace HumanResources.Payroll
{
    public class SalariedEmployee : Employee
    {
        private decimal weeklySalary;

        public decimal WeeklySalary
        {
            get
            {
                return this.weeklySalary;
            }

            set
            {
                this.weeklySalary = value;
            }
        }

        public SalariedEmployee(string firstName,
                                string lastName,
                                string socialInsuranceNumber,
                                decimal weeklySalary)
            : base(firstName, lastName, socialInsuranceNumber)
        {
            this.weeklySalary = weeklySalary;
        }

        public override decimal GetPay()
        {
            return this.weeklySalary;
        }

        public override string ToString()
        {
            return $"{base.ToString()} ({this.GetPay()})";
        }
    }
}
