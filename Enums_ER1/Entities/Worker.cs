using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enums_ER1.Entities.Enums;


namespace Enums_ER1.Entities
{
    internal class Worker
    {
        internal string Name { get; set; }
        internal WorkLevel Level { get; set; }
        internal double BaseSalary {  get; set; }
        internal List<HourContract> Contracts { get; set; }
        internal Department _Department { get; set; }
        


        public Worker(string Name, WorkLevel Level, double BaseSalary, Department _Department)
        {
            this.Name = Name;
            this.Level = Level;
            this.BaseSalary = BaseSalary;
            this._Department = _Department;
            
        }
        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int year, int month)
        {
            double sum = 0;
            
            foreach(HourContract contract in Contracts)
            {
                sum += (contract.Date.Year == year) && (contract.Date.Month == month) ? contract.TotalValue() : 0;
            }


            return sum + BaseSalary;
        }

        public override string ToString()
        {
            return $"Name: {this.Name}\nDepartment: {this._Department.Name}";
        }


    }
}
