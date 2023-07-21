using System.Transactions;
using System;
using Week5.Ex1;
using Week5.Ex2;
using Week5.Ex3;
using Week5.Ex4;
using Week5.Ex5;
using Week5.Ex6;

Console.WriteLine("------------Ex1----------");

BankAccount myAccount = new BankAccount(123456, "John Doe", 1000);

myAccount.Deposit(500);
myAccount.Withdraw(200);

Console.WriteLine(myAccount.GetBalance()); // Outputs 1300

List<Transactions> transactions = myAccount.GetTransactionsHistory();
foreach (Transactions transaction in transactions)
{
    Console.WriteLine($"{transaction.TimeStamp}: {transaction.Type} ${transaction.Amount}");
}

/* Outputs:
[Timestamp of first transaction]: Deposited $500
[Timestamp of second transaction]: Withdrew $200
*/

myAccount.AccountNumber = 654321;
myAccount.AccountHolder = "Jane Smith";

Console.WriteLine(myAccount.AccountNumber); // Outputs 654321
Console.WriteLine(myAccount.AccountHolder); // Outputs "Jane Smith

Console.WriteLine("------------Ex2----------");

Book book = new Book("The Great Gatsby", "F. Scott Fitzgerald", 180);

Console.WriteLine(book.GetTitle()); // Outputs "The Great Gatsby"
Console.WriteLine(book.GetAuthor()); // Outputs "F. Scott Fitzgerald"
Console.WriteLine(book.GetPageCount()); // Outputs 180
Console.WriteLine(book.GetCurrentPage()); // Outputs 1

book.NextPage();
Console.WriteLine(book.GetCurrentPage()); // Outputs 2

book.NextPage();
book.NextPage();
book.NextPage();
Console.WriteLine(book.GetCurrentPage()); // Outputs 5

book.PreviousPage();
Console.WriteLine(book.GetCurrentPage());
book.title = "The Great Gatsby (Revised Edition)";
Console.WriteLine(book.GetTitle()); // Outputs "The Great Gatsby (Revised Edition)"

book.author = "F. Scott Fitzgerald (Revised by Jane Doe)";
Console.WriteLine(book.GetAuthor()); // Outputs "F. Scott Fitzgerald (Revised by Jane Doe)"

Console.WriteLine("------------Ex3----------");

Rectangle rectangle1 = new Rectangle("Green", 6, 8);
Rectangle rectangle2 = new Rectangle("Yellow", 10, 12);
Console.WriteLine(rectangle1.CalculateArea());
Circle circle1 = new Circle("Purple", 3);
Circle circle2 = new Circle("Orange", 5);
Console.WriteLine(circle1.CalculateArea());

List<Shape> shapes = new List<Shape> { rectangle1, rectangle2, circle1, circle2 };

foreach (Shape shape in shapes)
{
    shape.CalculateArea();
}

shapes.Sort((shape1, shape2) => shape2.Area.CompareTo(shape1.Area));

foreach (Shape shape in shapes)
{
    Console.WriteLine(shape.Color + ": " + shape.Area);
}

// stiu ca aici nu afiseaza rezultatul calculului ariilor, dar am verificat metodele si functioneaza 

double totalPerimeter = 0;
foreach (Shape shape in shapes)
{
    totalPerimeter += shape.GetPerimeter();
}

Console.WriteLine("Total perimeter: " + totalPerimeter + " inches");



Console.WriteLine("------------EX4---------------");
//Manager manager = new Manager("John Doe", 35, 50000, Department.IT);
//Developer developer = new Developer("Jane Smith", 28, 30000, new List<string> { "C#", "JavaScript" }, false);

//Console.WriteLine(manager.CalculateBonus()); // Outputs 5000
//Console.WriteLine(developer.CalculateBonus()); // Outputs 6000

//Console.WriteLine(manager.GetContactInfo()); // Outputs "Name: John Doe, Age: 35, Department: IT, Email: john.d



Console.WriteLine("------------EX5---------------");
NewBankAccount account1 = new NewBankAccount(123456, "John Doe", 1000);
NewBankAccount account2 = new NewBankAccount(654321, "Jane Smith", 2000);

account1.Deposit(500);
account2.Withdraw(1000);

Console.WriteLine(account1.Balance); // Outputs 1500
Console.WriteLine(account2.Balance); // Outputs 1000

Console.WriteLine("------------EX6---------------");

IShape circle = new NewCircle(5, "yellow");
IShape rectangle = new NewRectangle(10, 5);

Console.WriteLine(circle.CalculateArea()); // Outputs 78.5398163397448
Console.WriteLine(rectangle.CalculateArea()); // Outputs 50

//Console.WriteLine(circle.CalculateArea("square feet")); // Outputs "Area: 78.5398163397448 square feet"
//Console.WriteLine(rectangle.CalculateArea("square meters")); // Outputs "Area: 50 square meters"

IColor circleColor = (IColor)circle;
circleColor.Color = "Red";

IColor rectangleColor = (IColor)rectangle;
rectangleColor.Color = "Blue";

Console.WriteLine(circleColor.Color); // Outputs "Red"
Console.WriteLine(rectangleColor.Color); // Outputs "Blue"