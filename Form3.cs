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
    public partial class Form3 : Form
    {
        thuvienDataContext db = new thuvienDataContext();
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            try
            {
                int intDM = Convert.ToInt32(this.Text);
                switch(intDM)
                {
                    case 1:
                        lblDanhMuc.Text = "Loại Sách";
                        dgv.DataSource = db.bangloaisach();
                        break;
                    case 2:
                        lblDanhMuc.Text = "Nhân Viên";
                        dgv.DataSource = db.XemNV();
                        break;
                    case 3:
                        lblDanhMuc.Text = "Nhà Xuất Bản";
                        dgv.DataSource = db.XemNXB();
                        break;
                    case 4:
                        lblDanhMuc.Text = "Quyển Sách";
                        dgv.DataSource = db.XemQS();
                        break;
                    case 5:
                        lblDanhMuc.Text = "Độc Giả";
                        dgv.DataSource = db.XemDG();
                        break;
                    case 6:
                        lblDanhMuc.Text = "Mượn sách";
                        dgv.DataSource = db.XemMS();
                        break;
                    case 7:
                        lblDanhMuc.Text = "Chi Tiết Phiếu Mượn";
                        dgv.DataSource = db.XemCTPM();
                        break;
                    case 8:
                        lblDanhMuc.Text = "Trả sách";
                        dgv.DataSource = db.XemTS();
                        break;
                    case 9:
                        lblDanhMuc.Text = "Phạt";
                        dgv.DataSource = db.XemPhat();
                        break;

                }
            }
            catch
            {
                MessageBox.Show("Lỗi rồi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
