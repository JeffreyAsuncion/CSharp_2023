using System;

namespace ConsoleApp2
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool canIVote = true;
            canIVote = false;

            Console.WriteLine("Biggest Integer : {0}", int.MaxValue);
            Console.WriteLine("Smallest Integer : {0}", int.MinValue);

            Console.WriteLine("Biggest Long : {0}", long.MaxValue);
            Console.WriteLine("Smallest Long : {0}", long.MinValue);

            decimal decPiVal = 3.1415926534897932384626433832M;
            decimal decBigNum = 3.00000000000000000000000000011M;
            Console.WriteLine("DEC : PI + bigNum = {0}", 
                decPiVal + decBigNum);

            Console.Read();
        }
    }
}