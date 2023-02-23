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
        static bool IsPlayAgainValid(string str)
        {
            if (str == "ja" || str == "nej")
            {
                return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            string player;
            string playAgain;
            bool continuePlaying;
            int winnerPoints = 2; // <-- ANPASSA ANTAL RUNDOR INNAN NÅGON VINNER
            do
            {
                Console.WriteLine("Välkommen till Sten, Sax eller Påse! Lycka till!\n");
                int playerPoints= 0;
                int computerPoints = 0;

                do
                {
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
                    }
                    else
                    {
                        Console.WriteLine("Ett poäng till datorn!");
                        computerPoints++;
                    }
                    Console.WriteLine($"Poängställning: Dina poäng {playerPoints} | Datorns poäng {computerPoints}\n");
                } while (playerPoints < winnerPoints && computerPoints < winnerPoints);
                if (playerPoints == winnerPoints)
                {
                    Console.WriteLine("Du vann!");
                }
                else
                {
                    Console.WriteLine("Datorn vann!");
                }
                Console.Write("vill du spela igen? (ja / nej) ");
                do
                {
                    playAgain = Console.ReadLine().ToLower();
                    if (IsPlayAgainValid(playAgain))
                    {
                        Console.WriteLine($"\n");
                    }
                    else
                    {
                        Console.Write("Ogiltligt svar, skriv 'ja' eller 'nej': ");
                    }
                } while (!IsPlayAgainValid(playAgain));

                continuePlaying = playAgain == "ja" ? true : false;

            } while (continuePlaying);
            Console.WriteLine("Välkommen tillbaka en annan gång!");
        }
    }
}