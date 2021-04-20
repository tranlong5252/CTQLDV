using ClosedXML.Excel;
using System;
using System.Data;
using System.Drawing;
using System.IO;
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
            panel1.Left = this.Width / 2 - panel1.Width / 2;
        }

        private void XuatDuLieu()
        {
            string sql = "";
            sql += " select *";
            sql += "from HO_SO";
            DataTable dt = DataProviderSQL.Doc(sql);
            dataDoanVien.DataSource = dt;
            dataDoanVien.Tag = dt;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dataDoanVien.Rows[i].Cells["STT"].Value = (i + 1);
            }
        }
        private void NhapDuLieu()
        {
            DataRow row = DataProviderSQL.Dong_moi("HO_SO");
            row["HO_TEN"] = txtname.Text;
            row["LOP"] = txtlop.Text;
            if (chknam.Checked == true)
            { row["GIOI_TINH"] = 1; }
            if (chknu.Checked == true)
            { row["GIOI_TINH"] = 0; }
            row["DIEN_THOAI"] = txtphone.Text;
            row["NGAY_SINH"] = txtngaysinh.Value;
            row["TRUONG"] = txtschool.Text;
            row["CHUC_VU"] = txtperm.Text;
            row["MO_TA"] = txtmota.Text;
            row["ADDRESS"] = txtAddress.Text;
            row["JOINED"] = txtJoin.Value;
            
            row["CARDNUM"] = txtCardNum.Text;


            if (txtBrowseimg.Text != "")
            {
                string a = txtBrowseimg.Text;
                byte[] data = converImgToByte(a);
                row["HINH"] = data;
            }
            DataProviderSQL.Ghi(row, "HO_SO");
            MessageBox.Show("Đã lưu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            XuatDuLieu();
        }

        private byte[] converImgToByte(string path)
        {
            FileStream fs;
            fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            byte[] picbyte = new byte[fs.Length];
            fs.Read(picbyte, 0, System.Convert.ToInt32(fs.Length));
            fs.Close();
            return picbyte;
        }

        private void CapNhatDuLieu()
        {
            string sql = " select * from HO_SO where id = " + txtID.Text + "";
            DataRow row = DataProviderSQL.Doc_Dong(sql);
            row["HO_TEN"] = txtname.Text;
            row["LOP"] = txtlop.Text;
            if (chknam.Checked == true)
            { row["GIOI_TINH"] = 1; }
            if (chknu.Checked == true)
            { row["GIOI_TINH"] = 0; }
            row["DIEN_THOAI"] = txtphone.Text;
            row["NGAY_SINH"] = txtngaysinh.Value;
            row["TRUONG"] = txtschool.Text;
            row["CHUC_VU"] = txtperm.Text;
            row["ADDRESS"] = txtAddress.Text;
            row["JOINED"] = txtJoin.Value;
            row["MO_TA"] = txtmota.Text;
            row["CARDNUM"] = txtCardNum.Text;


            if (txtBrowseimg.Text != "")
            {
                string a = txtBrowseimg.Text;
                byte[] data = converImgToByte(a);
                row["HINH"] = data;
            }
            DataProviderSQL.Ghi(row, "HO_SO");
            MessageBox.Show("Đã lưu!         ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            XuatDuLieu();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            XuatDuLieu();
            btnadd.Enabled = true;
        }

        private void dataDoanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnedit.Enabled = true;
            btndelete.Enabled = true;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataDoanVien.Rows[e.RowIndex];
                txtname.Text = row.Cells["HO_TEN"].Value.ToString();
                txtlop.Text = row.Cells["LOP"].Value.ToString();
                txtphone.Text = row.Cells["DIEN_THOAI"].Value.ToString();
                txtschool.Text = row.Cells["TRUONG"].Value.ToString();
                txtJoin.Text = row.Cells["JOINED"].Value.ToString();
                txtAddress.Text = row.Cells["ADDRESS"].Value.ToString();
                txtperm.Text = row.Cells["CHUC_VU"].Value.ToString();
                txtngaysinh.Text = row.Cells["NGAY_SINH"].Value.ToString();
                txtmota.Text = row.Cells["MO_TA"].Value.ToString();
                txtCardNum.Text = row.Cells["CARDNUM"].Value.ToString();
                string nam = row.Cells["GIOI_TINH"].Value.ToString();
                if (nam == "True")
                {
                    chknam.Checked = true;
                }
                else
                {
                    chknu.Checked = true;
                }

                txtID.Text = row.Cells["ID"].Value.ToString();
                if (row.Cells["HINH"].Value.ToString() != "")
                {
                    byte[] bytes = (byte[])row.Cells["HINH"].Value;
                    pictureDV.Image = ByteToImage(bytes);
                }
                else
                {
                    pictureDV.Image = null;
                }

            }
        }
        public static Bitmap ByteToImage(byte[] blob)
        {
            MemoryStream mStream = new MemoryStream();
            byte[] pData = blob;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            txtname.Text = "";
            txtlop.Text = "";
            txtphone.Text = "";
            txtschool.Text = "";
            txtperm.Text = "";
            txtngaysinh.Text = "";
            txtmota.Text = "";
            btnedit.Enabled = false;
            btndelete.Enabled = false;
            txtID.Text = "";
            txtJoin.Text = "";
            txtAddress.Text = "";
            txtCardNum.Text = "";
            pictureDV.Image = null;
            btnsave.Enabled = true;
            btncancel.Enabled = true;
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            btnadd.Enabled = false;
            btnsave.Enabled = true;
            btncancel.Enabled = true;
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            btnedit.Enabled = true;
            btndelete.Enabled = default;
            btnadd.Enabled = true;
            btnsave.Enabled = default;
            btncancel.Enabled = default;
        }
        private void Delete()
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Không có dữ liệu để xóa!         ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                DialogResult traloi;
                traloi = MessageBox.Show("Bạn chắc chắn muốn xóa?         ", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (traloi == DialogResult.OK)
                {
                    for (int i = 0; i < dataDoanVien.Rows.Count; i++)
                    {
                        if (dataDoanVien.Rows[i].Cells["CHON"].Value != null)
                        {
                            string id = "";
                            id = dataDoanVien.Rows[i].Cells["ID"].Value.ToString();
                            string sql = " select * from HO_SO where id = " + id + "";
                            DataRow row = DataProviderSQL.Doc_Dong(sql);
                            DataProviderSQL.Xoa(row);
                        }
                    
                    }
                    DialogResult dialogResult = MessageBox.Show("Đã xóa!         ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    XuatDuLieu();
                }
            }
        }
        private void btndelete_Click(object sender, EventArgs e)
            {
            Delete();
        }
                private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                if (txtname.Text == "" || txtAddress.Text == "" || txtphone.Text == ""
                    || txtschool.Text == "" || txtperm.Text == "" || txtlop.Text == "" || txtCardNum.Text == "")// tuong tự như vậy với các textbox còn lại
                {
                    MessageBox.Show("Bạn chưa nhập dữ liệu nào!         ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                NhapDuLieu();
            }
            else
            {
                if (txtname.Text == "" || txtAddress.Text == "" || txtphone.Text == ""
                    || txtschool.Text == ""||txtperm.Text==""||txtlop.Text==""||txtCardNum.Text=="")// tuong tự như vậy với các textbox còn lại

                {
                    MessageBox.Show("Bạn chưa nhập dữ liệu nào!         ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                CapNhatDuLieu();
            }
            btnsave.Enabled = default;
            btncancel.Enabled = default;
        }
     
        private void DuyetAnh()
        {
            string duong_dan = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            string folderPath = duong_dan;
            OpenFileDialog openFileDialog2 = new OpenFileDialog();
            openFileDialog2.InitialDirectory = folderPath;
            openFileDialog2.Title = "Browse Text Files";
            openFileDialog2.CheckFileExists = true;
            openFileDialog2.CheckPathExists = true;
            openFileDialog2.DefaultExt = "jpg";
            openFileDialog2.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            openFileDialog2.FilterIndex = 2;
            openFileDialog2.RestoreDirectory = true;
            openFileDialog2.ReadOnlyChecked = true;
            openFileDialog2.ShowReadOnly = true;
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                txtBrowseimg.Text = openFileDialog2.FileName;

                // string filepath = null;
                // OpenFileDialog ofdImages = new OpenFileDialog();
                // PictureBox objpt = new PictureBox();
                // if (ofdImages.ShowDialog() == DialogResult.OK)
                //  {
                //       filepath = ofdImages.FileName;
                //  }

                pictureDV.Image = Image.FromFile(txtBrowseimg.Text.ToString());
                // pictureDV.SizeMode = PictureBoxSizeMode.AutoSize;
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            DuyetAnh();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Tác giả: Phạm Trần Bạch Long\nHướng dẫn: Hồ Thị Xuân Định\nĐược tạo vào 02/2021", "Giới thiệu");
        }

        private void txtfilter_TextChanged(object sender, EventArgs e)
        {
            DataTable bang = (DataTable)dataDoanVien.Tag;
            string stringExpression = "HO_TEN like '%" + txtfilter.Text.ToUpper() + "%'";

            DataRow[] rows = bang.Select(stringExpression);
            DataTable filterData = new DataTable();
            if (rows.Length != 0)
            {
                filterData = rows.CopyToDataTable();
                dataDoanVien.DataSource = filterData;
                for (int i = 0; i < dataDoanVien.Rows.Count; i++)
                {
                    dataDoanVien.Rows[i].Cells["STT"].Value = i + 1;
                }
            }
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            
                DataTable bang = new DataTable();
                bang = (DataTable)dataDoanVien.Tag;
                // get path to save file
                string fn = DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() + "_" + "DuLieuDoanVien"; //this combobox is my report name
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Title = "Xuất Excel";
                sfd.FileName = fn.Replace("/", "-").Replace(" ", "_");
                sfd.Filter = "(*.xlsx)|*.xlsx";
                sfd.RestoreDirectory = true;
           //     sfd.ShowDialog();

          
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string path = sfd.FileName;
                    using (XLWorkbook wb = new XLWorkbook())
                    {

                        wb.Worksheets.Add(bang, "Sheet1");
                        wb.Worksheet(1).Columns().AdjustToContents();
                        wb.SaveAs(path);
                        DialogResult traloi = MessageBox.Show("Đã xuất Excel:\n" + path + "\nBạn có muốn mở không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                        if (traloi == DialogResult.Yes)
                        {
                            System.Diagnostics.Process.Start(path);
                        }
                    }
                }
                
            }
        }

    }
}
