//task1
static void GreetUser(string name)
{
    Console.WriteLine($"Welcome to DOT1002, {name}!");
}

//task2
static void Main(string [] args)
{
double result = CalculateArea (5);
Console.WriteLine($"Area: {result}");
}

static double CalculateArea (double radius, double pi = 3.14)
{
    return pi * radius * radius;
}

//task3
     static void Main(string [] args)
{
    Console.WriteLine("Please enter your passwoord:");
    string userPassword = Console.ReadLine();
    bool result = IsValidPassword(userPassword);
    Console.WriteLine($"Is Password Valid? {result}");
}

static bool IsValidPassword(string input)
{
    if(input.Length >= 6)
    {
        return true;
    }
    else
    {
        return false;
    }
}

//task4
Console.WriteLine("Please enter Celcius:");
int userCelcius = Convert.ToInt32(Console.ReadLine());

double fahrenheitResult = CelciusToFahrenheit(userCelcius);
Console.WriteLine($"{userCelcius}C is {fahrenheitResult}F");

static double CelciusToFahrenheit( int celcius)
{
    double fahrenheit = (celcius * 9.0 / 5.0) + 32;
    return fahrenheit;
}


//task5
Console.WriteLine("Please enter midterm:");
string midtermTitle = Console.ReadLine();

Console.WriteLine("Please enter a1:");
int assignment1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please enter a2:");
int assignment2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please emeter a3: ");
int assignment3 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please enter misterm:");
int midtermExam = Convert.ToInt32(Console.ReadLine());

PrintReport(midtermTitle, assignment1, assignment2, assignment3, midtermExam);

static void PrintReport(string title, int a1, int a2,int a3, int midterm)
{
    double rawScore = (a1 * 0.1) + (a2 * 0.1) + (a3 * 0.1) + (midterm * 0.7);
    int finalScore = Convert.ToInt32(rawScore);

    Console.WriteLine($"----{title}----");
    Console.WriteLine($"Assignment 1: {a1}");
    Console.WriteLine($"Assignment 2: {a2}");
    Console.WriteLine($"Assignment 3: {a3}");
    Console.WriteLine($"Midterm Score: {midterm}");
    Console.WriteLine($"Result for {title}: {finalScore}");
}