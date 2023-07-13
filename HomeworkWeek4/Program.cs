using HomeworkWeek4;

Console.WriteLine("----------Ex1-------------");



Crop porumb =new Crop("Porumb");
porumb.Water();
porumb.Water();
porumb.Water();
porumb.Water();
Console.WriteLine(porumb.currentStage);
porumb.Harvest();
Console.WriteLine(porumb.currentStage);


Console.WriteLine("----------Ex2-------------");
Farm Liliacul = new Farm("Liliacul", 20, 7);
Liliacul.AddAnimals();
Console.WriteLine("Numarul de animale este: " + " " + Liliacul.animalCount);
Liliacul.density = Liliacul.CalculateDensity();
Console.WriteLine("Densitatea animalelor este: " + Liliacul.density);

Console.WriteLine("----------Ex3-------------");
Book book = new Book("War and Peace", "Lev Tolstoy", 1869);

Console.WriteLine(book.GetTitle()); 
Console.WriteLine(book.GetAuthor()); 
Console.WriteLine(book.GetYear());

book.SetTitle("Anna Karenina");
book.SetAuthor("Lev Tolstoy");
book.SetYear(1877);
Console.WriteLine(book.GetTitle()); 
Console.WriteLine(book.GetAuthor()); 
Console.WriteLine(book.GetYear());

Console.WriteLine("----------Ex4-------------");
Product product = new Product("Apple", 0.99, 10);

Console.WriteLine(product.GetName()); 
Console.WriteLine(product.GetPrice()); 
Console.WriteLine(product.GetQuantity()); 

product.SetName("Orange");
product.SetPrice(1.49);
product.SetQuantity(20);

Console.WriteLine(product.GetName()); 
Console.WriteLine(product.GetPrice()); 
Console.WriteLine(product.GetQuantity());

Console.WriteLine("----------Ex5-------------");
Animal animal = new Animal("Max", "Dog", "Labrador Retriever", 2, "Yellow", 75, true);

Console.WriteLine(animal.GetName());
Console.WriteLine(animal.GetSpecies()); 
Console.WriteLine(animal.GetBreed()); 
Console.WriteLine(animal.GetAge()); 
Console.WriteLine(animal.GetColor()); 
Console.WriteLine(animal.GetWeight()); 
Console.WriteLine(animal.IsSpayedOrNeutered()); 

animal.SetName("Buddy");
animal.SetSpecies("Cat");
animal.SetBreed("Siamese");
animal.SetAge(5);
animal.SetColor("Gray");
animal.SetWeight(12);
animal.SetIsSpayedOrNeutered(false);

Console.WriteLine(animal.GetName()); 
Console.WriteLine(animal.GetSpecies()); 
Console.WriteLine(animal.GetBreed()); 
Console.WriteLine(animal.GetAge()); 
Console.WriteLine(animal.GetColor()); 
Console.WriteLine(animal.GetWeight()); 
Console.WriteLine(animal.IsSpayedOrNeutered());

Console.WriteLine("----------Ex6-------------");
Calculator calculator = new Calculator();

Console.WriteLine(calculator.Add(2, 3)); 
Console.WriteLine(calculator.Subtract(5, 2)); 
Console.WriteLine(calculator.Multiply(3, 4)); 
Console.WriteLine(calculator.Divide(10, 5)); 
Console.WriteLine(calculator.Power(2, 3)); 
Console.WriteLine(calculator.SquareRoot(9));

Console.WriteLine("----------Ex7-------------");
University myUniversity = new University("My University");

Student john = new Student("John", "Doe", 123456, 3.8);
Student jane = new Student("Jane", "Smith", 654321, 3.6);

 myUniversity.AddStudent(john);
myUniversity.AddStudent(jane);
Faculty mary = new Faculty("Mary", "Jones", 111111, new string[] { "Math", "Physics" });
Faculty bob = new Faculty("Bob", "Smith", 222222,new string[] {"English", "History"});

myUniversity.AddFaculty(mary);
myUniversity.AddFaculty(bob);

Console.WriteLine(myUniversity.GetStudentCount()); 
Console.WriteLine(myUniversity.GetFacultyCount());


Console.WriteLine("----------Ex8-------------");

// nu am mai avut timp sa il fac, din pacate...