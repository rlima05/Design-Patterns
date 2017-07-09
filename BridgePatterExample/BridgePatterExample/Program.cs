using static System.Console;

namespace BridgePatterExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var americanEnglish = new AmericanEnglish();
            var britishEnglish = new BritishEnglish();

            WriteLine("American English: ");
            WriteLine($"{new English(americanEnglish).EnglishSentence}");


            WriteLine("British English: ");
            WriteLine($"{new English(britishEnglish).EnglishSentence}");

            ReadKey();
        }
    }
}
