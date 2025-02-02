
namespace Principios_de__DRY_.Class
{
    public class Payroll
    {
        public decimal CalulateSalaryForFullTime(decimal baseSalary)
        {
            return CalcularExtras(baseSalary);
        }

        public decimal CalulateSalaryPartFullTime(decimal hourlyRate, int hoursWorked)
        {
            decimal salary = hourlyRate * hoursWorked;
            return CalcularExtras(salary);
        }

        private decimal CalcularExtras(decimal salary)
        {
            decimal tax = salary * 0.18m;
            decimal bonus = salary * 0.05m;

            return salary - tax + bonus;
        }

    }
}
