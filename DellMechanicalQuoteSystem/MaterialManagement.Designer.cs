namespace DellMechanicalQuoteSystem
{
    partial class MaterialManagement
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dellMechanicalDBDataSet = new DellMechanicalQuoteSystem.DellMechanicalDBDataSet();
            this.dellMechanicalDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materialTableAdapter = new DellMechanicalQuoteSystem.DellMechanicalDBDataSetTableAdapters.MaterialTableAdapter();
            this.btnUpdateMaterials = new System.Windows.Forms.Button();
            this.materialBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.materialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialUnitPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labourUnitPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dellMechanicalDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dellMechanicalDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.materialDataGridViewTextBoxColumn,
            this.materialUnitPriceDataGridViewTextBoxColumn,
            this.labourUnitPriceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.materialBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(8, 8);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(427, 440);
            this.dataGridView1.TabIndex = 0;
            // 
            // dellMechanicalDBDataSet
            // 
            this.dellMechanicalDBDataSet.DataSetName = "DellMechanicalDBDataSet";
            this.dellMechanicalDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dellMechanicalDBDataSetBindingSource
            // 
            this.dellMechanicalDBDataSetBindingSource.DataSource = this.dellMechanicalDBDataSet;
            this.dellMechanicalDBDataSetBindingSource.Position = 0;
            // 
            // materialBindingSource
            // 
            this.materialBindingSource.DataSource = this.dellMechanicalDBDataSetBindingSource;
            this.materialBindingSource.Position = 0;
            // 
            // materialTableAdapter
            // 
            this.materialTableAdapter.ClearBeforeFill = true;
            // 
            // btnUpdateMaterials
            // 
            this.btnUpdateMaterials.Location = new System.Drawing.Point(312, 456);
            this.btnUpdateMaterials.Name = "btnUpdateMaterials";
            this.btnUpdateMaterials.Size = new System.Drawing.Size(119, 23);
            this.btnUpdateMaterials.TabIndex = 1;
            this.btnUpdateMaterials.Text = "Update Materials";
            this.btnUpdateMaterials.UseVisualStyleBackColor = true;
            this.btnUpdateMaterials.Click += new System.EventHandler(this.btnUpdateMaterials_Click);
            // 
            // materialBindingSource1
            // 
            this.materialBindingSource1.DataMember = "Material";
            this.materialBindingSource1.DataSource = this.dellMechanicalDBDataSetBindingSource;
            // 
            // materialDataGridViewTextBoxColumn
            // 
            this.materialDataGridViewTextBoxColumn.DataPropertyName = "material";
            this.materialDataGridViewTextBoxColumn.HeaderText = "material";
            this.materialDataGridViewTextBoxColumn.Name = "materialDataGridViewTextBoxColumn";
            // 
            // materialUnitPriceDataGridViewTextBoxColumn
            // 
            this.materialUnitPriceDataGridViewTextBoxColumn.DataPropertyName = "materialUnitPrice";
            this.materialUnitPriceDataGridViewTextBoxColumn.HeaderText = "materialUnitPrice";
            this.materialUnitPriceDataGridViewTextBoxColumn.Name = "materialUnitPriceDataGridViewTextBoxColumn";
            // 
            // labourUnitPriceDataGridViewTextBoxColumn
            // 
            this.labourUnitPriceDataGridViewTextBoxColumn.DataPropertyName = "labourUnitPrice";
            this.labourUnitPriceDataGridViewTextBoxColumn.HeaderText = "labourUnitPrice";
            this.labourUnitPriceDataGridViewTextBoxColumn.Name = "labourUnitPriceDataGridViewTextBoxColumn";
            // 
            // MaterialManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 491);
            this.Controls.Add(this.btnUpdateMaterials);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MaterialManagement";
            this.Text = "MaterialManagement";
            this.Load += new System.EventHandler(this.MaterialManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dellMechanicalDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dellMechanicalDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private DellMechanicalDBDataSet dellMechanicalDBDataSet;
        private System.Windows.Forms.BindingSource dellMechanicalDBDataSetBindingSource;
        private System.Windows.Forms.BindingSource materialBindingSource;
        private DellMechanicalDBDataSetTableAdapters.MaterialTableAdapter materialTableAdapter;
        private System.Windows.Forms.Button btnUpdateMaterials;
        private System.Windows.Forms.BindingSource materialBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialUnitPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn labourUnitPriceDataGridViewTextBoxColumn;
    }
}