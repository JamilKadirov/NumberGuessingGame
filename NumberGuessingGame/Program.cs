namespace NumberGuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int winNum = r.Next(0, 100);

            bool win = false;

            do
            {
                Console.Write("Ugaday chislo ot 1 do 100: ");
                string s = Console.ReadLine();

                int i = int.Parse(s);

                if (i > winNum)
                {
                    Console.WriteLine("Slishkom mnogo! Davay po-menshe chislo...");
                }
                else if (i < winNum)
                {
                    Console.WriteLine("Malovato! Davay po-bolshe chislo...");
                }
                else if (i == winNum)
                {
                    Console.WriteLine("BINGO!!! TY POBEDIL!");
                    win = true;
                }
                Console.WriteLine();
            } while (win == false);

            Console.WriteLine("Spasibo za igru.\n");
            Console.Write("Dlya vyhoda nazhmi lyubuyu klavishu dvazhdy.");
            Console.ReadKey(true);

        }
    }
}