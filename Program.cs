// See https://aka.ms/new-console-template for more information
using FactoryDesignExample;

Console.WriteLine("Hello, World!");

var input = Console.ReadLine();

WrestlingFactory wrestlingFactory = new WrestlingFactory();
Wrestler output = wrestlingFactory.GetWrestler(input); 

Console.WriteLine();
Console.WriteLine("Name: " + output.GetName());
Console.WriteLine("Gender: " + output.GetGender());
Console.WriteLine("Faction: " + output.GetFaction());
Console.WriteLine("Title: " + output.GetTitles());