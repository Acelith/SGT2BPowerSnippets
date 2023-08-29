namespace Challenge_IfStatements_2
{
    internal class Program
    {
        private static int highscore;
        private static string highscorePlayer;
        static void Main(string[] args)
        {
            checkHighscore(50000, "bimboSexy85");
            checkHighscore(49999, "ciao");
            checkHighscore(50001, "miao");
            checkHighscore(3000, "bao");

            Console.Read();
        }
        public static void checkHighscore(int score, string playerName)
        {
            if (score > highscore)
            {
                // update the new score and player name
                highscore = score;
                highscorePlayer = playerName;

                Console.WriteLine("New highscore is " +  score 
                    + "\nNew highscore holder is " + playerName);
            } else
            {
                Console.WriteLine("The old highscore of " + highscore 
                    + " could not be broken and is still held by " + highscorePlayer);
            }
            Console.WriteLine("-------------------------------------");
        }
    }
}