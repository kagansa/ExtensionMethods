using System;
using VatExtensionExample.Extensions;

namespace VatExtensionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            double productPrice = 100;
            Console.WriteLine(productPrice.Kdv(18));
        }
    }
}
