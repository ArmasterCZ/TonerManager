namespace TonerManager
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
            this.bStorageOutput = new System.Windows.Forms.Button();
            this.bStorageInput = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSetData = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAddToner = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAddPrinter = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAddPlace = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bStorageOutput
            // 
            this.bStorageOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.bStorageOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bStorageOutput.Location = new System.Drawing.Point(13, 85);
            this.bStorageOutput.Name = "bStorageOutput";
            this.bStorageOutput.Size = new System.Drawing.Size(175, 89);
            this.bStorageOutput.TabIndex = 0;
            this.bStorageOutput.Text = "Výdej";
            this.bStorageOutput.UseVisualStyleBackColor = true;
            this.bStorageOutput.Click += new System.EventHandler(this.bStorageOutput_Click);
            // 
            // bStorageInput
            // 
            this.bStorageInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bStorageInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bStorageInput.Location = new System.Drawing.Point(208, 85);
            this.bStorageInput.Name = "bStorageInput";
            this.bStorageInput.Size = new System.Drawing.Size(175, 89);
            this.bStorageInput.TabIndex = 0;
            this.bStorageInput.Text = "Příjem";
            this.bStorageInput.UseVisualStyleBackColor = true;
            this.bStorageInput.Click += new System.EventHandler(this.bStorageInput_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(395, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSetData,
            this.tsmiAddToner,
            this.tsmiAddPrinter,
            this.tsmiAddPlace});
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.dataToolStripMenuItem.Text = "Data";
            // 
            // tsmiSetData
            // 
            this.tsmiSetData.Name = "tsmiSetData";
            this.tsmiSetData.Size = new System.Drawing.Size(180, 22);
            this.tsmiSetData.Text = "Zobraz uložená data";
            this.tsmiSetData.Click += new System.EventHandler(this.tsmiSetData_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // tsmiAddToner
            // 
            this.tsmiAddToner.Name = "tsmiAddToner";
            this.tsmiAddToner.Size = new System.Drawing.Size(180, 22);
            this.tsmiAddToner.Text = "Přidej toner";
            // 
            // tsmiAddPrinter
            // 
            this.tsmiAddPrinter.Name = "tsmiAddPrinter";
            this.tsmiAddPrinter.Size = new System.Drawing.Size(180, 22);
            this.tsmiAddPrinter.Text = "Přidej tiskárnu";
            // 
            // tsmiAddPlace
            // 
            this.tsmiAddPlace.Name = "tsmiAddPlace";
            this.tsmiAddPlace.Size = new System.Drawing.Size(180, 22);
            this.tsmiAddPlace.Text = "přidej místo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 186);
            this.Controls.Add(this.bStorageInput);
            this.Controls.Add(this.bStorageOutput);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bStorageOutput;
        private System.Windows.Forms.Button bStorageInput;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiSetData;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddToner;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddPrinter;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddPlace;
    }
}

