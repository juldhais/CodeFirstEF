namespace CodeFirstEF
{
    partial class MainForm
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
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.buttonSaveChanges = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.attackDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.defenseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heroBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid.AutoGenerateColumns = false;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.categoryIdDataGridViewTextBoxColumn,
            this.attackDataGridViewTextBoxColumn,
            this.defenseDataGridViewTextBoxColumn});
            this.dataGrid.DataSource = this.heroBindingSource;
            this.dataGrid.Location = new System.Drawing.Point(12, 41);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(960, 508);
            this.dataGrid.TabIndex = 0;
            // 
            // buttonSaveChanges
            // 
            this.buttonSaveChanges.Location = new System.Drawing.Point(12, 12);
            this.buttonSaveChanges.Name = "buttonSaveChanges";
            this.buttonSaveChanges.Size = new System.Drawing.Size(100, 23);
            this.buttonSaveChanges.TabIndex = 2;
            this.buttonSaveChanges.Text = "Save Changes";
            this.buttonSaveChanges.UseVisualStyleBackColor = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // categoryIdDataGridViewTextBoxColumn
            // 
            this.categoryIdDataGridViewTextBoxColumn.DataPropertyName = "CategoryId";
            this.categoryIdDataGridViewTextBoxColumn.DataSource = this.categoryBindingSource;
            this.categoryIdDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.categoryIdDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryIdDataGridViewTextBoxColumn.Name = "categoryIdDataGridViewTextBoxColumn";
            this.categoryIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.categoryIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.categoryIdDataGridViewTextBoxColumn.ValueMember = "Id";
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataSource = typeof(CodeFirstEF.Models.Category);
            // 
            // attackDataGridViewTextBoxColumn
            // 
            this.attackDataGridViewTextBoxColumn.DataPropertyName = "Attack";
            this.attackDataGridViewTextBoxColumn.HeaderText = "Attack";
            this.attackDataGridViewTextBoxColumn.Name = "attackDataGridViewTextBoxColumn";
            // 
            // defenseDataGridViewTextBoxColumn
            // 
            this.defenseDataGridViewTextBoxColumn.DataPropertyName = "Defense";
            this.defenseDataGridViewTextBoxColumn.HeaderText = "Defense";
            this.defenseDataGridViewTextBoxColumn.Name = "defenseDataGridViewTextBoxColumn";
            // 
            // heroBindingSource
            // 
            this.heroBindingSource.DataSource = typeof(CodeFirstEF.Models.Hero);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.buttonSaveChanges);
            this.Controls.Add(this.dataGrid);
            this.Name = "MainForm";
            this.Text = "Heroes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heroBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button buttonSaveChanges;
        private System.Windows.Forms.BindingSource heroBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn categoryIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn attackDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn defenseDataGridViewTextBoxColumn;
    }
}

