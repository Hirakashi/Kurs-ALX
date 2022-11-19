
namespace ALXCourse.Lessons.M1.L1.Classes

{
    public class Spider
    {
        public string Color;
        public string Species;
        public bool IsVenomous;
        public string Sex;

        public Spider()
        { }

        public Spider(string color, string species, bool isVenomous, string sex)
        {
            Color = color;
            Species = species;  
            IsVenomous = isVenomous;    
            Sex = sex;
        }
            public void Present()
        {
            Console.WriteLine($"Here is a new spider");
            Console.WriteLine($"Species: {Species}");
            Console.WriteLine($"Sex: {Sex}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Venom: {IsVenomous}");
        }
    }
}
