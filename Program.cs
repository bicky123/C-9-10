// See https://aka.ms/new-console-template for more information

using CSharp9.Models9;
using System;

Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine("C# 9 Featurs\n");
/// init keyword

var initClass = new InitClass { Id = 6 };
//initClass.Id = 7;

///

///Record keyword


var testRecord = new TestRecord("Test", "Math"); //positional property def
var testRecord1 = testRecord with { Subject = "Science" }; //Nondestructive mutation
Console.WriteLine("ToString: " + testRecord1.ToString()); //overridden ToString()
(string name, string sub) = testRecord; //When you initialize variables, the deconstructor allows you to get the values of all parameters of the declared record;

//Value equality check
if (testRecord == testRecord1)
    Console.WriteLine("Same obj");
else
    Console.WriteLine("Object's are not same");

TestRecord testRecord2 = new ("Test", "Math"); //Fit and finish features || Fit and finish features

// Pattern

string str = "test";
if(str is string) //Type patterns
{
    Console.WriteLine("yes: Type patterns");
}

if(str is object or string) //Combining patterns
{
    Console.WriteLine("yes: Combining patterns");
}

if(str is not string) //Inverting patterns
{
    Console.WriteLine("yes: Inverting patterns");
}

///two more pattern
///Relational patterns
int age = 2;
decimal discount = age switch
{
   <= 2 => 1,
   < 6  => 0.5m,
   < 10 => 0.2m,
   _ => 0
};
///Patterns within patterns

if (initClass is InitClass { Id : > 5 })
{
    Console.WriteLine("Patterns within patterns");
}

///

    Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("\n\nC# 10 Featurs\n");
var test = new Record10 { Name = "Bicky", Roll = 2};

var test1 = test with { Name = "Sonu" };

Console.WriteLine(test.ToString());
if (test == test1)
    Console.WriteLine("Same obj");
else
    Console.WriteLine("Object's are not same");

Console.WriteLine(test.GetHashCode());
Console.WriteLine(test1.GetHashCode());
Console.ForegroundColor = ConsoleColor.White;