using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinnerPartyApp
{
    public class Party
    {
        public const int CostOfFoodPerPerson = 25;

        private int numberOfPeople;

        private bool fancyDecorations;
        public virtual int NumberOfPeople
        {
            get { return numberOfPeople; }
            set
            {
                numberOfPeople = value;
                CalculateCostOfDecorations(fancyDecorations);
            }
        }
        public decimal CostOfDecorations = 0;

        public Party(int numberOfPeople, bool fancyDecorations)
        {
            this.numberOfPeople = numberOfPeople;
            this.fancyDecorations = fancyDecorations;
        }
        public void CalculateCostOfDecorations(bool fancy)
        {
            fancyDecorations = fancy;
            if (fancy)
            {
                CostOfDecorations = (NumberOfPeople * 15.00M) + 50;
            }
            else
            {

                CostOfDecorations = (NumberOfPeople * 7.50M) + 30;
            }
        }
        public virtual decimal CalculateCost()
        {
            //Each person costs $25 for food plus beverages
            decimal TotalCost = CostOfDecorations + (numberOfPeople * CostOfFoodPerPerson);
            if (numberOfPeople>12)
                TotalCost += 100;
            
            return TotalCost;

        }
    }
}
