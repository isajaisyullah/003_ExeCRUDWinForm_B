
namespace ExeCRUDWinForm
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.exeCRUDDataSet = new ExeCRUDWinForm.ExeCRUDDataSet();
            this.peminjamanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.peminjamanTableAdapter = new ExeCRUDWinForm.ExeCRUDDataSetTableAdapters.peminjamanTableAdapter();
            this.btnData = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.idPeminjamanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPenyewaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idKendaraanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tglPeminjamanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lamaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exeCRUDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peminjamanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(242, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DATA PEMINJAMAN";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnData);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 309);
            this.panel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPeminjamanDataGridViewTextBoxColumn,
            this.idPenyewaDataGridViewTextBoxColumn,
            this.idKendaraanDataGridViewTextBoxColumn,
            this.tglPeminjamanDataGridViewTextBoxColumn,
            this.lamaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.peminjamanBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(581, 239);
            this.dataGridView1.TabIndex = 0;
            // 
            // exeCRUDDataSet
            // 
            this.exeCRUDDataSet.DataSetName = "ExeCRUDDataSet";
            this.exeCRUDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // peminjamanBindingSource
            // 
            this.peminjamanBindingSource.DataMember = "peminjaman";
            this.peminjamanBindingSource.DataSource = this.exeCRUDDataSet;
            // 
            // peminjamanTableAdapter
            // 
            this.peminjamanTableAdapter.ClearBeforeFill = true;
            // 
            // btnData
            // 
            this.btnData.Location = new System.Drawing.Point(254, 270);
            this.btnData.Name = "btnData";
            this.btnData.Size = new System.Drawing.Size(169, 23);
            this.btnData.TabIndex = 1;
            this.btnData.Text = "Data Penyewa";
            this.btnData.UseVisualStyleBackColor = true;
            this.btnData.Click += new System.EventHandler(this.btnData_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(62, 270);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(157, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Tambah Peminjaman";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // idPeminjamanDataGridViewTextBoxColumn
            // 
            this.idPeminjamanDataGridViewTextBoxColumn.DataPropertyName = "idPeminjaman";
            this.idPeminjamanDataGridViewTextBoxColumn.HeaderText = "idPeminjaman";
            this.idPeminjamanDataGridViewTextBoxColumn.Name = "idPeminjamanDataGridViewTextBoxColumn";
            // 
            // idPenyewaDataGridViewTextBoxColumn
            // 
            this.idPenyewaDataGridViewTextBoxColumn.DataPropertyName = "idPenyewa";
            this.idPenyewaDataGridViewTextBoxColumn.HeaderText = "idPenyewa";
            this.idPenyewaDataGridViewTextBoxColumn.Name = "idPenyewaDataGridViewTextBoxColumn";
            // 
            // idKendaraanDataGridViewTextBoxColumn
            // 
            this.idKendaraanDataGridViewTextBoxColumn.DataPropertyName = "idKendaraan";
            this.idKendaraanDataGridViewTextBoxColumn.HeaderText = "idKendaraan";
            this.idKendaraanDataGridViewTextBoxColumn.Name = "idKendaraanDataGridViewTextBoxColumn";
            // 
            // tglPeminjamanDataGridViewTextBoxColumn
            // 
            this.tglPeminjamanDataGridViewTextBoxColumn.DataPropertyName = "tglPeminjaman";
            this.tglPeminjamanDataGridViewTextBoxColumn.HeaderText = "Tanggal";
            this.tglPeminjamanDataGridViewTextBoxColumn.Name = "tglPeminjamanDataGridViewTextBoxColumn";
            // 
            // lamaDataGridViewTextBoxColumn
            // 
            this.lamaDataGridViewTextBoxColumn.DataPropertyName = "lama";
            this.lamaDataGridViewTextBoxColumn.HeaderText = "Lama Peminjaman";
            this.lamaDataGridViewTextBoxColumn.Name = "lamaDataGridViewTextBoxColumn";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(460, 270);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "back";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exeCRUDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peminjamanBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ExeCRUDDataSet exeCRUDDataSet;
        private System.Windows.Forms.BindingSource peminjamanBindingSource;
        private ExeCRUDDataSetTableAdapters.peminjamanTableAdapter peminjamanTableAdapter;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnData;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPeminjamanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPenyewaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idKendaraanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tglPeminjamanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lamaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button3;
    }
}