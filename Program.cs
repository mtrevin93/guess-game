using System;


// Phase 8
// The program should be updated to...
// 1. Add a difficulty level of "Cheater" which will cause the program to continue prompting the user until they get the answer correct.

int count = 0;
bool isCheater = false;

Console.WriteLine("Pick a difficulty level...(Easy, Medium, Hard)");
string difficulty = Console.ReadLine().ToLower();
if (difficulty == "easy"){
    count = 0;
}
if (difficulty == "medium"){
    count = 2;
}
if (difficulty == "hard"){
    count = 4;
}
if (difficulty == "cheater"){
    isCheater = true;
}

Console.WriteLine($"{difficulty} mode! Guess the secret number...I'm not telling");

string guess = "0";
int secretNumber = new Random().Next(1,100);

while (int.Parse(guess) != secretNumber && count < 8){
    guess = Console.ReadLine();
    Console.WriteLine();
    if (int.Parse(guess) != secretNumber){
        Console.WriteLine($"Nope!");
        if (!isCheater){
            if (count < 8)
            count ++;
            if (count == 8){
                Console.WriteLine("Out of guesses! Too bad, so sad!");
                break;
            }
            if (int.Parse(guess) < secretNumber){
                Console.WriteLine($"{8 - count} Guesses left to guess the secret number...Try higer");
            }
            if (int.Parse(guess) > secretNumber){
            Console.WriteLine($"{8 - count} Guesses left to guess the secret number...Try lower");
            }
        }
        if (isCheater){
            if (int.Parse(guess) < secretNumber){
                Console.WriteLine("Guess however many times you want, you cheat...Try higher");
            }
            if (int.Parse(guess) > secretNumber){
            Console.WriteLine("Guesses however many times you want, you cheat...Try lower");
            }
        }
    }
    else {
        Console.WriteLine("Dang, I was having fun...");
    }
}

