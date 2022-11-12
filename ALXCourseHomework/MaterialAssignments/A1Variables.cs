using System;
using ALXCourseHomework.MaterialAssignments.Variables.Enums;
using DayOfWeek = ALXCourseHomework.MaterialAssignments.Variables.Enums.DayOfWeek;

namespace ALXCourseHomework.MaterialAssignments
{
    public class A1Variables
    {
        public static void Run()
        {
            string name = "Stefan";
            string surname = "Kowalski";
            char sex = 'm';
            int age = 50;
            int pesel = 558210121;
            double height = 1.80;
            Console.WriteLine($"{name}\n{surname}\n{sex}\n{age}\n{pesel}\n{height}");
            Console.WriteLine($"{name}\n{surname}\n{sex}\n{age}\n{pesel}\n{(int)height}");

            string dayOfWeak = DateTime.Now.ToString("ddd");
            DayOfWeek today;
            switch (dayOfWeak)
            {
                case "pon.":
                    today = DayOfWeek.MONDAY;
                    break;
                case "wt.":
                    today = DayOfWeek.TUESDAY;
                    break;
                case "śr.":
                    today = DayOfWeek.WEDNESDAY;
                    break;
                case "czw.":
                    today = DayOfWeek.THURSDAY;
                    break;
                case "pt.":
                    today = DayOfWeek.FRIDAY;
                    break;
                case "sob.":
                    today = DayOfWeek.SATURDAY;
                    break;
                case "niedz.":
                    today = DayOfWeek.SUNDAY;
                    break;
                default:
                    Console.WriteLine("Something is broken");
                    today = DayOfWeek.MONDAY;
                    break;
            }
            int month = int.Parse(DateTime.Now.ToString("MM"));

            Month monthNow;
            switch (month)
            {
                case 01:
                    monthNow = Month.JANUARY;
                    break;
                case 02:
                    monthNow = Month.FEBRUARY;
                    break;
                case 03:
                    monthNow = Month.MARCH;
                    break;
                case 04:
                    monthNow = Month.APRIL;
                    break;
                case 05:
                    monthNow = Month.MAY;
                    break;
                case 06:
                    monthNow = Month.JUNE;
                    break;
                case 07:
                    monthNow = Month.JULY;
                    break;
                case 08:
                    monthNow = Month.AUGUST;
                    break;
                case 09:
                    monthNow = Month.SEPTEMBER;
                    break;
                case 10:
                    monthNow = Month.OCTOBER;
                    break;
                case 11:
                    monthNow = Month.NOVEMBER;
                    break;
                case 12:
                    monthNow = Month.DECEMBER;
                    break;
                default:
                    Console.WriteLine("Something is broken (Month)");
                    monthNow = Month.APRIL;
                    break;

            }
            Console.WriteLine($"Today is {today} the {DateTime.Now.ToString("dd")} of {monthNow} {DateTime.Now.ToString("yyyy")}");


        }
    }
}
