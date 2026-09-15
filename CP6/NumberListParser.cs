namespace CP6;

public class NumberListParser
{
    public int SumValidNumbers(List<string> values)
    {
        var sum = 0;
        var processed = 0;

        try
        {
            foreach (var value in values)
            {
                processed++;

                try
                {
                    sum += int.Parse(value);
                }
                catch (FormatException) when (string.IsNullOrWhiteSpace(value))
                {
                    //пустую строку пропускаем
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(
                        $"Предупреждение: значение '{value}' не является целым числом {ex.Message}");
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine(
                        $"Критическая ошибка: значение '{value}' выходит за диапазон Int32 {ex.Message}");

                    throw;
                }
            }

            return sum;
        }
        finally
        {
            Console.WriteLine($"Обработано элементов: {processed}");
        }
    }
}
