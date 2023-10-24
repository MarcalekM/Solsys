using Solsys;

List<Planet> planets = new();
using StreamReader sr = new(
    path: @"..\..\..\src\solsys.txt",
    encoding: System.Text.Encoding.UTF8);
while (!sr.EndOfStream) planets.Add(new(sr.ReadLine()));

Console.WriteLine("1. feladat:");
Console.WriteLine($"\t{planets.Count} db bolygü van a naprendszerben\n");

Console.WriteLine("2. feladat:");
var f2 = planets.Average(x => x.Holdak);
Console.WriteLine($"\tA naprendszer egy bolgyójának átlegosan {f2} db holdja van\n");

Console.WriteLine("3. feladat:");
var f3 = planets.OrderByDescending(p => p.Terfogat)
                         .First();                        
Console.WriteLine($"\tA legnagyobb bolygó a {f3.Nev}");