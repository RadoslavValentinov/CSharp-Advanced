using System;
using System.Linq;

namespace Telephony
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] phoneNumber = Console.ReadLine().Split();
            string[] sait = Console.ReadLine().Split();

            ISmartphone phone = new Smartphone("");
           

            for (int i = 0; i < phoneNumber.Length; i++)
            {
                if (phoneNumber[i].Length==10)
                {
                    Console.WriteLine(phone.Calling(phoneNumber[i]));
                }
                else if (phoneNumber[i].Length==7)
                {
                    
                }
            }

            for (int i = 0; i < sait.Length; i++)
            {
                if (sait[i].Any(char.IsDigit))
                {
                    Console.WriteLine("Invalid URL!");
                    continue;
                }
                else
                {
                    Console.WriteLine(phone.Browsing(sait[i].ToString()));
                }

            }


        }
    }
}
