using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.ConsoleUI
{
    public class ValidInput
    {
        public static float GetValidFloat(float i_Min, float i_Max)
        {
            float value;
            while (!float.TryParse(Console.ReadLine(), out value) || value < i_Min || value > i_Max)
            {
                Console.WriteLine($"Invalid input, please enter a value between {i_Min} and {i_Max}");
            }

            return value;
        }
        public static int GetValidChoice(int i_Min, int i_Max)
        {
            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice) || choice < i_Min || choice > i_Max)
            {
                Console.WriteLine($"Invalid choice, please enter a number between {i_Min} and {i_Max}.");
            }

            return choice;
        }
    }
}
