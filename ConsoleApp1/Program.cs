// See https://aka.ms/new-console-template for more information
using ConsoleApp1;




List<Adat> adatok = new();
using StreamReader sr = new(
    path: @"..\..\..\SRC\adatok.txt",
    encoding: System.Text.Encoding.UTF8);
while (!sr.EndOfStream) adatok.Add(new Adat(sr.ReadLine()));

Console.WriteLine(adatok.Count());


