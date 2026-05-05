using System;
using System.Collections.Generic;
using System.Text;

namespace Revision_OOP.Encapsulation
{
    internal struct Employee
    {

        // Encapsulation: Separates Data Definition[Fields] from its Use[Getters & Setters] 

        
        #region Attributes
        private int id;
        private string? name;
        private decimal salary;
        // private decimal deducation; // Derived Attribute

        #endregion

        #region 1. Applying Encapsulations Throght Getters Setters [Old Approach]

        // Getter
        public int GetId()
        {
            return id;
        }

        // Setter

        public void SetId(int value)
        {
            id = value > 1000 && value < 10_000 ? value : 9999; // Data Validation
        }

        #endregion

        #region Properties

        // 2. Applying Encapsulations Throght Properties [New Approach] (Recommended)
        
        // 2.1 Full Properties

        public string? Name
        {
            get
            {
                return name;
            }
            set
            {
                // Data validation
                name = ValidateName(value);
            }
        }

        public decimal Salary
        {
            get { return salary; }
            set { salary = ValidateSalary(value); }
        }

        // ReadOnly
        public decimal Deducation
        {
            get { return salary * 0.2M; }
        }


        // 2.2  Automatic Property
        // Compiler will Generate Backing Field Hidden Private Attribute
        public int Age { get; set; }

        #endregion

        #region Constructors
        public Employee(int id, string? name, decimal salary)
        {
            this.id = id;
            this.name = ValidateName(name);
            this.salary = ValidateSalary(salary);

        }


        #endregion

        #region Methods
        public override string ToString()
        {
            return $"Id ={this.id}\nName = {this.name}\nSalary {this.salary:c}";
        } 


        private string ValidateName(string? name)
        {
           return name is null ? "N/A" : name.Length <= 10 ? name : name.Substring(0, 10);
        }

        private decimal ValidateSalary(decimal salary)
        {
            return  salary >= 5000 ? salary : 5000; ;
        }
        #endregion
    }
}
