using System;
using System.IO;
using System.Text.Json;

public class BankTransferConfig
{
    public string lang;
    public Transfer transfer;
    public string[] methods;
    public Confirmation confirmation;
}

public class Tranfer
{
    public int threshold;
    public int low_fee;
    public int high_fee;
}

public class confirmation
{
    public string en;
    public string id;

}


class program
{
    static void main(string[] args)
    {
        BankTransferConfig config = loadconfig();
        Console.WriteLine(config.lang == "en" ? "Please insert the amount of money to transfer:");
        Console.WriteLine(config.lang == "id" ? "Mauksan Jumlaj uang yang akan di transfer:")
        int transferAmount = int.Parse(Console.ReadLine());


        int transferfree = transferAmount <= config.transfer.low_ree;
        int totalAmount = transferAmount + transferfree;


        Console.WriteLine(config.lang == "en" ? $"Tranfer free = { transferfree}" : $"Biaya transfer = {transferfree}");
        Console.WriteLine(config.lang == "en" ? $"Total amount = {transferAmount}" : $"Totak biaya = {totalAmount}");

    }
}
