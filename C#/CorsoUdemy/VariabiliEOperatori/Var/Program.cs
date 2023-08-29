namespace Var
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var num1 = 0; // il compilatore assegna automaticamente un int alla variabile
            // num1 = "non va!"; una variabile gia inizializzata con un tipo non puo essere cambiato
            var num2 = 3.5; // il compilatore assegna automaticamente un double alla variabile
            var num3 = 5.2F; // il compilatore assegna automaticamente un float alla variabile
            var lettera = 'A'; // il compilatore assegna automaticamente un char alla variabile
            var isTrue = false; // il compilatore assegna automaticamente un bool alla variabile
            var text = "ciao"; // il compilatore assegna automaticamente una stringa alla variabile
        }
    }
}