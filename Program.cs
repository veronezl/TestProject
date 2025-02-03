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

// if else else if  ----------------------------------------------------------------------------------

//Random dice = new Random();
// Random dice = new();  // Esse código é equivalente ao código acima

// int roll1 = dice.Next(1, 7); // dice = dado de jogo
// int roll2 = dice.Next(1, 7);
// int roll3 = dice.Next(1, 7);

// int total = roll1 + roll2 + roll3;

// Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");


// if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
// {
//    if ((roll1 == roll2) && (roll2 == roll3))
//     {
//     Console.WriteLine("You rolled triples! +6 bonus to total!");
//     total += 6;
//     }
//     else
//     {
//         Console.WriteLine("You rolled doubles! +2 bonus to total!");
//         total += 2;
//     }
// }
// if (total >= 16)
// {
//     Console.WriteLine("You win a new car");
// }
// else if (total >= 10)
// {
//     Console.WriteLine("You win a new laptop!");
// }
// else if (total == 7)
// {
//     Console.WriteLine("You win a trip for two!");
// }
// else
// {
//     Console.WriteLine("You win a kitten!");
// }


// Aprimorar taxa de renovação de assinaturas


/*Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

if (daysUntilExpiration == 0)
{
    Console.WriteLine("Your subscription has expired.");
}
else if (daysUntilExpiration == 1)
{
    Console.WriteLine("Your subscription expires within a day!");
    discountPercentage = 20;
}
else if (daysUntilExpiration <= 5)
{
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
    discountPercentage = 10;
}
else if (daysUntilExpiration <= 10)
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}

if (discountPercentage > 0)
{
    Console.WriteLine($"Renew now and save {discountPercentage}%.");
}*/

// Exemplo de uso de Matriz e Foreach ---------------------------------------------------------------

/*string[] fraudulentOrderIDs = { "A123", "B456", "C789" };

/*string[] fraudulentOrderIDs = new string[3];
fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";
// fraudulentOrderIDs[3] = "D000";

Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

fraudulentOrderIDs[0] = "F000";

Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");*/

//------------------------------------------------------------------------------------------------

/*string[] names = { "Rowena", "Robin", "Bao" };
foreach (string name in names)
{
    Console.WriteLine(name);
}*/

// Saída: Rowena, Robin, Bao

// ------------------------------------------------------------------------------------------------

/*int[] inventory = { 200, 450, 700, 175, 250 };

int sum = 0;
int bin = 0;

foreach (int items in inventory)
{
    sum += items;
    bin++;
    Console.WriteLine($"Bin {bin} = items (Running total: {sum})");
}

Console.WriteLine($"We have {sum} items in inventory.");*/

// Atividade do modulo ------------------------------------------------------------------------------

/*string[] idPedidos = ["B123", "C243", "A345", "C15", "B177", "G3003", "C235", "B179"];

foreach (string idPedido in idPedidos)
{
    if (idPedido.StartsWith("B"))
    {
        Console.WriteLine(idPedido);
    }
}*/

// Criar código legível com convenções, espaço em branco e comentários ------------------------------

/*Exemplos de nome de variáveis:
char userOption;

int gameScore;

float particlesPerMillion;

bool processedCustomer;*/

// ------------------------------------------------------------------------------------------------

/*string firstName = "Bob";
int widgetsPurchased = 7;

Console.WriteLine($"{firstName} purchased {widgetsPurchased} widgets.");*/

// ------------------------------------------------------------------------------------------------

/*
  The following code creates five random OrderIDs
  to test the fraud detection process.  OrderIDs 
  consist of a letter from A to E, and a three
  digit number. Ex. A123.

Random random = new Random();
string[] orderIDs = new string[5];

for (int i = 0; i < orderIDs.Length; i++)
{
    int prefixValue = random.Next(65, 70);
    string prefix = Convert.ToChar(prefixValue).ToString();
    string suffix = random.Next(1, 1000).ToString("000");

    orderIDs[i] = prefix + suffix;
}

foreach (var orderID in orderIDs)
{
    Console.WriteLine(orderID);
}*/

// Exemplo de ilustrar como o espaço em branco é ignorado pelo compilador --------------------------

// Example 1:
/*Console
.
WriteLine
(
"Hello Example 1!"
)
;

// Example 2:
string firstWord="Hello";string lastWord="Example 2";Console.WriteLine(firstWord+" "+lastWord+"!");*/

// ------------------------------------------------------------------------------------------------

// Exemplo sem espaço em branco

/*Random dice = new Random();
int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);
int total = roll1 + roll2 + roll3;
Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");
if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3)) {
    if ((roll1 == roll2) && (roll2 == roll3)) {
        Console.WriteLine("You rolled triples!  +6 bonus to total!");
        total += 6; 
    } else {
        Console.WriteLine("You rolled doubles!  +2 bonus to total!");
        total += 2;
    }
}*/

// ------------------------------------------------------------------------------------------------

// Exemplo com espaço em branco - código mais legível

