namespace Saaristo_A2_StadiumSeating
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
            this.groupBoxStadium1 = new System.Windows.Forms.GroupBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.calculateButton = new System.Windows.Forms.Button();
            this.groupBoxStadium2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxInput1 = new System.Windows.Forms.TextBox();
            this.textBoxInput2 = new System.Windows.Forms.TextBox();
            this.textBoxInput3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxSum2 = new System.Windows.Forms.TextBox();
            this.textBoxSum3 = new System.Windows.Forms.TextBox();
            this.textBoxSum1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxSumTotal = new System.Windows.Forms.TextBox();
            this.groupBoxStadium1.SuspendLayout();
            this.groupBoxStadium2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxStadium1
            // 
            this.groupBoxStadium1.AutoSize = true;
            this.groupBoxStadium1.Controls.Add(this.textBoxInput3);
            this.groupBoxStadium1.Controls.Add(this.textBoxInput2);
            this.groupBoxStadium1.Controls.Add(this.textBoxInput1);
            this.groupBoxStadium1.Controls.Add(this.label4);
            this.groupBoxStadium1.Controls.Add(this.label3);
            this.groupBoxStadium1.Controls.Add(this.label2);
            this.groupBoxStadium1.Controls.Add(this.label1);
            this.groupBoxStadium1.Location = new System.Drawing.Point(29, 26);
            this.groupBoxStadium1.Name = "groupBoxStadium1";
            this.groupBoxStadium1.Size = new System.Drawing.Size(373, 261);
            this.groupBoxStadium1.TabIndex = 0;
            this.groupBoxStadium1.TabStop = false;
            this.groupBoxStadium1.Text = "Tickets Sold";
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(443, 311);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(131, 76);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(291, 311);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(130, 75);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(139, 311);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(126, 75);
            this.calculateButton.TabIndex = 4;
            this.calculateButton.Text = "Calculate Revenue";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // groupBoxStadium2
            // 
            this.groupBoxStadium2.Controls.Add(this.textBoxSumTotal);
            this.groupBoxStadium2.Controls.Add(this.label8);
            this.groupBoxStadium2.Controls.Add(this.textBoxSum1);
            this.groupBoxStadium2.Controls.Add(this.textBoxSum3);
            this.groupBoxStadium2.Controls.Add(this.textBoxSum2);
            this.groupBoxStadium2.Controls.Add(this.label7);
            this.groupBoxStadium2.Controls.Add(this.label6);
            this.groupBoxStadium2.Controls.Add(this.label5);
            this.groupBoxStadium2.Location = new System.Drawing.Point(425, 26);
            this.groupBoxStadium2.Name = "groupBoxStadium2";
            this.groupBoxStadium2.Size = new System.Drawing.Size(363, 261);
            this.groupBoxStadium2.TabIndex = 5;
            this.groupBoxStadium2.TabStop = false;
            this.groupBoxStadium2.Text = "Revenue Generated";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(20, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the number of tickets sold for each class of seats.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Class A:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Class B:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Class C:";
            // 
            // textBoxInput1
            // 
            this.textBoxInput1.Location = new System.Drawing.Point(105, 84);
            this.textBoxInput1.Name = "textBoxInput1";
            this.textBoxInput1.Size = new System.Drawing.Size(186, 22);
            this.textBoxInput1.TabIndex = 4;
            // 
            // textBoxInput2
            // 
            this.textBoxInput2.Location = new System.Drawing.Point(105, 126);
            this.textBoxInput2.Name = "textBoxInput2";
            this.textBoxInput2.Size = new System.Drawing.Size(186, 22);
            this.textBoxInput2.TabIndex = 5;
            // 
            // textBoxInput3
            // 
            this.textBoxInput3.Location = new System.Drawing.Point(105, 169);
            this.textBoxInput3.Name = "textBoxInput3";
            this.textBoxInput3.Size = new System.Drawing.Size(186, 22);
            this.textBoxInput3.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Class C:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(71, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Class B:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(71, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Class A:";
            // 
            // textBoxSum2
            // 
            this.textBoxSum2.Location = new System.Drawing.Point(144, 87);
            this.textBoxSum2.Name = "textBoxSum2";
            this.textBoxSum2.Size = new System.Drawing.Size(186, 22);
            this.textBoxSum2.TabIndex = 5;
            // 
            // textBoxSum3
            // 
            this.textBoxSum3.Location = new System.Drawing.Point(144, 129);
            this.textBoxSum3.Name = "textBoxSum3";
            this.textBoxSum3.Size = new System.Drawing.Size(186, 22);
            this.textBoxSum3.TabIndex = 6;
            // 
            // textBoxSum1
            // 
            this.textBoxSum1.Location = new System.Drawing.Point(144, 44);
            this.textBoxSum1.Name = "textBoxSum1";
            this.textBoxSum1.Size = new System.Drawing.Size(186, 22);
            this.textBoxSum1.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(86, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "Total:";
            // 
            // textBoxSumTotal
            // 
            this.textBoxSumTotal.Location = new System.Drawing.Point(144, 172);
            this.textBoxSumTotal.Name = "textBoxSumTotal";
            this.textBoxSumTotal.Size = new System.Drawing.Size(186, 22);
            this.textBoxSumTotal.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxStadium2);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.groupBoxStadium1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxStadium1.ResumeLayout(false);
            this.groupBoxStadium1.PerformLayout();
            this.groupBoxStadium2.ResumeLayout(false);
            this.groupBoxStadium2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxStadium1;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxStadium2;
        private System.Windows.Forms.TextBox textBoxInput3;
        private System.Windows.Forms.TextBox textBoxInput2;
        private System.Windows.Forms.TextBox textBoxInput1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSumTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxSum1;
        private System.Windows.Forms.TextBox textBoxSum3;
        private System.Windows.Forms.TextBox textBoxSum2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}

