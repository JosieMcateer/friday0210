namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            task t = new task();
            t.inttochar(789);    // seven hundred and eighty nine
            t.inttochar(1005);  // one thousand and five
            t.inttochar(9784);     // nine thousand seven hundred and eighty four
            t.inttochar(100005);    // invalid number
            t.inttochar(-100);     // invalid number
            Console.Read();
        }
    }
}
