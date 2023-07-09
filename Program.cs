namespace test_app;
class Program
{
    static void Main(string[] args)
    {
        // starting number: 1, end number: 1000
        LetterCounter letterCounter = new LetterCounter(1, 1000);
        int totalLetters = letterCounter.GetCount();
        Console.WriteLine($"total letters used are {totalLetters}");
    }
}
