namespace DO_Quoc_Toan_MTA
{
    partial class Form9
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form9));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.SoPhieuMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnxoa2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnmuon = new System.Windows.Forms.Button();
            this.txtnv = new System.Windows.Forms.TextBox();
            this.txtdg = new System.Windows.Forms.TextBox();
            this.dtpngaymuon = new System.Windows.Forms.DateTimePicker();
            this.cbnhanvien = new System.Windows.Forms.ComboBox();
            this.cbtendg = new System.Windows.Forms.ComboBox();
            this.txtso = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnxoa2);
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Panel2.Controls.Add(this.btnthoat);
            this.splitContainer1.Panel2.Controls.Add(this.btnluu);
            this.splitContainer1.Panel2.Controls.Add(this.btnmuon);
            this.splitContainer1.Panel2.Controls.Add(this.txtnv);
            this.splitContainer1.Panel2.Controls.Add(this.txtdg);
            this.splitContainer1.Panel2.Controls.Add(this.dtpngaymuon);
            this.splitContainer1.Panel2.Controls.Add(this.cbnhanvien);
            this.splitContainer1.Panel2.Controls.Add(this.cbtendg);
            this.splitContainer1.Panel2.Controls.Add(this.txtso);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(742, 345);
            this.splitContainer1.SplitterDistance = 418;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 164);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dan Mục Mượn Thêm";
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SoPhieuMuon,
            this.MaDG,
            this.MaNV,
            this.NgayMuon});
            this.dgv1.Location = new System.Drawing.Point(71, 19);
            this.dgv1.Name = "dgv1";
            this.dgv1.Size = new System.Drawing.Size(341, 140);
            this.dgv1.TabIndex = 0;
            // 
            // SoPhieuMuon
            // 
            this.SoPhieuMuon.DataPropertyName = "SoPhieuMuon";
            this.SoPhieuMuon.HeaderText = "Số Phiếu Mượn";
            this.SoPhieuMuon.Name = "SoPhieuMuon";
            // 
            // MaDG
            // 
            this.MaDG.DataPropertyName = "MaDG";
            this.MaDG.HeaderText = "Mã ĐG";
            this.MaDG.Name = "MaDG";
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã NV";
            this.MaNV.Name = "MaNV";
            // 
            // NgayMuon
            // 
            this.NgayMuon.DataPropertyName = "NgayMuon";
            this.NgayMuon.HeaderText = "Ngày Mượn";
            this.NgayMuon.Name = "NgayMuon";
            // 
            // btnxoa2
            // 
            this.btnxoa2.ImageIndex = 2;
            this.btnxoa2.ImageList = this.imageList1;
            this.btnxoa2.Location = new System.Drawing.Point(165, 218);
            this.btnxoa2.Name = "btnxoa2";
            this.btnxoa2.Size = new System.Drawing.Size(75, 23);
            this.btnxoa2.TabIndex = 14;
            this.btnxoa2.Text = "Xóa";
            this.btnxoa2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnxoa2.UseVisualStyleBackColor = true;
            this.btnxoa2.Click += new System.EventHandler(this.btnxoa2_Click);
            // 
            // button1
            // 
            this.button1.ImageIndex = 0;
            this.button1.ImageList = this.imageList1;
            this.button1.Location = new System.Drawing.Point(30, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "MươnSach";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.ImageIndex = 3;
            this.btnthoat.ImageList = this.imageList1;
            this.btnthoat.Location = new System.Drawing.Point(233, 162);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 23);
            this.btnthoat.TabIndex = 12;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnluu
            // 
            this.btnluu.ImageIndex = 1;
            this.btnluu.ImageList = this.imageList1;
            this.btnluu.Location = new System.Drawing.Point(135, 162);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(75, 23);
            this.btnluu.TabIndex = 11;
            this.btnluu.Text = "Lưu";
            this.btnluu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnmuon
            // 
            this.btnmuon.ImageIndex = 0;
            this.btnmuon.ImageList = this.imageList1;
            this.btnmuon.Location = new System.Drawing.Point(30, 162);
            this.btnmuon.Name = "btnmuon";
            this.btnmuon.Size = new System.Drawing.Size(75, 23);
            this.btnmuon.TabIndex = 10;
            this.btnmuon.Text = "Thêm";
            this.btnmuon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnmuon.UseVisualStyleBackColor = true;
            this.btnmuon.Click += new System.EventHandler(this.btnmuon_Click);
            // 
            // txtnv
            // 
            this.txtnv.Enabled = false;
            this.txtnv.Location = new System.Drawing.Point(233, 65);
            this.txtnv.Name = "txtnv";
            this.txtnv.Size = new System.Drawing.Size(36, 20);
            this.txtnv.TabIndex = 8;
            // 
            // txtdg
            // 
            this.txtdg.Enabled = false;
            this.txtdg.Location = new System.Drawing.Point(233, 31);
            this.txtdg.Name = "txtdg";
            this.txtdg.Size = new System.Drawing.Size(36, 20);
            this.txtdg.TabIndex = 7;
            // 
            // dtpngaymuon
            // 
            this.dtpngaymuon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpngaymuon.Location = new System.Drawing.Point(105, 97);
            this.dtpngaymuon.Name = "dtpngaymuon";
            this.dtpngaymuon.Size = new System.Drawing.Size(121, 20);
            this.dtpngaymuon.TabIndex = 4;
            // 
            // cbnhanvien
            // 
            this.cbnhanvien.FormattingEnabled = true;
            this.cbnhanvien.Location = new System.Drawing.Point(105, 65);
            this.cbnhanvien.Name = "cbnhanvien";
            this.cbnhanvien.Size = new System.Drawing.Size(121, 21);
            this.cbnhanvien.TabIndex = 3;
            // 
            // cbtendg
            // 
            this.cbtendg.FormattingEnabled = true;
            this.cbtendg.Location = new System.Drawing.Point(105, 31);
            this.cbtendg.Name = "cbtendg";
            this.cbtendg.Size = new System.Drawing.Size(121, 21);
            this.cbtendg.TabIndex = 2;
            // 
            // txtso
            // 
            this.txtso.Enabled = false;
            this.txtso.Location = new System.Drawing.Point(105, 5);
            this.txtso.Name = "txtso";
            this.txtso.Size = new System.Drawing.Size(121, 20);
            this.txtso.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày Mượn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên Nhân Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Độc Giả";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số Phiếu Mượn";
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
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 345);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form9";
            this.Load += new System.EventHandler(this.Form9_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpngaymuon;
        private System.Windows.Forms.ComboBox cbnhanvien;
        private System.Windows.Forms.ComboBox cbtendg;
        private System.Windows.Forms.TextBox txtso;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnmuon;
        private System.Windows.Forms.TextBox txtnv;
        private System.Windows.Forms.TextBox txtdg;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoPhieuMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayMuon;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnmuonsach;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnxoa2;
        private System.Windows.Forms.ImageList imageList1;
    }
}