/*
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
}
*/

// Atividade do módulo ------------------------------------------------------------------------------

/*
   This code reverses a message, counts the number of times 
   a particular character appears, then prints the results
   to the console window.
 */

/*
string originalMessage = "The quick brown fox jumps over the lazy dog.";

char[] message = originalMessage.ToCharArray();
Array.Reverse(message);

int letterCount = 0;

foreach (char letter in message)
{
    if (letter == 'o')
    {
        letterCount++;
    }
}

string newMessage = new String(message);

Console.WriteLine(newMessage);
Console.WriteLine($"'o' appears {letterCount} times.");
*/

// Trabalhe com dados variáveis ​​em aplicativos de console C# =====================================

// Escolher o tipo de dados correto em seu código C# -----------------------------------------

// Descobrir tipos integrais -------------------------------------------------------------------

/*
Console.WriteLine("Signed integral types:");

Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");

Console.WriteLine("");
Console.WriteLine("Unsigned integral types:");

Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");

Console.WriteLine("");
Console.WriteLine("Floating point types:");
Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");
*/

// Refêrencia de dado

/*
int[] ref_A = new int[1];
ref_A[0] = 2;
int[] ref_B = ref_A;
ref_B[0] = 5;

Console.WriteLine("--Reference Types--");
Console.WriteLine($"ref_A[0]: {ref_A[0]}");
Console.WriteLine($"ref_B[0]: {ref_B[0]}");
*/

// Converter tipos de dados usando técnicas de fundição e conversão em C# ---------------------------------------

// Explorar a coerção e a conversão de tipo de dados -------------------------------------------

// Pergunta: Tentar alterar o tipo de dados do valor geraria uma exceção no tempo de execução?

/*
int first = 2;
string second = "4";
string result = first + second;
Console.WriteLine(result);
*/

// Analisar se perderá dados:

/*
decimal myDecimal = 1.23456789m;
float myFloat = (float)myDecimal;
Console.WriteLine($"Decimal: {myDecimal}");
Console.WriteLine($"Float  : {myFloat}");
Output: 
Decimal: 1,23456789
Float  : 1,2345679
*/

// Use ToString() para converter um número em um string:

/*
int first = 5;
int second = 7;
string message = first.ToString() + second.ToString();
Console.WriteLine(message);
*/

// Converter um string em um int usando o método auxiliar Parse():

/*
string first = "5";
string second = "7";
int sum = int.Parse(first) + int.Parse(second);
Console.WriteLine(sum);
*/

// Converter um string em um int usando a classe Convert

/*
string value1 = "5";
string value2 = "7";
int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
Console.WriteLine(result);
*/

// Comparar a coerção e a conversão de um decimal em um int

/*
int value = (int)1.5m; // casting truncates
Console.WriteLine(value);

int value2 = Convert.ToInt32(1.5m); // converting rounds up
Console.WriteLine(value2);
*/

// Utilizar o método TryParse() para analisar uma cadeia de caracteres como um int:

// Examine a última linha de código no exemplo anterior, Console.WriteLine
// ($"Measurement (w/ offset): {50 + result}");, uma vez que a variável result é 
// definida fora da instrução if, ela pode ser acessada posteriormente em seu código.

/*
string value = "bad";
int result = 0;
if (int.TryParse(value, out result))
{
   Console.WriteLine($"Measurement: {result}");
}
else
{
   Console.WriteLine("Unable to report the measurement.");
}
if (result > 0)
Console.WriteLine($"Measurement (w/ offset): {50 + result}");
*/

// Exercício – Concluir um desafio em que é preciso combinar valores de matriz de cadeia de 
// caracteres como cadeias de caracteres e inteiros:

/*
string[] values = { "12,3", "45", "ABC", "11", "DEF" };

decimal total = 0m;
string message = "";

foreach (string value in values)
{
    decimal number; // stores the TryParse "out" value

    if (decimal.TryParse(value, out number))
    {
        total += number;
    }
    else
    {
        message += value;
    }
}

Console.WriteLine($"Message: {message}");
Console.WriteLine($"Total: {total}");
*/

// Exercício – Concluir o desafio de imprimir na tela operações matemáticas 
// como tipos de número específicos

/*
int value1 = 11;
decimal value2 = 6.2m;
float value3 = 4.3f;

// double result1 = Math.Round(value1 / (double)value2);
double result1 = Convert.ToInt32(value1 / value2);
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

decimal result2 = value2 / (decimal)value3;
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

float result3 = value3 / (float)value1;
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");
*/

// Executar operações em matrizes usando métodos auxiliares em C# ===================================

// Exercício – Conhecer as funções Sort() e Reverse():

// Criar uma matriz de paletes, depois classificá-los

/*
string[] pallets = ["B14", "A11", "B12", "A13"];

Console.WriteLine("Sorted...");
Array.Sort(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Console.WriteLine("Reversed...");
Array.Reverse(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
*/

// Exercício – Explorar os métodos Clear() e Resize()

