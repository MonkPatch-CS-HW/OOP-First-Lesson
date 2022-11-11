namespace Task1;

public class Program
{
    public static void Main(string[] args)
    {
        switch (args)
        {
            case ["table", var n]:
            {
                TablePrinter.PrintTable(int.Parse(n));
                break;
            }
            case ["vulgar", var input, var filename]:
            {
                var r = new Rational(input);
                var output = VulgarFractions.ToMixedVulgarFraction(r);
                File.WriteAllText(filename, output);
                break;
            }
            case ["generate", var number, var filename]:
            {
                using var file = new StreamWriter(filename);
                for (var i = 0; i < int.Parse(number); i++)
                {
                    var numerator1 = 1 + Random.Shared.Next() % 99;
                    var denominator1 = 1 + Random.Shared.Next() % 99;
                    var rational1 = new Rational(numerator1, denominator1);
                    
                    var numerator2 = 1 + Random.Shared.Next() % 99;
                    var denominator2 = 1 + Random.Shared.Next() % 99;
                    var rational2 = new Rational(numerator2, denominator2);
                    
                    var rational3 = rational1 + rational2;

                    var str1 = VulgarFractions.ToMixedVulgarFraction(rational1);
                    var str2 = VulgarFractions.ToMixedVulgarFraction(rational2);
                    var str3 = VulgarFractions.ToMixedVulgarFraction(rational3);
                    
                    file.WriteLine($"{str1}+{str2}={str3}");
                }

                break;
            }
            default:
            {
                Console.WriteLine("Incorrect usage");
                break;
            }
        }
    }
}