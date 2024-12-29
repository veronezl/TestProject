// Random dice = new Random();
// int roll1 = dice.Next();
// int roll2 = dice.Next(101);
// int roll3 = dice.Next(50, 101);

// Console.WriteLine($"First roll: {roll1}");
// Console.WriteLine($"Second roll: {roll2}");
// Console.WriteLine($"Third roll: {roll3}");

// int firstValue = 500;
// int secondValue = 600;
// int largerValue;

// largerValue = System.Math.Max(firstValue, secondValue);
// Console.WriteLine(largerValue);

// Exemplo de uso de Boolean

// string message = "The quick brown fox jumps over the lazy dog.";
// bool result = message.Contains("dog");
// Console.WriteLine(result);

// if (message.Contains("fox"))
// {
//     Console.WriteLine("What does the fox say?");
// }

// if else else if 

//Random dice = new Random();
Random dice = new();  // Esse código é equivalente ao código acima

int roll1 = dice.Next(1, 7); // dice = dado de jogo
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");


if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
   if ((roll1 == roll2) && (roll2 == roll3))
    {
    Console.WriteLine("You rolled triples! +6 bonus to total!");
    total += 6;
    }
    else
    {
        Console.WriteLine("You rolled doubles! +2 bonus to total!");
        total += 2;
    }
}
if (total >= 16)
{
    Console.WriteLine("You win a new car");
}
else if (total >= 10)
{
    Console.WriteLine("You win a new laptop!");
}
else if (total == 7)
{
    Console.WriteLine("You win a trip for two!");
}
else
{
    Console.WriteLine("You win a kitten!");
}
