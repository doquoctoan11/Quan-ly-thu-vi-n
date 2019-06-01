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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }
        thuvienDataContext db = new thuvienDataContext();
        Boolean tim = true;

        private void Form14_Load(object sender, EventArgs e)
        {
            txtmadg.Text = "";
            txtmadg.Focus();
            
        }

        private void btntim_Click(object sender, EventArgs e)
        {
            if(tim==true)
            {
                try
                {
                    dgv1.DataSource = db.TimKiemDocGia(Convert.ToInt32(txtmadg.Text));
                    Form14_Load(sender, e);

                }
                catch
                {
                    MessageBox.Show("không tìm thấy");
                }
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