// Usar métodos de matriz para limpar e redimensionar uma matriz

/*
string[] pallets = ["B14", "A11", "B12", "A13"];
Console.WriteLine("");

Array.Clear(pallets, 0, 2);
Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets, 6);
Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

pallets[4] = "C01";
pallets[5] = "C02";

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets, 3);
Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
*/

// Exercício – Descobrir Split() e Join()

// Use o ToCharArray() para reverter um string:

/*
string value = "abc123";
char[] valueArray = value.ToCharArray();
Array.Reverse(valueArray);
string result = new string(valueArray);
Console.WriteLine(result);
*/

// Combine todos os caracteres em uma nova cadeia de caracteres com valor separado 
// por vírgula usando Join()

/*
string value = "abc123";
char[] valueArray = value.ToCharArray();
Array.Reverse(valueArray);
// string result = new string(valueArray);
string result = String.Join(",", valueArray);
Console.WriteLine(result);

string[] items = result.Split(',');
foreach (string item in items)
{
    Console.WriteLine(item);
}
*/

// Escrever código para inverter cada palavra de uma mensagem

/*
string pangram = "The quick brown fox jumps over the lazy dog";

string[] message = pangram.Split();

string[] newMessage = new string[message.Length];

for (int i = 0; i < message.Length; i++)
{
    char[] letters = message[i].ToCharArray();
    Array.Reverse(letters);
    newMessage[i] = new string(letters);
}

string result = String.Join(" ", newMessage);
Console.WriteLine(result);  // The quick brown fox jumps over the lazy dog
*/

// Exercício – Concluir um desafio em que é preciso analisar uma cadeia de caracteres 
// de pedidos, classificá-los e marcar possíveis erros:

/*
string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

string[] idPedidos = orderStream.Split(",");

Array.Sort(idPedidos);

foreach (var idPedido in idPedidos)
{
    if (idPedido.Length == 4)
    {
        Console.WriteLine(idPedido);
    }

    else
    {
        Console.WriteLine(idPedido + "\t- Error");
    }

}
*/

// Formatar dados alfanuméricos para apresentação em C# =========================================

// Exercício – Investigar as noções básicas da formatação de cadeia de caracteres:

// Formatação Composta

/*
string first = "Hello";
string second = "World";
string result = string.Format("{0} {1}!", first, second);
Console.WriteLine(result);
*/

// Interpolação de cadeia de caracteres;

/*
string first = "Hello";
string second = "World";
Console.WriteLine($"{first} {second}!");
Console.WriteLine($"{second} {first}!");
Console.WriteLine($"{first} {first} {first}!");
*/

// Moeda de formatação:

/*
decimal price = 123.45m;
int discount = 50;
Console.WriteLine($"Price: {price:C} (Save {discount:C})");
*/

// Formatar números

/*
decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N} units");
Console.WriteLine($"Measurement: {measurement:N4} units");
*/

// Formatar percentuais

/*
decimal tax = .36785m;
Console.WriteLine($"Tax rate: {tax:P2}");
*/

// Combinar abordagens de formatação

/*
decimal price = 67.55m;
decimal salePrice = 59.99m;

string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), price);

yourDiscount += $"A discount of {((price - salePrice)/price):P2}!"; //inserted
Console.WriteLine(yourDiscount);
*/

//  Descobrir o preenchimento e alinhamento:

/*
string input = "Pad this";
 Console.WriteLine(input.PadLeft(12, '-'));
 Console.WriteLine(input.PadRight(12, '-'));
*/

//  Como trabalhar com cadeias de caracteres preenchidas

// Adicionar a ID de pagamento, nome, valor à saída

/*
string paymentId = "769C";
 string payeeName = "Mr. Stephen Ortega";
 string paymentAmount = "$5,000.00";

 var formattedLine = paymentId.PadRight(6);
 formattedLine += payeeName.PadRight(24);
 formattedLine += paymentAmount.PadLeft(10);

 Console.WriteLine("1234567890123456789012345678901234567890");
 Console.WriteLine(formattedLine);
*/

//  Exercício – Concluir um desafio em que é preciso aplicar a interpolação de cadeias de 
// caracteres a uma carta-modelo:

/*
string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

// Your logic here
System.Console.WriteLine($"Dear {customerName},\n");
System.Console.WriteLine($"As a custumer of our {currentProduct} offering we excited to tell you about a new financial product that would dramtically increase your return.\n");
System.Console.WriteLine($"Currently, you own {currentShares:N} shares at a return of {currentReturn:P2}.\n");
System.Console.WriteLine($"Our new product, {newProduct}, offers a return of {newReturn:P2}.  Given your current volume, your potential profit would be {newProfit:C}.\n");

Console.WriteLine("Here's a quick comparison:\n");

string comparisonMessage = "";

// Your logic here

comparisonMessage = currentProduct.PadRight(20);
comparisonMessage += $"{currentReturn:P2}".PadRight(10);
comparisonMessage += $"{currentProfit:C}\n".PadRight(20);
comparisonMessage += newProduct.PadRight(20);
comparisonMessage += $"{newReturn:P2}".PadRight(10);
comparisonMessage += $"{newProfit:C}\n".PadRight(20);

Console.WriteLine(comparisonMessage);
*/

