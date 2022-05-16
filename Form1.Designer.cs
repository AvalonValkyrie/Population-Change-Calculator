namespace Baldwin_ASG5_Population
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxStartingOrganismNumber = new System.Windows.Forms.TextBox();
            this.textBoxAvgDailyPercentIncrease = new System.Windows.Forms.TextBox();
            this.textBoxNumberOfDays = new System.Windows.Forms.TextBox();
            this.listBoxApproxPopulation = new System.Windows.Forms.ListBox();
            this.buttonCalculatePopulation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Starting number of organisms:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Average daily % increase:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Number of days to multiply:";
            // 
            // textBoxStartingOrganismNumber
            // 
            this.textBoxStartingOrganismNumber.Location = new System.Drawing.Point(164, 16);
            this.textBoxStartingOrganismNumber.Name = "textBoxStartingOrganismNumber";
            this.textBoxStartingOrganismNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxStartingOrganismNumber.TabIndex = 3;
            this.textBoxStartingOrganismNumber.Text = "1000";
            // 
            // textBoxAvgDailyPercentIncrease
            // 
            this.textBoxAvgDailyPercentIncrease.Location = new System.Drawing.Point(164, 43);
            this.textBoxAvgDailyPercentIncrease.Name = "textBoxAvgDailyPercentIncrease";
            this.textBoxAvgDailyPercentIncrease.Size = new System.Drawing.Size(100, 20);
            this.textBoxAvgDailyPercentIncrease.TabIndex = 4;
            this.textBoxAvgDailyPercentIncrease.Text = "10";
            // 
            // textBoxNumberOfDays
            // 
            this.textBoxNumberOfDays.Location = new System.Drawing.Point(164, 69);
            this.textBoxNumberOfDays.Name = "textBoxNumberOfDays";
            this.textBoxNumberOfDays.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumberOfDays.TabIndex = 5;
            this.textBoxNumberOfDays.Text = "5";
            // 
            // listBoxApproxPopulation
            // 
            this.listBoxApproxPopulation.FormattingEnabled = true;
            this.listBoxApproxPopulation.Location = new System.Drawing.Point(14, 113);
            this.listBoxApproxPopulation.Name = "listBoxApproxPopulation";
            this.listBoxApproxPopulation.Size = new System.Drawing.Size(540, 329);
            this.listBoxApproxPopulation.TabIndex = 6;
            // 
            // buttonCalculatePopulation
            // 
            this.buttonCalculatePopulation.Location = new System.Drawing.Point(295, 67);
            this.buttonCalculatePopulation.Name = "buttonCalculatePopulation";
            this.buttonCalculatePopulation.Size = new System.Drawing.Size(119, 23);
            this.buttonCalculatePopulation.TabIndex = 7;
            this.buttonCalculatePopulation.Text = "Calculate";
            this.buttonCalculatePopulation.UseVisualStyleBackColor = true;
            this.buttonCalculatePopulation.Click += new System.EventHandler(this.buttonCalculatePopulation_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 450);
            this.Controls.Add(this.buttonCalculatePopulation);
            this.Controls.Add(this.listBoxApproxPopulation);
            this.Controls.Add(this.textBoxNumberOfDays);
            this.Controls.Add(this.textBoxAvgDailyPercentIncrease);
            this.Controls.Add(this.textBoxStartingOrganismNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Baldwin ASG5 Population";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxStartingOrganismNumber;
        private System.Windows.Forms.TextBox textBoxAvgDailyPercentIncrease;
        private System.Windows.Forms.TextBox textBoxNumberOfDays;
        private System.Windows.Forms.ListBox listBoxApproxPopulation;
        private System.Windows.Forms.Button buttonCalculatePopulation;
    }
}

