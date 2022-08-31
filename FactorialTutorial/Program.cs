
//cleaned up version of the one below

Console.WriteLine("Calculate Factorial");
var message = "Enter factorial to calculate or zero to exit.";
int factorialNumber = GetIntFromUser(message);

while (factorialNumber != 0)
{
    int factorial = 1;

    for (var idx = 1; idx <= factorialNumber; idx++)
    {
        factorial *= idx;
    }

    Console.WriteLine($"{factorialNumber}! is {factorial}");

    factorialNumber = GetIntFromUser(message);
}

int GetIntFromUser(string message)
{
    Console.Write($"{message}: ");
    string response = Console.ReadLine();
    int resp = Convert.ToInt32(response);
    return resp;
}

/*  This is the original

Console.WriteLine("Calculate Factorial");

int again = -1;
do
{
    int factorialNumber = GetIntFromUser("Enter factorial to caclulate");
    int factorial = 1;

    for (int idx = 1; idx <= factorialNumber; idx++)
    {
        factorial *= idx;
    }

    Console.WriteLine($"{factorialNumber} is {factorial}");

    again = GetIntFromUser("Enter 0 to quit");
}
while (again != 0);

int GetIntFromUser(string message)
{
    Console.Write($"{message}: ");
    string response = Console.ReadLine();
    int resp = Convert.ToInt32(response);
    return resp;
}
*/