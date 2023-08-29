namespace WriteLine_PrintF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // fanno parte della classe Console

            // Stampa e mantiene il cursore sulla stessa linea (come Print) comando cw
            Console.Write("testo sulla stessa riga\n");

            // Stampa e manda il cursore in una nuova riga (come Println)
            Console.WriteLine("testo a capo");

            // Console.Read(); Prende un input singolo di tipo Char e lo ritorna in
            // ASCII senza consumare una newLine.
            // Inserendo 'a' ritorna 97 (valore decimale ASCII)
            int asciiValue = Console.Read();
            Console.WriteLine("ASCII value: " + asciiValue);

            Console.ReadLine(); // Svuota il buffere (come in.NextLine())

            // Console.ReadLine(); prende una stringa o un int e ne ritorna il valore.
            // Si usa come user input (come uno scanner di java!!!!!!!!!!!!!!)
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, " + name + "!");

            // Console.ReadKey(); Prende un qualsiasi tasto per continuare (o il tasto premuto)
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.WriteLine("Key pressed!");

            // esempi 1
            Console.Write("Enter a string and press enter: ");
            string readInput = Console.ReadLine();
            Console.WriteLine("You have entered: {0}",readInput);

            // esempio 2
            Console.Write("Enter a char and press enter: ");
            int asciiValue2 = Console.Read();
            Console.WriteLine("ASCII value is: {0}",asciiValue2);
            Console.ReadKey();

            Console.ReadLine(); // Svuota il buffere (come in.NextLine())

            // esempio 3
            Console.Write("Enter any string and press enter: ");
            string userName = Console.ReadLine();
            Console.WriteLine("You have entered: " + userName);
            Console.Write("Enter any key and press enter: ");
            int asciiValue3 = Console.Read();
            Console.WriteLine("ASCII value of the entered value is " + asciiValue3);

        }
    }
}