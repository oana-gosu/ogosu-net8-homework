// See https://aka.ms/new-console-template for more information
//Exercise 1
using System.Diagnostics.Metrics;

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
    }
}

else
{
    if (second >= third)
    {
        Console.WriteLine("Minimum is " + third);
        Console.WriteLine("Maximum is " + first);
    }
    else if (first <= third)
    {
        Console.WriteLine("Minimum is " + second);
        Console.WriteLine("maximum is " + third);
    }
    else
    {
        Console.WriteLine("Minimum is " + second);
        Console.WriteLine("maximum is " + first);
    }
}

//Exercise 2
int max, min;
max = (first > second && first > third) ?
                first : (second > third) ? second : third;

Console.WriteLine("Maximum is " + max);
min = (first < second && first < third) ?
                first : (second < third) ? second : third;
Console.WriteLine("minimum is " + min);

// Exercise 3
Console.WriteLine("Input no of days: ");
int no = Convert.ToInt32(Console.ReadLine());
int years = no / 365;
int months = (no % 365) / 30;
int days = (no % 365) % 30;
//if (years == 1)
//{
//    Console.WriteLine(years + "year"); }


//if (months == 1)
//{ 
//    {
//        Console.WriteLine(months + "month");
//    }
//    if (days == 1)
//    {
//        Console.WriteLine(days + "day");
//    }
//    else { Console.WriteLine(days + "days"); }

//}
//else { Console.WriteLine(months + "months"); }
//else
//{
//    Console.WriteLine(years + "years");
//    Console.WriteLine(months + "months");
//    Console.WriteLine(days + "days");
//} am incercat sa acopar cazurile in care rezultatul da an, luna, zi, dar m-am incurcat din nou in paranteze...

Console.WriteLine(years + "years");
Console.WriteLine(months + "months");
Console.WriteLine(days + "days");

// Exercise 4
Console.WriteLine("Enter the Physics mark:");
int Pm =  Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the Chemistry mark:");
int Cm = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the Biology mark:");
int Bm =  Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the Mathematics mark:");
int Mm =  Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the Computer Science mark:");
int CSm =  Convert.ToInt32(Console.ReadLine());
int Percentage = (Pm + Cm + Bm + Mm +CSm) / 5;
Console.WriteLine("Percentage is " + Percentage);
if (Percentage>=90)
{
    Console.WriteLine("Grade is A");
}
else if (Percentage>=80)
{
    Console.WriteLine("Grade is B");
}
else if(Percentage>=70)
{
    Console.WriteLine("Grade is C");
}
else if (Percentage>=60)
{
    Console.WriteLine("Grade is D");
}
else if (Percentage>=40)
{
    Console.WriteLine("Grade is E");
}
else
{
    Console.WriteLine("Grade is F");
}

//Exercise 5
Console.WriteLine("Input grade");
var grade = Console.ReadLine();
if (grade == "E") 
{
    Console.WriteLine("Excellent");
}
if (grade == "V")
{
    Console.WriteLine("Very Good");
}
if (grade == "G")
{
    Console.WriteLine("Good");
}
if (grade == "A")
{
    Console.WriteLine("Average");
}
if (grade == "F")
{
    Console.WriteLine("Fail");
}

//Exercise 6
Console.WriteLine("Input Temp");
int Temp = Convert.ToInt32(Console.ReadLine());
if (Temp<0)
    {
    Console.WriteLine("Freezing weather");
}
if (Temp>=0 && Temp<10)
{
    Console.WriteLine("Very Cold weather");
}
if (Temp>=10 && Temp<20)
{
    Console.WriteLine("Cold weather");
}
if (Temp >=20 && Temp<30)
{
    Console.WriteLine("Normal in Temp");
}
if (Temp>=30 && Temp<40)
{
    Console.WriteLine("Its Hot");
}
if (Temp>=40)
{
    Console.WriteLine("Its Very Hot");
}

