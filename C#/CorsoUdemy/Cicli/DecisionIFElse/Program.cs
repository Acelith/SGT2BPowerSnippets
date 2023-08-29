namespace DecisionIFElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //-------------------------------------------------
            // if/else if/ else statment
            //-------------------------------------------------
            Console.Write("Insert the temperature: ");
            string temperature = Console.ReadLine();
            // whith Parse() if the result is not parsable it throw an exception
            int numTemp = int.Parse(temperature);

            if (numTemp < 10)
            {
                Console.WriteLine("Take a coat");
            } else if (numTemp == 10)
            {
                Console.WriteLine("It's 10 degrees");
            }
            else
            {
                Console.WriteLine("Cozy & warm!");
            }

            //-------------------------------------------------
            // TryParse(<string to parse>, out <variable to store the result>)
            // return a boolean (true if is parable or false if it's not) without throwing exception
            //-------------------------------------------------
            Console.Write("Insert a number to pasrse: ");
            string askNumber = Console.ReadLine();
            int parsedValue;
            bool result = int.TryParse(askNumber, out parsedValue);

            if (result)
            {
                Console.WriteLine("Parsing successful. The number is '" + parsedValue + "'");
            }
            else
            {
                Console.WriteLine("Parsed failed");
            }

            // it's posible to pars in any dataType
            Console.Write("Insert a float number: ");
            string askFloatNumber = Console.ReadLine();
            float parsedFloatValue;
            bool floatResult = float.TryParse(askFloatNumber, out parsedFloatValue);

            if (floatResult)
            {
                Console.WriteLine("Parsing successful. The float number is '" 
                    + parsedFloatValue + "'");
            }
            else
            {
                Console.WriteLine("Parsed failed");
            }

            // it's posible to use the TryParse() direclty on the if/else statment as a boolean value
            Console.Write("Insert an integer number: ");
            string numberToCheck = Console.ReadLine();
            int numberParsed;

            if (int.TryParse(numberToCheck, out numberParsed))
            {
                Console.WriteLine("Parsing successful = '" + parsedFloatValue + "'");
            }
            else
            {
                Console.WriteLine("Parsed failed!");
            }

            //-------------------------------------------------
            // Nasted if statment
            //-------------------------------------------------
            bool isRegistered = true;
            string userName = "";
            bool isAdmin = true;

            //User-Input
            //Try "Mike"
            Console.WriteLine("Please enter you username");
            userName = Console.ReadLine();

            //Code inside will be executed, if isRegistered is true
            if (isRegistered)
            {
                Console.WriteLine("User is registered");

                //Code inside will be executed, if userName is not ""
                if (userName != "")
                {
                    Console.WriteLine("Hello {0}", userName);

                    //Code inside will be executed, if userName is "Mike"
                    if (isAdmin)
                    {
                        Console.WriteLine("Oh, an Admin logged in. Welcome");
                    }
                }
            }

            //The same result can be achieved by using logical and
            if (isRegistered && userName != "" && isAdmin)
            {
                Console.WriteLine("User is registered");
                Console.WriteLine("Hello {0}", userName);
                Console.WriteLine("Oh, an Admin logged in. Welcome");

                if (userName == "Mike")
                {
                    Console.WriteLine("Welcome, Master Mike");
                }
            }

            //This will keep the Console open
            Console.Read();
        }
    }
}