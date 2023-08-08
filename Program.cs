namespace part2_HW3
{
    internal class Program
    {
        delegate void PrintMsg(string someMsg);
        static void Main(string[] args)
        {
            PrintMsg printMsg;
            var printObject = new PrintClass();
            printMsg = printObject.PrintGreen;
            printMsg += printObject.PrintOrange;

            printMsg("Print some msg in correspronding color");

            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }

    public class PrintClass
    {
        public void PrintGreen(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(msg);
        }
        public void PrintOrange(string msg)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(msg);
        }
    }
}