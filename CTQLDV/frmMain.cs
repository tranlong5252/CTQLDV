using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CTQLDV
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

 

        private void frmMain_Load(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Maximized;
            panel1.Left = this.Width / 2 - panel1.Width / 2;
           

        }

        private void XuatDuLieu()
        {
            string sql = "";
            sql += " select *";
            sql += "from HO_SO";
            DataTable dt = DataProviderSQL.Doc(sql);
            dataDoanVien.DataSource = dt;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dataDoanVien.Rows[i].Cells[0].Value = (i + 1);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            XuatDuLieu();
        }

    }
}
