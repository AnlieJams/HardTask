using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите число: ");
        int number = int.Parse(Console.ReadLine());

        string[] digitPatterns =
        {
            "*****\n*   *\n*   *\n*   *\n*****",
            "    *\n    *\n    *\n    *\n    *",
            "*****\n    *\n*****\n*    \n*****",
            "*****\n    *\n*****\n    *\n*****",
            "*   *\n*   *\n*****\n    *\n    *",
            "*****\n*    \n*****\n    *\n*****",
            "*****\n*    \n*****\n*   *\n*****",
            "*****\n    *\n    *\n    *\n    *",
            "*****\n*   *\n*****\n*   *\n*****",
            "*****\n*   *\n*****\n    *\n*****" 
        };

        string numberString = number.ToString();

        for (int row = 0; row < 5; row++)
        {
            foreach (char digit in numberString)
            {
                int index = digit - '0';
                string digitPattern = digitPatterns[index];
                Console.Write(digitPattern.Split('\n')[row].Replace('*', digit));
            }

            Console.WriteLine();
        }
    }
}
