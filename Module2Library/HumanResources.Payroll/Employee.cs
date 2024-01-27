using System;

namespace HumanResources.Payroll
{
    public abstract class Employee
    {
        public string FirstName
        {
            get;
            private set;
        }

        public string LastName
        {
            get;
            private set;
        }

        public string SocialInsuranceNumber
        {
            get;
            private set;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="socialInsuranceNumber"></param>
        /// <exception cref="ArgumentException">
        /// Raise when the first name or last name is
        /// </exception>
        public Employee(string firstName, 
                        string lastName, 
                        string socialInsuranceNumber)
        {
            firstName = firstName.Trim();
            lastName = lastName.Trim();
            socialInsuranceNumber = socialInsuranceNumber.Trim();

            if(firstName.Length < 2)
            {
                throw new ArgumentException(
                    "The firstName must include 2 or more " +
                    "non-whitespace characters.",
                    "firstName"
                );
            }

            if (lastName.Length < 2)
            {
                throw new ArgumentException(
                    "The lastName must include 2 or more " +
                    "non-whitespace characters.",
                    "lastName"
                );
            }

            if(socialInsuranceNumber.Length != 9)
            {
                throw new ArgumentException(
                    "The {parameter-name} must include 9 " +
                    "non-whitespace characters.",
                    "lastName"
                );
            }

            this.FirstName = firstName;
            this.LastName = lastName;
            this.SocialInsuranceNumber = socialInsuranceNumber;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public abstract decimal GetPay();

        public override string ToString()
        {
            return $"Employee: {this.LastName}, {this.FirstName} " +
                   $"- {this.SocialInsuranceNumber}";
        }
    }
}
