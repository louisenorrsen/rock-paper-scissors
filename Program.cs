namespace Sten__sax_och_påse
{
    internal class Program
    {
        static bool IsValid(string str)
        {
            if (str == "sten" || str == "sax" || str == "påse")
            {
                return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen till Sten, Sax eller Påse! Lycka till!\n");
            string player;
            int playerPoints = 0;
            int computerPoints = 0;
            do {
                // REGISTRERAR DRAG FRÅN SPELAREN
                Console.Write("Din tur! välj sten, sax eller påse: ");
                do
                {
                    player = Console.ReadLine().ToLower();
                    if (IsValid(player))
                    {
                        Console.WriteLine($"Du valde {player}");
                    }
                    else
                    {
                        Console.Write("Ogiltligt svar, välj sten, sax eller påse: ");
                    }
                } while (!IsValid(player));

                // REGISTRERAR DRAG FRÅN DATORN
                Random random = new();
                string computer = Convert.ToString(random.Next(1, 3));

                switch (computer)
                {
                    case "1":
                        computer = "sten";
                        break;
                    case "2":
                        computer = "sax";
                        break;
                    case "3":
                        computer = "påse";
                        break;
                    default:
                        break;
                }
                Console.WriteLine($"Datorn valde {computer}");

                // AVGÖR VEM SOM VANN RUNDAN
                if (player == "sten" && computer == "sax" || player == "sax" && computer == "påse" || player == "påse" && computer == "sten")
                {
                    Console.WriteLine("Ett poäng till dig!");
                    playerPoints++;
                } else
                {
                    Console.WriteLine("Ett poäng till datorn!");
                    computerPoints++;
                }
            } while (playerPoints < 2 && computerPoints < 2);
        }
    }
}