namespace ChallengeLoops1Average
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int ParsedNumber = 0;
            int counter = 0;
            string input = "";
            Console.WriteLine("The score must be between 0 and 20." +
                "\nInsert '-1' for calculate the average and terminate the program." +
                "\nEnter the scores:");
            do
            {
                Console.Write("->");
                input = Console.ReadLine();
                bool check = int.TryParse(input, out ParsedNumber);
                if (check && ParsedNumber >= 0 && ParsedNumber <= 20)
                {
                    sum += ParsedNumber;
                    counter++;
                }
                else
                {
                    if (ParsedNumber != -1)
                    {
                        Console.WriteLine("Error, insert only numbers between 0 and 20");
                    }
                }
            }
            while (ParsedNumber != -1);
            if (counter != 0)
            {
                double average = (double)sum / counter;
                Console.WriteLine("The average is: " + average);
            }
            else
            {
                Console.WriteLine("The average it's not possible");
            }
            Console.Read();
        }
    }
}