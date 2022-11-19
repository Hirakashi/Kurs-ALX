namespace ALX_Course.Assignments.M2.L1
{
    public class SeniorityServiceTest
    {
        public static void Run()
        {
            var firstEmployee = new Employee("Adam", 1, 50000);
            var secondEmployee = new Employee("Piotr", 5, 80000);
            var thirdEmployee = new Employee("Patrul", 10, 100000);
            var fourthEmployee = new Employee("Marcin", 20, 150000);

            var seniorityService = new SeniorityService();

            seniorityService.ClassifySeniorityByExperience(firstEmployee);
            seniorityService.ClassifySeniorityByExperience(secondEmployee);
            seniorityService.ClassifySeniorityByExperience(thirdEmployee);
            seniorityService.ClassifySeniorityByExperience(fourthEmployee);

            Console.WriteLine("Juniors: ");
            PresentEmployees(seniorityService.JuniorEmployees);
            Console.WriteLine("Mids: ");
            PresentEmployees(seniorityService.MidEmployees);
            Console.WriteLine("Seniors: ");
            PresentEmployees(seniorityService.SeniorEmployees);
        }
        public static void PresentEmployees(List<Employee> employees)
        {
            foreach (var employee in employees)
            {
                Console.WriteLine($"Employee: {employee.Name}");
            }
        }
    }
}
