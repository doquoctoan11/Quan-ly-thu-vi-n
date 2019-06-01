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
    public partial class Form17 : Form
    {
        thuvienDataContext db = new thuvienDataContext();
        private Boolean timkiem = true;
        public Form17()
        {
            InitializeComponent();
        }
        private void Form17_Load(object sender, EventArgs e)
        {
            
            dgv2.DataSource = db.XemMS();
            txtsophieumuon.DataBindings.Clear();
            txtsophieumuon.DataBindings.Add("Text", dgv2.DataSource, "SoPhieuMuon");
            txtmadg.DataBindings.Clear();
            txtmadg.DataBindings.Add("Text", dgv2.DataSource, "MaDG");
            txtmanv.DataBindings.Clear();
            txtmanv.DataBindings.Add("Text", dgv2.DataSource, "MaNV");
            dtpngaynuon.DataBindings.Clear();
            dtpngaynuon.DataBindings.Add("Text", dgv2.DataSource, "NgayMuon");
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            try
            {
                if (timkiem == true)
                {
                    dgv1.DataSource = db.TimkiemSoPhieuMuon(Convert.ToInt32(txtmasach.Text));
                //    Form17_Load(sender, e);
                    timkiem = true;



                }
            }
            catch
            {
                MessageBox.Show("không tìm thấy");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //DialogResult traloi = MessageBox.Show("Bạn Muốn trả không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
          //  if(traloi==DialogResult.Yes)
          //  {
                try
                {
                    dgv2.DataSource = db.XoaDGmuonsach1(Convert.ToInt32(txtsophieumuon.Text));
                    MessageBox.Show("Bạn đã trả thành công");
                    Form17_Load(sender, e);
                }
                catch
                {
                    MessageBox.Show("Bạn không trả được");
                }
           // }
        }
    }
}
