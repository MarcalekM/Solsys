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

Console.Write("4. feladat:\nAdjon meg egy bolygó nevet:  ");
string bn = Console.ReadLine();
bool f4 = false;
foreach (Planet planet in planets)
{
    if (planet.Nev == bn) f4 = !f4;
}
if (f4) Console.WriteLine("\tMegtalálható a listában a keresett bolygó");
else Console.WriteLine("\tNem található meg a listában a keresett bolgyó");

Console.Write("5. feladat:\nAdjon meg egy számot:  ");
int hsz = int.Parse(Console.ReadLine());
var f5 = planets.Where(p => p.Holdak > hsz);
if (f5.Count() != 0)
{
    Console.WriteLine($"\tA következő bolygóknak van több mint {hsz} db holdja:");
    Console.Write("\t");
    foreach(var f in f5)
    {
        Console.Write($"'{f.Nev}'");
    }
}
else Console.WriteLine($"\tNincs a listában olyan bolygó, aminek több mint {hsz} db holdja van");