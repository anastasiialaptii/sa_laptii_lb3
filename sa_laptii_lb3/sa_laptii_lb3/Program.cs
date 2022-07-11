using System;

namespace sa_laptii_lb3
{
    class Program
    {
        static void Main(string[] args)
        {
            Scanner scanner = new Scanner("H:\\university\\магистратура кек ты до нее дожила\\war semester\\вечур\\lb3\\CocoR-CSharp\\src\\Input.txt");
            Parser parser = new Parser(scanner);
            parser.Parse();
            Console.Write(parser.errors.count + " errors detected");

            Console.ReadKey();
        }
    }
}
