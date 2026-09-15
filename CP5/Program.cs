using System.Collections;
using CP5;

var converter = new ConfigConverter();

var config = new Dictionary<string, string>
{
    ["timeout"] = "30"
};

Console.WriteLine("1. Корректное значение");
Console.WriteLine($"GetInt(config, \"timeout\") = {converter.GetInt(config, "timeout")}");
Console.WriteLine();

Console.WriteLine("2. Отсутствующий ключ");
TryGetInt(converter, config, "missing");
Console.WriteLine();

Console.WriteLine("3. Некорректное значение");
config["timeout"] = "тридцать";
TryGetInt(converter, config, "timeout");

static void TryGetInt(
    ConfigConverter converter,
    Dictionary<string, string> config,
    string key)
{
    try
    {
        Console.WriteLine(converter.GetInt(config, key));
    }
    catch (InvalidOperationException ex)
    {
        Console.WriteLine($"Сообщение: {ex.Message}");
        Console.WriteLine(
            $"Исходная причина: {ex.InnerException?.GetType().Name}: {ex.InnerException?.Message}");

        foreach (DictionaryEntry entry in ex.Data)
        {
            Console.WriteLine($"Data[{entry.Key}] = {entry.Value}");
        }
    }
}
