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
    public partial class Form12 : Form
    {
        thuvienDataContext db = new thuvienDataContext();
        public Form12()
        {
            InitializeComponent();
        }
        
        private void Form12_Load(object sender, EventArgs e)
        {
            dgv.DataSource = db.XemQS();
            txttra.DataBindings.Clear();
            txttra.DataBindings.Add("Text", dgv.DataSource, "MaSach");
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
           
            //txttra.Text = "";
           // txttra.Focus();
            
        }

        private void btnluu_Click(object sender, EventArgs e)
        {    
                try
                {
                    db.XoaSach1(Convert.ToInt32(txttra.Text));
                    Form12_Load(sender, e);
                    MessageBox.Show("Bạn đã trả xong", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Bạn  không trả được", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            
        }
    }
}
