namespace AgeClearance
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            string? strAge;

            Console.WriteLine("Enter your age:");
            strAge = Console.ReadLine();

            int.TryParse(strAge,out age);

            if(age >= 18)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("You're an adult. Welcome!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You're too young. Denied Access.");
            }
        }
    }
}