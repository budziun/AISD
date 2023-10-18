namespace ISI1_grupa1
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
            this.btnStart = new System.Windows.Forms.Button();
            this.nudLiczbaN = new System.Windows.Forms.NumericUpDown();
            this.btnFib1 = new System.Windows.Forms.Button();
            this.btnFib2 = new System.Windows.Forms.Button();
            this.Lbl_Bombel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudLiczbaN)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnStart.Location = new System.Drawing.Point(36, 185);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Bombel";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // nudLiczbaN
            // 
            this.nudLiczbaN.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.nudLiczbaN.Location = new System.Drawing.Point(36, 37);
            this.nudLiczbaN.Name = "nudLiczbaN";
            this.nudLiczbaN.Size = new System.Drawing.Size(127, 23);
            this.nudLiczbaN.TabIndex = 1;
            this.nudLiczbaN.ValueChanged += new System.EventHandler(this.nudLiczbaN_ValueChanged);
            // 
            // btnFib1
            // 
            this.btnFib1.Location = new System.Drawing.Point(36, 92);
            this.btnFib1.Name = "btnFib1";
            this.btnFib1.Size = new System.Drawing.Size(75, 23);
            this.btnFib1.TabIndex = 2;
            this.btnFib1.Text = "Fib1";
            this.btnFib1.UseVisualStyleBackColor = true;
            this.btnFib1.Click += new System.EventHandler(this.btnFib1_Click);
            // 
            // btnFib2
            // 
            this.btnFib2.Location = new System.Drawing.Point(36, 138);
            this.btnFib2.Name = "btnFib2";
            this.btnFib2.Size = new System.Drawing.Size(75, 23);
            this.btnFib2.TabIndex = 3;
            this.btnFib2.Text = "Fib2";
            this.btnFib2.UseVisualStyleBackColor = true;
            this.btnFib2.Click += new System.EventHandler(this.btnFib2_Click);
            // 
            // Lbl_Bombel
            // 
            this.Lbl_Bombel.AutoSize = true;
            this.Lbl_Bombel.Location = new System.Drawing.Point(223, 79);
            this.Lbl_Bombel.MinimumSize = new System.Drawing.Size(50, 0);
            this.Lbl_Bombel.Name = "Lbl_Bombel";
            this.Lbl_Bombel.Size = new System.Drawing.Size(50, 15);
            this.Lbl_Bombel.TabIndex = 4;
            this.Lbl_Bombel.Click += new System.EventHandler(this.Lbl_Bombel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 246);
            this.Controls.Add(this.Lbl_Bombel);
            this.Controls.Add(this.btnFib2);
            this.Controls.Add(this.btnFib1);
            this.Controls.Add(this.nudLiczbaN);
            this.Controls.Add(this.btnStart);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(527, 285);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(527, 285);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudLiczbaN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnStart;
        private NumericUpDown nudLiczbaN;
        private Button btnFib1;
        private Button btnFib2;
        private Label Lbl_Bombel;
    }
}