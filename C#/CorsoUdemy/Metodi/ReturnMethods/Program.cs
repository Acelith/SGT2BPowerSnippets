namespace ReturnMethods
{
    internal class Program
    {
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        public static int Multiplie(int num1, int num2)
        {
            return num1 * num2;
        }
        // se i parametri sono di tipo diverso fa un casting con troncamento!!!
        public static double Divide(double num1, double num2)
        {
            return num1 / num2;
        }
        static void Main(string[] args)
        {
            // salvataggio della chiamata di un metodo in una variabile
            int sum = Add(10, 25);
            Console.WriteLine(sum);

            // stampa del risultato della chiamata (non riutilizabile)
            Console.WriteLine(Add(5, 7));

            // chiamata di un metodo con parametri che a loro volta chiamano un metodo
            int tripleSum = Add(Add(1, 2), Add(10,20)); // (es: somma di 2 somme)
            Console.WriteLine(tripleSum);

            Console.WriteLine(Multiplie(5, 3));

            Console.WriteLine(Divide(5, 3));

            Console.Read();
        }
    }
}