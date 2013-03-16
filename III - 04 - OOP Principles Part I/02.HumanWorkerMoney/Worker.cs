using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanWorkerMoney
{
    class Worker : Human
    {
        private const int defaultWorkDaysInWeek = 5;

        public decimal weekSalary { get; private set; }
        public decimal workHoursPerDay { get; private set; }
        public int workDaysInWeek { get; private set; }

        public Worker(string firstName, string lastName, decimal weekSalary, decimal workHoursPerDay, int workDaysInWeek = defaultWorkDaysInWeek)
            : base(firstName, lastName)
        {
            this.weekSalary = weekSalary;
            this.workHoursPerDay = workHoursPerDay;
            this.workDaysInWeek = workDaysInWeek;
        }
        public decimal GetMoneyPerHour()
        {
            return this.weekSalary / this.workDaysInWeek / this.workHoursPerDay;
        }

        public override string ToString()
        {
            StringBuilder info = new StringBuilder();

            info.AppendLine("Week salary: " + this.weekSalary);
            info.AppendLine("Work hours per day: " + this.workHoursPerDay);
            info.AppendFormat("Money per hour: {0:0.000}", this.GetMoneyPerHour()).AppendLine();

            return base.ToString(info.ToString());
        }
    }
}
