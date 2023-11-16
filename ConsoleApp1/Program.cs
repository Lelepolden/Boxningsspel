using System.Linq.Expressions;
using System.Runtime.CompilerServices;

Console.WriteLine("Välkommen till Spelet Skriv starta för att spela eller avsluta om du inte vill.");
string starta = Console.ReadLine();
if (starta == "starta")
{
    Console.WriteLine("Skriv ditt användarnamn");
}
else if (starta == "Starta")
{
    Console.WriteLine("Skriv ditt användarnamn");
}
else return;
string p1name = Console.ReadLine();

Console.WriteLine("skriv andra spelarens användarnamn.");
string p2name = Console.ReadLine();

int p1HP = 100;
int p2HP = 100;

Random generator = new Random();

Console.WriteLine("Båda spelarna börjar med 100 HP");

while (p1HP > 0 && p2HP > 0){
    Console.WriteLine($"Nästa Runda.");
Console.ReadLine();

int damage1 = generator.Next(-20,51);
p2HP = p2HP - damage1;
if (damage1 < 0 && p2HP < 100){
    Console.WriteLine($"{p1name} missade sin attack och {p2name} healade {damage1}hp");
}
else {
Console.WriteLine($"{p1name} gör {damage1} damage på {p2name}!");
}
int damage2 = generator.Next(-20,51);
p1HP = p1HP - damage2;
if (damage2 < 0 && p1HP < 100){
    Console.WriteLine($"{p2name} missade sin attack och {p1name} healade {damage2}hp");
}
else {
Console.WriteLine($"{p2name} gör {damage2} damage på {p1name}!");
}
Console.WriteLine($"{p1name} har {p1HP}hp   |   {p2name} har {p2HP}hp");
Console.ReadLine();
}

if (p1HP <= 0){
    Console.WriteLine($"{p2name} vann!");
}
if (p2HP <= 0){
    Console.WriteLine($"{p1name} vann!");
}
Console.ReadLine();