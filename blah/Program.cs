using System.Reflection.Metadata.Ecma335;

namespace blah
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Upgift 1
            /*
             Console.ForegroundColor = ConsoleColor.Cyan;
             bool inWork = true;
             float num1 = 0f;
             float num2 = 0f;
             while (inWork)
             {
                 Console.WriteLine("!OBS! use , to do decimals!");
                 Console.WriteLine("---------------------------");
                 Console.WriteLine("Write Your First Input");
                 string input1 = Console.ReadLine();
                 Console.WriteLine("Write Your Second Input");
                 string input2 = Console.ReadLine();

                try
                {
                     num1 = float.Parse(input1);
                     num2 = float.Parse(input2);
                 }
                 catch
                 {
                     continue;
                 }

                 float temp = num1;
                 num1 = num2;
                 num2 = temp;
                 Console.WriteLine("Second Input: " + num1 + "\nFirst Input: " + num2);
                 inWork = false;
             }
             */



            //Upgift 2
            /*
            bool asking = true;
            while (asking)
            {

            Console.WriteLine("What day is it?");
            string day = Console.ReadLine();
            day = day.ToLower();
            switch (day)
            {
                case "monday":
                    Console.WriteLine("-School");
                    break;

                case "tuesday":
                    Console.WriteLine("-wash dishes");
                    break;

                case "wednesday":
                    Console.WriteLine("-Swimming");
                    break;

                case "thursday":
                    Console.WriteLine("-shop");
                    break;

                case "friday":
                    Console.WriteLine("-gym and rest");
                    break;

                case "saturday":
                    Console.WriteLine("-gym");
                    break;

                case "sunday":
                    Console.WriteLine("-rest");
                    break;

                default:
                        continue;
                       
                    

            }
            }
            */

            // Upgift 3

            /*
            string[] days = { "  Monday ", " Tuesday ", "Wednesday", "Thursday ", "  Friday ", " Saturday", "  Sunday " };
            Console.Write("| ");
            for (int i = 0; i < 7; i++)
            {
                Console.Write(days[i] + " | ");
            }
            Console.WriteLine();

            Console.WriteLine("-------------------------------------------------------------------------------------");
            for (int date = 1; date < 32; date++)
            {
                
                Console.Write("| ");
                Console.Write("    " + date + "    ");
                if (date <= 9)
                {
                    Console.Write(" ");
                }
                if (date == 7)
                {
                    Console.Write("|");
                    Console.WriteLine();
                    Console.WriteLine("-------------------------------------------------------------------------------------");

                }

                if (date == 14)
                {
                    Console.Write("|");
                    Console.WriteLine();
                    Console.WriteLine("-------------------------------------------------------------------------------------");

                }
                if (date == 21)
                {
                    Console.Write("|");
                    Console.WriteLine();
                    Console.WriteLine("-------------------------------------------------------------------------------------");

                }
                if (date == 28)
                {
                    Console.Write("|");
                    Console.WriteLine();
                    Console.WriteLine("-------------------------------------------------------------------------------------");

                }
                

            }
            Console.Write("|");
            */
        }
    }
}
