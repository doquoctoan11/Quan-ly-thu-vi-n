using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DO_Quoc_Toan_MTA
{
    public partial class Form18 : Form
    {
        thuvienDataContext db = new thuvienDataContext();
        private Boolean timkiem = true;
        private Boolean Tra = false;
        public Form18()
        {
            InitializeComponent();
        }
        private void Form18_Load(object sender, EventArgs e)
        {
            dgv2.DataSource = db.XemTS();
          /*  txtsopm.DataBindings.Clear();
            txtsopm.DataBindings.Add("Text", dgv2.DataSource, "SoPhieuMuon");
            txtmasach2.DataBindings.Clear();
            txtmasach2.DataBindings.Add("Text", dgv2.DataSource, "MaSach");
            txtmanv.DataBindings.Clear();
            txtmanv.DataBindings.Add("Text", dgv2.DataSource, "MaNV");*/
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            try
            {
                if (timkiem == true)
                {
                    dgv1.DataSource = db.TimkiemSoPhieuMuon(Convert.ToInt32(txtmasach.Text));
                   
                    timkiem = true;



                }
            }
            catch
            {
                MessageBox.Show("không tìm thấy");
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btntra_Click(object sender, EventArgs e)
        {
            txtsopm.Text = "";
            txtmasach2.Text = "";
            txtmanv.Text = "";
            dtpngaytra.Text = "";
            txtsopm.Focus();
            Tra = true;
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if(Tra==true)
            {
                try
                {
                    dgv2.DataSource = db.ThemTraSach(Convert.ToInt32(txtsopm.Text), Convert.ToInt32(txtmasach2.Text), Convert.ToInt32(txtmanv.Text), dtpngaytra.Value);
                    Form18_Load(sender, e);
                    MessageBox.Show("Trả sách thành công");
                    Tra = false;
                }
                catch
                {
                    MessageBox.Show("Không trả sách được");
                }
            }
        }
    }
}
