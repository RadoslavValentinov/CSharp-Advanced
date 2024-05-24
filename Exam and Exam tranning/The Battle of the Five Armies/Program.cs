using System;

namespace The_Battle_of_the_Five_Armies
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input
            int armor = int.Parse(Console.ReadLine());
            int row = int.Parse(Console.ReadLine());

            char[][] combatfield = new char[row][];

            for (int i = 0; i < row; i++)
            {
                var input = Console.ReadLine().ToCharArray();
                combatfield[i] = input;
            }

            int indexrowArmy = 0;
            int indexcolarmy = 0;
            for (int raws = 0; raws < combatfield.Length; raws++)
            {
                for (int col = 0; col < combatfield[raws].Length ; col++)
                {
                    if (combatfield[raws][col] == 'A')
                    {
                        indexrowArmy = raws;
                        indexcolarmy = col; 
                    }
                }
            }

            while (true)
            {
                string[] comand = Console.ReadLine().Split();
                string action = comand[0];
                int rowOrc = int.Parse(comand[1]);
                int colOrc = int.Parse(comand[2]);

                combatfield[rowOrc][colOrc] = 'O';
                combatfield[indexrowArmy][indexcolarmy] = '-';
                armor--;
                if (action=="up" && indexrowArmy-1 >= 0)
                {
                    indexrowArmy--;
                }
                else if (action=="down" && indexrowArmy+ 1 < row)
                {
                    indexrowArmy++;
                }
                else if (action=="left" && indexcolarmy-1 >= 0)
                {
                    indexcolarmy--;
                }
                else if (action=="right" &&  indexcolarmy+1 < combatfield[indexrowArmy].Length)
                {
                    indexcolarmy++;
                }

                if (combatfield[indexrowArmy][indexcolarmy] == 'O')
                {
                    armor -= 2;
                }
                if (armor <= 0)
                {
                    combatfield[indexrowArmy][indexcolarmy] = 'X';
                    Console.WriteLine($"The army was defeated at {indexrowArmy};{indexcolarmy}.");
                    break;
                }
                
                if (combatfield[indexrowArmy][indexcolarmy]=='M')
                {
                    combatfield[indexrowArmy][indexcolarmy] = '-';
                    Console.WriteLine($"The army managed to free the Middle World! Armor left: {armor}");
                    break;
                }
                combatfield[indexrowArmy][indexcolarmy] = 'A';
            }

            foreach (var item in combatfield)
            {
                Console.WriteLine(item);
            }
            // Result -- 100/100
        }
    }
}
