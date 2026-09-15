using CP4_Balance;

var b1 = new Balance(100m);
var b2 = new Balance(100m);
var b3 = new Balance(-50m);

Console.WriteLine($"b1 = {b1}");
Console.WriteLine($"b2 = {b2}");
Console.WriteLine($"b3 = {b3}");
Console.WriteLine();

Console.WriteLine($"b1 == b2: {b1 == b2}");
Console.WriteLine($"b1 != b3: {b1 != b3}");
Console.WriteLine($"b1 > b3:  {b1 > b3}");
Console.WriteLine($"b1 < b3:  {b1 < b3}");
Console.WriteLine($"b1 >= b2: {b1 >= b2}");
Console.WriteLine($"b1 <= b2: {b1 <= b2}");
Console.WriteLine();

if (b1)
    Console.WriteLine("b1: баланс положительный");

if (b3)
    Console.WriteLine("b3: баланс положительный");
else
    Console.WriteLine("b3: баланс не положительный");
