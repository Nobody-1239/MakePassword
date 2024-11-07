
using make_password;

namespace MakePassword
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose password leveln1. Easyn2. Hard");
            int level = 0;
            while (true)
            {
                try
                {
                    level = int.Parse(Console.ReadLine());
                    if (level < 1 || level > 2)
                    {
                        Console.WriteLine("Please enter a valid level (1 or 2)");
                        continue;
                    }
                    break;
                }
                catch
                {
                    Console.WriteLine("Please enter a number");
                }
            }

            Console.WriteLine("Enter length of password");
            int length = 0; // Correct variable name
            while (true)
            {
                try
                {
                    length = int.Parse(Console.ReadLine());
                    if (length <= 0)
                    {
                        Console.WriteLine("Please enter a positive number for length");
                        continue;
                    }
                    break;
                }
                catch
                {
                    Console.WriteLine("Please enter a number");
                }
            }

            Console.WriteLine("Do you want to have symbols? (yes/no)");
            bool symbols = Console.ReadLine().ToLower() == "yes";

            //---------------------------------------------------
            Password password = new Password();
            password.PasswordGenerator(level, length, symbols);
            Console.ReadKey();
        }
    }
}