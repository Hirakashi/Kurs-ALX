
using System.ComponentModel.DataAnnotations;

namespace ALXCourse.Lessons.Assignments.M2
{
    public class SeniorityServiceTest
    {
        public static void Run()
        {
            var firstEmployee = new Employee();
            firstEmployee.YearsOfExperience = 0;
            firstEmployee.Name = "Adam";
            
            var secondEmployee = new Employee();
            secondEmployee.YearsOfExperience = 5;
            secondEmployee.Name = "Piotrek";
            
            var thirdEmployee = new Employee();
            thirdEmployee.YearsOfExperience = 10;
            thirdEmployee.Name = "Patryk";
            
            var fourthEmployee = new Employee();
            fourthEmployee.YearsOfExperience = 20;
            fourthEmployee.Name = "Daniel";
            
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
            foreach(var employee in employees)
            {
                Console.WriteLine($"Employee: {employee.Name}");
            }
        }  
            
    }   
}
