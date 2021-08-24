using System;


// Phase 5
// The program should be updated to...
// 1. Use a random number between 1 and 100 instead of a hard-coded number.
// 2. The prompt should display the number of guesses the user has left.
// Phase 6
// The program should be updated to...
// 1. Inform the user if their guess was too high or too low, when they guess incorrectly.
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
int secretNumber = 42;

while (int.Parse(guess) != secretNumber && count < 4){
    guess = Console.ReadLine();
    Console.WriteLine();
    if (int.Parse(guess) != secretNumber){
        Console.WriteLine($"Nope!");
        if (count < 4)
        count ++;
        Console.WriteLine($"{4 - count} Guesses left to guess the secret number...");
    }
    else {
        Console.WriteLine("Dang, I was having fun...");
    }
}

