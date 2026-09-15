using System.Globalization;

namespace CP9;

public class OrderProcessor
{
    public void ProcessOrders(IEnumerable<string> rawOrders)
    {
        var processed = 0;
        var succeeded = 0;
        var skipped = 0;

        try
        {
            foreach (var rawOrder in rawOrders)
            {
                processed++;

                var parts = rawOrder.Split(';');

                if (parts.Length != 3 ||
                    !decimal.TryParse(
                        parts[1],
                        NumberStyles.Number,
                        CultureInfo.InvariantCulture,
                        out var price) ||
                    !int.TryParse(parts[2], out var quantity))
                {
                    Console.WriteLine(
                        $"Пропущено: '{rawOrder}' - неверный формат");
                    skipped++;
                    continue;
                }

                try
                {
                    if (price < 0)
                    {
                        throw new OrderProcessingException(
                            $"Цена не может быть отрицательной: {price}.");
                    }

                    Console.WriteLine(
                        $"Заказ {parts[0]} обработан: цена {price}, количество {quantity}");
                    succeeded++;
                }
                catch (OrderProcessingException ex)
                    when (ex.Message.Contains("Цена", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Пропущено: {ex.Message}");
                    skipped++;
                }
            }
        }
        finally
        {
            Console.WriteLine();
            Console.WriteLine(
                $"Обработано: {processed}, успешно: {succeeded}, пропущено: {skipped}");
        }
    }
}