/* Output
Dear Ms. Barros,

As a custumer of our Magic Yield offering we excited to tell you about a new financial product that 
would dramtically increase your return.

Currently, you own 2.975.000,000 shares at a return of 12,75%.

Our new product, Glorious Future, offers a return of 13,13%.  Given your current volume, 
your potential profit would be R$ 63.000.000,00.

Here's a quick comparison:

Magic Yield         12,75%    R$ 55.000.000,00
Glorious Future     13,13%    R$ 63.000.000,00
*/

// Modificar o conteúdo de cadeias de caracteres usando métodos internos de tipo de dados em C# =============================

// Exercício – Use os métodos auxiliares IndexOf() e Substring() da cadeia de caracteres:

// Escreva um código para encontrar pares de parênteses inseridas em uma cadeia de caracteres:

/*
string message = "Find what is (inside the parentheses)";

int openingPosition = message.IndexOf('(');
int closingPosition = message.IndexOf(')');

Console.WriteLine(openingPosition);
Console.WriteLine(closingPosition);
*/

// Output: 14, 36

// Adicione o código para recuperar o valor entre parênteses:

/*
string message = "Find what is (inside the parentheses)";

int openingPosition = message.IndexOf('(');
int closingPosition = message.IndexOf(')');

// Console.WriteLine(openingPosition);
// Console.WriteLine(closingPosition);

int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));
*/

// Output: (inside the parentheses

// Modificar a posição inicial da subcadeia de caracteres:

/*
string message = "Find what is (inside the parentheses)";

int openingPosition = message.IndexOf('(');
int closingPosition = message.IndexOf(')');

openingPosition += 1;

System.Console.WriteLine(openingPosition); // Output: 14

int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));
*/

// Output: inside the parentheses

// Mais exemple de posição inicial da subcadeia de caracteres:

/*
string message = "What is the value <span>between the tags</span>?";

int openingPosition = message.IndexOf("<span>");
int closingPosition = message.IndexOf("</span>");

openingPosition += 6;
int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));
*/

// Output: between the tags

// Evitar valores mágicos:

/*
string message = "What is the value <span>between the tags</span>?";

const string openSpan = "<span>";
const string closeSpan = "</span>";

int openingPosition = message.IndexOf(openSpan);
int closingPosition = message.IndexOf(closeSpan);

openingPosition += openSpan.Length;
int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));
*/

// Output: between the tags

// Exercício – Usar os métodos auxiliares IndexOf() e LastIndexOf() da cadeia de caracteres:

/*
string message = "hello there!";

int first_h = message.IndexOf('h');
int last_h = message.LastIndexOf('h');

Console.WriteLine($"For the message: '{message}', the first 'h' is at position {first_h} and the last 'h' is at position {last_h}.");
*/

// Output: For the message: 'hello there!', the first 'h' is at position 0 and the last 'h' is at position 7.

// Recuperar a última ocorrência de uma subcadeia de caracteres:

/*
string message = "(What if) I am (only interested) in the last (set of parentheses)?";
int openingPosition = message.LastIndexOf('(');

openingPosition += 1;
int closingPosition = message.LastIndexOf(')');
int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));
*/

// Output: only interested in the last

// Recuperar todas as instâncias de subcadeias de caracteres dentro de parênteses:

/*
string message = "(What if) there are (more than) one (set of parentheses)?";
while (true)
{
    int openingPosition = message.IndexOf('(');
    if (openingPosition == -1) break;

    openingPosition += 1;
    int closingPosition = message.IndexOf(')');
    int length = closingPosition - openingPosition;
    Console.WriteLine(message.Substring(openingPosition, length));

    // Note the overload of the Substring to return only the remaining 
    // unprocessed message:
    message = message.Substring(closingPosition + 1);
}
*/

// Output: What if, more than, set of parentheses: 

// Trabalhe com diferentes tipos de conjuntos de símbolos usando IndexOfAny(): 

/*
string message = "Hello, world!";
char[] charsToFind = { 'a', 'e', 'i' };

int index = message.IndexOfAny(charsToFind);

Console.WriteLine($"Found '{message[index]}' in '{message}' at index: {index}.");
*/

// Output: Found 'e' in 'Hello, world!' at index: 1.

// Outro exemplo de IndexOfAny():

/*
string message = "Help (find) the {opening symbols}";
Console.WriteLine($"Searching THIS Message: {message}");
char[] openSymbols = { '[', '{', '(' };
int startPosition = 5;
int openingPosition = message.IndexOfAny(openSymbols);
Console.WriteLine($"Found WITHOUT using startPosition: {message.Substring(openingPosition)}");

openingPosition = message.IndexOfAny(openSymbols, startPosition);
Console.WriteLine($"Found WITH using startPosition {startPosition}:  {message.Substring(openingPosition)}");
*/

