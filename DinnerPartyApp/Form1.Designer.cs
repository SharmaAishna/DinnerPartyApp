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
            label1 = new Label();
            numericUpDownPeopleNumber = new NumericUpDown();
            checkBoxFancyDecoration = new CheckBox();
            checkBoxHealthyOption = new CheckBox();
            lblCost = new Label();
            CostLabel = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPeopleNumber).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(91, 84);
            label1.Name = "label1";
            label1.Size = new Size(124, 20);
            label1.TabIndex = 0;
            label1.Text = "NumberOfPeople";
            // 
            // numericUpDownPeopleNumber
            // 
            numericUpDownPeopleNumber.Location = new Point(91, 121);
            numericUpDownPeopleNumber.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            numericUpDownPeopleNumber.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownPeopleNumber.Name = "numericUpDownPeopleNumber";
            numericUpDownPeopleNumber.Size = new Size(207, 27);
            numericUpDownPeopleNumber.TabIndex = 1;
            numericUpDownPeopleNumber.Value = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDownPeopleNumber.ValueChanged += numericUpDownPeopleNumber_ValueChanged;
            // 
            // checkBoxFancyDecoration
            // 
            checkBoxFancyDecoration.AutoSize = true;
            checkBoxFancyDecoration.Location = new Point(91, 167);
            checkBoxFancyDecoration.Name = "checkBoxFancyDecoration";
            checkBoxFancyDecoration.Size = new Size(149, 24);
            checkBoxFancyDecoration.TabIndex = 2;
            checkBoxFancyDecoration.Text = "Fancy decorations";
            checkBoxFancyDecoration.UseVisualStyleBackColor = true;
            checkBoxFancyDecoration.CheckedChanged += checkBoxFancyDecoration_CheckedChanged;
            // 
            // checkBoxHealthyOption
            // 
            checkBoxHealthyOption.AutoSize = true;
            checkBoxHealthyOption.Location = new Point(91, 197);
            checkBoxHealthyOption.Name = "checkBoxHealthyOption";
            checkBoxHealthyOption.Size = new Size(132, 24);
            checkBoxHealthyOption.TabIndex = 3;
            checkBoxHealthyOption.Text = "Healthy Option";
            checkBoxHealthyOption.UseVisualStyleBackColor = true;
            checkBoxHealthyOption.CheckedChanged += checkBoxHealthyOption_CheckedChanged;
            // 
            // lblCost
            // 
            lblCost.AutoSize = true;
            lblCost.Location = new Point(91, 257);
            lblCost.Name = "lblCost";
            lblCost.Size = new Size(38, 20);
            lblCost.TabIndex = 4;
            lblCost.Text = "Cost";
            // 
            // CostLabel
            // 
            CostLabel.BorderStyle = BorderStyle.Fixed3D;
            CostLabel.Location = new Point(145, 257);
            CostLabel.Name = "CostLabel";
            CostLabel.Size = new Size(153, 22);
            CostLabel.TabIndex = 5;
            CostLabel.Text = "$";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 9);
            label3.Name = "label3";
            label3.Size = new Size(517, 20);
            label3.TabIndex = 6;
            label3.Text = "If Healthy option $5 per person and 5% discount on party else 20 per person ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 36);
            label4.Name = "label4";
            label4.Size = new Size(614, 20);
            label4.TabIndex = 7;
            label4.Text = "If cost of decoration is fancy 15 pp  and 50 one time cost else 7.50 pp with 30 one time cost";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(657, 360);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(CostLabel);
            Controls.Add(lblCost);
            Controls.Add(checkBoxHealthyOption);
            Controls.Add(checkBoxFancyDecoration);
            Controls.Add(numericUpDownPeopleNumber);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Party Planner";
            ((System.ComponentModel.ISupportInitialize)numericUpDownPeopleNumber).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private NumericUpDown numericUpDownPeopleNumber;
        private CheckBox checkBoxFancyDecoration;
        private CheckBox checkBoxHealthyOption;
        private Label lblCost;
        private Label CostLabel;
        private Label label3;
        private Label label4;
    }
}