namespace CP7;

public class BankingException : Exception
{
    public BankingException() { }

    public BankingException(string message)
        : base(message) { }

    public BankingException(string message, Exception innerException)
        : base(message, innerException) { }
}
