namespace CP7;

public class BankAccount
{
    public string AccountId { get; }
    public decimal Balance { get; private set; }

    public BankAccount(string accountId, decimal initialBalance)
    {
        if (string.IsNullOrEmpty(accountId) ||
            accountId.Length != 6 ||
            !accountId.All(char.IsDigit))
        {
            throw new InvalidAccountException(accountId, 6);
        }

        AccountId = accountId;
        Balance = initialBalance;
    }

    public void Withdraw(decimal amount)
    {
        if (amount > Balance)
        {
            throw new InsufficientFundsException(amount, Balance);
        }

        Balance -= amount;
    }
}
