int n = 25;
decimal divider = 1;
decimal e = 0;


// Goes through every number up to the value that n has been set to
for (int i = 0; i <= n; n--)
{
    divider = 1;
    // Gets the factorial of the current number
    for (int j = n; j != 0; j--)
    {
        divider *= j;
    }

    // Adds 1/n! to the value of e
    e += 1 / divider;
}

Console.WriteLine(e);
Console.ReadLine();