/* Output
Searching THIS Message: Help (find) the {opening symbols}
Found WITHOUT using startPosition: (find) the {opening symbols}
Found WITH using startPosition 5:  (find) the {opening symbols}
*/

// Outro exemplo de IndexOfAny():

/*
string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

// The IndexOfAny() helper method requires a char array of characters. 
// You want to look for:

char[] openSymbols = { '[', '{', '(' };

// You'll use a slightly different technique for iterating through 
// the characters in the string. This time, use the closing 
// position of the previous iteration as the starting index for the 
//next open symbol. So, you need to initialize the closingPosition 
// variable to zero:

int closingPosition = 0;

while (true)
{
    int openingPosition = message.IndexOfAny(openSymbols, closingPosition);

    if (openingPosition == -1) break;

    string currentSymbol = message.Substring(openingPosition, 1);

    // Now  find the matching closing symbol
    char matchingSymbol = ' ';

    switch (currentSymbol)
    {
        case "[":
            matchingSymbol = ']';
            break;
        case "{":
            matchingSymbol = '}';
            break;
        case "(":
            matchingSymbol = ')';
            break;
    }

    // To find the closingPosition, use an overload of the IndexOf method to specify 
    // that the search for the matchingSymbol should start at the openingPosition in the string. 

    openingPosition += 1;
    closingPosition = message.IndexOf(matchingSymbol, openingPosition);

    // Finally, use the techniques you've already learned to display the sub-string:

    int length = closingPosition - openingPosition;
    Console.WriteLine(message.Substring(openingPosition, length));
}
*/

// Output: different symbols, open symbol, matching closing symbol

// Exercício – Usar os métodos Remove() e Replace(): 

// Usar o método Remove()

// Remover caracteres em locais específicos de uma cadeia de caracteres:

/*
string data = "12345John Smith          5000  3  ";
string updatedData = data.Remove(5, 20);
Console.WriteLine(updatedData);
*/

// Output: 123455000  3

// Usar o método Replace(): 

// Remover caracteres, independentemente de onde eles aparecem em uma cadeia de caracteres: 

/*
string message = "This--is--ex-amp-le--da-ta";
message = message.Replace("--", " ");
message = message.Replace("-", "");
Console.WriteLine(message);
*/

// Exercício: conclua um desafio para extrair, substituir e remover os dados de uma cadeia de 
// caracteres de entrada

/*
const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

// Your work here

// Extract the "quantity"
const string openSpan = "<span>";
const string closeSpan = "</span>";

int quantityStart = input.IndexOf(openSpan) + openSpan.Length; // + length of <span> so index at end of <span> tag
int quantityEnd= input.IndexOf(closeSpan);
int quantityLength = quantityEnd - quantityStart;
quantity = input.Substring(quantityStart, quantityLength);
quantity = $"Quantity: {quantity}";

// Set output to input, replacing the trademark symbol with the registered trademark symbol
const string tradeSymbol = "&trade;";
const string regSymbol = "&reg;";
output = input.Replace(tradeSymbol, regSymbol);

// Remove the opening <div> tag
const string openDiv = "<div>";
int divStart = output.IndexOf(openDiv);
output = output.Remove(divStart, openDiv.Length);

// Remove the closing </div> tag and add "Output:" to the beginning
const string closeDiv = "</div>";
int divCloseStart = output.IndexOf(closeDiv);
output = "Output: " + output.Remove(divCloseStart, closeDiv.Length);

Console.WriteLine(quantity);
Console.WriteLine(output);
*/

// Crie métodos em aplicativos de console C# =============================================

// Normalmente definimos todos os métodos no final do programa. Por exemplo:

/*
int[] a = {1,2,3,4,5};

Console.WriteLine("Contents of Array:");
PrintArray();

void PrintArray()
{
    foreach (int x in a)
    {
        Console.Write($"{x} ");
    }
    Console.WriteLine();
}
*/

// Execução do método: 

/*
Console.WriteLine("Before calling a method");
SayHello();
Console.WriteLine("After calling a method");

void SayHello() 
{
    Console.WriteLine("Hello World!");
}
*/

// Práticas recomendadas de nomear métodos, exemplo: 

/*
void ShowData(string a, int b, int c);
void DisplayDate(string month, int day, int year);
*/

// Criar primeiro método: 

/*
Console.WriteLine("Generation random numbers:");
DisplayRandowNumbers();

void DisplayRandowNumbers()
{
    Random random = new Random();

    for (int i = 0; i < 5; i++)
    {
        Console.Write($"{random.Next(1, 100)} ");
    }

    Console.WriteLine();
}
*/

// Criar métodos reutilizáveis: 

