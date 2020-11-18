using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Week.one.challenge
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void NameAndAge()
        {
            string firstName = "Ben";
            string lastName = "Thomas";
            int age = 23;
            Console.WriteLine(age + 7);
            Console.WriteLine(age - 7);
            Console.WriteLine(age * 7);
            Console.WriteLine(age / 7);
            Console.WriteLine(age % 7);

        }

        [TestMethod]
        public void Array()
        {
            string[] movie = { "Avatar", "frozen", "inception", "moana" };
        }

        [TestMethod]
        public void ListOfDates()
        {
            List<DateTime> listOfDates = new List<DateTime>();
            DateTime today = DateTime.Today;
            listOfDates.Add(today);
            listOfDates.Add(new DateTime(2020, 11, 25));
            listOfDates.Add(new DateTime(2020, 4, 11));
            listOfDates.Add(new DateTime(2020, 30, 5));


        }

        [TestMethod]
        public void HowMuchSleepDidYouGet()
        {
            Console.WriteLine("how many hours of sleep did you get?");
            int hours = 4;
            if (hours >= 10)
            {
                Console.WriteLine("you got a ton of sleep");
            }
            else if (hours >= 8 && hours < 10) 
            {
                Console.WriteLine("that is a good amount of sleeo");
            }
            else if (hours >= 4 && hours < 8)
            {
                Console.WriteLine("that is about as much sleep as i usually get");
            }
            else
            {
                Console.WriteLine("get some sleep!");
            }



        }


        [TestMethod]
        public void HowHasYourDayBeen()
        {
            string userDay = "Okay";
            switch (userDay)
            {
                case "great":
                    Console.WriteLine("Glad you are having a great day");
                    break;
                case "good":
                    Console.WriteLine("it is a day to be good on");
                    break;
                case "okay":
                    Console.WriteLine("hopefully it will get better from here");
                    break;
                case "bad":
                    Console.WriteLine("there is always tomorrow");
                    break;
                case ":(":
                    Console.WriteLine("I guess this is us now");
                    break;
                default:
                    Console.WriteLine("please enter something above");
                    break;
            }
        }
        [TestMethod]
        public void Supercalifragilisticexpialidocious()
        {
            string name = "supercalifragilisticexpialidocious";
            foreach(char letter in name)
            {
                if ( letter == 'i')
                {
                    Console.WriteLine(letter);
                }
                else
                {
                    Console.WriteLine("not an i");
                }
            }
        }
    }
}
