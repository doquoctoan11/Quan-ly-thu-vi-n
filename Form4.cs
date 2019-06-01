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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        thuvienDataContext db = new thuvienDataContext();
        Boolean them = false;
       
        private void Form4_Load(object sender, EventArgs e)
        {
            dgvDG.DataSource = db.XemDG();
            txtma.DataBindings.Clear();
            txtma.DataBindings.Add("Text", dgvDG.DataSource, "MaDG");
            txtten.DataBindings.Clear();
            txtten.DataBindings.Add("Text", dgvDG.DataSource, "TenDG");
            txtdiachi.DataBindings.Clear();
            txtdiachi.DataBindings.Add("Text", dgvDG.DataSource, "DiaChi");
          //  dtpngaysinh.DataBindings.Clear();
          //  dtpngaysinh.DataBindings.Add("Text", dgvDG.DataSource, "NgaySinh");
            txtemail.DataBindings.Clear();
            txtemail.DataBindings.Add("Text", dgvDG.DataSource, "Email");
            cbgioitinh.DataBindings.Clear();
            cbgioitinh.DataBindings.Add("Text", dgvDG.DataSource, "GioiTinh");
          //  dtphan.DataBindings.Clear();
           // dtphan.DataBindings.Add("Text", dgvDG.DataSource, "HanSuDung");
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            txtma.Text = "";
            txtten.Text = "";
            txtdiachi.Text = "";
            dtpngaysinh.Text = "";
            txtemail.Text = "";
            cbgioitinh.Text = "";
            dtphan.Text = "";
            txtten.Focus();
            them = true;

        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (them == true)
            {
                try
                {
                    db.ThemDG(txtten.Text, txtdiachi.Text, dtpngaysinh.Value, txtemail.Text, cbgioitinh.Text, dtphan.Value);
                    Form4_Load(sender, e);         
                    them = false;
                    MessageBox.Show("Thêm thành công");
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
                    db.SuaDG1(Convert.ToInt32(txtma.Text), txtten.Text, txtdiachi.Text, dtpngaysinh.Value, txtemail.Text, cbgioitinh.Text, dtphan.Value);
                    Form4_Load(sender, e);
                    MessageBox.Show("sửa thành công");
                }
                catch
                {
                    MessageBox.Show("không sửa được");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                db.XoaDG(Convert.ToInt32(txtma.Text));
                Form4_Load(sender, e);
                MessageBox.Show("Xóa thành công");
            }
            catch
            {
                MessageBox.Show("Không  xóa được");
            }
        }

        private void dtpngaysinh_ValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
