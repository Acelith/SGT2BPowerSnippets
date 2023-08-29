namespace Challenge_IfStatements
{
    internal class Program
    {
        // private static variable (they cant be modified directli becouse of the private keyword
        // and they are accessible in all the class (outside theire scope) becouse of the static keyword
        private static string username;
        private static string password;
        static void Main(string[] args)
        {
            Register();
            Login();

            Console.Read();
        }
        public static void Register()
        {
            Console.WriteLine("Please register into our database:");
            Console.Write("Username: ");
            username = Console.ReadLine();
            Console.Write("Password: ");
            password = Console.ReadLine();
            Console.WriteLine("Registration sucessfull");
        }
        public static void Login()
        {
            Console.WriteLine("Please enter your username:");
            if (username == Console.ReadLine())
            {
                Console.WriteLine("Please enter your password:");
                if (password == Console.ReadLine())
                {
                    Console.WriteLine("Login sucessfull, welcome " + username);
                }
                else
                {
                    Console.WriteLine("Your credential aren't corect!");
                }
            }
            else
            {
                Console.WriteLine("Your credential aren't corect!");
            }
        }
    }
}