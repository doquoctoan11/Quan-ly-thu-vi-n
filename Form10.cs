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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }
        thuvienDataContext db = new thuvienDataContext();
        Boolean them = false;

        private void Form10_Load(object sender, EventArgs e)
        {
            cbso.DisplayMember = "MaDG";
            cbso.ValueMember = "SoPhieuMuon";
            cbso.DataSource = db.XemMS();
            cbso.DataBindings.Clear();
            cbso.DataBindings.Add("Text", cbso.DataSource, "SoPhieuMuon");
            cbtensach.DisplayMember = "TenSach";
            cbtensach.ValueMember = "MaSach";
            cbtensach.DataSource = db.XemQS();
            cbtensach.DataBindings.Clear();
            cbtensach.DataBindings.Add("Text", cbtensach.DataSource, "TenSach");
            txttensach.DataBindings.Clear();
            txttensach.DataBindings.Add("Text", cbtensach.DataSource, "MaSach");
            dgvctpm.DataSource = db.XemCTPM();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            cbso.Text = "";
            txttensach.Text = "";
            dtphantra.Text = "";
            cbso.Focus();
            them = true;
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if(them==true)
            {
                try
                {
                    db.ThemCTMUONsach1(Convert.ToInt32(cbso.Text), Convert.ToInt32(txttensach.Text), dtphantra.Value);
                    Form10_Load(sender, e);
                    MessageBox.Show("Thêm thành công");
                    them = false;
                }
                catch
                {
                    MessageBox.Show("Thêm Không thành công");

                }
                        
            }
            else
            {
                try
                {
                    db.SuaCTMUONsach1(Convert.ToInt32(cbso.Text), Convert.ToInt32(txttensach.Text), dtphantra.Value);
                    Form10_Load(sender, e);
                    MessageBox.Show("Sửa thành công");
                    them = false;
                }
                catch
                {
                    MessageBox.Show("Sửa Không thành công");

                }
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                db.XoaCTMUONsach1(Convert.ToInt32(cbso.Text));
                Form10_Load(sender, e);
                MessageBox.Show("Xóa thành công");
                them = false;
            }
            catch
            {
                MessageBox.Show("Xóa Không thành công");

            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
