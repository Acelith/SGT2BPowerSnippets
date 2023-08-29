namespace StringAndSomeMethods
{
    internal class Program
    {
        /// <summary>
        /// Commento equivalente alla javadoc!
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // declaration
            string myName = "Simone";
            string myLastName = "Boffelli";

            // concat
            string fullName = string.Concat(myName, " ", myLastName);
            Console.WriteLine(fullName);
            string message = "        my name is " + myName + ", pleased to meet you!";

            // metodo indexOf
            int index = myName.IndexOf("e");
            Console.WriteLine($"la lettera 'a' si trova all'indice numero {index}");

            // da la lunghezza della stringa
            Console.WriteLine($"la stringa 'messaggio' e' lunga {message.Length} caratteri");

            // stampa
            Console.WriteLine(message);

            // metodo trim
            message = message.Trim();
            Console.WriteLine(message);

            // metodo toUpperCase
            string capsMessage = message.ToUpper();
            Console.WriteLine(capsMessage);

            // metodo toLowerCase
            Console.WriteLine(capsMessage.ToLower());

            // substring
            Console.WriteLine(myName.Substring(2));
            Console.WriteLine(myName.Substring(2, 3));
            Console.WriteLine(message.Substring(3, message.Length-8));

            // replace
            Console.WriteLine(message.Replace("!", " :)"));

            // IsNullOrWhiteSpace
            Console.WriteLine(String.IsNullOrWhiteSpace(myName));

            //String.Format
            string fString = String.Format("My name is {0}", myName);
            Console.WriteLine(fString);

            // non esiste il charAt in C#, si deve usare l'indice dell'array
            // di char che compone la stringa
            char charAtIndex = message[0];
            Console.WriteLine(charAtIndex);

            Console.WriteLine(charAtIndex.ToString().ToUpper() 
                + message.Substring(1, message.Length-1).Replace("!", " @_@"));

            // challenge
            string challenge;
            Console.WriteLine("Please enter your name and press enter");
            challenge = Console.ReadLine();
            Console.WriteLine($"Upper case: {challenge.ToUpper()}");
            Console.WriteLine($"Lower case: {challenge.ToLower()}");
            Console.WriteLine($"Trim (no space): {challenge.Trim()}");
            Console.WriteLine($"substring: {challenge.Substring(2, challenge.Length-2)}");

            // challenge2
            Console.WriteLine("Enter a string here: ");
            string challenge2 = Console.ReadLine();
            Console.WriteLine("Enter the character to search: ");
            char charToFind = Console.ReadLine()[0];
            int indexToFind = challenge2.IndexOf(charToFind);
            Console.WriteLine(indexToFind);

            Console.WriteLine("Enter your first name: ");
            string firstName = Console.ReadLine().Trim().ToUpper();
            char firstNameIndex = firstName[0];
            string firstNameSubstr = firstName.Substring(1, firstName.Length-1).ToLower();
            firstName = firstNameIndex + firstNameSubstr;
            Console.WriteLine("Enter your last name: ");
            string lastName = Console.ReadLine().Trim().ToUpper();
            char lastNameIndex = lastName[0];
            string lastNameSubstr = lastName.Substring(1, lastName.Length-1).ToLower();
            lastName = lastNameIndex + lastNameSubstr;
            string name = string.Concat(firstName + " " + lastName);
            Console.WriteLine(name);

            Console.Read();
        }
    }
}