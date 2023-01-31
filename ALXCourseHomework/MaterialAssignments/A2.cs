using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXCourseHomework.MaterialAssignments
{
    public class A2
    {
        public static void Run()
        {
            double a = 3;
            double b = 6;
            double c = 15;
            double resut = Math.Pow(a, b) / 2 % c;
            Console.WriteLine($" (({a}^{b})/2) % {c} = {resut}");
            resut += 5;
            if (resut > a)
            {
                Console.WriteLine($"{resut} > {a}");
            }

            DemorganLaw(false, false);
            DemorganLaw(false, true);
            DemorganLaw(true, false);
            DemorganLaw(true, true);


        }
        public static void DemorganLaw (bool a, bool b)
        {
            Console.WriteLine($"(~({a} ∧ {b})) <=> ((~{a})∨(~{b})) <=> {!a || !b}");
        }
    }
}
