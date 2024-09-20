namespace Twitter;

class Twitter
{
    static void Main(string[] args)
    {
        string message = Console.ReadLine();
        int g = message.Length;
        if (g > 140)
        {
            Console.WriteLine("Rejected");
        }
        else
        {
            Console.WriteLine("Posted");
        }
    }
}
