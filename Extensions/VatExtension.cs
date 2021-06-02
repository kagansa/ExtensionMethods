namespace VatExtensionExample.Extensions
{
    public static class VatExtension
    {
        public static double Kdv(this double price, int vatRate)
        {
            return price + (price * vatRate / 100);
        }
    }
}