/*
using System;

int[] times = {800, 1200, 1600, 2000};
int diff = 0;

Console.WriteLine("Enter current GMT");
int currentGMT = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Current Medicine Schedule:");
DisplayTimes();

Console.WriteLine("Enter new GMT");
int newGMT = Convert.ToInt32(Console.ReadLine());

if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
{
    Console.WriteLine("Invalid GMT");
}
else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0) 
{
    diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));

    AdjustTimes();
} 
else 
{
    diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));

    AdjustTimes();
}

Console.WriteLine("New Medicine Schedule:");
DisplayTimes();

Console.WriteLine();

void DisplayTimes() 
{
    // Format and display medicine times
    foreach (int val in times)
    {
        string time = val.ToString();
        int len = time.Length;

        if (len >= 3)
        {
            time = time.Insert(len - 2, ":");
        }
        else if (len == 2)
        {
            time = time.Insert(0, "0:");
        }
        else
        {
            time = time.Insert(0, "0:0");
        }

        Console.Write($"{time} ");
    }

    Console.WriteLine();
}

void AdjustTimes() 
{
    // Adjust the times by adding the difference, keeping the value within 24 hours
    for (int i = 0; i < times.Length; i++) 
    {
        times[i] = ((times[i] + diff)) % 2400;
    }
}
*/

// Usar métodos para estruturar código: 

// Tarefa de verificar ips válidos:

/*
if ipAddress consists of 4 numbers
and
if each ipAddress number has no leading zeroes
and
if each ipAddress number is in range 0 - 255

then ipAddress is valid

else ipAddress is invalid
*/

/*
string[] ipv4Input = {"107.31.1.5", "255.0.0.255", "555..0.555", "255...255"};
string[] address;
bool validLength = false;
bool validZeroes = false;
bool validRange = false;

foreach (string ip in ipv4Input) 
{
    address = ip.Split(".", StringSplitOptions.RemoveEmptyEntries);

    ValidateLength(); 
    ValidateZeroes(); 
    ValidateRange();

    if (validLength && validZeroes && validRange) 
    {
        Console.WriteLine($"{ip} is a valid IPv4 address");
    } 
    else 
    {
        Console.WriteLine($"{ip} is an invalid IPv4 address");
    }
}

void ValidateLength() 
{
    validLength = address.Length == 4;
};

void ValidateZeroes() 
{
    foreach (string number in address) 
    {
        if (number.Length > 1 && number.StartsWith("0")) 
        {
            validZeroes = false;
            return;
        }
    }

    validZeroes = true;
}

void ValidateRange() 
{
    foreach (string number in address) 
    {
        int value = int.Parse(number);
        if (value < 0 || value > 255) 
        {
            validRange = false;
            return;
        }
    }
    validRange = true;
}
*/

// Exercício – Concluir o desafio de criar um método reutilizável:

/*
Random random = new Random();
int luck = random.Next(100);

string[] text = { "You have much to", "Today is a day to", "Whatever work you do", "This is an ideal time to" };
string[] good = { "look forward to.", "try new things!", "is likely to succeed.", "accomplish your dreams!" };
string[] bad = { "fear.", "avoid major decisions.", "may have unexpected outcomes.", "re-evaluate your life." };
string[] neutral = { "appreciate.", "enjoy time with friends.", "should align with your values.", "get in tune with nature." };

TellFortune();

void TellFortune()
{
    Console.WriteLine("A fortune teller whispers the following words:");
    string[] fortune = (luck > 75 ? good : (luck < 25 ? bad : neutral));
    for (int i = 0; i < 4; i++)
    {
        Console.Write($"{text[i]} {fortune[i]} ");
    }
}
*/

// Usar parâmetros em métodos:

// Neste exemplo, o método CountTo aceita um parâmetro inteiro chamado
// max. O parâmetro é referenciado no loop for do método. 
// Quando CountTo é chamado, o inteiro 5 é fornecido como um argumento.

/*
CountTo(5);

	void CountTo(int max) 
	{
		for (int i = 0; i < max; i++)
		{
			Console.Write($"{i}, ");
		}
	}
*/

// Criar um método com parâmetros:

// Observe que os parâmetros são declarados da mesma forma que você declara
// variáveis, usando o tipo de dados seguido pelo nome da variável. 
// Você pode usar parâmetros de qualquer tipo de dados, 
// como string, bool, int, matrizes e muito mais! Vários parâmetros 
// em um método são sempre separados por vírgulas.

/*
int[] schedule = { 800, 1200, 1600, 2000 };

DisplayAdjustedTimes(schedule, 6, -6);

void DisplayAdjustedTimes(int[] times, int currentGMT, int newGMT)
{
    int diff = 0;
    if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
    {
        Console.WriteLine("Invalid GMT");
    }
    else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0)
    {
        diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
    }
    else
    {
        diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
    }

    for (int i = 0; i < times.Length; i++)
    {
        int newTime = ((times[i] + diff)) % 2400;
        Console.WriteLine($"{times[i]} -> {newTime}");
    }
}
*/

//  Entender o escopo do método:

