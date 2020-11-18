using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Week.one.challenge
{
    [TestClass]
    public class UnitTest1
    {
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
