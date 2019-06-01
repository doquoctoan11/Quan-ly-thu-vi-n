using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DO_Quoc_Toan_MTA
{
    public partial class Form8 : Form
    {
        thuvienDataContext db = new thuvienDataContext();
        private Boolean TKPM = false;
        private Boolean TKDG = false;
        public Form8()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            TKPM = true;
            if(TKPM==true)
            {
                try
                {
                    dgvPM.DataSource=db.TimKiemPM(Convert.ToInt32(txtmapm.Text));

                    dgvCTPM.DataSource = db.TimKiemHanTra(Convert.ToInt32(txtmapm.Text));
                }
                catch
                {
                    MessageBox.Show("Không có");
                }
            }
           /* else
            {
                MessageBox.Show("không có");*/
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            TKDG = true;
            if(TKDG==true)
            {
                try
                {
                    dgvDG.DataSource = db.TimKiemDG(Convert.ToInt32(txtmadg.Text));
                }
                catch
                {
                    MessageBox.Show("không có");
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form frm = new Form9();
            frm.Text = "Danh Mục Mượn Sách";
            frm.ShowDialog();
        }
    }
}
