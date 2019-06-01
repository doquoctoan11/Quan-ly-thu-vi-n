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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }
        thuvienDataContext db = new thuvienDataContext();
        Boolean tra = false;
        private void Form11_Load(object sender, EventArgs e)
        {
           

        }

        private void btntra_Click(object sender, EventArgs e)
        {
            txtmasach.Enabled = true;
            txtmasach.Text = "";
            txtmasach.Focus();
             tra = true;
            
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if(tra==true)
            {
                dgvtra.DataSource = db.TraSach1(Convert.ToInt32(txtmasach.Text));
                txtmasach.DataBindings.Clear();
                txtmasach.DataBindings.Add("Text", dgvtra.DataSource, "MaSach");
                Form11_Load(sender, e);
                tra = false;
            }
        }

        private void txtmasach_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
         //   DialogResult lenh = MessageBox.Show("Bạn có chắc chắn muốn trả hay không", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
          //  if (lenh == DialogResult.Yes)
           // {
               // try
               // {
                    //  db.Tra(Convert.ToInt32(txtmasach.Text));
                    //int CurrentIndex = dgvtra.CurrentCell.RowIndex;
                    //string Masv = Convert.ToString(dgvtra.Rows[CurrentIndex].Cells[0].Value.ToString());
                    //   db.Tra(Convert.ToUInt32(dgvtra.CurrentCell.RowIndex);

                    Form frm = new Form18();
                    frm.Text = "Trả Sách";
                    frm.ShowDialog();

               // }
               // catch
              //  {
                 //   MessageBox.Show("Bạn  không trả được", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               // }
           // }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
