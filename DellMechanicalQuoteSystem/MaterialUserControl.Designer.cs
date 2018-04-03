namespace DellMechanicalQuoteSystem
{
    partial class MaterialUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.cmbMaterialType = new System.Windows.Forms.ComboBox();
            this.lblUnitCost = new System.Windows.Forms.Label();
            this.lblLabourUnitCost = new System.Windows.Forms.Label();
            this.lblMaterialCost = new System.Windows.Forms.Label();
            this.lblLabourCost = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // numQuantity
            // 
            this.numQuantity.Location = new System.Drawing.Point(21, 15);
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(53, 26);
            this.numQuantity.TabIndex = 0;
            // 
            // cmbMaterialType
            // 
            this.cmbMaterialType.FormattingEnabled = true;
            this.cmbMaterialType.Location = new System.Drawing.Point(117, 15);
            this.cmbMaterialType.Name = "cmbMaterialType";
            this.cmbMaterialType.Size = new System.Drawing.Size(285, 28);
            this.cmbMaterialType.TabIndex = 1;
            // 
            // lblUnitCost
            // 
            this.lblUnitCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUnitCost.Location = new System.Drawing.Point(408, 12);
            this.lblUnitCost.Name = "lblUnitCost";
            this.lblUnitCost.Padding = new System.Windows.Forms.Padding(5);
            this.lblUnitCost.Size = new System.Drawing.Size(105, 32);
            this.lblUnitCost.TabIndex = 2;
            this.lblUnitCost.Text = "label1";
            // 
            // lblLabourUnitCost
            // 
            this.lblLabourUnitCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLabourUnitCost.Location = new System.Drawing.Point(653, 11);
            this.lblLabourUnitCost.Name = "lblLabourUnitCost";
            this.lblLabourUnitCost.Padding = new System.Windows.Forms.Padding(5);
            this.lblLabourUnitCost.Size = new System.Drawing.Size(107, 32);
            this.lblLabourUnitCost.TabIndex = 3;
            this.lblLabourUnitCost.Text = "label2";
            // 
            // lblMaterialCost
            // 
            this.lblMaterialCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMaterialCost.Location = new System.Drawing.Point(526, 11);
            this.lblMaterialCost.Name = "lblMaterialCost";
            this.lblMaterialCost.Padding = new System.Windows.Forms.Padding(5);
            this.lblMaterialCost.Size = new System.Drawing.Size(113, 33);
            this.lblMaterialCost.TabIndex = 5;
            this.lblMaterialCost.Text = "label4";
            // 
            // lblLabourCost
            // 
            this.lblLabourCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLabourCost.Location = new System.Drawing.Point(777, 11);
            this.lblLabourCost.Name = "lblLabourCost";
            this.lblLabourCost.Padding = new System.Windows.Forms.Padding(5);
            this.lblLabourCost.Size = new System.Drawing.Size(107, 32);
            this.lblLabourCost.TabIndex = 6;
            this.lblLabourCost.Text = "label1";
            // 
            // MaterialUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.lblLabourCost);
            this.Controls.Add(this.lblMaterialCost);
            this.Controls.Add(this.lblLabourUnitCost);
            this.Controls.Add(this.lblUnitCost);
            this.Controls.Add(this.cmbMaterialType);
            this.Controls.Add(this.numQuantity);
            this.Name = "MaterialUserControl";
            this.Size = new System.Drawing.Size(899, 54);
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.ComboBox cmbMaterialType;
        private System.Windows.Forms.Label lblUnitCost;
        private System.Windows.Forms.Label lblLabourUnitCost;
        private System.Windows.Forms.Label lblMaterialCost;
        private System.Windows.Forms.Label lblLabourCost;
    }
}
