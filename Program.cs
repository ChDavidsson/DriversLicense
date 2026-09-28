namespace DriversLicense;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hur gammal är du?");
        int age = int.Parse(Console.ReadLine()!);

        if (age < 18)
        {
            Console.WriteLine("Du är för ung för att köra bil");
            return;
        }

        Console.WriteLine("Har du körkort? (ja/nej)");
        string körkort = Console.ReadLine()!;

        if (körkort == "ja")
        {
            Console.WriteLine("Du får köra bil");
        }
        else
        {
            Console.WriteLine("Du får inte köra bil");
        }
    }
}
