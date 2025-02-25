        Random random = new Random();
        int numberToGuess = random.Next(1, 11); // Random number between 1 and 11 (inclusive)
        int maxAttempts = 3; // Set the maximum number of attempts
        int numberOfTries = 0;
        bool hasGuessedCorrectly = false;

        Console.WriteLine("Welcome to the Number Guessing Game!");
        Console.WriteLine("I have selected a number between 1 and 11. You have 3 attempts to guess it.");

        while (!hasGuessedCorrectly && numberOfTries < maxAttempts)
        {
            Console.Write("Enter your guess: ");
            string userInput = Console.ReadLine();

            // Validate input
            if (int.TryParse(userInput, out int playerGuess))
            {
                numberOfTries++;

                if (playerGuess < 1 || playerGuess > 11)
                {
                    Console.WriteLine("Please guess a number between 1 and 11.");
                }
                else if (playerGuess < numberToGuess)
                {
                    Console.WriteLine("Too low! Try again.");
                }
                else if (playerGuess > numberToGuess)
                {
                    Console.WriteLine("Too high! Try again.");
                }
                else
                {
                    hasGuessedCorrectly = true;
                    Console.WriteLine($"Congratulations! You've guessed the number {numberToGuess} in {numberOfTries} tries.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }

            // Provide feedback on remaining attempts
            if (!hasGuessedCorrectly)
            {
                int remainingAttempts = maxAttempts - numberOfTries;
                if (remainingAttempts > 0)
                {
                    Console.WriteLine($"You have {remainingAttempts} attempts left.");
                }
                else
                {
                    Console.WriteLine($"Sorry, you've used all your attempts! The correct number was {numberToGuess}.");
                }
            }
        }

        Console.WriteLine("Thank you for playing!");