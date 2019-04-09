using System;

namespace DemoConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var number = "1234";
                byte b = Convert.ToByte(number);
            }
            catch (Exception)
            {
                Console.WriteLine("Data type can't be converted");
            }
        }
    }
}
