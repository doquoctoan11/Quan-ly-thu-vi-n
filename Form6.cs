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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        thuvienDataContext db = new thuvienDataContext();
        Boolean them = false;
        private void Form6_Load(object sender, EventArgs e)
        {
            dgvNXB.DataSource = db.XemNXB();
            txtma.DataBindings.Clear();
            txtma.DataBindings.Add("Text", dgvNXB.DataSource, "MaNXB");
            txtten.DataBindings.Clear();
            txtten.DataBindings.Add("Text", dgvNXB.DataSource, "TenNXB");
            txtdiachi.DataBindings.Clear();
            txtdiachi.DataBindings.Add("Text", dgvNXB.DataSource, "DiaChi");
                
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            txtma.Text = "";
            txtten.Text = "";
            txtdiachi.Text = "";
            txtten.Focus();
            them = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(them==true)
            {
                try
                {
                    db.ThemNXB(txtten.Text, txtdiachi.Text);
                    Form6_Load(sender, e);
                    MessageBox.Show("Thêm thành công");
                    them = false;
                    
                }
                catch
                {
                    MessageBox.Show("không thêm được");
                }
            }
            else
            {
                try
                {
                    db.SuaNXB(Convert.ToInt32(txtma.Text), txtten.Text, txtdiachi.Text);
                    Form6_Load(sender, e);
                    MessageBox.Show("sua thành công");
                }
                catch
                {
                    MessageBox.Show("không sưa được");
                }
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                db.XoaNXB(Convert.ToInt32(txtma.Text));
                Form6_Load(sender, e);
                MessageBox.Show("Xóa Thành công");
            }
            catch
            {
                MessageBox.Show("không xóa được");
            }

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
