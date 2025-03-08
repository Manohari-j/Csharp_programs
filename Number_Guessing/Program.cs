namespace Number_Guessing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            int num = rand.Next(50);
            //Console.WriteLine(num);
            int allowed_guesses = 5;
            int guess_count = 0;

            while(guess_count < allowed_guesses)
            {
                Console.WriteLine("Guess a number (0 to 50):  ");
                int guess = Convert.ToInt32(Console.ReadLine());
                guess_count++;
                

                if (num==guess)
                {
                    Console.WriteLine("You won");
                    Console.WriteLine("Number of guesses: "+guess_count);
                    break;
                }
                else if(num>guess)
                {
                    Console.WriteLine("Your guess is lower!");
                }
                else 
                {
                    Console.WriteLine("Your guess is higher!");
                }
            }

            if(guess_count >= allowed_guesses)
            {
                Console.WriteLine("You lose!");
                Console.WriteLine("Number of guesses: " + guess_count);
            }

            Console.ReadKey();
        }
    }
}