// Testar o escopo de variáveis

/*
string[] students = {"Jenna", "Ayesha", "Carlos", "Viktor"};

DisplayStudents(students);
DisplayStudents(new string[] {"Robert","Vanya"});

void DisplayStudents(string[] students) 
{
    foreach (string student in students) 
    {
        Console.Write($"{student}, ");
    }
    Console.WriteLine();
}
*/

//  Mais exemplo: 

/*
double pi = 3.14159;
PrintCircleInfo(12);
PrintCircleInfo(24);

void PrintCircleInfo(int radius) 
{
    Console.WriteLine($"Circle with radius {radius}");
    PrintCircleArea(radius);
    PrintCircleCircumference(radius);
}

void PrintCircleArea(int radius)
{
    double area = pi * (radius * radius);
    Console.WriteLine($"Area = {area}");
}

void PrintCircleCircumference(int radius)
{
    double circumference = 2 * pi * radius;
    Console.WriteLine($"Circumference = {circumference}");
}
*/

//  Métodos com parâmetros opcionais

/*
Criar um aplicativo RSVP
Nesta tarefa, você criará um breve aplicativo para 
convidados para RSVP a um evento. Os convidados 
informarão o tamanho da festa e possíveis alergias. 
Você também adicionará a opção para restringir RSVPs 
a uma lista restrita de convidados.
*/

/*
string[] guestList = { "Rebecca", "Nadia", "Noor", "Jonte" };
string[] rsvps = new string[10];
int count = 0;

RSVP("Rebecca");
RSVP("Nadia", 2, "Nuts");
RSVP(name: "Linh", partySize: 2, inviteOnly: false);
RSVP("Tony", allergies: "Jackfruit", inviteOnly: true);
RSVP("Noor", 4, inviteOnly: false);
RSVP("Jonte", 2, "Stone fruit", false);
ShowRSVPs();

void RSVP(string name, int partySize = 1, string allergies = "none", bool inviteOnly = true)
{
    if (inviteOnly)
    {
        bool found = false;
        foreach (string guest in guestList)
        {
            if (guest.Equals(name))
            {
                found = true;
                break;
            }
        }
        if (!found)
        {
            Console.WriteLine($"Sorry, {name} is not on the guest list");
            return;
        }
    }
    rsvps[count] = $"Name: {name}, \tParty Size: {partySize}, \tAllergies: {allergies}";
    count++;
}

void ShowRSVPs()
{
    Console.WriteLine("\nTotal RSVPs:");
    for (int i = 0; i < count; i++)
    {
        Console.WriteLine(rsvps[i]);
    }
}
*/

// Exercício – Concluir o desafio de exibir endereços de email:

/*
string[,] corporate = 
	{
		{"Robert", "Bavin"}, {"Simon", "Bright"},
		{"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
		{"Sarah", "Delucchi"}, {"Sinan", "Ali"}};

	string[,] external = 
	{
		{"Vinnie", "Ashton"}, {"Cody", "Dysart"},
		{"Shay", "Lawrence"}, {"Daren", "Valdes"}
	};

	string externalDomain = "hayworth.com";

	for (int i = 0; i < corporate.GetLength(0); i++) 
	{
		DisplayEmail(first: corporate[i,0], last: corporate[i,1]);
	}

	for (int i = 0; i < external.GetLength(0); i++) 
	{
		DisplayEmail(first: external[i,0], last: external[i,1], domain: externalDomain);
	}

	void DisplayEmail(string first, string last, string domain = "contoso.com") 
	{
		string email = first.Substring(0, 2) + last;
		email = email.ToLower();
		Console.WriteLine($"{email}@{domain}");
	}
*/

// Crie métodos C# que retornem valores -------------------------------------------------------

// Entender a sintaxe do tipo de retorno:

// Usar métodos para calcular o preço total de compra


/*double total = 0;
double minimumSpend = 30.00;

double[] items = { 15.97, 3.50, 12.25, 22.99, 10.98 };
double[] discounts = { 0.30, 0.00, 0.10, 0.20, 0.50 };

for (int i = 0; i < items.Length; i++)
{
    total += GetDiscountedPrice(i);
}

if (TotalMeetsMinimum())
{
    total -= 5.00;
}

Console.WriteLine($"Total: ${FormatDecimal(total)}");

double GetDiscountedPrice(int itemIndex)
{
    // Calculate the discounted price of the item
    double result = items[itemIndex] * (1 - discounts[itemIndex]);
    return result;
}

bool TotalMeetsMinimum()
{
    // Check if the total meets the minimum
    return total >= minimumSpend;
}

string FormatDecimal(double input)
{
    // Format the double so only 2 decimal places are displayed
    return input.ToString().Substring(0, 5);
}
*/

// Retornar números de métodos:

// Criar um método que retorna um inteiro:

// Converter dolar para vnd->

