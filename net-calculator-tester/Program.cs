namespace net_calculator_tester
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Calculator!");

            Calculator calculator = new Calculator();
            int x = 1;
            int y = 2;
            Console.WriteLine($"Addition: {x} + {y} = {calculator.Add(x, y)}");

            //.....
        }
    }
}
