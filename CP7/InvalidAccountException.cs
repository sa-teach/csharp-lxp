namespace CP7;

public class InvalidAccountException : BankingException
{
    public string AccountId { get; } = string.Empty;

    public InvalidAccountException() { }

    public InvalidAccountException(string message)
        : base(message) { }

    public InvalidAccountException(string message, Exception innerException)
        : base(message, innerException) { }

    public InvalidAccountException(string accountId, int requiredLength)
        : base($"Неверный номер счета: '{accountId}'. Номер должен состоять из {requiredLength} цифр.")
    {
        AccountId = accountId;
    }
}
