using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinnerPartyApp
{
    public class BirthdayParty : Party
    {
        int CakeSize;

        private string cakeWriting="";
        public string CakeWriting
        {
            get
            {
                return this.cakeWriting;
            }
            set
            {
                int maxLength;
                if (CakeSize == 8)
                {
                    maxLength = 16;
                }
                maxLength = 40;

                if (value.Length > maxLength)
                {
                    MessageBox.Show("Too many Letters for a cake" + CakeSize + "inch cake");
                }

                if (maxLength > this.cakeWriting.Length)
                {
                    maxLength = this.cakeWriting.Length;
                    this.cakeWriting = cakeWriting.Substring(0, maxLength);
                }
                else
                {
                    this.cakeWriting = value;
                }
                
            }

        }
        public BirthdayParty(int numberOfPeople,bool fancyDecoration, string cakeWriting)
            :base(numberOfPeople,fancyDecoration)
        {
            CalculateCakeSize();
            this.CakeWriting = cakeWriting;
        CalculateCostOfDecorations(fancyDecoration);
        }

        public void CalculateCakeSize()
        {
            if(NumberOfPeople<=4)
                CakeSize = 8;

            CakeSize = 16;
        }
        public override decimal CalculateCost()
        {
            decimal cakeCost;
            if (CakeSize == 8)
            {
                cakeCost = 40M + (CakeWriting.Length * .25M);
            }
            else
            { cakeCost = 75M + (CakeWriting.Length * .25M); }  

            

            return base.CalculateCost() + cakeCost;
        }
       
    }
}
