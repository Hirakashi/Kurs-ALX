
namespace ALXCourse.Lessons.Assignments.M2
{
    public class SeniorityService
    {
        public List<Employee> JuniorEmployees;
        public List<Employee> MidEmployees;
        public List<Employee> SeniorEmployees;

        public SeniorityService()
        {
            JuniorEmployees = new List<Employee>(); 
            MidEmployees = new List<Employee>();
            SeniorEmployees = new List<Employee>();
        }
        public void ClassifySeniorityBySalary(Employee employee)
        {
            switch (employee.YearlySalary)
            {
                case < 80000:
                    JuniorEmployees.Add(employee);
                    break;
                case < 120000:
                    MidEmployees.Add(employee);
                    break;
                default:
                    SeniorEmployees.Add(employee);
                    break;
            }
        }
        public void ClassifySeniorityByExperience(Employee employee)
        {
            switch (employee.YearsOfExperience)
            {
                case < 5:
                    JuniorEmployees.Add(employee);
                    break;
                case < 10:
                    MidEmployees.Add(employee);
                    break;
                default:
                    SeniorEmployees.Add(employee);
                    break;
            }
        }
    }
}
