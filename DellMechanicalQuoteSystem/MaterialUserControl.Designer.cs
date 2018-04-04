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
            this.cmbMaterialType = new System.Windows.Forms.ComboBox();
            this.lblUnitCost = new System.Windows.Forms.Label();
            this.lblLabourUnitCost = new System.Windows.Forms.Label();
            this.lblMaterialCost = new System.Windows.Forms.Label();
            this.lblLabourCost = new System.Windows.Forms.Label();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbMaterialType
            // 
            this.cmbMaterialType.FormattingEnabled = true;
            this.cmbMaterialType.Location = new System.Drawing.Point(13, 8);
            this.cmbMaterialType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbMaterialType.Name = "cmbMaterialType";
            this.cmbMaterialType.Size = new System.Drawing.Size(191, 21);
            this.cmbMaterialType.TabIndex = 1;
            this.cmbMaterialType.SelectedIndexChanged += new System.EventHandler(this.cmbMaterialType_SelectedIndexChanged);
            // 
            // lblUnitCost
            // 
            this.lblUnitCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUnitCost.Location = new System.Drawing.Point(272, 8);
            this.lblUnitCost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUnitCost.Name = "lblUnitCost";
            this.lblUnitCost.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.lblUnitCost.Size = new System.Drawing.Size(71, 21);
            this.lblUnitCost.TabIndex = 2;
            // 
            // lblLabourUnitCost
            // 
            this.lblLabourUnitCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLabourUnitCost.Location = new System.Drawing.Point(435, 7);
            this.lblLabourUnitCost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLabourUnitCost.Name = "lblLabourUnitCost";
            this.lblLabourUnitCost.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.lblLabourUnitCost.Size = new System.Drawing.Size(72, 21);
            this.lblLabourUnitCost.TabIndex = 3;
            // 
            // lblMaterialCost
            // 
            this.lblMaterialCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMaterialCost.Location = new System.Drawing.Point(351, 7);
            this.lblMaterialCost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaterialCost.Name = "lblMaterialCost";
            this.lblMaterialCost.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.lblMaterialCost.Size = new System.Drawing.Size(76, 22);
            this.lblMaterialCost.TabIndex = 5;
            // 
            // lblLabourCost
            // 
            this.lblLabourCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLabourCost.Location = new System.Drawing.Point(518, 7);
            this.lblLabourCost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLabourCost.Name = "lblLabourCost";
            this.lblLabourCost.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.lblLabourCost.Size = new System.Drawing.Size(72, 21);
            this.lblLabourCost.TabIndex = 6;
            // 
            // numQuantity
            // 
            this.numQuantity.Location = new System.Drawing.Point(216, 8);
            this.numQuantity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(42, 20);
            this.numQuantity.TabIndex = 7;
            // 
            // MaterialUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.numQuantity);
            this.Controls.Add(this.lblLabourCost);
            this.Controls.Add(this.lblMaterialCost);
            this.Controls.Add(this.lblLabourUnitCost);
            this.Controls.Add(this.lblUnitCost);
            this.Controls.Add(this.cmbMaterialType);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MaterialUserControl";
            this.Size = new System.Drawing.Size(599, 35);
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbMaterialType;
        private System.Windows.Forms.Label lblUnitCost;
        private System.Windows.Forms.Label lblLabourUnitCost;
        private System.Windows.Forms.Label lblMaterialCost;
        private System.Windows.Forms.Label lblLabourCost;
        private System.Windows.Forms.NumericUpDown numQuantity;
    }
}
