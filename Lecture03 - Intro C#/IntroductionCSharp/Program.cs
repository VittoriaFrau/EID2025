// Variables

using System.Collections;
using System.Globalization;

int myNum = 5;
double myDoubleNum = 5.99D;
char myLetter = 'D';
bool myBool = true;
string myText = "Hello";
float myFloat = 5.75F;

string[] myBoardGames = {"Unlock", "Victorian Mastermind", "Wonderbook"};
string[] myMovies = new string[3] {"The Lord of The Rings", "Dead Poets Society", "Hidden Figures"};

//Access the elements
Console.WriteLine(myMovies[0]);

// Change an element
myBoardGames[0] = "Merchants Cove";

// length
Console.WriteLine(myBoardGames.Length);

//add an element to the array myboardgames
Array.Resize(ref myBoardGames, 4);
myBoardGames[3] = "Monopoli";

ArrayList myArray = new ArrayList();
 
myArray.Add(12.56);
myArray.Add("Hello World");
myArray.Add(null);
myArray.Add('V');
myArray.Add(1234);

foreach(var elements in myArray)
{
    Console.WriteLine(elements);
}


myArray.Remove('V');
Console.WriteLine(myArray.Count); // 4
myArray.Clear();
myArray.Sort(); 

string txt = "Hello World";
Console.WriteLine("The length of the txt string is: " + txt.Length);
Console.WriteLine(txt.ToUpper());   // Outputs "HELLO WORLD"
Console.WriteLine(txt.ToLower());   // Outputs "hello world"

Console.WriteLine("Hello " + "World"); //Concatenation through the + operator
Console.WriteLine("Hello \n World"); //New line

int year = 2025;

if (year > 2015)
{
    Console.WriteLine("Year is greater than 2015");
}
else
{
    Console.WriteLine("Year is not greater than 2015");
}

Console.WriteLine(year > 2015 ? "Year is greater than 2015" : "Year is not greater than 2015");

switch (year)
{
    case 2013 :
        Console.WriteLine("It's 2013!");
        break;
    case 2012 :
        Console.WriteLine("It's 2012!");
        break;
    default :
        Console.WriteLine("It's " + year + "!");
        break;
}

while (year >= 2013)
{
    // Code to be executed
}

do
{
    // Code to be executed
} while(year >= 2013);

string [] collection  = {"Hello", "World", "!"};

for (int i = 0; i < collection.Length; i++)
{
    Console.WriteLine(i);
}
foreach (var item in collection)
{
    Console.WriteLine(item);
}

// example of a method
int Sum(int a, int b)
{
    return a + b;
}

class User
{
    public string name;
    public int age;
    private string password;

    public User(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public void Greet()
    {
        Console.WriteLine("Hello, my name is " + name);
    }

    public void SetPassword(string password)
    {
        
    }

}

public class Boiler
{

    private int temperature;
    private Boolean status; //true on, false off
    public const int DEFAULT_TEMPERATURE = 25;

    public Boiler()
    {
        temperature = DEFAULT_TEMPERATURE;
        status = false;
    }

    public void turnOn()
    {
        if (status)
        {
            Console.WriteLine("Boiler is already on");
            return;
        }

        status = true;
    }

    public void turnOff()
    {
        if (!status)
        {
            Console.WriteLine("Boiler is already off");
            return;
        }

        status = false;
    }

    public void toggle()
    {
        status = !status;
    }

    public void increment()
    {
        increment(1);
    }

    public void increment(int n)
    {
        if (status)
        {
            temperature += n;
        }
    }

    public void printInformation()
    {
        String statusString = status ? "accesa" : "spenta";
        Console.WriteLine(
            "Status: " + statusString + ". Temperature: " + temperature + ".");
    }
}

