namespace MeilleurMoment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] pricesByDays = new int[] { 7, 1, 4, 3, 2, 7 };
            CalculProfits c = new CalculProfits();
            int myProfit = c.CalculcalculateProfits(pricesByDays);
            Console.WriteLine(myProfit);
        }
    }
}
