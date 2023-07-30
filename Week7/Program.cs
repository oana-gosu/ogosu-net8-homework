
using Week7.Ex1;
using Week7.Ex2;
using Week7.Ex3;
using Week7.Ex5;
using Week7.Ex6;
using Week7.Ex9;
using Week7.Ex10;

Console.WriteLine("------Ex1------");

Console.WriteLine("Input date: ");
DateTime inputDate = DateTime.Parse(Console.ReadLine());
bool DateOK(DateTime imputDate)
{
    if (inputDate >= DateTime.Now)
    {
        return true;
    }
    else
    {
        throw new InvalidDateException("Date must be in the future");
    }
}
try 
{
    if (DateOK(inputDate))
    {
        Console.WriteLine("Date OK!");
    }
}
catch 
{
    Console.WriteLine("Date must be in the future!");
}

    

Console.WriteLine("----- Ex2-------");
Console.WriteLine("Input name: ");
string name = Console.ReadLine();
bool NameOK(string name)
{
    if (name != " ")
    {
        return true;
    }
    else
    {
        throw new BlankNameException("Name cannot be blank!");
    }
}
try 
{
    if (NameOK(name)) 
    {
        Console.WriteLine("Name OK");
    }
}
catch 
{
    Console.WriteLine("Name cannot be blank!");
}


Console.WriteLine("-----Ex3-----");
List<int> numbers = new List<int> { };

try 
{
    for (int i = 1; i <= 5; i++)
    {
        Console.WriteLine("Input no");
        numbers.Add(int.Parse(Console.ReadLine()));
    }
    int suma = numbers.Sum();
    Console.WriteLine("The sum is: " + suma);
    double media = numbers.Average();
    Console.WriteLine("The average is: " + media);
}
catch (FormatException ex)
{
    Console.WriteLine("Input was not in correct format");
}
catch (OverflowException ex)
{
    Console.WriteLine("Arithmetic operation resulted in an overflow.");
}
catch (DevideByZeroException ex)
{

}

Console.WriteLine("-------Ex4------");
Console.WriteLine("Enter the name of the file: ");
string fileName = Console.ReadLine();
string path = @"C:\\Users\\Oana\\OneDrive\\Documents\\GitHub\\ogosu-net8-homework\\Week7\\" + fileName;

bool fileExists = File.Exists(path);
try 
{
    if (!fileExists)
    {
        Console.WriteLine("File does not exist.");
        Console.WriteLine("Enter some text to write to the file:");
        string textToFile = Console.ReadLine();
        File.WriteAllText(path, textToFile);
        Console.WriteLine("File contents:");
        Console.WriteLine(File.ReadAllText(path));
    
    }
    else
    {
        if (File.ReadAllText(path) == "")
        {
            Console.WriteLine("File is empty.");
            Console.WriteLine("Enter some text to write to the file:");
            string textToFile = Console.ReadLine();
            File.AppendAllText(path, textToFile);
            Console.WriteLine("File contents:");
            Console.WriteLine(File.ReadAllText(path));
        }
        else
        {
            Console.WriteLine("File contents:");
            Console.WriteLine(File.ReadAllText(path));
        }
    }
}
catch (IOException ex)
{
    Console.WriteLine("IO Exception!");

}

Console.WriteLine("------Ex5------");
DateTime dateTime = DateTime.Now;
Console.WriteLine(dateTime.ToFullDate());

Console.WriteLine("-------Ex6-------");

Console.WriteLine("Input no: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(number.ToBinary());

Console.WriteLine("-----Ex7-----");

List<int> ints = new List<int> { 1, 17, 22, 45, 142};
var result = ints.Where(i => i % 2 == 0)
                 .Sum(i => i * i);
Console.WriteLine(result);


Console.WriteLine("-----Ex8-----");

List<int> numere = new List<int> { 2, 5, 12, 7, 34 };
var squares = numere.Select(x=> x*x)
                    .ToList();
foreach(int i in squares) { Console.Write(i + " "); }

Console.WriteLine(" ");
Console.WriteLine("------Ex9------");
var students = new List<Student> {
  new Student { Name = "Alice", Grade = "A" },
  new Student { Name = "Bob", Grade = "B" },
  new Student { Name = "Charlie", Grade = "A" },
  new Student { Name = "Dave", Grade = "C" }
};
var studentsResult = students.Where(s => s.Grade=="A")
                            .OrderByDescending(s => s.Name)
                            .ToList();
foreach(Student x in studentsResult) { Console.WriteLine(x.Name); }

Console.WriteLine("-----Ex10-----");
var products = new List<Product> {
  new Product { Name = "Product 1", Category = "Category 1", Price = 10 },
  new Product { Name = "Product 2", Category = "Category 2", Price = 20 },
  new Product { Name = "Product 3", Category = "Category 1", Price = 15 },
  new Product { Name = "Product 4", Category = "Category 3", Price = 5 },
  new Product { Name = "Product 5", Category = "Category 3", Price = 5 }
};
var orderedProducts = products.OrderBy(x => x.Name)
                              .OrderBy(x=> x.Price)
                              .OrderBy(x=> x.Category)
                              .ToList(); 

foreach(Product i in orderedProducts) { Console.WriteLine(i.Category + " "+i.Name+ " "+i.Price); }

Console.WriteLine("------Ex11------");
var avgPrices = products.GroupBy(x => x.Category)
    .Select(p => new
    {
        avgPrice = p.Average(x => x.Price),
        Category = p.Key
    })
    .OrderByDescending(x=>x.avgPrice);

foreach(var i in avgPrices) { Console.WriteLine(i.Category + " " + i.avgPrice); }







