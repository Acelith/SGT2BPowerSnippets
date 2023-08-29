namespace DatatypesIntFloatDouble
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declaring
            int num1;
            // assigne a value
            num1 = 13;
            // declaration + assigne
            int num2 = 23;
            // multiple declaration
            int num3, num4, num5;
            // calculation
            int sum = num1 + num2;
            // concatenation
            Console.WriteLine("num1 is " + num1); // casting to string
            Console.WriteLine("num1: " + num1 + " + num2: " + num2 + " is " + sum);

            double d1 = 3.1415;
            double d2 = 5.1;
            double dDiv = d1 / d2;
            Console.WriteLine("d1/d2=" + dDiv);

            float f1 = 3.1415F; // add F at the end!
            float f2 = 5.1F;
            float fDiv = f1 / f2;
            Console.WriteLine("f1/f2=" + fDiv);

            // implicit casting
            double dIDiv = d1 / num1;
            Console.WriteLine("d1/num1=" + dIDiv);

            // explicit casting (troncamento)
            int dIDivInt = (int)d1 / num1;
            Console.WriteLine("d1/num1=" + dIDivInt);

            // challenge
            sbyte mySByte = -20; // accetta valori negativi (da -128 a 127)
            byte myByte =  20; // NON accetta valori negativi (da 0 a 255)
            short myShort = 32;
            int myInt = 6000;
            long myLong = 1000000;

            float myFloat = 3.4F;
            double myDouble = 4.746532;
            decimal myDecimal = 5.4563456345M;

            char myChar = 'A';
            string myString = "I control text";
            string parse = "1234";
            int parseValue = int.Parse(parse); // int.parce() converte una stringa in int

            Console.WriteLine("\n----------\nsByte: {0}\nByte: {1}\nShort: {2}\nInt: {3}\nLong: {4}" +
                "\n----------\nFloat: {5}\nDouble: {6}\nDecimal: {7}" +
                "\n----------\nChar: \'{8}\'\n{9}\nString: {10}\nString parsed to int: {11}"
                , mySByte, myByte, myShort, myInt, myLong, myFloat, myDouble, myDecimal, myChar, myString, parse, parseValue);

            Console.Read();
        }
    }
}