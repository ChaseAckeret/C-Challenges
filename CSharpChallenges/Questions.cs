using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpChallenges
{
    [TestClass]
    public class Questions
    {
        [TestMethod]
        public void Question1()
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
        public void Question2()
        {

        }

        [TestMethod]
        public void Question3()
        {

        }

        [TestMethod]
        public void Question4()
        {

        }

        [TestMethod]
        public void Question5()
        {

        }

        [TestMethod]
        public void Question6()
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
        public void Question7()
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
