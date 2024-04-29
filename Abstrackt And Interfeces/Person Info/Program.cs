using System;
using System.Threading.Channels;

namespace PersonInfo
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string id = Console.ReadLine();
            string birthdate = Console.ReadLine();
            IIdentifiable idnum = new Citizen(name,age,id,birthdate);
            IBirthable date = new Citizen(name, age, id, birthdate);
           
            Console.WriteLine(idnum.Id);
            Console.WriteLine(date.Birthdate);


        }
    }
}
