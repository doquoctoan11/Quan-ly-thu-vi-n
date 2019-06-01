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
    public partial class Form13 : Form
    {
        thuvienDataContext db = new thuvienDataContext();
        public Form13()
        {
            InitializeComponent();
        }
        private void rdo1_CheckedChanged(object sender, EventArgs e)
        {
            dgv.DataSource = db.SoSachdangmuon();
        }

        private void rdo2_CheckedChanged(object sender, EventArgs e)
        {
            dgv.DataSource = db.SoSachDaTra();
        }

        private void rdo3_CheckedChanged(object sender, EventArgs e)
        {
            dgv.DataSource = db.SoSachTraMuon();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
