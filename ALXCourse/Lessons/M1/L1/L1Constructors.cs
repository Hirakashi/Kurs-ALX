using ALXCourse.Lessons.M1.L1.Classes;


namespace ALX_Course.Lessons.M1.L1
{
    public class L1Constructors
    {
        public static void Run()
        {
            var spider = new Spider();
            spider.Color = "black";
            spider.Species = "tarantula";
            spider.IsVenomous = false;
            spider.Sex = "female";

            var blackWidow = new Spider("Black", "Black Widow", true, "Female");
        }
    }
}
