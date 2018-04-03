namespace DellMechanicalQuoteSystem
{
    partial class formMain
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
            this.tabSections = new System.Windows.Forms.TabControl();
            this.tabSection1 = new System.Windows.Forms.TabPage();
            this.btnAddMaterial = new System.Windows.Forms.Button();
            this.txtExtraCost = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblTotalMaterial = new System.Windows.Forms.Label();
            this.lblTotalLabourHours = new System.Windows.Forms.Label();
            this.lblTotalLabour = new System.Windows.Forms.Label();
            this.txtTotalCost = new System.Windows.Forms.TextBox();
            this.btnNewSection = new System.Windows.Forms.Button();
            this.btnPrintQuote = new System.Windows.Forms.Button();
            this.tabSections.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabSections
            // 
            this.tabSections.Controls.Add(this.tabSection1);
            this.tabSections.Location = new System.Drawing.Point(210, 26);
            this.tabSections.Name = "tabSections";
            this.tabSections.SelectedIndex = 0;
            this.tabSections.Size = new System.Drawing.Size(946, 552);
            this.tabSections.TabIndex = 0;
            // 
            // tabSection1
            // 
            this.tabSection1.AutoScroll = true;
            this.tabSection1.Location = new System.Drawing.Point(4, 29);
            this.tabSection1.Name = "tabSection1";
            this.tabSection1.Padding = new System.Windows.Forms.Padding(10);
            this.tabSection1.Size = new System.Drawing.Size(938, 519);
            this.tabSection1.TabIndex = 0;
            this.tabSection1.Text = "Section 1";
            this.tabSection1.UseVisualStyleBackColor = true;
            // 
            // btnAddMaterial
            // 
            this.btnAddMaterial.Location = new System.Drawing.Point(735, 610);
            this.btnAddMaterial.Name = "btnAddMaterial";
            this.btnAddMaterial.Padding = new System.Windows.Forms.Padding(10);
            this.btnAddMaterial.Size = new System.Drawing.Size(230, 54);
            this.btnAddMaterial.TabIndex = 5;
            this.btnAddMaterial.Text = "Add Material";
            this.btnAddMaterial.UseVisualStyleBackColor = true;
            this.btnAddMaterial.Click += new System.EventHandler(this.btnAddMaterial_Click);
            // 
            // txtExtraCost
            // 
            this.txtExtraCost.Location = new System.Drawing.Point(45, 345);
            this.txtExtraCost.Name = "txtExtraCost";
            this.txtExtraCost.Size = new System.Drawing.Size(100, 26);
            this.txtExtraCost.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Menu;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Location = new System.Drawing.Point(256, 594);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(10);
            this.label10.Size = new System.Drawing.Size(73, 42);
            this.label10.TabIndex = 1;
            this.label10.Text = "label1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Menu;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Location = new System.Drawing.Point(377, 605);
            this.label11.Name = "label11";
            this.label11.Padding = new System.Windows.Forms.Padding(10);
            this.label11.Size = new System.Drawing.Size(73, 42);
            this.label11.TabIndex = 2;
            this.label11.Text = "label2";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.Menu;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Location = new System.Drawing.Point(479, 605);
            this.label12.Name = "label12";
            this.label12.Padding = new System.Windows.Forms.Padding(10);
            this.label12.Size = new System.Drawing.Size(73, 42);
            this.label12.TabIndex = 3;
            this.label12.Text = "label3";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.Menu;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label13.Location = new System.Drawing.Point(588, 618);
            this.label13.Name = "label13";
            this.label13.Padding = new System.Windows.Forms.Padding(10);
            this.label13.Size = new System.Drawing.Size(73, 42);
            this.label13.TabIndex = 4;
            this.label13.Text = "label4";
            // 
            // lblTotalMaterial
            // 
            this.lblTotalMaterial.AutoSize = true;
            this.lblTotalMaterial.BackColor = System.Drawing.SystemColors.Menu;
            this.lblTotalMaterial.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalMaterial.Location = new System.Drawing.Point(55, 55);
            this.lblTotalMaterial.Name = "lblTotalMaterial";
            this.lblTotalMaterial.Padding = new System.Windows.Forms.Padding(10);
            this.lblTotalMaterial.Size = new System.Drawing.Size(73, 42);
            this.lblTotalMaterial.TabIndex = 6;
            this.lblTotalMaterial.Text = "label5";
            // 
            // lblTotalLabourHours
            // 
            this.lblTotalLabourHours.AutoSize = true;
            this.lblTotalLabourHours.BackColor = System.Drawing.SystemColors.Menu;
            this.lblTotalLabourHours.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalLabourHours.Location = new System.Drawing.Point(81, 266);
            this.lblTotalLabourHours.Name = "lblTotalLabourHours";
            this.lblTotalLabourHours.Padding = new System.Windows.Forms.Padding(10);
            this.lblTotalLabourHours.Size = new System.Drawing.Size(73, 42);
            this.lblTotalLabourHours.TabIndex = 9;
            this.lblTotalLabourHours.Text = "label8";
            // 
            // lblTotalLabour
            // 
            this.lblTotalLabour.AutoSize = true;
            this.lblTotalLabour.BackColor = System.Drawing.SystemColors.Menu;
            this.lblTotalLabour.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalLabour.Location = new System.Drawing.Point(72, 208);
            this.lblTotalLabour.Name = "lblTotalLabour";
            this.lblTotalLabour.Padding = new System.Windows.Forms.Padding(10);
            this.lblTotalLabour.Size = new System.Drawing.Size(73, 42);
            this.lblTotalLabour.TabIndex = 10;
            this.lblTotalLabour.Text = "label9";
            // 
            // txtTotalCost
            // 
            this.txtTotalCost.Location = new System.Drawing.Point(81, 444);
            this.txtTotalCost.Name = "txtTotalCost";
            this.txtTotalCost.Size = new System.Drawing.Size(100, 26);
            this.txtTotalCost.TabIndex = 12;
            // 
            // btnNewSection
            // 
            this.btnNewSection.Location = new System.Drawing.Point(26, 539);
            this.btnNewSection.Name = "btnNewSection";
            this.btnNewSection.Padding = new System.Windows.Forms.Padding(5);
            this.btnNewSection.Size = new System.Drawing.Size(128, 53);
            this.btnNewSection.TabIndex = 13;
            this.btnNewSection.Text = "New Section";
            this.btnNewSection.UseVisualStyleBackColor = true;
            this.btnNewSection.Click += new System.EventHandler(this.btnNewSection_Click);
            // 
            // btnPrintQuote
            // 
            this.btnPrintQuote.Location = new System.Drawing.Point(26, 618);
            this.btnPrintQuote.Name = "btnPrintQuote";
            this.btnPrintQuote.Padding = new System.Windows.Forms.Padding(5);
            this.btnPrintQuote.Size = new System.Drawing.Size(128, 51);
            this.btnPrintQuote.TabIndex = 14;
            this.btnPrintQuote.Text = "Print Quote";
            this.btnPrintQuote.UseVisualStyleBackColor = true;
            this.btnPrintQuote.Click += new System.EventHandler(this.btnPrintQuote_Click);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1173, 697);
            this.Controls.Add(this.btnPrintQuote);
            this.Controls.Add(this.btnNewSection);
            this.Controls.Add(this.txtTotalCost);
            this.Controls.Add(this.txtExtraCost);
            this.Controls.Add(this.lblTotalLabour);
            this.Controls.Add(this.lblTotalLabourHours);
            this.Controls.Add(this.lblTotalMaterial);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnAddMaterial);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tabSections);
            this.Name = "formMain";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Dell Mechanical Quote System";
            this.tabSections.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabSections;
        private System.Windows.Forms.TabPage tabSection1;
        private System.Windows.Forms.Button btnAddMaterial;
        private System.Windows.Forms.TextBox txtExtraCost;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblTotalMaterial;
        private System.Windows.Forms.Label lblTotalLabourHours;
        private System.Windows.Forms.Label lblTotalLabour;
        private System.Windows.Forms.TextBox txtTotalCost;
        private System.Windows.Forms.Button btnNewSection;
        private System.Windows.Forms.Button btnPrintQuote;
    }
}

