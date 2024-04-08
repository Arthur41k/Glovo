using System.Security.Cryptography;

namespace Glovo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Restaurant restaurant = new Restaurant();
            restaurant.AddInfo();
        }
    }
}
