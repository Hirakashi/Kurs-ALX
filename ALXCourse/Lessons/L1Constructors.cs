using ALXCourse.Lessons.Classes;
using System.Reflection.Metadata;

namespace ALXCourse.Lessons
{
    public class L1Constructors
    {
        public static void Test()
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
