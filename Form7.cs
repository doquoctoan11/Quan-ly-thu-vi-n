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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        thuvienDataContext db = new thuvienDataContext();
        Boolean them = false;
        private void Form7_Load(object sender, EventArgs e)
        {
            dgvtheloai.DataSource = db.bangloaisach();
            txtma.DataBindings.Clear();
            txtma.DataBindings.Add("Text", dgvtheloai.DataSource, "MaLoaiSach");
            txtloai.DataBindings.Clear();
            txtloai.DataBindings.Add("Text", dgvtheloai.DataSource, "LoaiSach");
            


        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            txtma.Text = "";
            txtloai.Text = "";
            txtloai.Focus();
            them = true;
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if(them==true)
            {
                try
                {
                    db.ThemLoaiSach1(txtloai.Text);
                    Form7_Load(sender, e);
                    MessageBox.Show("Thêm thành công");
                    them = false;
                }
                catch
                {
                    MessageBox.Show("Không Thêm được");
                }
            }
            else
            {
                try
                {
                    db.SuaLoaiSach1(Convert.ToInt32(txtma.Text), txtloai.Text);
                    Form7_Load(sender, e);
                    MessageBox.Show("Sửa Thành công");
                }
                catch
                {
                    MessageBox.Show("không sửa được");
                }
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                db.XoaLoaiSach(Convert.ToInt32(txtma.Text));
                Form7_Load(sender, e);
                MessageBox.Show("Xóa Thành công");
            }
            catch
            {
                MessageBox.Show("Không xóa được");
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
