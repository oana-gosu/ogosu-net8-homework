// See https://aka.ms/new-console-template for more information
using System;
using System.Linq.Expressions;

Console.WriteLine("-------Ex1---------");
int[] numbers = new int[]{1, 3, 2, 6, 12};
int sum = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] %2 ==0) { sum = sum+ numbers[i];}
}
Console.WriteLine("Suma nr pare este " + sum);

Console.WriteLine("--------Ex2---------");
int[] numb = new int[] { 6, 3, 4, 3, 6 };
for (int i = 0; i <= (numbers.Length-1); i++)
{
    
   for (int j = i+1; j < numbers.Length; j++)
    if (numb[i]  == numb[j]) { Console.WriteLine(numb[i]); }
}


Console.WriteLine("-------Ex3------");
var litere = new List<string>() { "a", "b", "b", "c", "c", "d" };
for (int i = 1;i<=litere.Count-1;i++)
{
    if (litere[i-1] == litere[i])
    {
        litere.RemoveAt(i);
        i--;
    }
}
for (int i = 0; i < litere.Count; i++)
{
    Console.WriteLine(litere[i]);
}

Console.WriteLine("-------Ex4------");

int[] newnumb = new int[] { 1, 4, 5, 2, 1, 4, 3, 1, 2 };
for (int i = 0; i < newnumb.Length; i++)
{
    int count = 1;
    for (int j = i + 1; j < newnumb.Length; j++)
    {
        if (newnumb[i] == newnumb[j])
        {
           
            count++;
        }
    }
    Console.WriteLine("Numarul " +newnumb[i] + " apare de " + count + " ori");

}


//stiu ca ar trebui sa sara atunci cand ajunge la un numar pe care l-a numarat deja, dar inca nu stiu cum sa fac asta

Console.WriteLine("-------Ex5------");
List<int> numere = new List<int>();
List<int> even = new List<int>();
List<int> odd = new List<int>();
Console.WriteLine("Introduceti numarul de elemente ");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i<=n; i++)
{
    Console.WriteLine("Introduceti element:");
    numere.Add(Convert.ToInt32(Console.ReadLine()));

}
for (int i = 0; i< numere.Count;i++)
{
    if (numere[i]%2 == 0)
    {
        even.Add(numere[i]);
    }
    else odd.Add(numere[i]);
}
Console.WriteLine("Numerele impare:");
for (int i=0; i<odd.Count;i++)
{
    Console.WriteLine(odd[i]);
}
Console.WriteLine("Numerele pare:");
for (int i = 0; i < even.Count; i++)
{
    Console.WriteLine(even[i]);
}
//probabil se poate face si cu array-uri, dar mi s-a parut mult mai simplu cu liste


Console.WriteLine("-------- Ex6-------");
Console.WriteLine("Input first no ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second no");
int b= Convert.ToInt32(Console.ReadLine());
List<int> colectie = new List<int>();
Console.WriteLine("Colectia este: ");
if (a<b)
{
    for (int i =a; i<=b; i++)
    {
        colectie.Add(i);
        Console.WriteLine(i);
    }
}

else
{
    for (int i = b; i <= a; i++)
    {
        colectie.Add(i);
        Console.WriteLine(i);
    }

}
Console.WriteLine("Divizibele la 3:");
foreach (int element in colectie)
{
    if (element%3 == 0)
    {
        Console.WriteLine(element);
    }
}

Console.WriteLine("-------- Ex7-------");
List<int> altaLista = new List<int>();
for (int i=123; i<=234; i++)
{
    altaLista.Add(i);
}
foreach(int element in altaLista)
{
    if (element%3 == 0 && element%5 ==0)
    {
        Console.WriteLine(element + " FizzBuzz");
        
    }
    else if (element%3 == 0)
    {
        Console.WriteLine(element + " Fizz");
       
    }
    else if (element%5 == 0) 
    {
        Console.WriteLine(element + " Buzz");
       
    }
else Console.WriteLine(element);
}

Console.WriteLine("-------- Ex8-------");
List<string> nume =  new List<string>();
for (int i=1; i<=10; i++)
{
    Console.WriteLine("Input name:");
    nume.Add(Console.ReadLine());
}
Console.WriteLine("Primele 6 nume sunt: ");
int index = 0;
while (index<=5)
{
    Console.WriteLine(nume[index]);
    index++;
}


Console.WriteLine("-------- Ex9-------");
int altNumar;
do
{
    Console.WriteLine("Input no ");
    altNumar = Convert.ToInt32(Console.ReadLine());
} while (altNumar != 0);


Console.WriteLine("-------- Ex10-------");
int k = -1;
do
{
    Console.WriteLine(k);

    if (k % 21 == 0)
    {
        break;
    }
    k--;
} while (k >= -123);

Console.WriteLine("-------- Ex11-------");
int iterator=1;
List<string> list = new List<string>();
while (iterator<=10)
{
    Console.WriteLine("Input name");
    list.Add(Console.ReadLine());
    iterator++;
}
foreach (string s in list)
{
    if (s.StartsWith("a") || s.StartsWith("b") || s.StartsWith("A") || s.StartsWith("B"))
    { continue; }
    Console.WriteLine(s);
}
