//task1
Console.WriteLine("What is your name: ");
string userName = Console.ReadLine();
Console.Write($"Hello {userName}");

//task2
int firstNumber = Convert.ToInt32(Console.ReadLine());
int secondNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(firstNumber + secondNumber);

//task3
Console.WriteLine("Input 1:");
int numberFirst = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input 2 :");
int numberSecond = Convert.ToInt32( Console.ReadLine());

Console.WriteLine("Input 3: ");
string anOperation = Console.ReadLine();

if (anOperation == "add")
{
    int sum = numberFirst+numberSecond;
    Console.WriteLine($"Answer is: {sum} ({numberFirst} + {numberSecond} = {sum})");
}
else if (anOperation == "subtract")
{
    int substract= numberFirst - numberSecond;
    Console.WriteLine($" Answer is: {substract} ({numberFirst} - {numberSecond} = {substract}");
}
else if (anOperation == "multiply")
{
    int multiply = numberFirst * numberSecond;
    Console.WriteLine($"Answer is: {multiply} ({numberFirst} * {numberSecond}= {multiply})");
}

//task4
Console.WriteLine("Input 1: ");
double numberFirst = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input 2: ");
double numberSecond = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input 3: ");
string anOperation =Console.ReadLine();

if (anOperation == "add")
{
double sum = numberFirst + numberSecond;
  Console.WriteLine($"Answer is: {sum}");  
}
else if (anOperation == "subtract")
{
    double subtract = numberFirst - numberSecond;
    Console.WriteLine($"Answer is: {subtract}");
}
else if (anOperation == "multiply")
{
    double multiply = numberFirst * numberSecond;
    Console.WriteLine($"Answer is: {multiply}");
}
else if (anOperation == "divide")
{
    double divide = numberFirst / numberSecond;
    Console.WriteLine($"Answer is: {divide}");
}
else
 Console.WriteLine(" Input 3 is wrong type.");

 //task5
List<int>ResultVanDerPoel = [1, 2, 1];
List<int>ResultWoutAert = [3, 4, 3];
List<int>ResultMadsPetersan = [6,3,4];

double AverageVdp =ResultVanDerPoel.Average();
double AverageWa = ResultWoutAert.Average();
double AverageMp = ResultMadsPetersan.Average();

Console.WriteLine("Name: Standings -> Avarage Standşng");

Console.WriteLine($"Van Der Poel: -> {AverageVdp}");
Console.WriteLine($"Van Aert:  -> {AverageWa}");
Console.WriteLine($"Petersen:  -> {AverageMp}");

if (AverageVdp < AverageMp && AverageVdp < AverageWa)
{
    Console.WriteLine($"Winner is Van Der Poel and his avarage standing is {AverageVdp}");
}
else if (AverageMp < AverageVdp && AverageMp < AverageWa)
{
    Console.WriteLine($"Winner is Mads Petersen and hia avarage standing is {AverageMp}");
}
else if (AverageWa <AverageMp && AverageWa< AverageVdp)
{
    Console.WriteLine($"Winner is Van Aert nd his avarage standing is {AverageWa}");
}

//task6
Console.WriteLine("What is the name of the cyclist");
string cyclistName= Console.ReadLine();

Console.WriteLine("How many race did he finish?");
int races = Convert.ToInt32(Console.ReadLine());

List<int>results = [];
Console.WriteLine($"what are the results for {cyclistName}");

for ( int i = 0 ; i< races; i++)
{
    results.Add(Convert.ToInt32(Console.ReadLine()));
}
string tireler ="";
foreach (int result in results)
{
    tireler += $"{result}-";
}

Console.WriteLine($"Results for {cyclistName}: {tireler}");
Console.WriteLine($"His average standing is: {results.Average()}");

//task7
Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    if ((roll1 == roll2) && (roll2 == roll3))
    {
        Console.WriteLine("You rolled triples!  +6 bonus to total!");
        total += 6;
    }
    else
    {
        Console.WriteLine("You rolled doubles!  +2 bonus to total!");
        total += 2;

    }

    Console.WriteLine($"Your total including the bonus: {total}");
}

if (total >=15)
{
    Console.WriteLine("you win!");
}
else
{
    Console.WriteLine("Sorry, you lose.");
}

//task8
Console.WriteLine("Please enter a quote from a game.");
string quote = Console.ReadLine();
Console.WriteLine("Please enter a letter to count");
char letter = char.Parse(Console.ReadLine());

int letterCount=0;
foreach (char a in quote )
{
    if (a == letter)
    {
        letterCount++;
    }
}

char [] quoteArray = quote.ToCharArray();
Array.Reverse(quoteArray);
string reversedQuote = new string(quoteArray);

Console.WriteLine(reversedQuote);
Console.WriteLine($"{letter} appear {letterCount}");
