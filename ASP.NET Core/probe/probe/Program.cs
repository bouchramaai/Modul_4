namespace probe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText(@"C:\Users\ITAD2-TN12\Desktop\ASP.NET Core\probe.txt");

            Console.WriteLine(text);
        }
    }
}
