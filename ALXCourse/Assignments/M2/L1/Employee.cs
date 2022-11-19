namespace ALX_Course.Assignments.M2.L1
{
    public class Employee
    {
        public string Name;
        public int YearsOfExperience;
        public decimal YearlySalary;

        public Employee()
        { }
        public Employee(string name, int yearsOfExperience, decimal yearlySalary)
        {
            Name = name;
            YearsOfExperience = yearsOfExperience;
            YearlySalary = yearlySalary;
        }
    }
}
