using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;
using System.Data.Sql;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;
//using DevExpress.XtraEditors;

namespace CTQLDV
{
    public class DataProviderSQL
    {

        public static string duongDan = System.IO.Directory.GetCurrentDirectory();
        //public static String ChuoiKetNoi = @" Data Source=.\SQLEXPRESS;AttachDbFilename=" + duongDan + "\\QLCV.mdf;Integrated Security=True;User Instance=True";
         public static String ChuoiKetNoi = @" Data Source=DELL5548\SQLEXPRESS;Initial Catalog=QLDoanVien;Integrated Security=True";
        #region "DOC - GHI"
        public static DataTable Doc(String ChuoiLenh)
        {
            DataTable Kq = new DataTable() ;
            if (!ChuoiLenh.ToUpper().Contains("SELECT"))
            {
                ChuoiLenh = "select * from " + ChuoiLenh; 
            }
            // 
            try
            {
                                   
                SqlDataAdapter BoThichUng = new SqlDataAdapter(ChuoiLenh, ChuoiKetNoi);
                BoThichUng.FillSchema(Kq, SchemaType.Source);
                BoThichUng.Fill(Kq);
            }
            catch(Exception Loi)
            {
                String TB = "Lỗi truy xuất CSDL \n";
                //TB += "Chuỗi lệnh :" + ChuoiLenh + "\n";
                TB += "Lỗi :" + Loi.Message  + "\n";
                MessageBox.Show(TB);
            }
            return Kq;

        }
        public static DataRow Doc_Dong(string Chuoi_lenh)
        {
            DataRow Kq = null;
            DataTable Bang = Doc(Chuoi_lenh);
            if (Bang.Rows.Count > 0)
            {
                Kq = Bang.Rows[0];
            }
            return Kq;
        }

        public static DataTable DocProc(String TenProc, String Ten)
        {
            DataTable Kq = new DataTable();
            SqlConnection conn = new SqlConnection(ChuoiKetNoi);
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                cmd = new SqlCommand(TenProc, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@tentk", SqlDbType.NVarChar));
                cmd.Parameters["@tentk"].Value = Ten;
                da.SelectCommand = cmd;
                da.Fill(dt);


            }
            catch (Exception Loi)
            {
                String TB = "Lỗi truy xuất CSDL \n";
                TB += "Lỗi :" + Loi.Message + "\n";
                MessageBox.Show(TB);
            }
            return dt;

        }
   
        public static int GhiBang(DataTable Bang, String TenBang="") 
        {
            int kq = 0;
            if (TenBang == "") TenBang = Bang.TableName;
            String ChuoiLenh = "Select * from " + TenBang;
            try
            {
                SqlDataAdapter BoThichUng = new SqlDataAdapter(ChuoiLenh, ChuoiKetNoi);
                SqlCommandBuilder BoPhatSinhLenh = new SqlCommandBuilder(BoThichUng);
                
                //AddHandler Bo_thich_ung.RowUpdated, AddressOf Cap_nhat_ma_so
                kq = BoThichUng.Update(Bang);
            }
            catch(Exception Loi)
            {
                String TB = "Lỗi truy xuất CSDL \n";
                TB += "Chuỗi lệnh :" + ChuoiLenh + "\n";
                TB += "Lỗi :" + Loi.Message + "\n";
                MessageBox.Show(TB);
            }

            return kq;
        }
        public static void BulkInsertDataTable(string tableName,DataTable dataTable)//(string tableName, DataTable dataTable)
        {

            using (SqlConnection dbConnection = new SqlConnection(ChuoiKetNoi))
            {
                dbConnection.Open();
                using (SqlBulkCopy s = new SqlBulkCopy(dbConnection))
                {
                    s.DestinationTableName = tableName;
                    foreach (var column in dataTable.Columns)
                        s.ColumnMappings.Add(column.ToString(), column.ToString());
                    s.WriteToServer(dataTable);
                }
            }

        }
        #endregion
  
        public static bool KiemTraTenCot(String TenBang, String TenCot)
        {
            bool kq = false;
            DataTable bang = DataProviderSQL.Doc(TenBang);
            int socot = bang.Columns.Count;
            for (int i = 0; i < socot; i++)
            {
                if (TenCot.ToUpper() == bang.Columns[i].ColumnName.ToUpper())
                {
                    return true;
                }
            }
                return kq;
        }
#region "XUAT"

        //public static void XuatLenComboBoxDev(DataTable Bang, DevExpress.XtraEditors.LookUpEdit TenComboBox, String TenCotTheHien, String TenCotMa)
        //{


        //    TenComboBox.Properties.DataSource = Bang;
        //    TenComboBox.Properties.DisplayMember = TenCotTheHien;
        //    TenComboBox.Properties.ValueMember = TenCotMa;
        //    TenComboBox.Properties.Columns.Add( new DevExpress.XtraEditors.Controls.LookUpColumnInfo(TenCotTheHien));
        //    TenComboBox.Properties.ShowHeader = false;
        //    TenComboBox.Properties.ShowFooter = false;
           
        //    //TenComboBox.Properties.Columns.Add(
        //    //TenComboBox.Properties.co
        //    //TenComboBox.Properties.Columns.Add(TenComboBox.Properties.Columns[1]);
        //}

