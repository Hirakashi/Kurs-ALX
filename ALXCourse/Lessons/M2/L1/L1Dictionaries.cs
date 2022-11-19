using ALXCourse.Lessons.M2.L1.ClassesAndEnums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALX_Course.Lessons.M2.L1
{
    public class L1Dictionaries
    {
        public static void Run()
        {
            var fruitDictionary = new Dictionary<int, string>()
            {
                {1,"Banana"},
                {2,"Apple" },
                {3,"Pineapple" },
                {4,"Raspberry" }
            };
        }
        public static void Run1()
        {
       
        }
        public static User MapDTO(UserDTO userDTO)
        {
            var user = new User();
            user.Name = userDTO.Name;

            Dictionary<string, UserRoles> mapDictionary = new Dictionary<string, UserRoles>()
            {
                { "administrator",UserRoles.ADMINISTRATOR},
                { "user",UserRoles.USER},
                { "supervisor",UserRoles.SUPERVISIOR},
            };
            var rolefromDTO = userDTO.Role
                .ToLower()
                .Replace(" ", "");
            user.Role = mapDictionary[rolefromDTO];

            return user;
        }
    }
}
