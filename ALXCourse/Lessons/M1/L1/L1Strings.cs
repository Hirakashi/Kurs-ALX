﻿using ALXCourse.Lessons.M1.L1.Classes;
namespace ALXCourse.Lessons.M1.L1;

    public class L1Strings
    {
        public static void Run()
        {
            string name = "Milosz";
            Console.WriteLine(name);
            name = "Agata";
            Console.WriteLine(name);
            name = name + " ma kroliczki";
            Console.WriteLine(name);

            ExpandString(name, "Hello");
            Console.WriteLine(name);
            ExpandString(name, "something");
        }
        public static void ExpandString(string word, string extension)
        {
            word = word = extension;
        }
        public static void ConcetanationTestRun()
        {
            string word1 = "Agata ma";
            string word2 = "króliki dwa";

            string concat1 = word1 + word2;
            Console.WriteLine(concat1);
            string concat2 = word1 + " " + word2;
            Console.WriteLine(concat2);
            string concat3 = $"{word1} {word2} i je bardzo kocha!";
            Console.WriteLine(concat3);
        }
    }

