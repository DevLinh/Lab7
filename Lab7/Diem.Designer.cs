namespace Lab7
{
    partial class frmDiem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDiem));
            System.Windows.Forms.Label maSoLabel;
            System.Windows.Forms.Label maMHLabel;
            System.Windows.Forms.Label diemLabel;
            this.basicStudentManagementDataSet = new Lab7.BasicStudentManagementDataSet();
            this.ketQuaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ketQuaTableAdapter = new Lab7.BasicStudentManagementDataSetTableAdapters.KetQuaTableAdapter();
            this.tableAdapterManager = new Lab7.BasicStudentManagementDataSetTableAdapters.TableAdapterManager();
            this.ketQuaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.ketQuaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.maSoTextBox = new System.Windows.Forms.TextBox();
            this.maMHTextBox = new System.Windows.Forms.TextBox();
            this.diemTextBox = new System.Windows.Forms.TextBox();
            this.ketQuaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            maSoLabel = new System.Windows.Forms.Label();
            maMHLabel = new System.Windows.Forms.Label();
            diemLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.basicStudentManagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ketQuaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ketQuaBindingNavigator)).BeginInit();
            this.ketQuaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ketQuaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // basicStudentManagementDataSet
            // 
            this.basicStudentManagementDataSet.DataSetName = "BasicStudentManagementDataSet";
            this.basicStudentManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ketQuaBindingSource
            // 
            this.ketQuaBindingSource.DataMember = "KetQua";
            this.ketQuaBindingSource.DataSource = this.basicStudentManagementDataSet;
            // 
            // ketQuaTableAdapter
            // 
            this.ketQuaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.KetQuaTableAdapter = this.ketQuaTableAdapter;
            this.tableAdapterManager.KhoaTableAdapter = null;
            this.tableAdapterManager.MonTableAdapter = null;
            this.tableAdapterManager.SinhVienTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Lab7.BasicStudentManagementDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ketQuaBindingNavigator
            // 
            this.ketQuaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.ketQuaBindingNavigator.BindingSource = this.ketQuaBindingSource;
            this.ketQuaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.ketQuaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.ketQuaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.ketQuaBindingNavigatorSaveItem});
            this.ketQuaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.ketQuaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.ketQuaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.ketQuaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.ketQuaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.ketQuaBindingNavigator.Name = "ketQuaBindingNavigator";
            this.ketQuaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.ketQuaBindingNavigator.Size = new System.Drawing.Size(366, 25);
            this.ketQuaBindingNavigator.TabIndex = 0;
            this.ketQuaBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // ketQuaBindingNavigatorSaveItem
            // 
            this.ketQuaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ketQuaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("ketQuaBindingNavigatorSaveItem.Image")));
            this.ketQuaBindingNavigatorSaveItem.Name = "ketQuaBindingNavigatorSaveItem";
            this.ketQuaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.ketQuaBindingNavigatorSaveItem.Text = "Save Data";
            this.ketQuaBindingNavigatorSaveItem.Click += new System.EventHandler(this.KetQuaBindingNavigatorSaveItem_Click);
            // 
            // maSoLabel
            // 
            maSoLabel.AutoSize = true;
            maSoLabel.Location = new System.Drawing.Point(16, 43);
            maSoLabel.Name = "maSoLabel";
            maSoLabel.Size = new System.Drawing.Size(41, 13);
            maSoLabel.TabIndex = 1;
            maSoLabel.Text = "Mã Số:";
            // 
            // maSoTextBox
            // 
            this.maSoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ketQuaBindingSource, "MaSo", true));
            this.maSoTextBox.Location = new System.Drawing.Point(94, 40);
            this.maSoTextBox.Name = "maSoTextBox";
            this.maSoTextBox.Size = new System.Drawing.Size(100, 20);
            this.maSoTextBox.TabIndex = 2;
            // 
            // maMHLabel
            // 
            maMHLabel.AutoSize = true;
            maMHLabel.Location = new System.Drawing.Point(16, 69);
            maMHLabel.Name = "maMHLabel";
            maMHLabel.Size = new System.Drawing.Size(72, 13);
            maMHLabel.TabIndex = 3;
            maMHLabel.Text = "Mã Môn Học:";
            // 
            // maMHTextBox
            // 
            this.maMHTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ketQuaBindingSource, "MaMH", true));
            this.maMHTextBox.Location = new System.Drawing.Point(94, 66);
            this.maMHTextBox.Name = "maMHTextBox";
            this.maMHTextBox.Size = new System.Drawing.Size(100, 20);
            this.maMHTextBox.TabIndex = 4;
            // 
            // diemLabel
            // 
            diemLabel.AutoSize = true;
            diemLabel.Location = new System.Drawing.Point(16, 95);
            diemLabel.Name = "diemLabel";
            diemLabel.Size = new System.Drawing.Size(34, 13);
            diemLabel.TabIndex = 5;
            diemLabel.Text = "Điểm:";
            // 
            // diemTextBox
            // 
            this.diemTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ketQuaBindingSource, "Diem", true));
            this.diemTextBox.Location = new System.Drawing.Point(94, 92);
            this.diemTextBox.Name = "diemTextBox";
            this.diemTextBox.Size = new System.Drawing.Size(100, 20);
            this.diemTextBox.TabIndex = 6;
            // 
            // ketQuaDataGridView
            // 
            this.ketQuaDataGridView.AutoGenerateColumns = false;
            this.ketQuaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ketQuaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.ketQuaDataGridView.DataSource = this.ketQuaBindingSource;
            this.ketQuaDataGridView.Location = new System.Drawing.Point(12, 145);
            this.ketQuaDataGridView.Name = "ketQuaDataGridView";
            this.ketQuaDataGridView.Size = new System.Drawing.Size(340, 293);
            this.ketQuaDataGridView.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaSo";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã Số";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MaMH";
            this.dataGridViewTextBoxColumn2.HeaderText = "Mã Môn Học";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Diem";
            this.dataGridViewTextBoxColumn3.HeaderText = "Điểm";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // frmDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 450);
            this.Controls.Add(this.ketQuaDataGridView);
            this.Controls.Add(maSoLabel);
            this.Controls.Add(this.maSoTextBox);
            this.Controls.Add(maMHLabel);
            this.Controls.Add(this.maMHTextBox);
            this.Controls.Add(diemLabel);
            this.Controls.Add(this.diemTextBox);
            this.Controls.Add(this.ketQuaBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmDiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập Điểm Thi";
            this.Load += new System.EventHandler(this.FrmDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.basicStudentManagementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ketQuaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ketQuaBindingNavigator)).EndInit();
            this.ketQuaBindingNavigator.ResumeLayout(false);
            this.ketQuaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ketQuaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BasicStudentManagementDataSet basicStudentManagementDataSet;
        private System.Windows.Forms.BindingSource ketQuaBindingSource;
        private BasicStudentManagementDataSetTableAdapters.KetQuaTableAdapter ketQuaTableAdapter;
        private BasicStudentManagementDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator ketQuaBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton ketQuaBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox maSoTextBox;
        private System.Windows.Forms.TextBox maMHTextBox;
        private System.Windows.Forms.TextBox diemTextBox;
        private System.Windows.Forms.DataGridView ketQuaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}