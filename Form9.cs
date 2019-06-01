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
    public partial class Form9 : Form
    {
        thuvienDataContext db = new thuvienDataContext();
        private Boolean muon = false;
        public Form9()
        {
            InitializeComponent();
        }
        private void Form9_Load(object sender, EventArgs e)
        {
            cbtendg.DisplayMember = "TenDG";
            cbtendg.ValueMember = "MaDG";
            cbtendg.DataSource = db.XemDG();
            cbtendg.DataBindings.Clear();
            cbtendg.DataBindings.Add("Text", cbtendg.DataSource, "TenDG");
            txtdg.DataBindings.Clear();
            txtdg.DataBindings.Add("Text", cbtendg.DataSource, "MaDG");

            cbnhanvien.DisplayMember = "Hoten";
            cbnhanvien.ValueMember = "MaNV";
            cbnhanvien.DataSource = db.XemNV();
            cbnhanvien.DataBindings.Clear();
            cbnhanvien.DataBindings.Add("Text", cbnhanvien.DataSource, "HoTen");
            txtnv.DataBindings.Clear();
            txtnv.DataBindings.Add("Text", cbnhanvien.DataSource, "MaNV");

           /* cbtensach.DisplayMember = "TenSach";
            cbtensach.ValueMember = "MaSach";
            cbtensach.DataSource = db.XemQS();
            cbtensach.DataBindings.Clear();
            cbtensach.DataBindings.Add("Text", cbtensach.DataSource, "TenSach");
            txtsach.DataBindings.Clear();
            txtsach.DataBindings.Add("Text", cbtensach.DataSource, "MaSach");*/
           dgv1.DataSource = db.XemMS();

            txtso.DataBindings.Clear();
            txtso.DataBindings.Add("Text", dgv1.DataSource, "SoPhieuMuon");
          //  dgv2.DataSource = db.XemCTPM();

        }

        private void btnmuon_Click(object sender, EventArgs e)
        {
            txtso.Text = "";
            txtdg.Text = "";
            txtnv.Text = "";
            dtpngaymuon.Text = "";
       //    txtsach.Text = "";
       //    dtpngaytra.Text = "";
            muon = true;
        //    muon1 = true;
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (muon == true)
            {
                try
                {
                   dgv1.DataSource=  db.ThemMuonSach(Convert.ToInt32(txtdg.Text), Convert.ToInt32(txtnv.Text), dtpngaymuon.Value);

                    Form9_Load(sender, e);
                    MessageBox.Show("Thêm Thành công");
                    muon = false;
                }
                catch
                {
                    MessageBox.Show("Không thêm được");
                }
            }
            else
            {
                try
                {
                    dgv1.DataSource = db.SuaMuonSach(Convert.ToInt32(txtso.Text),Convert.ToInt32(txtdg.Text), Convert.ToInt32(txtnv.Text), dtpngaymuon.Value);

                    Form9_Load(sender, e);
                    MessageBox.Show("Sửa Thành công");
                    muon = false;
                }
                catch
                {
                    MessageBox.Show(" Sửa Không được");
                }
            }
        }
       //    private void btnmuonsach_Click(object sender, EventArgs e)
            //{
               /* if (muon1 == true)
                    try
                    {


                        dgv2.DataSource = db.ThemCTMUONsach1(Convert.ToInt32(txtso.Text),Convert.ToInt32(txtsach.Text), dtpngaytra.Value);
                        Form9_Load(sender, e);
                        MessageBox.Show("Mượn Thành công thành ");
                        muon1 = false;
                    }
                    catch
                    {
                        MessageBox.Show("Mượn Không thành công");
                    }*/
        //  }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frm = new Form10();
            frm.Text = "Mượn thêm sách";
            frm.ShowDialog();
        }

        private void btnxoa2_Click(object sender, EventArgs e)
        {
            try
            {
                dgv1.DataSource = db.XoaMuonSach(Convert.ToInt32(txtso.Text));

                Form9_Load(sender, e);
                MessageBox.Show("Xóa Thành công");
                muon = false;
            }
            catch
            {
                MessageBox.Show("Không xóa được");
            }
        }
    }
}
