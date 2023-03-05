using System;

class HomeworkFive
{
    static void Main(string[] args)
    {
        startGame();

    }

    
    static void startGame()
    {
        welcomingMessage();
        int randomNumber = getRandomNumber();
        int userNumber;
        
        for (int counter = 1; counter <= 3; counter++)
        {
            userNumber = enterNumber();
            if (checkGame(userNumber, randomNumber, counter))
            {
                return;
            }
        }
        Console.WriteLine("You have LOST!");
        
        newGame();
    }


    static void welcomingMessage()
    {
        Console.WriteLine("Let's start the game. I have hidden numbers for you.");
        Console.WriteLine("This number is between 0 to 20. Please, guess it.");
        Console.WriteLine("You have three attemps. Good Luck!");
    }

  
    static int getRandomNumber()
    {
        return new Random().Next(0, 21);
    }


    static int enterNumber()
    {
        Console.Write("Please enter a number: ");
        return Int32.Parse(Console.ReadLine());
    }


    static bool checkGame(int userNumber, int randomNumber, int counter)
    {
        if (randomNumber == userNumber)
        {
            Console.WriteLine("You have won!");
            newGame();
            return true;
        }
        else if (randomNumber > userNumber && counter != 3)
        {
            Console.WriteLine("Your number is lower than random number.");
        }
        else if (randomNumber < userNumber && counter != 3)
        {
            Console.WriteLine("Your number is higher than random number");
        }
        return false;
    }

    static void newGame()
    {
        Console.WriteLine();
        string playAgain = "yes";
        Console.WriteLine("Play again (yes / no)?");
        string enteredAnswer = Console.ReadLine();

        if (enteredAnswer == playAgain)
        {

            startGame();
            return;
        }
        else
        {
            Console.WriteLine("Thanks for game");
        }

    }

}