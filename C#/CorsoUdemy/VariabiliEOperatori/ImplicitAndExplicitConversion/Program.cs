namespace ImplicitAndExplicitConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // implicit casting
            int num = 12390532;
            long bigNum = num;
            Console.WriteLine("Implicit casting: " 
                + num + " " + bigNum);

            float myFloat = 13.37F;
            double myNewDouble = myFloat;
            Console.WriteLine("Implicit casting: " 
                + myFloat + " " + myNewDouble);

            // expicit casting (trounc)
            double myDouble = 13.37;
            int myInt;
            myInt = (int)myDouble;
            Console.WriteLine("Explicit castings (with truncation): "
                + myDouble + " " + myInt);

            // type conversion
            string myString1 = myDouble.ToString();
            string myString2 = myInt.ToString();
            string myString3 = myFloat.ToString();
            Console.WriteLine("Numbers converted to String: " 
                + myString1 + " " + myString2 + " " + myString3);

            bool sunIsShining = false;
            string myString4 = sunIsShining.ToString();
            Console.WriteLine("Boolean converted to String: " 
                + myString4);

            Console.Read();
        }
    }
}