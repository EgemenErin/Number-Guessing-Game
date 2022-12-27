namespace User_Guesses_Number;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("");
        Console.WriteLine("Welcome to Number Guessing Game! :)");
        Console.WriteLine("");
        Console.WriteLine("A Number Between 0 - 100 has been generated.");
        Random random = new Random();
        bool play = true;
        int min = 0;
        int max = 101;
        int guesses = 0;
        int randomnum = random.Next(min, max);
        string userresponse;
        Console.WriteLine("Guess the number: ");
        while (play)
        {
            int input = Convert.ToInt32(Console.ReadLine());
            if (input < randomnum)
            {
                Console.WriteLine("Higher!");
                guesses += 1;
            }
            else if (input > randomnum)
            {
                Console.WriteLine("Lower!");
                guesses += 1;
            }
            else if (input == randomnum)
            {
                Console.WriteLine("Congrats! you guessed it in " + guesses + " amount of tries! :)");
                guesses += 1;
                play = false;
            }
        }
        Console.WriteLine("Would you like to play again (Y/N)");
        userresponse = Console.ReadLine();
        userresponse = userresponse.ToUpper();
        if (userresponse == "Y")
        {
            play = true;
        }
        else if (userresponse == "N")
        {
            Console.WriteLine("Thank you for playing! :)");
            return;
        }
        else
        {
            return;
        }



    }
}

