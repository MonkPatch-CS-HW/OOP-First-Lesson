namespace Task1;

public class Program
{
    public static void Main(string[] args)
    {
        switch (args)
        {
            case ["table", var n]:
                TablePrinter.PrintTable(int.Parse(n));
                break;
            case ["vulgar", var input, var filename]:
                var r = new Rational(input);
                var output = VulgarFractions.ToMixedVulgarFraction(r);
                File.WriteAllText(filename, output);
                break;
            default:
                Console.WriteLine("Usage: Task1.exe command rational filename");
                break;
        }
    }
}