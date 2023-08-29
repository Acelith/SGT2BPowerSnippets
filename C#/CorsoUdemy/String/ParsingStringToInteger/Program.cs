namespace ParsingStringToInteger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // if we add 2 string it concatenates the result using
            // the characters, does not do any math operations
            string myString = "15";
            string myString2 = "13";
            string result = myString + myString2;
            Console.WriteLine(result);

            // by parsing a string we can obtain a primitive type
            int num1 = Int32.Parse(myString); // parsing int
            int num2 = Int32.Parse(myString2);
            double dub = Double.Parse(myString2); // parsing double
            int intResult = num1 + num2;
            Console.WriteLine(intResult);

            // TryParse() is used to convert a string representation
            // of a number to an integer value and returns a boolean
            // indicating whether the conversion was successful or not.
            string attempt = "ciao";
            bool success = Int32.TryParse(attempt, out int num3);
            // print the boolean result
            Console.WriteLine(success);
            // if/else result based on the boolean value
            // instead of if/else it can endle by using try/catch statement
            if (success)
            {
                Console.WriteLine(num3);
            }
            else
            {
                Console.WriteLine("Invalid input");
            }

        }
    }
}