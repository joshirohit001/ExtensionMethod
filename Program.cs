// See https://aka.ms/new-console-template for more information

using ExtensionMethod;

int number = 10;
int sqOfNumber = number.SquareOfNumber();
/*------------------------------------------------*/
/*------------------------------------------------*/
List<int> obj = new List<int>();
obj.Add(10);
obj.Add(20);
int Multiply = obj.ListIndexerMultiply();
Console.WriteLine(sqOfNumber);
Console.WriteLine(Multiply);
Console.ReadLine();