var quit = false;
while (!quit)
{



    Console.Write("Enter an integer: ");
    var answer = Console.ReadLine();
    Console.WriteLine($"Answer is {answer}");
    var number = Convert.ToInt32(answer);


    string evenOrOdd;
    if (number % 2 == 0)
    {
        evenOrOdd = "Even";
    }
    else
    {
        evenOrOdd = "Odd";
    }

    Console.WriteLine($"The number is {number} is {evenOrOdd}");

    Console.WriteLine("Do you want to quit? (Y/N) :");
    var quitAnswer = Console.ReadLine();
    if (quitAnswer == "Y" || quitAnswer == "y")
    {
        quit = true;
    }
}

Console.WriteLine("Done...");