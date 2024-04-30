using System;
using System.Linq;
using System.Text;


namespace Telephony1
{
    public class Startup
    {
        public static void Main()
        {
            Smartphone smartphone = new Smartphone("Nokia");
            string[] phones = Console.ReadLine().Split();
            string[] websites = Console.ReadLine().Split();
            foreach (var phone in phones)
            {
                Console.WriteLine(smartphone.Call(phone));
            }
            foreach (var website in websites)
            {
                Console.WriteLine(smartphone.Browse(website));
            }
        }
    }
}

