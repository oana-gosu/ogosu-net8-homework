// See https://aka.ms/new-console-template for more information
//Exercise 1
Console.WriteLine("Input first no:");
int first = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second no:");
int second = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input third no:");
int third = Convert.ToInt32(Console.ReadLine());
if (first <= second)
{
    if (second <= third)
    {
        Console.WriteLine("Minimum is " + first);
        Console.WriteLine("Maximum is " + third);
    }
    else if (first <= third) 
    {
        Console.WriteLine("Minimum is " + first);
        Console.WriteLine("Maximum is " + second);
    }
        else 
        {
        Console.WriteLine("Minimum is " + third);
        Console.WriteLine("Maximum is " + second);
    };

else if (first <= third) 
    {
        Console.WriteLine("Minimum is " + second);
        Console.WriteLine("Maximum is " + third);
    }
    else 
    {
        Console.WriteLine("Minimum is " + second);
        Console.WriteLine("maximum is " + first);
    }
}

