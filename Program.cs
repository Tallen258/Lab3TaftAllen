// See https://aka.ms/new-console-template for more information
// While loop
while (true)
{
    Console.WriteLine("choose a number between 10 and 99");
    string userInput = Console.ReadLine();
    if (userInput == "exit")
    {

        Console.WriteLine("Thank You for playing");
        break;
    }

    int usernumber = int.Parse(userInput);
    if (usernumber >= 10 && usernumber <= 99 && usernumber == 23 || usernumber == 46 || usernumber == 69 || usernumber == 92)
    {
        Console.WriteLine("yes");
        ConsoleColor background = Console.BackgroundColor;
        Console.BackgroundColor = ConsoleColor.Green;
        Console.Clear();
        break;
    }
    else if (usernumber >= 10 && usernumber <= 99 && usernumber != 23 && usernumber != 46 && usernumber != 69 && usernumber != 92)
    {
        Console.BackgroundColor = ConsoleColor.Red;
        Console.Clear();
        break;
    }

    else
    {
        Console.WriteLine("invalid number");
    }


}

do
{
    Console.WriteLine("choose a Number between 10 and 99");
    string secondInput = Console.ReadLine();
    if (secondInput == "exit")
    {
        Console.WriteLine("Thank You for playing");
        break;
    }
    int secondNumber = int.Parse(secondInput);
    if (secondNumber >= 10 && secondNumber <= 99 && secondNumber == 34 || secondNumber == 68)
    {
        Console.WriteLine("yes");
        ConsoleColor background = Console.BackgroundColor;
        Console.BackgroundColor = ConsoleColor.Green;
        Console.Clear();
        break;
    }
    else if (secondNumber >= 10 && secondNumber <= 99 && secondNumber != 34 && secondNumber != 68)
    {
        Console.BackgroundColor = ConsoleColor.Red;
        Console.Clear();
        break;
    }
    else
    {
        Console.WriteLine("invalid number");
    }

} while (true);

// for loop
for (; ; )
{
    Console.WriteLine("choose a Number between 10 and 99");
    string thirdNumber = Console.ReadLine();
    if (thirdNumber == "exit")
    {
        Console.WriteLine("Thank You for playing");
        break;
    }
    int thirdInput = int.Parse(thirdNumber);
    if (thirdInput >= 10 && thirdInput <= 99 && thirdInput == 33 || thirdInput == 66 || thirdInput == 99)
    {
        Console.WriteLine("yes");
        ConsoleColor background = Console.BackgroundColor;
        Console.BackgroundColor = ConsoleColor.Green;
        Console.Clear();
        break;

    }

    else if (thirdInput >= 10 && thirdInput <= 99 && thirdInput != 33 && thirdInput != 66 && thirdInput != 99)
    {

        Console.BackgroundColor = ConsoleColor.Red;
        Console.Clear();
        break;
    }
    else
    {
        Console.WriteLine("invalid number");
    }


}
while (true)
{
    // giving options using a switch statement
    Console.WriteLine("case 1 is for addition");
    Console.WriteLine("case 2 is for subtraction");
    Console.WriteLine("case 3 is for multiplication");
    Console.WriteLine("case 4 is for division");
Console.WriteLine("please choose what you would like to do");
    string switchnumbers = Console.ReadLine();
    int switchInput = int.Parse(switchnumbers);

    switch (switchInput)
    {
        case 1: { 
Console.WriteLine("enter first number");
            int a = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("enter second number");
            int b = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Addition of two numbers : "+(a+b));
            
Console.ReadLine();

    break;
        }
        case 2:{
Console.WriteLine("enter first number");
            int a = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("enter second number");
           
            int b = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Addition of two numbers : "+(a-b));

            break;
        }
        case 3:{
            Console.WriteLine("enter first number");
            int a = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("enter second number");
           
            int b = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Addition of two numbers : "+(a*b));

            break;
        }
        case 4:{
            Console.WriteLine("enter first number");
            int a = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("enter second number");
           
            int b = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Addition of two numbers : "+(a/b));

            break;
        }
      
        default: 

            break;

    }
}

