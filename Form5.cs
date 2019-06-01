using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace DO_Quoc_Toan_MTA
{
    public partial class Form5 : Form
    {
        thuvienDataContext db = new thuvienDataContext();
        private Boolean them = false;
        public Form5()
        {
            InitializeComponent();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Form5_Load(object sender, EventArgs e)
        {
           cbnxb.DisplayMember = "TenNXB";
            cbnxb.ValueMember = "MaNXB";
            cbnxb.DataSource = db.XemNXB();
            cbnxb.DataBindings.Clear();
            cbnxb.DataBindings.Add("Text", cbnxb.DataSource, "TenNXB");
            txtnxb.DataBindings.Clear();
            txtnxb.DataBindings.Add("Text", cbnxb.DataSource, "MaNXB");
            cbloai.DisplayMember = "LoaiSach";
            cbloai.ValueMember = "MaLoaiSach";
            cbloai.DataSource = db.bangloaisach();
            cbloai.DataBindings.Clear();
            cbloai.DataBindings.Add("Text", cbloai.DataSource, "LoaiSach");
            txtloai.DataBindings.Clear();
            txtloai.DataBindings.Add("Text", cbloai.DataSource, "MaLoaiSach");

            dgvSach.DataSource = db.XemQS();
            txtma.DataBindings.Clear();
            txtma.DataBindings.Add("Text", dgvSach.DataSource, "MaSach");
            txtten.DataBindings.Clear();
            txtten.DataBindings.Add("Text", dgvSach.DataSource, "TenSach");
            txttacgia.DataBindings.Clear();
            txttacgia.DataBindings.Add("Text", dgvSach.DataSource, "TacGia");
          //  txtnam.DataBindings.Clear();
          //  txtnam.DataBindings.Add("Text", dgvSach.DataSource, "NamXB");
          //  txtsoluong.DataBindings.Clear();
          //  txtsoluong.DataBindings.Add("Text", dgvSach.DataSource, "SoLuong");
            
         
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            txtten.Text = "";
            txttacgia.Text = "";
            cbnxb.Text = "";
            cbloai.Text = "";
            txtnam.Text = "";
            txtsoluong.Text = "";
            txtnxb .Text= "";
            txtloai.Text = "";
            txtten.Focus();
            them = true;
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if(them==true)
            {
                try
                {
                    db.ThemSach(txtten.Text, txttacgia.Text, Convert.ToInt32(txtnxb.Text), Convert.ToInt32(txtloai.Text), Convert.ToInt32(txtnam.Text), Convert.ToInt32(txtsoluong.Text));

                    Form5_Load(sender, e);
                    MessageBox.Show("them ok");
                    
                    them = false;
                }
                catch
                {
                    MessageBox.Show("không thêm đc");
                }
            }
            else
            {
                try
                {
                   db.SuaSach1(Convert.ToInt32(txtma.Text),txtten.Text, txttacgia.Text, Convert.ToInt32(txtnxb.Text), Convert.ToInt32(txtloai.Text), Convert.ToInt32(txtnam.Text), Convert.ToInt32(txtsoluong.Text));
                    Form5_Load(sender, e);
                    MessageBox.Show("Sua Thành công");
                }
                catch
                {
                    MessageBox.Show("Không Sửa được");

                }
            }           
        }
       private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
               db.XoaSach1(Convert.ToInt32(txtma.Text));
                Form5_Load(sender, e);
                MessageBox.Show("Xóa thành công");

            }
            catch
            {
                MessageBox.Show("không xóa được");
            }
        }
    }
}
