using System;

public class Converter
{
    private double usdToUah;
    private double eurToUah;

    public Converter(double usdToUah, double eurToUah)
    {
        this.usdToUah = usdToUah;
        this.eurToUah = eurToUah;
    }

    public double ConvertUahToUsd(double uahAmount)
    {
        return uahAmount / usdToUah;
    }

    public double ConvertUsdToUah(double usdAmount)
    {
        return usdAmount * usdToUah;
    }

    public double ConvertUahToEur(double uahAmount)
    {
        return uahAmount / eurToUah;
    }

    public double ConvertEurToUah(double eurAmount)
    {
        return eurAmount * eurToUah;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Converter converter = new Converter(37.5, 40); 

        Console.WriteLine("Choose option:");
        Console.WriteLine("1 -  UAH to USD");
        Console.WriteLine("2 -  USD to UAH");
        Console.WriteLine("3 -  UAH to EUR");
        Console.WriteLine("4 -  EUR to UAH");

        int choice = int.Parse(Console.ReadLine());

        Console.Write("Enter sum: ");
        double amount = double.Parse(Console.ReadLine());

        double result = 0;

        switch (choice)
        {
            case 1:
                result = converter.ConvertUahToUsd(amount);
                Console.WriteLine($"{amount} UAH = {result} USD");
                break;
            case 2:
                result = converter.ConvertUsdToUah(amount);
                Console.WriteLine($"{amount} USD = {result} UAH");
                break;
            case 3:
                result = converter.ConvertUahToEur(amount);
                Console.WriteLine($"{amount} UAH = {result} EUR");
                break;
            case 4:
                result = converter.ConvertEurToUah(amount);
                Console.WriteLine($"{amount} EUR = {result} UAH");
                break;
            default:
                Console.WriteLine("Невірний вибір операції.");
                break;
        }
    }
}
