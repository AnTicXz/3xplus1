using System;
using System.Threading;


namespace _3x_1
{
    class Program
    {   
        static void Main(string[] args)
        {
             int ThreeX(int value)
            {
                while(value  1)
                {
                    if(value % 2 == 0)
                    {
                        value = value /2;
                    }
                    else
                    {
                        value = 3 * value + 1;
                    }
                }
                return value;
            }
            Console.WriteLine(ThreeX(5));
        }
    }
}
