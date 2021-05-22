
namespace project
{
    partial class TheLoai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TheLoai));
            System.Windows.Forms.Label maTheLoaiLabel;
            System.Windows.Forms.Label tenTheLoaiLabel;
            this.quanLyThuVienDataSet = new project.QuanLyThuVienDataSet();
            this.theLoaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.theLoaiTableAdapter = new project.QuanLyThuVienDataSetTableAdapters.TheLoaiTableAdapter();
            this.tableAdapterManager = new project.QuanLyThuVienDataSetTableAdapters.TableAdapterManager();
            this.theLoaiBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.theLoaiBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.maTheLoaiTextBox = new System.Windows.Forms.TextBox();
            this.tenTheLoaiTextBox = new System.Windows.Forms.TextBox();
            this.theLoaiDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            maTheLoaiLabel = new System.Windows.Forms.Label();
            tenTheLoaiLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.theLoaiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.theLoaiBindingNavigator)).BeginInit();
            this.theLoaiBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.theLoaiDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // quanLyThuVienDataSet
            // 
            this.quanLyThuVienDataSet.DataSetName = "QuanLyThuVienDataSet";
            this.quanLyThuVienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // theLoaiBindingSource
            // 
            this.theLoaiBindingSource.DataMember = "TheLoai";
            this.theLoaiBindingSource.DataSource = this.quanLyThuVienDataSet;
            // 
            // theLoaiTableAdapter
            // 
            this.theLoaiTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DocGiaTableAdapter = null;
            this.tableAdapterManager.MuonTraTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.NhaXuatBanTableAdapter = null;
            this.tableAdapterManager.SachTableAdapter = null;
            this.tableAdapterManager.TacGiaTableAdapter = null;
            this.tableAdapterManager.TheLoaiTableAdapter = this.theLoaiTableAdapter;
            this.tableAdapterManager.TheThuVienTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = project.QuanLyThuVienDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // theLoaiBindingNavigator
            // 
            this.theLoaiBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.theLoaiBindingNavigator.BindingSource = this.theLoaiBindingSource;
            this.theLoaiBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.theLoaiBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.theLoaiBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.theLoaiBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.theLoaiBindingNavigatorSaveItem});
            this.theLoaiBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.theLoaiBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.theLoaiBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.theLoaiBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.theLoaiBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.theLoaiBindingNavigator.Name = "theLoaiBindingNavigator";
            this.theLoaiBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.theLoaiBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.theLoaiBindingNavigator.TabIndex = 0;
            this.theLoaiBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 22);
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 20);
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
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
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
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // theLoaiBindingNavigatorSaveItem
            // 
            this.theLoaiBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.theLoaiBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("theLoaiBindingNavigatorSaveItem.Image")));
            this.theLoaiBindingNavigatorSaveItem.Name = "theLoaiBindingNavigatorSaveItem";
            this.theLoaiBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.theLoaiBindingNavigatorSaveItem.Text = "Save Data";
            this.theLoaiBindingNavigatorSaveItem.Click += new System.EventHandler(this.theLoaiBindingNavigatorSaveItem_Click);
            // 
            // maTheLoaiLabel
            // 
            maTheLoaiLabel.AutoSize = true;
            maTheLoaiLabel.Location = new System.Drawing.Point(216, 77);
            maTheLoaiLabel.Name = "maTheLoaiLabel";
            maTheLoaiLabel.Size = new System.Drawing.Size(91, 17);
            maTheLoaiLabel.TabIndex = 1;
            maTheLoaiLabel.Text = "Ma The Loai:";
            // 
            // maTheLoaiTextBox
            // 
            this.maTheLoaiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.theLoaiBindingSource, "MaTheLoai", true));
            this.maTheLoaiTextBox.Location = new System.Drawing.Point(313, 74);
            this.maTheLoaiTextBox.Name = "maTheLoaiTextBox";
            this.maTheLoaiTextBox.Size = new System.Drawing.Size(100, 22);
            this.maTheLoaiTextBox.TabIndex = 2;
            // 
            // tenTheLoaiLabel
            // 
            tenTheLoaiLabel.AutoSize = true;
            tenTheLoaiLabel.Location = new System.Drawing.Point(235, 137);
            tenTheLoaiLabel.Name = "tenTheLoaiLabel";
            tenTheLoaiLabel.Size = new System.Drawing.Size(97, 17);
            tenTheLoaiLabel.TabIndex = 3;
            tenTheLoaiLabel.Text = "Ten The Loai:";
            // 
            // tenTheLoaiTextBox
            // 
            this.tenTheLoaiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.theLoaiBindingSource, "TenTheLoai", true));
            this.tenTheLoaiTextBox.Location = new System.Drawing.Point(338, 134);
            this.tenTheLoaiTextBox.Name = "tenTheLoaiTextBox";
            this.tenTheLoaiTextBox.Size = new System.Drawing.Size(100, 22);
            this.tenTheLoaiTextBox.TabIndex = 4;
            // 
            // theLoaiDataGridView
            // 
            this.theLoaiDataGridView.AutoGenerateColumns = false;
            this.theLoaiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.theLoaiDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.theLoaiDataGridView.DataSource = this.theLoaiBindingSource;
            this.theLoaiDataGridView.Location = new System.Drawing.Point(45, 257);
            this.theLoaiDataGridView.Name = "theLoaiDataGridView";
            this.theLoaiDataGridView.RowHeadersWidth = 51;
            this.theLoaiDataGridView.RowTemplate.Height = 24;
            this.theLoaiDataGridView.Size = new System.Drawing.Size(705, 220);
            this.theLoaiDataGridView.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaTheLoai";
            this.dataGridViewTextBoxColumn1.HeaderText = "MaTheLoai";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TenTheLoai";
            this.dataGridViewTextBoxColumn2.HeaderText = "TenTheLoai";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // TheLoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 497);
            this.Controls.Add(this.theLoaiDataGridView);
            this.Controls.Add(tenTheLoaiLabel);
            this.Controls.Add(this.tenTheLoaiTextBox);
            this.Controls.Add(maTheLoaiLabel);
            this.Controls.Add(this.maTheLoaiTextBox);
            this.Controls.Add(this.theLoaiBindingNavigator);
            this.Name = "TheLoai";
            this.Text = "TheLoai";
            this.Load += new System.EventHandler(this.TheLoai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.theLoaiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.theLoaiBindingNavigator)).EndInit();
            this.theLoaiBindingNavigator.ResumeLayout(false);
            this.theLoaiBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.theLoaiDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QuanLyThuVienDataSet quanLyThuVienDataSet;
        private System.Windows.Forms.BindingSource theLoaiBindingSource;
        private QuanLyThuVienDataSetTableAdapters.TheLoaiTableAdapter theLoaiTableAdapter;
        private QuanLyThuVienDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator theLoaiBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton theLoaiBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox maTheLoaiTextBox;
        private System.Windows.Forms.TextBox tenTheLoaiTextBox;
        private System.Windows.Forms.DataGridView theLoaiDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}