/*
double usd = 23.73;
int vnd = UsdToVnd(usd);

Console.WriteLine($"${usd} USD = ${vnd} VND");

Console.WriteLine($"${vnd} VND = ${VndToUsd(vnd)} USD");

int UsdToVnd(double usd) 
{
    int rate = 23500;
    return (int)(rate * usd);
}

double VndToUsd(int vnd) 
{
    double rate = 23500;
    return vnd / rate;
}
*/

// Retornar cadeias de caracteres de métodos:

// Criar um método que retorna uma cadeia de caracteres -----------------------------------------------------------------

/*
string input = "snake";

System.Console.WriteLine(input);
System.Console.WriteLine(ReverseWord(input));

string ReverseWord(string word)
{
    string result = "";
    for (int i = word.Length - 1; i >= 0; i--)
    {
        result += word[i];
    }

    return result;
}
*/

// Criar um método para inverter as palavras de uma frase:

/*
string input = "there are snakes at the zoo";

System.Console.WriteLine(input);
System.Console.WriteLine(ReverseSentence(input));

string ReverseSentence (string input)
{
    string result = "";
    string[] words = input.Split(' ');

    foreach (string word in words)
    {
        result += ReverseWord(word) + " ";
    }

    return result.Trim();
}

string ReverseWord(string word) 
{
    string result = "";
    for (int i = word.Length - 1; i >= 0; i--) 
    {
        result += word[i];
    }
    return result;
}
*/

// Retornar boolianos de métodos -------------------------------------------------------------------------------------

/*
string[] words = {"racecar" ,"talented", "deified", "tent", "tenet"};

Console.WriteLine("Is it a palindrome?");
foreach (string word in words) 
{
    Console.WriteLine($"{word}: {IsPalindrome(word)}");
}

bool IsPalindrome(string word)
{
    int start = 0;
    int end = word.Length - 1;

    while (start < end)
    {
        if (word[start] != word[end])
        {
            return false;
        }
        start++;
        end--;
    }
    
    return true;
}
*/

// Retornar matrizes de métodos -------------------------------------------------------------------------------------

// Localizar moedas para fazer alterações: 

/*
int target = 60;
int[] coins = new int[] {5, 5, 50, 25, 25, 10, 5};
int[] result = TwoCoins(coins, target);

if (result.Length == 0) 
{
    Console.WriteLine("No two coins make change");
} 
else 
{
    Console.WriteLine($"Change found at positions {result[0]} and {result[1]}");
}

int[] TwoCoins(int[] coins, int target)
{
   for (int curr = 0; curr < coins.Length; curr++)
   {
         for (int next = curr + 1; next < coins.Length; next++)
         {
            if (coins[curr] + coins[next] == target)
            {
               return new int[] { curr, next };
            }
         }
   }
   
   return new int[0];
}
*/

// Localizar vários pares de moedas que dão troco:

/*
int target = 80;
int[] coins = new int[] {5, 5, 50, 25, 25, 10, 5};
int[,] result = TwoCoins(coins, target);

if (result.Length == 0) 
{
    Console.WriteLine("No two coins make change");
} 
else 
{
    Console.WriteLine("Change found at positions:");
    for (int i = 0; i < result.GetLength(0); i++) 
    {
        if (result[i,0] == -1) 
        {
            break;
        }
        Console.WriteLine($"{result[i,0]},{result[i,1]}");
    }
}

int[,] TwoCoins(int[] coins, int target) 
{
    int[,] result = {{-1,-1},{-1,-1},{-1,-1},{-1,-1},{-1,-1}};
    int count = 0;

    for (int curr = 0; curr < coins.Length; curr++) 
    {
        for (int next = curr + 1; next < coins.Length; next++) 
        {    
            if (coins[curr] + coins[next] == target) 
            {
                result[count, 0] = curr;
                result[count, 1] = next;
                count++;
            }
            if (count == result.GetLength(0)) 
            {
                return result;
            }
        }
    }
    return (count == 0) ? new int[0,0] : result;
}
*/ 

// Exercício – Concluir o desafio de adicionar métodos para tornar o jogo viável: --------------------------------------

/*
Random random = new Random();

Console.WriteLine("Would you like to play? (Y/N)");
if (ShouldPlay()) 
{
    PlayGame();
}

bool ShouldPlay() 
{
    string response = Console.ReadLine();
    return response.ToLower().Equals("y");
}

void PlayGame() 
{
    var play = true;

    while (play) {
        var target = GetTarget();
        var roll = RollDice();

        Console.WriteLine($"Roll a number greater than {target} to win!");
        Console.WriteLine($"You rolled a {roll}");
        Console.WriteLine(WinOrLose(roll, target));
        Console.WriteLine("\nPlay again? (Y/N)");

        play = ShouldPlay();
    }
}

int GetTarget() 
{
    return random.Next(1, 6);
}

int RollDice() 
{
    return random.Next(1, 7);
}

string WinOrLose(int roll, int target) 
{
    if (roll > target) 
    {
        return "You win!";
    }
    return "You lose!";
}
*/