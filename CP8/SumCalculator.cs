namespace CP8;

public class SumCalculator
{
    public int SumChecked(int[] numbers)
    {
        try
        {
            var sum = 0;

            foreach (var number in numbers)
            {
                sum = checked(sum + number);
            }

            return sum;
        }
        catch (OverflowException)
        {
            Console.WriteLine("Предупреждение: сумма превышает диапазон int");
            return int.MaxValue;
        }
    }

    public int ParseOrZero(string input)
    {
        return int.TryParse(input, out var result) ? result : 0;
    }
}
