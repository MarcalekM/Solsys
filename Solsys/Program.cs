using Solsys;

List<Planet> planets = new();
using StreamReader sr = new(
    path: @"..\..\..\src.solsys.txt",
    encoding: System.Text.Encoding.UTF8);
while (!sr.EndOfStream) planets.Add(new(sr.ReadLine()));

Console.WriteLine("1. feladat:");
Console.WriteLine($"\t{planets.Count} db bolygü van a naprendszerben\n");

Console.WriteLine("2. feladat:");
double atlagHold = 0;
foreach (Planet planet in planets)
{
    atlagHold += planet.Holdak;
}
atlagHold /= planets.Count;
Console.WriteLine($"\tA naprendszer egy bolgyójának átlegosan {atlagHold} db holdja van\n");