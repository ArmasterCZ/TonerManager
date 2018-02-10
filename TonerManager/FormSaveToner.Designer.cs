namespace TonerManager
{
    partial class FormSaveToner
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
            this.tbType = new System.Windows.Forms.TextBox();
            this.tbBareCode = new System.Windows.Forms.TextBox();
            this.cbColor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bWrite = new System.Windows.Forms.Button();
            this.bErase = new System.Windows.Forms.Button();
            this.bClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbType
            // 
            this.tbType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbType.Location = new System.Drawing.Point(100, 7);
            this.tbType.Name = "tbType";
            this.tbType.Size = new System.Drawing.Size(227, 20);
            this.tbType.TabIndex = 1;
            // 
            // tbBareCode
            // 
            this.tbBareCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBareCode.Location = new System.Drawing.Point(100, 62);
            this.tbBareCode.Name = "tbBareCode";
            this.tbBareCode.Size = new System.Drawing.Size(227, 20);
            this.tbBareCode.TabIndex = 1;
            // 
            // cbColor
            // 
            this.cbColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbColor.BackColor = System.Drawing.Color.Silver;
            this.cbColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbColor.FormattingEnabled = true;
            this.cbColor.Items.AddRange(new object[] {
            "Cyan",
            "Magenta",
            "Yellow",
            "Black"});
            this.cbColor.Location = new System.Drawing.Point(100, 33);
            this.cbColor.Name = "cbColor";
            this.cbColor.Size = new System.Drawing.Size(227, 21);
            this.cbColor.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Typ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Barva:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Čárový kód:";
            // 
            // bWrite
            // 
            this.bWrite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bWrite.Location = new System.Drawing.Point(252, 121);
            this.bWrite.Name = "bWrite";
            this.bWrite.Size = new System.Drawing.Size(75, 23);
            this.bWrite.TabIndex = 4;
            this.bWrite.Text = "Zapsat";
            this.bWrite.UseVisualStyleBackColor = true;
            this.bWrite.Click += new System.EventHandler(this.bWrite_Click);
            // 
            // bErase
            // 
            this.bErase.Location = new System.Drawing.Point(171, 121);
            this.bErase.Name = "bErase";
            this.bErase.Size = new System.Drawing.Size(75, 23);
            this.bErase.TabIndex = 4;
            this.bErase.Text = "Smazat";
            this.bErase.UseVisualStyleBackColor = true;
            this.bErase.Click += new System.EventHandler(this.bErase_Click);
            // 
            // bClose
            // 
            this.bClose.Location = new System.Drawing.Point(15, 121);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(75, 23);
            this.bClose.TabIndex = 4;
            this.bClose.Text = "Zavři";
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // FormSaveToner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 156);
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.bErase);
            this.Controls.Add(this.bWrite);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbColor);
            this.Controls.Add(this.tbBareCode);
            this.Controls.Add(this.tbType);
            this.Name = "FormSaveToner";
            this.Text = "Zapsat Toner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbType;
        private System.Windows.Forms.TextBox tbBareCode;
        private System.Windows.Forms.ComboBox cbColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bWrite;
        private System.Windows.Forms.Button bErase;
        private System.Windows.Forms.Button bClose;
    }
}