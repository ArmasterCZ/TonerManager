namespace TonerManager
{
    partial class FormStorageOutput
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
            this.cbPrinter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbPeople = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbToner = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mtbCyan = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mtbMagenta = new System.Windows.Forms.MaskedTextBox();
            this.mtbYellow = new System.Windows.Forms.MaskedTextBox();
            this.mtbBlack = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lSklademCyan = new System.Windows.Forms.Label();
            this.lSklademMagenta = new System.Windows.Forms.Label();
            this.lSklademYellow = new System.Windows.Forms.Label();
            this.lSklademBlack = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbPrinter
            // 
            this.cbPrinter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbPrinter.FormattingEnabled = true;
            this.cbPrinter.Location = new System.Drawing.Point(12, 29);
            this.cbPrinter.Name = "cbPrinter";
            this.cbPrinter.Size = new System.Drawing.Size(196, 26);
            this.cbPrinter.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tiskárna:";
            // 
            // cbPeople
            // 
            this.cbPeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbPeople.FormattingEnabled = true;
            this.cbPeople.Location = new System.Drawing.Point(214, 29);
            this.cbPeople.Name = "cbPeople";
            this.cbPeople.Size = new System.Drawing.Size(185, 26);
            this.cbPeople.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pro:";
            // 
            // cbToner
            // 
            this.cbToner.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbToner.FormattingEnabled = true;
            this.cbToner.Location = new System.Drawing.Point(405, 29);
            this.cbToner.Name = "cbToner";
            this.cbToner.Size = new System.Drawing.Size(170, 26);
            this.cbToner.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(411, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Toner:";
            // 
            // mtbCyan
            // 
            this.mtbCyan.BackColor = System.Drawing.Color.Cyan;
            this.mtbCyan.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mtbCyan.Location = new System.Drawing.Point(13, 93);
            this.mtbCyan.Mask = "0";
            this.mtbCyan.Name = "mtbCyan";
            this.mtbCyan.Size = new System.Drawing.Size(63, 38);
            this.mtbCyan.TabIndex = 2;
            this.mtbCyan.Text = "0";
            this.mtbCyan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbCyan.Click += new System.EventHandler(this.increaseTextBoxNumber);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Výdej:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Skladem:";
            // 
            // mtbMagenta
            // 
            this.mtbMagenta.BackColor = System.Drawing.Color.Magenta;
            this.mtbMagenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mtbMagenta.Location = new System.Drawing.Point(82, 93);
            this.mtbMagenta.Mask = "0";
            this.mtbMagenta.Name = "mtbMagenta";
            this.mtbMagenta.Size = new System.Drawing.Size(63, 38);
            this.mtbMagenta.TabIndex = 2;
            this.mtbMagenta.Text = "0";
            this.mtbMagenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbMagenta.Click += new System.EventHandler(this.increaseTextBoxNumber);
            // 
            // mtbYellow
            // 
            this.mtbYellow.BackColor = System.Drawing.Color.Yellow;
            this.mtbYellow.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mtbYellow.Location = new System.Drawing.Point(151, 93);
            this.mtbYellow.Mask = "0";
            this.mtbYellow.Name = "mtbYellow";
            this.mtbYellow.Size = new System.Drawing.Size(63, 38);
            this.mtbYellow.TabIndex = 2;
            this.mtbYellow.Text = "0";
            this.mtbYellow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbYellow.Click += new System.EventHandler(this.increaseTextBoxNumber);
            // 
            // mtbBlack
            // 
            this.mtbBlack.BackColor = System.Drawing.Color.Silver;
            this.mtbBlack.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mtbBlack.Location = new System.Drawing.Point(220, 93);
            this.mtbBlack.Mask = "0";
            this.mtbBlack.Name = "mtbBlack";
            this.mtbBlack.Size = new System.Drawing.Size(63, 38);
            this.mtbBlack.TabIndex = 2;
            this.mtbBlack.Text = "0";
            this.mtbBlack.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbBlack.Click += new System.EventHandler(this.increaseTextBoxNumber);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Cyan";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(91, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Magenta";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(165, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Yellow";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(234, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Black";
            // 
            // lSklademCyan
            // 
            this.lSklademCyan.AutoSize = true;
            this.lSklademCyan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lSklademCyan.Location = new System.Drawing.Point(37, 147);
            this.lSklademCyan.Name = "lSklademCyan";
            this.lSklademCyan.Size = new System.Drawing.Size(14, 15);
            this.lSklademCyan.TabIndex = 1;
            this.lSklademCyan.Text = "0";
            this.lSklademCyan.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lSklademMagenta
            // 
            this.lSklademMagenta.AutoSize = true;
            this.lSklademMagenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lSklademMagenta.Location = new System.Drawing.Point(106, 147);
            this.lSklademMagenta.Name = "lSklademMagenta";
            this.lSklademMagenta.Size = new System.Drawing.Size(14, 15);
            this.lSklademMagenta.TabIndex = 1;
            this.lSklademMagenta.Text = "0";
            this.lSklademMagenta.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lSklademYellow
            // 
            this.lSklademYellow.AutoSize = true;
            this.lSklademYellow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lSklademYellow.Location = new System.Drawing.Point(176, 147);
            this.lSklademYellow.Name = "lSklademYellow";
            this.lSklademYellow.Size = new System.Drawing.Size(14, 15);
            this.lSklademYellow.TabIndex = 1;
            this.lSklademYellow.Text = "0";
            this.lSklademYellow.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lSklademBlack
            // 
            this.lSklademBlack.AutoSize = true;
            this.lSklademBlack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lSklademBlack.Location = new System.Drawing.Point(244, 147);
            this.lSklademBlack.Name = "lSklademBlack";
            this.lSklademBlack.Size = new System.Drawing.Size(14, 15);
            this.lSklademBlack.TabIndex = 1;
            this.lSklademBlack.Text = "0";
            this.lSklademBlack.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(415, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 37);
            this.button1.TabIndex = 3;
            this.button1.Text = "Zapsat výdej";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FormStorageOutput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 190);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mtbBlack);
            this.Controls.Add(this.mtbYellow);
            this.Controls.Add(this.mtbMagenta);
            this.Controls.Add(this.mtbCyan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbToner);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbPeople);
            this.Controls.Add(this.lSklademBlack);
            this.Controls.Add(this.lSklademYellow);
            this.Controls.Add(this.lSklademMagenta);
            this.Controls.Add(this.lSklademCyan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbPrinter);
            this.Name = "FormStorageOutput";
            this.Text = "FormStorageInput";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbPrinter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPeople;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbToner;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtbCyan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mtbMagenta;
        private System.Windows.Forms.MaskedTextBox mtbYellow;
        private System.Windows.Forms.MaskedTextBox mtbBlack;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lSklademCyan;
        private System.Windows.Forms.Label lSklademMagenta;
        private System.Windows.Forms.Label lSklademYellow;
        private System.Windows.Forms.Label lSklademBlack;
        private System.Windows.Forms.Button button1;
    }
}