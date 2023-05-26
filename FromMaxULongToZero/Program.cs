using System;

namespace FromMaxULongToZero
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong maxLong = UInt64.MaxValue;
            int operationsDone = 0;
            Console.WriteLine(maxLong);
            do
            {
                maxLong = (maxLong % 2 == 0) ? maxLong/2 : maxLong-1 ;
                operationsDone++;
                Console.WriteLine(maxLong);
            } while (maxLong != 0);
            Console.WriteLine("Number of operations done over original number:" + operationsDone);
        }
    }
}
