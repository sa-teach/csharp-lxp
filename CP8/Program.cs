using CP8;

var calculator = new SumCalculator();

Console.WriteLine("1. Обычная сумма");
Console.WriteLine($"Результат: {calculator.SumChecked(new[] { 1, 2, 3 })}");
Console.WriteLine();

Console.WriteLine("2. Переполнение");
Console.WriteLine($"Результат: {calculator.SumChecked(new[] { int.MaxValue, 1 })}");
Console.WriteLine();

Console.WriteLine("3. TryParse с числом");
Console.WriteLine($"Результат для \"42\": {calculator.ParseOrZero("42")}");
Console.WriteLine();

Console.WriteLine("4. TryParse с неверной строкой");
Console.WriteLine($"Результат для \"abc\": {calculator.ParseOrZero("abc")}");
