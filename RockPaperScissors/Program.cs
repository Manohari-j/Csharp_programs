namespace RockPaperScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            String[] choices = { "rock", "scissors", "paper" };

            int num = rand.Next(0,choices.Length);
            String choice = choices[num];

            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("Enter any one (rock, paper, scissors): ");
                String answer = (Console.ReadLine()).ToLower();

                if (answer !="rock"&& answer != "paper" && answer != "scissors")
                {
                    Console.WriteLine("Please enter only any one from the following(rock, paper, scissors)");
                    continue;
                }

                if(answer == choice)
                {
                    Console.WriteLine("It's a tie!!");
                }
                else if(choice == "rock" && answer == "paper" || choice == "paper" && answer == "scissors" || choice == "scissors" && answer == "rock")
                    Console.WriteLine("You Won!!");
                else if (answer  == "rock" && choice == "paper" || answer  == "paper" && choice == "scissors" || answer  == "scissors" && choice == "rock")
                    Console.WriteLine("You lose!!");

                Console.WriteLine("Choice of computer is "+choice);

                Console.WriteLine("Do you want to play again?(y/n) :");
                String play = (Console.ReadLine()).ToLower();

                if(play =="n")
                {
                    isRunning = false;
                }


            }

        }
    }
}
