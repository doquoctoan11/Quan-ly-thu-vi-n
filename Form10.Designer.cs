namespace DO_Quoc_Toan_MTA
{
    partial class Form10
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form10));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.txttensach = new System.Windows.Forms.TextBox();
            this.dtphantra = new System.Windows.Forms.DateTimePicker();
            this.cbtensach = new System.Windows.Forms.ComboBox();
            this.cbso = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvctpm = new System.Windows.Forms.DataGridView();
            this.SoPhieuMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HạnTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvctpm)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnthoat);
            this.panel1.Controls.Add(this.btnxoa);
            this.panel1.Controls.Add(this.btnluu);
            this.panel1.Controls.Add(this.btnthem);
            this.panel1.Controls.Add(this.txttensach);
            this.panel1.Controls.Add(this.dtphantra);
            this.panel1.Controls.Add(this.cbtensach);
            this.panel1.Controls.Add(this.cbso);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(352, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 261);
            this.panel1.TabIndex = 0;
            // 
            // btnthoat
            // 
            this.btnthoat.ImageIndex = 3;
            this.btnthoat.ImageList = this.imageList1;
            this.btnthoat.Location = new System.Drawing.Point(174, 208);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 23);
            this.btnthoat.TabIndex = 11;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.ImageIndex = 2;
            this.btnxoa.ImageList = this.imageList1;
            this.btnxoa.Location = new System.Drawing.Point(22, 208);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 10;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnluu
            // 
            this.btnluu.ImageIndex = 1;
            this.btnluu.ImageList = this.imageList1;
            this.btnluu.Location = new System.Drawing.Point(174, 155);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(75, 23);
            this.btnluu.TabIndex = 9;
            this.btnluu.Text = "Lưu";
            this.btnluu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnthem
            // 
            this.btnthem.ImageIndex = 0;
            this.btnthem.ImageList = this.imageList1;
            this.btnthem.Location = new System.Drawing.Point(22, 155);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 23);
            this.btnthem.TabIndex = 8;
            this.btnthem.Text = "Thêm";
            this.btnthem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // txttensach
            // 
            this.txttensach.Location = new System.Drawing.Point(255, 67);
            this.txttensach.Name = "txttensach";
            this.txttensach.Size = new System.Drawing.Size(28, 20);
            this.txttensach.TabIndex = 7;
            // 
            // dtphantra
            // 
            this.dtphantra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtphantra.Location = new System.Drawing.Point(98, 102);
            this.dtphantra.Name = "dtphantra";
            this.dtphantra.Size = new System.Drawing.Size(151, 20);
            this.dtphantra.TabIndex = 5;
            // 
            // cbtensach
            // 
            this.cbtensach.FormattingEnabled = true;
            this.cbtensach.Location = new System.Drawing.Point(98, 67);
            this.cbtensach.Name = "cbtensach";
            this.cbtensach.Size = new System.Drawing.Size(151, 21);
            this.cbtensach.TabIndex = 4;
            // 
            // cbso
            // 
            this.cbso.FormattingEnabled = true;
            this.cbso.Location = new System.Drawing.Point(98, 34);
            this.cbso.Name = "cbso";
            this.cbso.Size = new System.Drawing.Size(151, 21);
            this.cbso.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hạn Trả";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên sách";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số Phiếu mượn";
            // 
            // dgvctpm
            // 
            this.dgvctpm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvctpm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SoPhieuMuon,
            this.MaSach,
            this.HạnTra});
            this.dgvctpm.Location = new System.Drawing.Point(13, 13);
            this.dgvctpm.Name = "dgvctpm";
            this.dgvctpm.Size = new System.Drawing.Size(285, 150);
            this.dgvctpm.TabIndex = 1;
            // 
            // SoPhieuMuon
            // 
            this.SoPhieuMuon.DataPropertyName = "SoPhieuMuon";
            this.SoPhieuMuon.HeaderText = "Số Phiếu Mượn";
            this.SoPhieuMuon.Name = "SoPhieuMuon";
            // 
            // MaSach
            // 
            this.MaSach.DataPropertyName = "MaSach";
            this.MaSach.HeaderText = "Mã Sách";
            this.MaSach.Name = "MaSach";
            // 
            // HạnTra
            // 
            this.HạnTra.DataPropertyName = "HanTra";
            this.HạnTra.HeaderText = "Hạn Trả";
            this.HạnTra.Name = "HạnTra";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Thêm.png");
            this.imageList1.Images.SetKeyName(1, "Lưu.png");
            this.imageList1.Images.SetKeyName(2, "Xóa.png");
            this.imageList1.Images.SetKeyName(3, "Thoát.png");
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 261);
            this.Controls.Add(this.dgvctpm);
            this.Controls.Add(this.panel1);
            this.Name = "Form10";
            this.Text = "Form10";
            this.Load += new System.EventHandler(this.Form10_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvctpm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvctpm;
        private System.Windows.Forms.TextBox txttensach;
        private System.Windows.Forms.DateTimePicker dtphantra;
        private System.Windows.Forms.ComboBox cbtensach;
        private System.Windows.Forms.ComboBox cbso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoPhieuMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn HạnTra;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.ImageList imageList1;
    }
}