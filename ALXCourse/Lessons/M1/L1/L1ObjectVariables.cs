﻿using ALXCourse.Lessons.M1.L1.Classes;

namespace ALX_Course.Lessons.M1.L1
{
    public class L1ObjectVariables
    {
        public static void Run()
        {
            Dog dog = new Dog();
            dog.Jump();
            dog.Bark();
            dog.Name = "Ruby";
            dog.Race = "Husky";
            dog.Age = 4;
            dog.sex = 'f';
            dog.Present();
            NumOfPups pups = new NumOfPups();
            pups = dog.Breed(8);
            dog.GrowOlder(2);
            dog.GetOlderAge();
            dog.Present();
        }
        public static void Run2()
        {
            Dog dog2 = new Dog();
            dog2.Jump();
            dog2.Bark();
            dog2.Name = "Amper";
            dog2.Race = "Golden retriever";
            dog2.Age = 4;
            dog2.sex = 'm';
            dog2.Present();
            NumOfPups pups = new NumOfPups();
            pups = dog2.Breed(8);
        }

    }

}

