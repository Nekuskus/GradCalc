namespace GradCalc
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if(disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.StopnInLabel = new System.Windows.Forms.Label();
            this.GradInLabel = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.StopnOutLabel = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.GradOutLabel = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.RandomNumberButton = new System.Windows.Forms.Button();
            this.RandomNumLabel = new System.Windows.Forms.Label();
            this.RandomNumOutLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(21, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // StopnInLabel
            // 
            this.StopnInLabel.AutoSize = true;
            this.StopnInLabel.Location = new System.Drawing.Point(21, 17);
            this.StopnInLabel.Name = "StopnInLabel";
            this.StopnInLabel.Size = new System.Drawing.Size(43, 13);
            this.StopnInLabel.TabIndex = 1;
            this.StopnInLabel.Text = "Stopnie";
            // 
            // GradInLabel
            // 
            this.GradInLabel.AutoSize = true;
            this.GradInLabel.Location = new System.Drawing.Point(21, 73);
            this.GradInLabel.Name = "GradInLabel";
            this.GradInLabel.Size = new System.Drawing.Size(35, 13);
            this.GradInLabel.TabIndex = 3;
            this.GradInLabel.Text = "Grady";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(21, 85);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            // 
            // StopnOutLabel
            // 
            this.StopnOutLabel.AutoSize = true;
            this.StopnOutLabel.Location = new System.Drawing.Point(191, 73);
            this.StopnOutLabel.Name = "StopnOutLabel";
            this.StopnOutLabel.Size = new System.Drawing.Size(43, 13);
            this.StopnOutLabel.TabIndex = 7;
            this.StopnOutLabel.Text = "Stopnie";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(191, 85);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 6;
            // 
            // GradOutLabel
            // 
            this.GradOutLabel.AutoSize = true;
            this.GradOutLabel.Location = new System.Drawing.Point(191, 17);
            this.GradOutLabel.Name = "GradOutLabel";
            this.GradOutLabel.Size = new System.Drawing.Size(35, 13);
            this.GradOutLabel.TabIndex = 9;
            this.GradOutLabel.Text = "Grady";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(191, 29);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 8;
            // 
            // RandomNumberButton
            // 
            this.RandomNumberButton.Location = new System.Drawing.Point(14, 10);
            this.RandomNumberButton.Name = "RandomNumberButton";
            this.RandomNumberButton.Size = new System.Drawing.Size(129, 23);
            this.RandomNumberButton.TabIndex = 10;
            this.RandomNumberButton.Text = "Wylosuj numerek!";
            this.RandomNumberButton.UseVisualStyleBackColor = true;
            this.RandomNumberButton.Click += new System.EventHandler(this.RandomNumberButton_Click);
            // 
            // RandomNumLabel
            // 
            this.RandomNumLabel.AutoSize = true;
            this.RandomNumLabel.Location = new System.Drawing.Point(11, 36);
            this.RandomNumLabel.Name = "RandomNumLabel";
            this.RandomNumLabel.Size = new System.Drawing.Size(100, 13);
            this.RandomNumLabel.TabIndex = 11;
            this.RandomNumLabel.Text = "Losowa liczba dnia:";
            // 
            // RandomNumOutLabel
            // 
            this.RandomNumOutLabel.AutoSize = true;
            this.RandomNumOutLabel.Location = new System.Drawing.Point(108, 36);
            this.RandomNumOutLabel.Name = "RandomNumOutLabel";
            this.RandomNumOutLabel.Size = new System.Drawing.Size(25, 13);
            this.RandomNumOutLabel.TabIndex = 12;
            this.RandomNumOutLabel.Text = "Cyfr";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.RandomNumberButton);
            this.panel1.Controls.Add(this.RandomNumOutLabel);
            this.panel1.Controls.Add(this.RandomNumLabel);
            this.panel1.Location = new System.Drawing.Point(344, 112);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(156, 63);
            this.panel1.TabIndex = 13;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.splitContainer1.Size = new System.Drawing.Size(287, 104);
            this.splitContainer1.SplitterDistance = 52;
            this.splitContainer1.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 187);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.GradOutLabel);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.StopnOutLabel);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.GradInLabel);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.StopnInLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.splitContainer1);
            this.MaximumSize = new System.Drawing.Size(528, 225);
            this.MinimumSize = new System.Drawing.Size(528, 225);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label StopnInLabel;
        private System.Windows.Forms.Label GradInLabel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label StopnOutLabel;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label GradOutLabel;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button RandomNumberButton;
        private System.Windows.Forms.Label RandomNumLabel;
        private System.Windows.Forms.Label RandomNumOutLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}

