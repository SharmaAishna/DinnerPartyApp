using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinnerPartyApp
{
    public class DinnerParty
    {
        public int NumberOfPeople;
        decimal CostOfDecorations = 0;
        decimal CostOfBeveragesPerPerson;
        const int CostOfFoodPerPerson = 25;
        public void SetHealthyOption(bool healthOption)
        {
            if (healthOption)
            {
                CostOfBeveragesPerPerson = 5.00M;
            }
            else
            {
                CostOfBeveragesPerPerson = 20.00M;
            }
        }

        public void CalculateCostOfDecorations(bool fancy)
        {
            if (fancy)
            {
                CostOfDecorations = (NumberOfPeople * 15.00M) + 50;
            }
            else
            {

                CostOfDecorations = (NumberOfPeople * 7.50M) + 30;
            }
        }

        public decimal CalculateCost(bool healthyOption)
        {
            decimal TotalCost= CostOfDecorations + ((CostOfBeveragesPerPerson+
            CostOfFoodPerPerson )* NumberOfPeople);

            if (healthyOption)
            {
              return  TotalCost *= .95M;
            }
            else
            return TotalCost;
        }
    }
}
