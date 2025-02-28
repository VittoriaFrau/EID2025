using System.Collections;

string italianHi = "Ciao";
string danishHi = "Hej";
int myFavouriteNumber;


int[] numbers = {1, 2, 3};
int[] numbersSecond;

numbers = new[] { 3, 4, 5, 6 };


myFavouriteNumber = 7;
Console.WriteLine(danishHi);


ArrayList pets = new ArrayList();
pets.Add("Baloo");
pets.Add("Nemo");
pets.Add("Line");

pets.Sort();

for (int i = 0; i < pets.Count; i++)
{
    Console.WriteLine(pets[i]);
}

foreach (var pet in pets)
{
    Console.WriteLine(pet);
}