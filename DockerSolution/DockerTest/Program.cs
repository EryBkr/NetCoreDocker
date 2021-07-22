using System;

namespace DockerTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int i= 1;
            while (i<10000)
            {
                Console.WriteLine($"i değeri: {i}");
                i++;
                System.Threading.Thread.Sleep(1000);
            }
            
        }
    }
}
