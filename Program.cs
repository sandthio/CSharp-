using System;

// Namespace
namespace NumberGuesser
{
    // Main Class
    class Program
    {
        // Entry Point Method 
        static void Main(String[] args)
        {
            GetAppInfo();  //Run GetAppInfo function

            GreetUser(); // Ask for users name and greet

            //Ask users name
            Console.WriteLine("What is your name?");

            //Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, lets play a game...", inputName);

            while (true)
            {

                //Create a new Randon object
                Random random = new Random();

                //Init correct number
                int correctNumber = random.Next(1, 10);

                // init guess var
                int guess = 0;

                //Ask user for number
                Console.WriteLine("Guess a number between 1 and 10");

                //While guess is not correct
                while (guess != correctNumber)
                {
                    //Get users input
                    string input = Console.ReadLine();


                    //Make sure its a number
                    if (!int.TryParse(input, out guess))
                    {
                        // Change  text color
                        Console.ForegroundColor = ConsoleColor.Red;

                        //Print error message
                        PrintColorMessage(ConsoleColor.Red, "Please enter an actual number");

                        //Reset text color
                        Console.ResetColor();

                        //Keep going
                        continue;

                    }

                    //Cast to int and put in guess
                    guess = Int32.Parse(input);


                    //Match guess to correct number
                    if (guess != correctNumber)
                    {

                        //Print error message
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again");

                        //Reset text color
                        Console.ResetColor();

                    }


                }

                //Print success message
                PrintColorMessage(ConsoleColor.Yellow, "CORRECT!! You guessed it!");

                // Change  text color
                Console.ForegroundColor = ConsoleColor.Yellow;

                    //Tell user its the correct number
                    //Console.WriteLine("You are CORRECT!");

                    //Reset text color
                    //Console.ResetColor();

                    //Ask user to play again
                    Console.WriteLine("Play Again? [Y or N]");


                    //Get answer
                    string answer = Console.ReadLine().ToUpper();

                    if (answer == "Y")
                    {
                        continue;
                    }
                    else if (answer == "N")
                    {

                        return;
                    }
                    else
                    {
                        return;

                    }

                
            }


        }

        // Get and Display app info
        static void GetAppInfo() {
            // Set App Vars
            string appName = "Number Gueser";
            string appVersion = "1.0.0";
            string appAuthor = "Sandra Thiongo";



            // Change  text color
            Console.ForegroundColor = ConsoleColor.DarkBlue;

            // Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            //Reset text color
            Console.ResetColor();

        }

        //Ask users name and greet
        static void GreetUser()
        {
            //Ask users name
            Console.WriteLine("What is your name?");

            //get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game. . ", inputName);

        }


        //Print colot message
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            // Change text color
            Console.ForegroundColor = color;

            //Tell user its not a number
            Console.WriteLine(message);

            //Reset text color
            Console.ResetColor();

        }
        











    }

    
    
}