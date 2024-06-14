using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeilleurMoment
{
    internal class ProfitMaximum

    {
        public int ProfitMaximumForPriceArray(int[] priceArrayByDays) 
        {
            int startIbdex = 0; int arrayLength = priceArrayByDays.Length;
            List<int> profitlist = new List<int>();

            while (startIbdex < arrayLength-1)
            {
                int endIndex = GetMaxProfitIndex (startIbdex, priceArrayByDays);

                int profitToIndex = СalculateProfitByIndexes(startIbdex, endIndex, priceArrayByDays);

                AddToProfitList(profitlist, profitToIndex);

                startIbdex= endIndex+1;
            }
            return profitlist.Sum();
        }

        public int GetMaxProfitIndex(int startIndex,int[] priceArrayByDays) 
        {
            int arrayLength     = priceArrayByDays.Length;
            int maxProfitIndex  = startIndex;

            for (int i = startIndex; i < arrayLength-1; i++) 
            {
                if (priceArrayByDays[maxProfitIndex] < priceArrayByDays[i + 1])
                {
                    maxProfitIndex = i+1;
                }
                else 
                {
                    break;
                } 
            }
            return maxProfitIndex;
        }

        public int СalculateProfitByIndexes(int startIndex,int endIndex, int[] priceArrayByDays)
        { 
            int profitResultat = 0;

            if (startIndex >= 0 && endIndex < priceArrayByDays.Length)
            {
                profitResultat = priceArrayByDays[endIndex] - priceArrayByDays[startIndex];
            }
            return profitResultat;
        }

        private void AddToProfitList(List<int> profitList, int profit)
        {
            profitList.Add(profit);
        }

    }
}
