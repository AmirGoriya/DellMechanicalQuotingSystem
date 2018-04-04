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
            this.cmbMaterialType.BackColor = System.Drawing.SystemColors.Menu;
            this.cmbMaterialType.FormattingEnabled = true;
            this.cmbMaterialType.Location = new System.Drawing.Point(20, 12);
            this.cmbMaterialType.Name = "cmbMaterialType";
            this.cmbMaterialType.Size = new System.Drawing.Size(284, 28);
            this.cmbMaterialType.TabIndex = 1;
            this.cmbMaterialType.SelectedIndexChanged += new System.EventHandler(this.cmbMaterialType_SelectedIndexChanged);
            // 
            // lblUnitCost
            // 
            this.lblUnitCost.BackColor = System.Drawing.SystemColors.Menu;
            this.lblUnitCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUnitCost.Location = new System.Drawing.Point(408, 12);
            this.lblUnitCost.Name = "lblUnitCost";
            this.lblUnitCost.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblUnitCost.Size = new System.Drawing.Size(106, 31);
            this.lblUnitCost.TabIndex = 2;
            // 
            // lblLabourUnitCost
            // 
            this.lblLabourUnitCost.BackColor = System.Drawing.SystemColors.Menu;
            this.lblLabourUnitCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLabourUnitCost.Location = new System.Drawing.Point(652, 11);
            this.lblLabourUnitCost.Name = "lblLabourUnitCost";
            this.lblLabourUnitCost.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblLabourUnitCost.Size = new System.Drawing.Size(107, 31);
            this.lblLabourUnitCost.TabIndex = 3;
            // 
            // lblMaterialCost
            // 
            this.lblMaterialCost.BackColor = System.Drawing.SystemColors.Menu;
            this.lblMaterialCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMaterialCost.Location = new System.Drawing.Point(526, 11);
            this.lblMaterialCost.Name = "lblMaterialCost";
            this.lblMaterialCost.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblMaterialCost.Size = new System.Drawing.Size(113, 33);
            this.lblMaterialCost.TabIndex = 5;
            // 
            // lblLabourCost
            // 
            this.lblLabourCost.BackColor = System.Drawing.SystemColors.Menu;
            this.lblLabourCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLabourCost.Location = new System.Drawing.Point(777, 11);
            this.lblLabourCost.Name = "lblLabourCost";
            this.lblLabourCost.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblLabourCost.Size = new System.Drawing.Size(107, 31);
            this.lblLabourCost.TabIndex = 6;
            // 
            // numQuantity
            // 
            this.numQuantity.BackColor = System.Drawing.SystemColors.Menu;
            this.numQuantity.Location = new System.Drawing.Point(324, 12);
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(63, 26);
            this.numQuantity.TabIndex = 7;
            // 
            // MaterialUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.numQuantity);
            this.Controls.Add(this.lblLabourCost);
            this.Controls.Add(this.lblMaterialCost);
            this.Controls.Add(this.lblLabourUnitCost);
            this.Controls.Add(this.lblUnitCost);
            this.Controls.Add(this.cmbMaterialType);
            this.Name = "MaterialUserControl";
            this.Size = new System.Drawing.Size(898, 54);
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
