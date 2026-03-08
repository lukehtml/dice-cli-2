namespace dice_cli
{
    class DiceCli
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            if (args.Length == 0)
            {
                Console.Beep();
                Console.WriteLine("Please input something.");
            }
            else {
                switch (args[0])
                {
                    case "roll":
                    {
                        string[] ndmNotation = args[1].Split("d");
                        int times = int.Parse(ndmNotation[0]);
                        int total = 0;
                        int sides = Convert.ToInt32(ndmNotation[1]) + 1;
                        for (int i = 0; i < times; i++)
                        {
                            int rolled = rand.Next(1, sides);
                            total += rolled;
                            Console.Write($"You rolled a");
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.Write($" {rolled} \n");
                            Console.ForegroundColor = ConsoleColor.Gray;
                        }
                        Console.Write($"You rolled a total of ");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write($"{total}\n");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        break;
                    }
                    case "help":
                    {
                        Console.WriteLine("How to roll dice: You use NdM notation aka Number of dice, dice, aMount of sides on dice");
                        break;
                    }


                    default:
                    {
                        Console.Write($"{args[0]} isn't a command in this tool, use dice roll with NdM notation to roll, run dice help to see what NdM is.");
                        break;

                    }
                    
                }
            


            }
        }
    }
}