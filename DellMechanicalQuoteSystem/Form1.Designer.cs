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
            this.lblSecLabourCost = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblSecMaterialCost = new System.Windows.Forms.Label();
            this.lblSecLabourHours = new System.Windows.Forms.Label();
            this.lblTotalMaterial = new System.Windows.Forms.Label();
            this.lblTotalLabourHours = new System.Windows.Forms.Label();
            this.lblTotalLabour = new System.Windows.Forms.Label();
            this.btnNewSection = new System.Windows.Forms.Button();
            this.btnPrintQuote = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDeductions = new System.Windows.Forms.TextBox();
            this.lblSecTotal = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btCalculateSection = new System.Windows.Forms.Button();
            this.tabSections.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabSections
            // 
            this.tabSections.Controls.Add(this.tabSection1);
            this.tabSections.Location = new System.Drawing.Point(140, 17);
            this.tabSections.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabSections.Name = "tabSections";
            this.tabSections.SelectedIndex = 0;
            this.tabSections.Size = new System.Drawing.Size(631, 366);
            this.tabSections.TabIndex = 0;
            // 
            // tabSection1
            // 
            this.tabSection1.AutoScroll = true;
            this.tabSection1.Location = new System.Drawing.Point(4, 22);
            this.tabSection1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabSection1.Name = "tabSection1";
            this.tabSection1.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.tabSection1.Size = new System.Drawing.Size(623, 340);
            this.tabSection1.TabIndex = 0;
            this.tabSection1.Text = "Section 1";
            this.tabSection1.UseVisualStyleBackColor = true;
            // 
            // btnAddMaterial
            // 
            this.btnAddMaterial.Location = new System.Drawing.Point(617, 389);
            this.btnAddMaterial.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddMaterial.Name = "btnAddMaterial";
            this.btnAddMaterial.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnAddMaterial.Size = new System.Drawing.Size(153, 35);
            this.btnAddMaterial.TabIndex = 5;
            this.btnAddMaterial.Text = "Add Material";
            this.btnAddMaterial.UseVisualStyleBackColor = true;
            this.btnAddMaterial.Click += new System.EventHandler(this.btnAddMaterial_Click);
            // 
            // txtExtraCost
            // 
            this.txtExtraCost.Location = new System.Drawing.Point(17, 281);
            this.txtExtraCost.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtExtraCost.Name = "txtExtraCost";
            this.txtExtraCost.Size = new System.Drawing.Size(104, 20);
            this.txtExtraCost.TabIndex = 11;
            // 
            // lblSecLabourCost
            // 
            this.lblSecLabourCost.BackColor = System.Drawing.SystemColors.Menu;
            this.lblSecLabourCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSecLabourCost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSecLabourCost.Location = new System.Drawing.Point(287, 437);
            this.lblSecLabourCost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSecLabourCost.Name = "lblSecLabourCost";
            this.lblSecLabourCost.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.lblSecLabourCost.Size = new System.Drawing.Size(96, 27);
            this.lblSecLabourCost.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.SystemColors.Menu;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Location = new System.Drawing.Point(487, 437);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.label11.Size = new System.Drawing.Size(96, 27);
            this.label11.TabIndex = 2;
            // 
            // lblSecMaterialCost
            // 
            this.lblSecMaterialCost.BackColor = System.Drawing.SystemColors.Menu;
            this.lblSecMaterialCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSecMaterialCost.Location = new System.Drawing.Point(187, 437);
            this.lblSecMaterialCost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSecMaterialCost.Name = "lblSecMaterialCost";
            this.lblSecMaterialCost.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.lblSecMaterialCost.Size = new System.Drawing.Size(96, 27);
            this.lblSecMaterialCost.TabIndex = 3;
            // 
            // lblSecLabourHours
            // 
            this.lblSecLabourHours.BackColor = System.Drawing.SystemColors.Menu;
            this.lblSecLabourHours.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSecLabourHours.Location = new System.Drawing.Point(387, 437);
            this.lblSecLabourHours.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSecLabourHours.Name = "lblSecLabourHours";
            this.lblSecLabourHours.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.lblSecLabourHours.Size = new System.Drawing.Size(96, 27);
            this.lblSecLabourHours.TabIndex = 4;
            // 
            // lblTotalMaterial
            // 
            this.lblTotalMaterial.BackColor = System.Drawing.SystemColors.Menu;
            this.lblTotalMaterial.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalMaterial.Location = new System.Drawing.Point(18, 54);
            this.lblTotalMaterial.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalMaterial.Name = "lblTotalMaterial";
            this.lblTotalMaterial.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.lblTotalMaterial.Size = new System.Drawing.Size(103, 27);
            this.lblTotalMaterial.TabIndex = 6;
            // 
            // lblTotalLabourHours
            // 
            this.lblTotalLabourHours.BackColor = System.Drawing.SystemColors.Menu;
            this.lblTotalLabourHours.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalLabourHours.Location = new System.Drawing.Point(17, 169);
            this.lblTotalLabourHours.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalLabourHours.Name = "lblTotalLabourHours";
            this.lblTotalLabourHours.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.lblTotalLabourHours.Size = new System.Drawing.Size(103, 27);
            this.lblTotalLabourHours.TabIndex = 9;
            // 
            // lblTotalLabour
            // 
            this.lblTotalLabour.BackColor = System.Drawing.SystemColors.Menu;
            this.lblTotalLabour.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalLabour.Location = new System.Drawing.Point(18, 109);
            this.lblTotalLabour.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalLabour.Name = "lblTotalLabour";
            this.lblTotalLabour.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.lblTotalLabour.Size = new System.Drawing.Size(103, 27);
            this.lblTotalLabour.TabIndex = 10;
            // 
            // btnNewSection
            // 
            this.btnNewSection.Location = new System.Drawing.Point(19, 385);
            this.btnNewSection.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNewSection.Name = "btnNewSection";
            this.btnNewSection.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.btnNewSection.Size = new System.Drawing.Size(103, 34);
            this.btnNewSection.TabIndex = 13;
            this.btnNewSection.Text = "New Section";
            this.btnNewSection.UseVisualStyleBackColor = true;
            this.btnNewSection.Click += new System.EventHandler(this.btnNewSection_Click);
            // 
            // btnPrintQuote
            // 
            this.btnPrintQuote.Location = new System.Drawing.Point(19, 432);
            this.btnPrintQuote.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPrintQuote.Name = "btnPrintQuote";
            this.btnPrintQuote.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.btnPrintQuote.Size = new System.Drawing.Size(103, 33);
            this.btnPrintQuote.TabIndex = 14;
            this.btnPrintQuote.Text = "Print Quote";
            this.btnPrintQuote.UseVisualStyleBackColor = true;
            this.btnPrintQuote.Click += new System.EventHandler(this.btnPrintQuote_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Material Cost";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 419);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Material Cost";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 263);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Extra Costs";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 153);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Label Hours";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 92);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Labour Cost";
            // 
            // txtDeductions
            // 
            this.txtDeductions.Location = new System.Drawing.Point(19, 323);
            this.txtDeductions.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDeductions.Name = "txtDeductions";
            this.txtDeductions.Size = new System.Drawing.Size(103, 20);
            this.txtDeductions.TabIndex = 20;
            // 
            // lblSecTotal
            // 
            this.lblSecTotal.AutoSize = true;
            this.lblSecTotal.Location = new System.Drawing.Point(523, 421);
            this.lblSecTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSecTotal.Name = "lblSecTotal";
            this.lblSecTotal.Size = new System.Drawing.Size(31, 13);
            this.lblSecTotal.TabIndex = 21;
            this.lblSecTotal.Text = "Total";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(401, 421);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Labour Hours";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(305, 421);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Labour Cost";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(39, 305);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 13);
            this.label15.TabIndex = 26;
            this.label15.Text = "Deductions";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(36, 214);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(60, 13);
            this.label16.TabIndex = 27;
            this.label16.Text = "Total Costs";
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.BackColor = System.Drawing.SystemColors.Menu;
            this.lblTotalCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalCost.Location = new System.Drawing.Point(19, 230);
            this.lblTotalCost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.lblTotalCost.Size = new System.Drawing.Size(103, 27);
            this.lblTotalCost.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 6);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 24);
            this.label6.TabIndex = 29;
            this.label6.Text = "Quote Totals";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(315, 389);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 24);
            this.label9.TabIndex = 30;
            this.label9.Text = "Section Totals";
            // 
            // btCalculateSection
            // 
            this.btCalculateSection.Location = new System.Drawing.Point(617, 437);
            this.btCalculateSection.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btCalculateSection.Name = "btCalculateSection";
            this.btCalculateSection.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btCalculateSection.Size = new System.Drawing.Size(153, 35);
            this.btCalculateSection.TabIndex = 31;
            this.btCalculateSection.Text = "Calculate Section";
            this.btCalculateSection.UseVisualStyleBackColor = true;
            this.btCalculateSection.Click += new System.EventHandler(this.btCalculateSection_Click);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(782, 482);
            this.Controls.Add(this.btCalculateSection);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblSecTotal);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblSecLabourHours);
            this.Controls.Add(this.lblSecMaterialCost);
            this.Controls.Add(this.txtDeductions);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPrintQuote);
            this.Controls.Add(this.btnNewSection);
            this.Controls.Add(this.txtExtraCost);
            this.Controls.Add(this.lblTotalLabour);
            this.Controls.Add(this.lblTotalLabourHours);
            this.Controls.Add(this.lblTotalMaterial);
            this.Controls.Add(this.btnAddMaterial);
            this.Controls.Add(this.lblSecLabourCost);
            this.Controls.Add(this.tabSections);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "formMain";
            this.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
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
        private System.Windows.Forms.Label lblSecLabourCost;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblSecMaterialCost;
        private System.Windows.Forms.Label lblSecLabourHours;
        private System.Windows.Forms.Label lblTotalMaterial;
        private System.Windows.Forms.Label lblTotalLabourHours;
        private System.Windows.Forms.Label lblTotalLabour;
        private System.Windows.Forms.Button btnNewSection;
        private System.Windows.Forms.Button btnPrintQuote;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDeductions;
        private System.Windows.Forms.Label lblSecTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btCalculateSection;
    }
}

