namespace Aula45Exercicio2
{
    class Employee
    {
        public string Name;
        public double Salary;
        public double Tax;

        public double NetSalary()
        {
            return Salary - Tax;
        }

        public void UpgradeSalary(double upgrade)
        {
            Salary = Salary * (1 + (upgrade / 100));
        }

        public override string ToString()
        {
            return $"{Name}, ${NetSalary().ToString("F2")}";
        }
    }
}
