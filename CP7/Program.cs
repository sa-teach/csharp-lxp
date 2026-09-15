using CP7;

var operations = new List<(string AccountId, decimal Balance, decimal WithdrawAmount)>
{
    ("12345", 1000m, 0m),
    ("123456", 1000m, 2000m),
    ("123456", 1000m, 500m)
};

foreach (var operation in operations)
{
    try
    {
        var account = new BankAccount(operation.AccountId, operation.Balance);

        if (operation.WithdrawAmount > 0)
        {
            account.Withdraw(operation.WithdrawAmount);
        }

        Console.WriteLine(
            $"Счет {account.AccountId}: операция выполнена, баланс = {account.Balance}");
    }
    catch (InsufficientFundsException ex)
    {
        Console.WriteLine(
            $"Недостаточно средств: запрошено {ex.RequestedAmount}, доступно {ex.AvailableBalance}");
    }
    catch (InvalidAccountException ex)
    {
        Console.WriteLine($"Неверный номер счета: {ex.AccountId}");
    }
    catch (BankingException ex)
    {
        Console.WriteLine($"Банковская ошибка: {ex.Message}");
    }
}
