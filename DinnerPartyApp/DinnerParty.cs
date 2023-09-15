using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinnerPartyApp
{
    public class DinnerParty:Party
    {
        
        public decimal CostOfBeveragesPerPerson;

        public DinnerParty(int numberOfPeople, bool healthyOption, bool fancyDecorations)
            :base(numberOfPeople,fancyDecorations)
        {
           
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

        public decimal CalculateCost(bool healthyOption)
        {
            decimal totalCost= base.CalculateCost() + (CostOfBeveragesPerPerson* NumberOfPeople);

            if (healthyOption)
            {
              return  totalCost *= .95M;
            }
            else
            return totalCost;
        }
    }
}
