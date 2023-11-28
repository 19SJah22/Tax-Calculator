namespace PRG521_FA3_TaxCalculator
{
    partial class TaxCalculator
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
            this.SamountLabel = new System.Windows.Forms.Label();
            this.StaxLabel = new System.Windows.Forms.Label();
            this.UserTexBox = new System.Windows.Forms.TextBox();
            this.PercNum = new System.Windows.Forms.NumericUpDown();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PercNum)).BeginInit();
            this.SuspendLayout();
            // 
            // SamountLabel
            // 
            this.SamountLabel.AutoSize = true;
            this.SamountLabel.Location = new System.Drawing.Point(152, 112);
            this.SamountLabel.Name = "SamountLabel";
            this.SamountLabel.Size = new System.Drawing.Size(98, 16);
            this.SamountLabel.TabIndex = 6;
            this.SamountLabel.Text = "Sales amount : ";
            this.SamountLabel.Click += new System.EventHandler(this.SamountLabel_Click);
            // 
            // StaxLabel
            // 
            this.StaxLabel.AutoSize = true;
            this.StaxLabel.Location = new System.Drawing.Point(173, 171);
            this.StaxLabel.Name = "StaxLabel";
            this.StaxLabel.Size = new System.Drawing.Size(77, 16);
            this.StaxLabel.TabIndex = 7;
            this.StaxLabel.Text = "Sales Tax : ";
            this.StaxLabel.Click += new System.EventHandler(this.StaxLabel_Click);
            // 
            // UserTexBox
            // 
            this.UserTexBox.Location = new System.Drawing.Point(308, 106);
            this.UserTexBox.Name = "UserTexBox";
            this.UserTexBox.Size = new System.Drawing.Size(182, 22);
            this.UserTexBox.TabIndex = 8;
            this.UserTexBox.TextChanged += new System.EventHandler(this.UserTexBox_TextChanged);
            // 
            // PercNum
            // 
            this.PercNum.Location = new System.Drawing.Point(308, 165);
            this.PercNum.Name = "PercNum";
            this.PercNum.Size = new System.Drawing.Size(138, 22);
            this.PercNum.TabIndex = 9;
            this.PercNum.ValueChanged += new System.EventHandler(this.PercNum_ValueChanged);
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(254, 231);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 28);
            this.SubmitButton.TabIndex = 10;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(347, 231);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 29);
            this.ClearButton.TabIndex = 11;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(442, 232);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 28);
            this.ExitButton.TabIndex = 12;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // TaxCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.PercNum);
            this.Controls.Add(this.UserTexBox);
            this.Controls.Add(this.StaxLabel);
            this.Controls.Add(this.SamountLabel);
            this.Name = "TaxCalculator";
            this.Text = "Tax Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.PercNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SamountLabel;
        private System.Windows.Forms.Label StaxLabel;
        private System.Windows.Forms.TextBox UserTexBox;
        private System.Windows.Forms.NumericUpDown PercNum;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button ExitButton;
    }
}

