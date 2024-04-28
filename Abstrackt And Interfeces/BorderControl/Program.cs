using System;
using System.Collections.Generic;

namespace BorderControl
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Ibirthdates human = null;
            var humanAndRobot = new Dictionary<string, Ibirthdates>();
            Iindetification robot = null;

            while (input != "End")
            {
                string[] splited = input.Split();


                string action = splited[0];

                if (action == "Robot")
                {
                    string model = splited[1];
                    string id = splited[2];
                    robot = new Robots(model, id);
                }
                else if (action == "Pet")
                {
                    string name = splited[1];
                    string date = splited[2];
                    humanAndRobot.Add(date, human);
                }
                else if (action == "Citizen")
                {
                    string name = splited[1];
                    int age = int.Parse(splited[2]);
                    string id = splited[3];
                    string date = splited[4];
                    human = new Citizens(name, age, id, date);
                    humanAndRobot.Add(date, human);
                }
                input = Console.ReadLine();
            }

            string digitsid = Console.ReadLine();

            foreach (var item in humanAndRobot)
            {
                if (item.Key.Contains(digitsid))
                {
                    Console.WriteLine(item.Key);
                }
            }// RuntaimError==80/100
        }
    }
}
