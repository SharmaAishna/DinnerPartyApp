namespace DinnerPartyApp
{
    public partial class Form1 : Form
    {
        DinnerParty dinnerParty;
        BirthdayParty birthdayParty;
        public Form1()
        {
            InitializeComponent();

            dinnerParty = new((int)numericUpDownPeopleNumber.Value, checkBoxHealthyOption.Checked, checkBoxFancyDecoration.Checked);
            dinnerParty.SetHealthyOption(checkBoxHealthyOption.Checked);
            dinnerParty.CalculateCostOfDecorations(checkBoxFancyDecoration.Checked);
            DisplayDinnerPartyCost();

            birthdayParty = new BirthdayParty((int)numericUpDownBirthday.Value, CheckboxFancyBirthday.Checked, textBoxBirthday.Text);
            DisplayBirthdayPartyCost();
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

        private void FancyBirthday_CheckedChanged(object sender, EventArgs e)
        {
            birthdayParty.CalculateCostOfDecorations(CheckboxFancyBirthday.Checked);
            DisplayBirthdayPartyCost();
        }

        private void textBoxBirthday_TextChanged(object sender, EventArgs e)
        {
            birthdayParty.CakeWriting = textBoxBirthday.Text;
            DisplayBirthdayPartyCost();
        }

        private void numericUpDownBirthday_ValueChanged(object sender, EventArgs e)
        {
            birthdayParty.NumberOfPeople = (int)numericUpDownBirthday.Value;
            DisplayBirthdayPartyCost();
        }

        private void DisplayBirthdayPartyCost()
        {
            decimal cost = BirthdayParty.CalculateCost(CheckboxFancyBirthday.Checked);
            CostLabel.Text = cost.ToString("c");
        }

    }
}