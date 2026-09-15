using CP6;

var parser = new NumberListParser();

Console.WriteLine("1. Обычный сценарий");
var values = new List<string> { "10", "", "abc", "20" };

var sum = parser.SumValidNumbers(values);
Console.WriteLine($"Итоговая сумма: {sum}");
Console.WriteLine();

Console.WriteLine("2. Сценарий с переполнением");
var overflowValues = new List<string> { "5", "9999999999", "10" };

try
{
    parser.SumValidNumbers(overflowValues);
}
catch (OverflowException ex)
{
    Console.WriteLine("OverflowException передан вызывающему коду через throw;");
    Console.WriteLine($"Сообщение: {ex.Message}");
}
