using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpChallenges
{
    [TestClass]
    public class Questions
    {
        [TestMethod]
        public void Question1_NameAndAge()
        {
            string firstName;
            string lastName;
            int age;

            firstName = "Chase";
            lastName = "Ackeret";
            age = 28;
            Console.WriteLine($"My name is {firstName } {lastName}, and I am {age}.");
        }
        [TestMethod]
        public void Question2_Array()
        {
            string[] movie1 = { "Harry Potter", "Public Enemy", "Peaky Blinders", "Money Heist"};
        }
        [TestMethod]
        public void Question3_DatesAndTimes()
        {
            List<DateTime> listOfDates = new List<DateTime>();
            DateTime today = DateTime.Now;
            listOfDates.Add(today);
            listOfDates.Add(new DateTime(2020,12,25));
            listOfDates.Add(new DateTime(2020, 3, 12));
            listOfDates.Add(new DateTime(2020, 6, 16));
        }
        [TestMethod]
        public void Question4_MathOperators()
        {
            int age = 28;
            Console.WriteLine(age + 7);
            Console.WriteLine(age - 7);
            Console.WriteLine(age * 7);
            Console.WriteLine(age / 7);
            Console.WriteLine(age % 7);
        }
        [TestMethod]
        public void Question5_Conditionals()
        {
            Console.WriteLine("How many hours of sleep did you get?");
            int hours = 4;  //Would be Console.ReadLine();

            if (hours >= 10)
            {
                Console.WriteLine("Wow, that's a lot of sleep!");
            }
            else if (8 < hours && hours < 10)
            {
                Console.WriteLine("You should be pretty rested.");
            }
            else if (4 < hours && hours < 8)
            {
                Console.WriteLine("Bummer!");
            }
            else
            {
                Console.WriteLine("Oh man, get some sleep!");
            }
        }
        [TestMethod]
        public void Question6_SwitchCase()
        {
            string firstQuestion = "How are you doing today?";
            Console.WriteLine(firstQuestion);
            string answer = Console.ReadLine().ToLower();

            switch (answer)
            {
                case "great":
                    Console.WriteLine("I am glad to hear that your day is great!");
                    break;
                case "good":
                    Console.WriteLine("That is good news!");
                    break;
                case "okay":
                    Console.WriteLine("I hope your day gets better!");
                    break;
                case "bad":
                    Console.WriteLine("I am sorry to hear that. Is there anything I can do to help?");
                    break;
                case ":(":
                    Console.WriteLine("That sounds like a horrible day!");
                    break;
                default:
                    break;
            }
        }
        [TestMethod]
        public void Question7_Supercalifragilisticexpialidocious()
        {
            string word = "Supercalifragilisticexpialidocious";
            //--Part 1
            foreach (char letter in word)
            {
                Console.WriteLine(letter);
            }
            //--Part 2 and Bonus 2
            foreach (char letter in word)
            {
                if (letter.Equals('i') || letter.Equals('l'))
                {
                    Console.WriteLine(letter);
                }
                else
                {
                    Console.WriteLine("Not an i or l.");
                }
            }
            //--Bonus 1
            Console.WriteLine(word.Length);
        }
    }
}
