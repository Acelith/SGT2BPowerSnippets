namespace Constants
{
    // Constants are immutable values which are known 
    // at compile time and do not change for the life of the program.

    class Program
    {
        // constants as fields
        const double PI = 3.14159265359;
        const int Weeks = 52, Months = 12;
        // Create a constant of type string with your birthday as its value
        const string Birthday = "31.05.1988";
        const string Birthday2 = "05.31.1988";
        const string Birthday3 = "2018-05-31";

        static void Main(string[] args)
        {
            Console.WriteLine("My birthday is always going to be: {0}", Birthday);
            Console.ReadKey();
        }
    }
}