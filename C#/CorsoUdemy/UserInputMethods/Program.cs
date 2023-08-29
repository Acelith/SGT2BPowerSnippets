namespace UserInputMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calculate());
            Console.Read();
        }
        public static int Calculate()
        {
            Console.Write("Enter the first number: ");
            string num1 = Console.ReadLine();
            Console.Write("Enter the second number: ");
            string num2 = Console.ReadLine();

            int number1 = int.Parse(num1);
            int number2 = int.Parse(num2);


            int result = number1 + number2;

            return result;

        }
    }
}