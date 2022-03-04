using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ayi daxil edin:      ");
            string ay = Console.ReadLine();
            if ((ay == "iyun") || (ay == "iyul") || (ay == "avqust"))
                Console.Write("Yay fesli");


            else if ((ay == "sentyabr") || (ay == "oktyabr") || (ay == "noyabr"))
                Console.Write("Payiz fesli");


            else if ((ay == "dekabr") || (ay == "yanvar") || (ay == "fevral"))
                Console.Write("Qis fesli");


            else if ((ay == "mart") || (ay == "aprel") || (ay == "may"))
                Console.Write("Yaz fesli");
            else
                Console.Write("Daxil etdiyiniz Ay adi deyil");

            Console.ReadKey();

        }
    }
}