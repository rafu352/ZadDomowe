/// zadanie domowe

string name = "Ewa";
string sex = "kobieta";
var age = 30;
if (sex == "kobieta" && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat.");
}
else if (sex == "kobieta" && name == "Ewa" && age == 30)
{
    Console.WriteLine("Ewa, lat 30.");
}
else if (sex != "kobieta" && age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna.");
}