namespace DO_Quoc_Toan_MTA
{
    partial class Form14
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form14));
            this.btntim = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmadg = new System.Windows.Forms.TextBox();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.btnthoat = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // btntim
            // 
            this.btntim.ImageIndex = 1;
            this.btntim.ImageList = this.imageList1;
            this.btntim.Location = new System.Drawing.Point(318, 28);
            this.btntim.Name = "btntim";
            this.btntim.Size = new System.Drawing.Size(75, 23);
            this.btntim.TabIndex = 0;
            this.btntim.Text = "Tìm";
            this.btntim.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btntim.UseVisualStyleBackColor = true;
            this.btntim.Click += new System.EventHandler(this.btntim_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Độc Giả";
            // 
            // txtmadg
            // 
            this.txtmadg.Location = new System.Drawing.Point(192, 30);
            this.txtmadg.Name = "txtmadg";
            this.txtmadg.Size = new System.Drawing.Size(100, 20);
            this.txtmadg.TabIndex = 2;
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(91, 87);
            this.dgv1.Name = "dgv1";
            this.dgv1.Size = new System.Drawing.Size(368, 150);
            this.dgv1.TabIndex = 3;
            // 
            // btnthoat
            // 
            this.btnthoat.ImageIndex = 0;
            this.btnthoat.ImageList = this.imageList1;
            this.btnthoat.Location = new System.Drawing.Point(452, 27);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 23);
            this.btnthoat.TabIndex = 4;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Thoát.png");
            this.imageList1.Images.SetKeyName(1, "Tìm Kiếm.png");
            // 
            // Form14
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 261);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.txtmadg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btntim);
            this.Name = "Form14";
            this.Text = "Form14";
            this.Load += new System.EventHandler(this.Form14_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btntim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmadg;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.ImageList imageList1;
    }
}