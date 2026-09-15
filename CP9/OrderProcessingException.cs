namespace CP9;

public class OrderProcessingException : Exception
{
    public OrderProcessingException() { }

    public OrderProcessingException(string message)
        : base(message) { }

    public OrderProcessingException(string message, Exception innerException)
        : base(message, innerException) { }
}
