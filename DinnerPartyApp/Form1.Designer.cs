namespace DinnerPartyApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabDinnerParty = new TabPage();
            label4 = new Label();
            label3 = new Label();
            CostLabel = new Label();
            lblCost = new Label();
            checkBoxHealthyOption = new CheckBox();
            checkBoxFancyDecoration = new CheckBox();
            numericUpDownPeopleNumber = new NumericUpDown();
            label1 = new Label();
            tabBirthdayParty = new TabPage();
            textBoxBirthday = new TextBox();
            labelCakeWriting = new Label();
            CostBirthday = new Label();
            label5 = new Label();
            CheckboxFancyBirthday = new CheckBox();
            numericUpDownBirthday = new NumericUpDown();
            BirthdayNumberOfPeople = new Label();
            label2 = new Label();
            label6 = new Label();
            label7 = new Label();
            tabControl1.SuspendLayout();
            tabDinnerParty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPeopleNumber).BeginInit();
            tabBirthdayParty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBirthday).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabDinnerParty);
            tabControl1.Controls.Add(tabBirthdayParty);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(659, 362);
            tabControl1.TabIndex = 0;
            // 
            // tabDinnerParty
            // 
            tabDinnerParty.Controls.Add(label4);
            tabDinnerParty.Controls.Add(label3);
            tabDinnerParty.Controls.Add(CostLabel);
            tabDinnerParty.Controls.Add(lblCost);
            tabDinnerParty.Controls.Add(checkBoxHealthyOption);
            tabDinnerParty.Controls.Add(checkBoxFancyDecoration);
            tabDinnerParty.Controls.Add(numericUpDownPeopleNumber);
            tabDinnerParty.Controls.Add(label1);
            tabDinnerParty.Location = new Point(4, 29);
            tabDinnerParty.Name = "tabDinnerParty";
            tabDinnerParty.Padding = new Padding(3);
            tabDinnerParty.Size = new Size(651, 329);
            tabDinnerParty.TabIndex = 0;
            tabDinnerParty.Text = "Dinner Party";
            tabDinnerParty.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 56);
            label4.Name = "label4";
            label4.Size = new Size(614, 20);
            label4.TabIndex = 15;
            label4.Text = "If cost of decoration is fancy 15 pp  and 50 one time cost else 7.50 pp with 30 one time cost";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 29);
            label3.Name = "label3";
            label3.Size = new Size(517, 20);
            label3.TabIndex = 14;
            label3.Text = "If Healthy option $5 per person and 5% discount on party else 20 per person ";
            // 
            // CostLabel
            // 
            CostLabel.BorderStyle = BorderStyle.Fixed3D;
            CostLabel.Location = new Point(148, 277);
            CostLabel.Name = "CostLabel";
            CostLabel.Size = new Size(153, 22);
            CostLabel.TabIndex = 13;
            CostLabel.Text = "$";
            // 
            // lblCost
            // 
            lblCost.AutoSize = true;
            lblCost.Location = new Point(94, 277);
            lblCost.Name = "lblCost";
            lblCost.Size = new Size(38, 20);
            lblCost.TabIndex = 12;
            lblCost.Text = "Cost";
            // 
            // checkBoxHealthyOption
            // 
            checkBoxHealthyOption.AutoSize = true;
            checkBoxHealthyOption.Location = new Point(94, 217);
            checkBoxHealthyOption.Name = "checkBoxHealthyOption";
            checkBoxHealthyOption.Size = new Size(132, 24);
            checkBoxHealthyOption.TabIndex = 11;
            checkBoxHealthyOption.Text = "Healthy Option";
            checkBoxHealthyOption.UseVisualStyleBackColor = true;
            checkBoxHealthyOption.CheckedChanged += checkBoxHealthyOption_CheckedChanged;
            // 
            // checkBoxFancyDecoration
            // 
            checkBoxFancyDecoration.AutoSize = true;
            checkBoxFancyDecoration.Location = new Point(94, 187);
            checkBoxFancyDecoration.Name = "checkBoxFancyDecoration";
            checkBoxFancyDecoration.Size = new Size(149, 24);
            checkBoxFancyDecoration.TabIndex = 10;
            checkBoxFancyDecoration.Text = "Fancy decorations";
            checkBoxFancyDecoration.UseVisualStyleBackColor = true;
            checkBoxFancyDecoration.CheckedChanged += checkBoxFancyDecoration_CheckedChanged;
            // 
            // numericUpDownPeopleNumber
            // 
            numericUpDownPeopleNumber.Location = new Point(94, 141);
            numericUpDownPeopleNumber.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            numericUpDownPeopleNumber.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownPeopleNumber.Name = "numericUpDownPeopleNumber";
            numericUpDownPeopleNumber.Size = new Size(207, 27);
            numericUpDownPeopleNumber.TabIndex = 9;
            numericUpDownPeopleNumber.Value = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDownPeopleNumber.ValueChanged += numericUpDownPeopleNumber_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(94, 104);
            label1.Name = "label1";
            label1.Size = new Size(124, 20);
            label1.TabIndex = 8;
            label1.Text = "NumberOfPeople";
            // 
            // tabBirthdayParty
            // 
            tabBirthdayParty.Controls.Add(label7);
            tabBirthdayParty.Controls.Add(label6);
            tabBirthdayParty.Controls.Add(label2);
            tabBirthdayParty.Controls.Add(textBoxBirthday);
            tabBirthdayParty.Controls.Add(labelCakeWriting);
            tabBirthdayParty.Controls.Add(CostBirthday);
            tabBirthdayParty.Controls.Add(label5);
            tabBirthdayParty.Controls.Add(CheckboxFancyBirthday);
            tabBirthdayParty.Controls.Add(numericUpDownBirthday);
            tabBirthdayParty.Controls.Add(BirthdayNumberOfPeople);
            tabBirthdayParty.Location = new Point(4, 29);
            tabBirthdayParty.Name = "tabBirthdayParty";
            tabBirthdayParty.Padding = new Padding(3);
            tabBirthdayParty.Size = new Size(651, 329);
            tabBirthdayParty.TabIndex = 1;
            tabBirthdayParty.Text = "Birthday Party";
            tabBirthdayParty.UseVisualStyleBackColor = true;
            // 
            // textBoxBirthday
            // 
            textBoxBirthday.Location = new Point(55, 227);
            textBoxBirthday.Name = "textBoxBirthday";
            textBoxBirthday.Size = new Size(203, 27);
            textBoxBirthday.TabIndex = 18;
            textBoxBirthday.Text = "Happy Birthday";
            textBoxBirthday.TextChanged += textBoxBirthday_TextChanged;
            // 
            // labelCakeWriting
            // 
            labelCakeWriting.AutoSize = true;
            labelCakeWriting.Location = new Point(51, 198);
            labelCakeWriting.Name = "labelCakeWriting";
            labelCakeWriting.Size = new Size(94, 20);
            labelCakeWriting.TabIndex = 17;
            labelCakeWriting.Text = "Cake Writing";
            // 
            // CostBirthday
            // 
            CostBirthday.BorderStyle = BorderStyle.Fixed3D;
            CostBirthday.Location = new Point(109, 279);
            CostBirthday.Name = "CostBirthday";
            CostBirthday.Size = new Size(153, 24);
            CostBirthday.TabIndex = 16;
            CostBirthday.Text = "$";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(55, 279);
            label5.Name = "label5";
            label5.Size = new Size(38, 20);
            label5.TabIndex = 15;
            label5.Text = "Cost";
            // 
            // CheckboxFancyBirthday
            // 
            CheckboxFancyBirthday.AutoSize = true;
            CheckboxFancyBirthday.Location = new Point(55, 161);
            CheckboxFancyBirthday.Name = "CheckboxFancyBirthday";
            CheckboxFancyBirthday.Size = new Size(149, 24);
            CheckboxFancyBirthday.TabIndex = 14;
            CheckboxFancyBirthday.Text = "Fancy decorations";
            CheckboxFancyBirthday.UseVisualStyleBackColor = true;
            CheckboxFancyBirthday.CheckedChanged += FancyBirthday_CheckedChanged;
            // 
            // numericUpDownBirthday
            // 
            numericUpDownBirthday.Location = new Point(51, 117);
            numericUpDownBirthday.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            numericUpDownBirthday.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownBirthday.Name = "numericUpDownBirthday";
            numericUpDownBirthday.Size = new Size(207, 27);
            numericUpDownBirthday.TabIndex = 11;
            numericUpDownBirthday.Value = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDownBirthday.ValueChanged += numericUpDownBirthday_ValueChanged;
            // 
            // BirthdayNumberOfPeople
            // 
            BirthdayNumberOfPeople.AutoSize = true;
            BirthdayNumberOfPeople.Location = new Point(51, 85);
            BirthdayNumberOfPeople.Name = "BirthdayNumberOfPeople";
            BirthdayNumberOfPeople.Size = new Size(124, 20);
            BirthdayNumberOfPeople.TabIndex = 10;
            BirthdayNumberOfPeople.Text = "NumberOfPeople";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 15);
            label2.Name = "label2";
            label2.Size = new Size(271, 20);
            label2.TabIndex = 19;
            label2.Text = "If No. Of People more than 12,add $100";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 35);
            label6.Name = "label6";
            label6.Size = new Size(443, 20);
            label6.TabIndex = 20;
            label6.Text = "Cake for less than 4 people 8 inch cake $40.more 16inch cake $75.";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 55);
            label7.Name = "label7";
            label7.Size = new Size(627, 20);
            label7.TabIndex = 21;
            label7.Text = "Writing on cake each letter .25. 8 inch can have max 16 letters.16 inch can have max 40 letters.";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(657, 360);
            Controls.Add(tabControl1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Party Planner";
            tabControl1.ResumeLayout(false);
            tabDinnerParty.ResumeLayout(false);
            tabDinnerParty.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPeopleNumber).EndInit();
            tabBirthdayParty.ResumeLayout(false);
            tabBirthdayParty.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBirthday).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabDinnerParty;
        private Label label4;
        private Label label3;
        private Label CostLabel;
        private Label lblCost;
        private CheckBox checkBoxHealthyOption;
        private CheckBox checkBoxFancyDecoration;
        private NumericUpDown numericUpDownPeopleNumber;
        private Label label1;
        private TabPage tabBirthdayParty;
        private NumericUpDown numericUpDownBirthday;
        private Label BirthdayNumberOfPeople;
        private TextBox textBoxBirthday;
        private Label labelCakeWriting;
        private Label CostBirthday;
        private Label label5;
        private CheckBox CheckboxFancyBirthday;
        private Label label2;
        private Label label7;
        private Label label6;
    }
}