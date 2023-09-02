using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinnerPartyApp
{
    public class DinnerParty
    {
        const int CostOfFoodPerPerson = 25;
        private int numberOfPeople;
        public int NumberOfPeople { 
            get { return numberOfPeople; }
            set {
                numberOfPeople = value;
               CalculateCostOfDecorations(fancyDecorations);
            }
        }

        private bool fancyDecorations;

       public decimal CostOfDecorations = 0;
       public decimal CostOfBeveragesPerPerson;

        public DinnerParty(int numberOfPeople, bool healthyOption, bool fancyDecorations)
        {
            this.NumberOfPeople = numberOfPeople;
            this.fancyDecorations = fancyDecorations;
            SetHealthyOption(healthyOption);
            CalculateCostOfDecorations(fancyDecorations);

        }
      
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
            decimal totalCost= CostOfDecorations + ((CostOfBeveragesPerPerson+
            CostOfFoodPerPerson )* NumberOfPeople);

            if (healthyOption)
            {
              return  totalCost *= .95M;
            }
            else
            return totalCost;
        }
    }
}
