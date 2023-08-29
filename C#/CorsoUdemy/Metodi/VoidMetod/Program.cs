namespace VoidMetod
{
    internal class Program
    {
        // struttura di un metodo
        // acces (public, private, ecc) modifier (static, 'non void')  return type (void, int, ecc)
        // method's name (lowerCammelCase) parameters (param.1, param2, ecc)
        public static void writeSomething()
        {
            Console.WriteLine("I am coled from a method");
        }
        public static void writeSomethingSpecific(string myText)
        {
            Console.WriteLine(myText);
        }
        static void Main(string[] args)
        {
            // chiamata a un metodo
            writeSomething();
            writeSomethingSpecific("ciao a tutti, miao bao");
            Console.Read();

        }
    }
}