        public static void XuatLenComboBox(DataTable Bang, ComboBox TenComboBox, String TenCotTheHien, String TenCotMa)
        {
            TenComboBox.DataSource = Bang;
            if (TenCotTheHien == "")
            {
                //  DataColumn CotTheHien = Bang.Columns();
            }
            if (TenCotMa == "")
            {

            }
            TenComboBox.DisplayMember = TenCotTheHien;
            TenComboBox.ValueMember = TenCotMa;

        }
        public static DataTable Doc_cau_truc(string Chuoi_lenh, string Ten_bang = "")
        {
            DataTable Kq = new DataTable();
            if (!Chuoi_lenh.ToUpper().Contains("SELECT"))
            {
                Chuoi_lenh = "Select * From " + Chuoi_lenh;
            }
            try
            {
                //Dim Bo_thich_ung As New OleDbDataAdapter(Chuoi_lenh, Chuoi_ket_noi)
                SqlDataAdapter Bo_thich_ung = new SqlDataAdapter(Chuoi_lenh, ChuoiKetNoi);
                Bo_thich_ung.FillSchema(Kq, SchemaType.Source);
                Kq.Columns[0].AutoIncrementSeed = 10;
            }
            catch (Exception Loi)
            {
                MessageBox.Show(Loi.Message);
            }
            if (!Chuoi_lenh.Contains("SELECT") & !string.IsNullOrEmpty(Ten_bang))
            {
                Kq.TableName = Ten_bang;
            }
            return Kq;
        }
        public static void XuatLenListBox(DataTable Bang, ListBox TenListBox, String TenCotTheHien, String TenCotMa)
        {
            TenListBox.DataSource = Bang;
            //  DataColumn CotTheHien = Bang.Columns();
            if (string.IsNullOrEmpty(TenCotTheHien))
            {
            }

            if (string.IsNullOrEmpty(TenCotMa))
            {
            }
            TenListBox.DisplayMember = TenCotTheHien;
            TenListBox.ValueMember = TenCotMa;
        }

        public static void XuatLenCheckListBox(DataTable Bang, CheckedListBox TenListBox, String TenCotTheHien, String TenCotMa)
        {
            TenListBox.DataSource = Bang;
            //  DataColumn CotTheHien = Bang.Columns();
            if (string.IsNullOrEmpty(TenCotTheHien))
            {
            }

            if (string.IsNullOrEmpty(TenCotMa))
            {
            }
            TenListBox.DisplayMember = TenCotTheHien;
            TenListBox.ValueMember = TenCotMa;
        }


        public static DataRow Chon(ListBox Danh_sach_chon)
        {
            DataRow Kq = default(DataRow);
            DataRowView Th_Kq = (DataRowView)Danh_sach_chon.SelectedItem; // Danh_sach_chon.SelectedItem;
            Kq = Th_Kq.Row;
            return Kq;
        }

#endregion


 #region "XU LY TREN DONG"
        public static DataRow ChonTuComboBox(ComboBox TenComboBox)
        {
            DataRow kq;
            DataTable Bang = (DataTable)TenComboBox.DataSource;
            int chiso = TenComboBox.SelectedIndex;
            kq = Bang.Rows[chiso];
            return kq;
        }
        public static DataRow ChonTuLuoi(DataGridView TenLuoi)
        {
            DataRow kq;
            DataRowView Th_Dong = (DataRowView)TenLuoi.CurrentRow.DataBoundItem;
            kq = Th_Dong.Row;
            return kq;
        }
       
        public static bool Ghi(DataRow Dong, string Ten_bang = "")
        {
            bool Kq = false;
            Kq = GhiBang(Dong.Table, Ten_bang) > 0;
            return Kq;
        }
        public static DataRow Dong_moi(string Ten_bang)
        {
            DataRow Kq = default(DataRow);
            // xai ham nay ne

            DataTable Bang = Doc_cau_truc(Ten_bang);
            Kq = Bang.NewRow();
            Bang.Rows.Add(Kq);
            return Kq;
        }
        public static bool Xoa(DataRow Dong, string Ten_bang = "")
        {
            bool Kq = false;
            DataTable Bang = Dong.Table;
            Dong.Delete();
            Kq = GhiBang(Bang, Ten_bang) > 0;
            return Kq;
        }
#endregion


        public static double Thuc_hien_lenh(string Chuoi_lenh)
        {
            double Kq = 0;
            SqlConnection Ket_noi = new SqlConnection(ChuoiKetNoi);
            Ket_noi.Open();
            SqlCommand Lenh = new SqlCommand(Chuoi_lenh, Ket_noi);
            Lenh.CommandTimeout = 360;
            Kq = Lenh.ExecuteNonQuery();
            Ket_noi.Close();
            return Kq;
        }

        public static void ExtractRAR(string rar_file, string path_file)
        {   
            ProcessStartInfo ps = new ProcessStartInfo();    
            // - File chương trình nén và giải nén Winar    
            ps.FileName = @"C:\\Program Files\\WinRAR\\Rar.exe";    
            // - Tham số truyền vào câu lệnh (vd: rar.exe x - trong đó x là tham số)    
            // - rar_file: tên file nén | path_file: đường dẫn giải nén(file đc giải nén, thư mục đc giải nén)    
            // - \" Thêm vào một dấu nháy kép ("")    
            ps.Arguments = "x -y \"" + rar_file + "\" \"" + path_file + "\"";    
            ps.WindowStyle = ProcessWindowStyle.Hidden;     
            // - Ẩn cửa sổ giải nén    
            // - Chạy câu lệnh giải nén    
            Process proc = Process.Start(ps);    
            // - Thoát sau khi giải nén xong    
            proc.WaitForExit();
        }

    }

    

}
