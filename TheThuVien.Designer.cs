
namespace project
{
    partial class TheThuVien
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
            this.quanLyThuVienDataSet = new project.QuanLyThuVienDataSet();
            this.theLoaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.theLoaiTableAdapter = new project.QuanLyThuVienDataSetTableAdapters.TheLoaiTableAdapter();
            this.tableAdapterManager = new project.QuanLyThuVienDataSetTableAdapters.TableAdapterManager();
            this.maTheLoaiTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.theLoaiBindingSource)).BeginInit();
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
            // maTheLoaiTextBox
            // 
            this.maTheLoaiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.theLoaiBindingSource, "MaTheLoai", true));
            this.maTheLoaiTextBox.Location = new System.Drawing.Point(250, 96);
            this.maTheLoaiTextBox.Name = "maTheLoaiTextBox";
            this.maTheLoaiTextBox.Size = new System.Drawing.Size(100, 22);
            this.maTheLoaiTextBox.TabIndex = 2;
            // 
            // TheThuVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.maTheLoaiTextBox);
            this.Name = "TheThuVien";
            this.Text = "TheThuVien";
            this.Load += new System.EventHandler(this.TheThuVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quanLyThuVienDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.theLoaiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QuanLyThuVienDataSet quanLyThuVienDataSet;
        private System.Windows.Forms.BindingSource theLoaiBindingSource;
        private QuanLyThuVienDataSetTableAdapters.TheLoaiTableAdapter theLoaiTableAdapter;
        private QuanLyThuVienDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox maTheLoaiTextBox;
    }
}