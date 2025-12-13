Console.WriteLine("Input the first number:");
string input = Console.ReadLine();
int a = int.Parse(input);

Console.WriteLine("Input the second number:");
input = Console.ReadLine();
int b = int.Parse(input);

Console.WriteLine("What do you want to do with those numbers?\r\n[A]dd\r\n[S]ubtract\r\n[M]ultiply");
input = Console.ReadLine();

if (input == "A")
{
    Console.WriteLine(a + " + " + b + " = " + (a + b));
}
else if (input == "S")
{
    Console.WriteLine(a + " - " + b + " = " + (a - b));
}
else if (input == "M")
{
    Console.WriteLine(a + " * " + b + " = " + (a * b));
}
else
{
    Console.WriteLine("invalid option");
}

Console.ReadKey();