namespace CP5;

public class ConfigConverter
{
    public int GetInt(Dictionary<string, string> config, string key)
    {
        string rawValue;

        try
        {
            rawValue = config[key];
        }
        catch (KeyNotFoundException ex)
        {
            var wrapped = new InvalidOperationException(
                $"не найден ключ конфигурации '{key}'", ex);

            wrapped.Data["ConfigKey"] = key;
            throw wrapped;
        }

        try
        {
            return int.Parse(rawValue);
        }
        catch (FormatException ex)
        {
            var wrapped = new InvalidOperationException(
                $"Значение настройки '{key}' не удалось преобразовать в int", ex);

            wrapped.Data["ConfigKey"] = key;
            wrapped.Data["RawValue"] = rawValue;
            throw wrapped;
        }
    }
}
