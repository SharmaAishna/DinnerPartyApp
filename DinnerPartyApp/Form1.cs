namespace DinnerPartyApp
{
    public partial class Form1 : Form
    {
        DinnerParty dinnerParty;
        public Form1()
        {
            InitializeComponent();
            dinnerParty = new((int)numericUpDownPeopleNumber.Value, checkBoxHealthyOption.Checked, checkBoxFancyDecoration.Checked);

            dinnerParty.SetHealthyOption(checkBoxHealthyOption.Checked);
            dinnerParty.CalculateCostOfDecorations(checkBoxFancyDecoration.Checked);
            DisplayDinnerPartyCost();

        }

        private void checkBoxFancyDecoration_CheckedChanged(object sender, EventArgs e)
        {

            dinnerParty.CalculateCostOfDecorations(checkBoxFancyDecoration.Checked);
            DisplayDinnerPartyCost();
        }

        private void checkBoxHealthyOption_CheckedChanged(object sender, EventArgs e)
        {

            dinnerParty.SetHealthyOption(checkBoxHealthyOption.Checked);
            DisplayDinnerPartyCost();
        }

        private void numericUpDownPeopleNumber_ValueChanged(object sender, EventArgs e)
        {
            dinnerParty.NumberOfPeople = (int)numericUpDownPeopleNumber.Value;
            DisplayDinnerPartyCost();
        }
        private void DisplayDinnerPartyCost()
        {

            decimal cost = dinnerParty.CalculateCost(checkBoxHealthyOption.Checked);
            CostLabel.Text = cost.ToString("c");
        }
    }
}