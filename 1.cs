using System;

public enum AccountType {
    Checking,
    Deposit
}
class Program {
    static void Main() {

        AccountType goldAccount = AccountType.Checking, platinumAccount = AccountType.Deposit;
        Console.WriteLine("The Customer Account Type is {0}", goldAccount);
        Console.WriteLine("The Customer Account Type is {0}", platinumAccount);

    }
}