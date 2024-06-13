using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeilleurMoment
{
    public class CalculProfits
    {
        public int CalculcalculateProfits(int[] pricesByDays ) 
        { int profitMaximun = 0;
          bool thereIsNoMin = false;
            while (!thereIsNoMin)
            {
               int indexOfMin = indexOfMinimumInArrayNotZero(pricesByDays);
                if (indexOfMin > 0)
                { 
                    int pricesByDay = pricesByDays[indexOfMin];
                    List<int> dayOfMaxPriceAfter = maximumInArray(pricesByDays, indexOfMin + 1);
                }
            }
            return profitMaximun;
        }

        private int indexOfMinimumInArrayNotZero(int[] arrayToProcessing)
        {   int minimumInArray  = arrayToProcessing.Max();
            int lenghtArray     = arrayToProcessing.Length;
            int indexMinInArray = -1 ;

            for (int i=0;i< lenghtArray;i++)
            {
                if ( arrayToProcessing[i]< minimumInArray && arrayToProcessing[i] != 0) 
                {
                    indexMinInArray = i;
                }
            }
            return indexMinInArray ;
            ;
        }

        private List<int> maximumInArray(int[] arrayToProcessing, int indexOfStart)
        {
            int maximumInArray = 0;
            int lenghtArray = arrayToProcessing.Length;
            List<int> list = new List<int>();

            for (int i = indexOfStart; i < lenghtArray; i++) 
            {
                if (maximumInArray < arrayToProcessing[i]) 
                {
                    maximumInArray = arrayToProcessing[i];
                    list.Add(i);
                }
            }
            return list;
        }
    }
}
