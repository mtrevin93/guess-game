using System;



// Phase 7
// The program should be updated to...
// 1. Prompt the user for a difficulty level before they are prompted to guess the number.
// 2. The difficulty level should determine how many guesses the user gets.  
//    The difficulty levels should be:
//    • Easy - this gives the user eight guesses.
//    • Medium - this gives the user six guesses.
//    • Hard - this gives the user four guesses.
// Phase 8
// The program should be updated to...
// 1. Add a difficulty level of "Cheater" which will cause the program to continue prompting the user until they get the answer correct.

Console.WriteLine("Guess the secret number...I'm not telling");

string guess = "0";
int count = 0;
int secretNumber = new Random().Next(1,100);

while (int.Parse(guess) != secretNumber && count < 4){
    guess = Console.ReadLine();
    Console.WriteLine();
    if (int.Parse(guess) != secretNumber){
        Console.WriteLine($"Nope!");
        if (count < 4)
        count ++;
        if (count == 4){
            Console.WriteLine("Out of guesses! Too bad, so sad!");
            break;
        }
        if (int.Parse(guess) < secretNumber){
            Console.WriteLine($"{4 - count} Guesses left to guess the secret number...Try higer");
        }
        if (int.Parse(guess) > secretNumber){
        Console.WriteLine($"{4 - count} Guesses left to guess the secret number...Try lower");
        }
    }
    else {
        Console.WriteLine("Dang, I was having fun...");
    }
}

