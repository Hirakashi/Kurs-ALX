
namespace ALXCourse.Lessons.Classes
{
    public class Dog
    {
        public string Name;
        public int Age;
        public string Race;
        public bool Goodboi = true;
        public char sex;

        public void Jump()
        {
            Console.WriteLine("Hop! Hop!");

        }
        public void Bark()
        {
            Console.WriteLine("Woof! Woof!");
        }
        public int GetOlderAge()
        {
            return Age++;
        }
        public void GrowOlder(int numberOfYears)
        {
            Age += numberOfYears;
        }
        public NumOfPups Breed(int x)
        {
            NumOfPups pups = new NumOfPups();
            pups.NumberOfMalePups = 0;
            pups.NumberOfFemalePups = 0;
            if (sex == 'f')
            {
               ;
                int y = x / 2;
                int z = y;
                if (x % 2 != 0)
                {
                    z++;
                }
                pups.NumberOfMalePups = y - 1;
                pups.NumberOfFemalePups = z + 1;
                Console.WriteLine("Male Pups: " + pups.NumberOfMalePups);
                Console.WriteLine("Female Pups: " + pups.NumberOfFemalePups);
                return pups;
            }
            Console.WriteLine("it can't");
            return pups;

        }
        public void Present()
        {
            Console.WriteLine("Here's dog: \"" + Name + "\"!");
            Console.WriteLine("Race: " + Race);
            Console.WriteLine("Age: " + Age);
            if (Goodboi == true)
            {
                if (sex == 'f')
                {
                    Console.WriteLine("She's a Good Girl!");
                }
                if (sex == 'm')
                {
                    Console.WriteLine("He's a Good Boy!");
                }
            }
            if (Goodboi == false)
            {
                Console.WriteLine("Bad dog!? impossible!");                
            }
        }
    }
}
