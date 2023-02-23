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
            Console.WriteLine("Välkommen till Sten, Sax eller Påse! Lycka till!");
            string player;

            // REGISTRERAR DRAG FRÅN SPELAREN
            Console.Write("Din tur! välj sten, sax eller påse: ");
            do {
                player = Console.ReadLine().ToLower();
                if (IsValid(player))
                {
                    Console.WriteLine($"Du valde {player}");
                } else
                {
                    Console.Write("Ogiltligt svar, välj sten, sax eller påse: ");
                }
            } while(!IsValid(player));

            // REGISTRERAR DRAG FRÅN DATORN
            Random random = new();
            string computer = Convert.ToString(random.Next(1,3));

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

            Console.WriteLine(player + " " + computer);
        }
    }
}