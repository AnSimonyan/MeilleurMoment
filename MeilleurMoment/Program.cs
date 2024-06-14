namespace MeilleurMoment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] pricesByDays = new int[] { 1,2,3,4,5};
            //int[] pricesByDays = new int[] { 7, 1, 5, 3, 6,4 };
            int[] pricesByDays = new int[] { 7,6,4,3,1 };
            ProfitMaximum c = new ProfitMaximum();
            int myProfit = c.ProfitMaximumForPriceArray(pricesByDays);
            Console.WriteLine(myProfit);
        }
    }
}
