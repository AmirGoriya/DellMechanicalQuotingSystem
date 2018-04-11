using System;

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
            this.components = new System.ComponentModel.Container();
            this.cmbMaterialType = new System.Windows.Forms.ComboBox();
            this.materialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dellMechanicalDBDataSet = new DellMechanicalQuoteSystem.DellMechanicalDBDataSet();
            this.lblMaterialUnitCost = new System.Windows.Forms.Label();
            this.lblLabourUnitCost = new System.Windows.Forms.Label();
            this.lblMaterialCost = new System.Windows.Forms.Label();
            this.lblLabourCost = new System.Windows.Forms.Label();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.materialTableAdapter = new DellMechanicalQuoteSystem.DellMechanicalDBDataSetTableAdapters.MaterialTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dellMechanicalDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbMaterialType
            // 
            this.cmbMaterialType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbMaterialType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbMaterialType.BackColor = System.Drawing.SystemColors.Menu;
            this.cmbMaterialType.DataSource = this.materialBindingSource;
            this.cmbMaterialType.DisplayMember = "material";
            this.cmbMaterialType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaterialType.FormattingEnabled = true;
            this.cmbMaterialType.Location = new System.Drawing.Point(13, 28);
            this.cmbMaterialType.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMaterialType.Name = "cmbMaterialType";
            this.cmbMaterialType.Size = new System.Drawing.Size(191, 21);
            this.cmbMaterialType.TabIndex = 1;
            this.cmbMaterialType.ValueMember = "Id";
            this.cmbMaterialType.Leave += new System.EventHandler(this.cmbMaterialType_Leave);
            // 
            // materialBindingSource
            // 
            this.materialBindingSource.DataMember = "Material";
            this.materialBindingSource.DataSource = this.dellMechanicalDBDataSet;
            // 
            // dellMechanicalDBDataSet
            // 
            this.dellMechanicalDBDataSet.DataSetName = "DellMechanicalDBDataSet";
            this.dellMechanicalDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblMaterialUnitCost
            // 
            this.lblMaterialUnitCost.BackColor = System.Drawing.SystemColors.Menu;
            this.lblMaterialUnitCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMaterialUnitCost.Location = new System.Drawing.Point(272, 28);
            this.lblMaterialUnitCost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaterialUnitCost.Name = "lblMaterialUnitCost";
            this.lblMaterialUnitCost.Padding = new System.Windows.Forms.Padding(3);
            this.lblMaterialUnitCost.Size = new System.Drawing.Size(71, 21);
            this.lblMaterialUnitCost.TabIndex = 2;
            // 
            // lblLabourUnitCost
            // 
            this.lblLabourUnitCost.BackColor = System.Drawing.SystemColors.Menu;
            this.lblLabourUnitCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLabourUnitCost.Location = new System.Drawing.Point(435, 27);
            this.lblLabourUnitCost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLabourUnitCost.Name = "lblLabourUnitCost";
            this.lblLabourUnitCost.Padding = new System.Windows.Forms.Padding(3);
            this.lblLabourUnitCost.Size = new System.Drawing.Size(72, 21);
            this.lblLabourUnitCost.TabIndex = 3;
            // 
            // lblMaterialCost
            // 
            this.lblMaterialCost.BackColor = System.Drawing.SystemColors.Menu;
            this.lblMaterialCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMaterialCost.Location = new System.Drawing.Point(351, 27);
            this.lblMaterialCost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaterialCost.Name = "lblMaterialCost";
            this.lblMaterialCost.Padding = new System.Windows.Forms.Padding(3);
            this.lblMaterialCost.Size = new System.Drawing.Size(76, 22);
            this.lblMaterialCost.TabIndex = 5;
            // 
            // lblLabourCost
            // 
            this.lblLabourCost.BackColor = System.Drawing.SystemColors.Menu;
            this.lblLabourCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLabourCost.Location = new System.Drawing.Point(518, 27);
            this.lblLabourCost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLabourCost.Name = "lblLabourCost";
            this.lblLabourCost.Padding = new System.Windows.Forms.Padding(3);
            this.lblLabourCost.Size = new System.Drawing.Size(72, 21);
            this.lblLabourCost.TabIndex = 6;
            // 
            // numQuantity
            // 
            this.numQuantity.BackColor = System.Drawing.SystemColors.Menu;
            this.numQuantity.Location = new System.Drawing.Point(216, 28);
            this.numQuantity.Margin = new System.Windows.Forms.Padding(2);
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(42, 20);
            this.numQuantity.TabIndex = 7;
            this.numQuantity.Enter += new System.EventHandler(this.numQuantity_Enter);
            this.numQuantity.Leave += new System.EventHandler(this.numQuantity_Leave);
            // 
            // materialTableAdapter
            // 
            this.materialTableAdapter.ClearBeforeFill = true;
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
            this.Controls.Add(this.lblMaterialUnitCost);
            this.Controls.Add(this.cmbMaterialType);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MaterialUserControl";
            this.Size = new System.Drawing.Size(610, 57);
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dellMechanicalDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbMaterialType;
        private System.Windows.Forms.Label lblMaterialUnitCost;
        private System.Windows.Forms.Label lblLabourUnitCost;
        private System.Windows.Forms.Label lblMaterialCost;
        private System.Windows.Forms.Label lblLabourCost;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.BindingSource materialBindingSource;
        private DellMechanicalDBDataSet dellMechanicalDBDataSet;
        private DellMechanicalDBDataSetTableAdapters.MaterialTableAdapter materialTableAdapter;
    }
}
