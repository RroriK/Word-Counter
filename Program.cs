namespace Word_Counter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your text");
            Console.Write(">>> "); string usText = Console.ReadLine();

            int usLeng = usText.Length;

            Console.WriteLine($"You have entered {usLeng} characters");
        }
    }
}