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
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }
        thuvienDataContext db = new thuvienDataContext();
        Boolean tim = true;

        private void Form15_Load(object sender, EventArgs e)
        {
            txtmasach.Text = "";
            txtmasach.Focus();

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btntim_Click(object sender, EventArgs e)
        {
            if(tim==true)
            {
                try
                {
                    dgv2.DataSource = db.TimKiemSach(Convert.ToInt32(txtmasach.Text));
                    Form15_Load(sender, e);

                }
                catch
                {
                    MessageBox.Show("Không Tìm thấy");
                }
            }
        }
    }
}
