using System;

namespace CTQLDV
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtID = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtJoin = new System.Windows.Forms.DateTimePicker();
            this.lbDateJoin = new System.Windows.Forms.Label();
            this.lbAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.txtngaysinh = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtmota = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtschool = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtperm = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.chknu = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtlop = new System.Windows.Forms.TextBox();
            this.lbname = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.chknam = new System.Windows.Forms.RadioButton();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtBrowseimg = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureDV = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtfilter = new System.Windows.Forms.TextBox();
            this.btnXuat = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.dataDoanVien = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HO_TEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIOI_TINH = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.LOP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHUC_VU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TRUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAY_SINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ADDRESS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIEN_THOAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JOINED = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MO_TA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDV)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDoanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Location = new System.Drawing.Point(7, 8);
            this.panel1.MinimumSize = new System.Drawing.Size(870, 590);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(870, 590);
            this.panel1.TabIndex = 0;
            // 
            // txtID
            // 
            this.txtID.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtID.Location = new System.Drawing.Point(814, 29);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(49, 20);
            this.txtID.TabIndex = 24;
            this.txtID.Visible = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(812, 8);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(51, 13);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Giới thiệu";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bungee", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(327, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "QUẢN LÝ ĐOÀN VIÊN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.Controls.Add(this.txtJoin);
            this.groupBox2.Controls.Add(this.lbDateJoin);
            this.groupBox2.Controls.Add(this.lbAddress);
            this.groupBox2.Controls.Add(this.txtAddress);
            this.groupBox2.Controls.Add(this.btnsave);
            this.groupBox2.Controls.Add(this.btndelete);
            this.groupBox2.Controls.Add(this.btnedit);
            this.groupBox2.Controls.Add(this.btnadd);
            this.groupBox2.Controls.Add(this.txtngaysinh);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtmota);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtschool);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtperm);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtphone);
            this.groupBox2.Controls.Add(this.chknu);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtlop);
            this.groupBox2.Controls.Add(this.lbname);
            this.groupBox2.Controls.Add(this.txtname);
            this.groupBox2.Controls.Add(this.chknam);
            this.groupBox2.Controls.Add(this.btncancel);
            this.groupBox2.Controls.Add(this.btnBrowse);
            this.groupBox2.Controls.Add(this.txtBrowseimg);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.Location = new System.Drawing.Point(4, 49);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(860, 233);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin";
            // 
            // txtJoin
            // 
            this.txtJoin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtJoin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtJoin.Location = new System.Drawing.Point(379, 87);
            this.txtJoin.Name = "txtJoin";
            this.txtJoin.Size = new System.Drawing.Size(157, 20);
            this.txtJoin.TabIndex = 32;
            // 
            // lbDateJoin
            // 
            this.lbDateJoin.AutoSize = true;
            this.lbDateJoin.Location = new System.Drawing.Point(374, 71);
            this.lbDateJoin.Name = "lbDateJoin";
            this.lbDateJoin.Size = new System.Drawing.Size(82, 13);
            this.lbDateJoin.TabIndex = 31;
            this.lbDateJoin.Text = "Ngày vào Đoàn";
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Location = new System.Drawing.Point(374, 23);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(40, 13);
            this.lbAddress.TabIndex = 29;
            this.lbAddress.Text = "Địa chỉ";
            // 
            // txtAddress
            // 
            this.txtAddress.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtAddress.Location = new System.Drawing.Point(377, 39);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(159, 20);
            this.txtAddress.TabIndex = 28;
            // 
            // btnsave
            // 
            this.btnsave.Enabled = false;
            this.btnsave.Location = new System.Drawing.Point(775, 183);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 23;
            this.btnsave.Text = "Lưu";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btndelete
            // 
            this.btndelete.Enabled = false;
            this.btndelete.Location = new System.Drawing.Point(775, 105);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 22;
            this.btndelete.Text = "Xóa";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnedit
            // 
            this.btnedit.Enabled = false;
            this.btnedit.Location = new System.Drawing.Point(775, 66);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(75, 23);
            this.btnedit.TabIndex = 21;
            this.btnedit.Text = "Sửa";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnadd
            // 
            this.btnadd.Enabled = false;
            this.btnadd.Location = new System.Drawing.Point(775, 27);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 20;
            this.btnadd.Text = "Thêm";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // txtngaysinh
            // 
            this.txtngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtngaysinh.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtngaysinh.Location = new System.Drawing.Point(196, 86);
            this.txtngaysinh.Name = "txtngaysinh";
            this.txtngaysinh.Size = new System.Drawing.Size(157, 20);
            this.txtngaysinh.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(193, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Ngày sinh";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(191, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Mô tả";
            // 
            // txtmota
            // 
            this.txtmota.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtmota.Location = new System.Drawing.Point(194, 136);
            this.txtmota.Multiline = true;
            this.txtmota.Name = "txtmota";
            this.txtmota.Size = new System.Drawing.Size(159, 68);
            this.txtmota.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Trường";
            // 
            // txtschool
            // 
            this.txtschool.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtschool.Location = new System.Drawing.Point(20, 184);
            this.txtschool.Name = "txtschool";
            this.txtschool.Size = new System.Drawing.Size(159, 20);
            this.txtschool.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Chức vụ";
            // 
            // txtperm
            // 
            this.txtperm.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtperm.Location = new System.Drawing.Point(20, 136);
            this.txtperm.Name = "txtperm";
            this.txtperm.Size = new System.Drawing.Size(159, 20);
            this.txtperm.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Số điện thoại";
            // 
            // txtphone
            // 
            this.txtphone.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtphone.Location = new System.Drawing.Point(20, 87);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(159, 20);
            this.txtphone.TabIndex = 9;
            // 
            // chknu
            // 
            this.chknu.AutoSize = true;
            this.chknu.Location = new System.Drawing.Point(313, 40);
            this.chknu.Name = "chknu";
            this.chknu.Size = new System.Drawing.Size(39, 17);
            this.chknu.TabIndex = 8;
            this.chknu.TabStop = true;
            this.chknu.Text = "Nữ";
            this.chknu.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(259, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Giới tính:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Lớp";
            // 
            // txtlop
            // 
            this.txtlop.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtlop.Location = new System.Drawing.Point(196, 39);
            this.txtlop.Name = "txtlop";
            this.txtlop.Size = new System.Drawing.Size(49, 20);
            this.txtlop.TabIndex = 5;
            // 
            // lbname
            // 
            this.lbname.AutoSize = true;
            this.lbname.Location = new System.Drawing.Point(17, 23);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(54, 13);
            this.lbname.TabIndex = 4;
            this.lbname.Text = "Họ và tên";
            // 
            // txtname
            // 
            this.txtname.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtname.Location = new System.Drawing.Point(20, 39);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(159, 20);
            this.txtname.TabIndex = 3;
            // 
            // chknam
            // 
            this.chknam.AutoSize = true;
            this.chknam.Checked = true;
            this.chknam.Location = new System.Drawing.Point(260, 40);
            this.chknam.Name = "chknam";
            this.chknam.Size = new System.Drawing.Size(47, 17);
            this.chknam.TabIndex = 1;
            this.chknam.TabStop = true;
            this.chknam.Text = "Nam";
            this.chknam.UseVisualStyleBackColor = true;
            // 
            // btncancel
            // 
            this.btncancel.Enabled = false;
            this.btncancel.Location = new System.Drawing.Point(775, 144);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 23);
            this.btncancel.TabIndex = 0;
            this.btncancel.Text = "Hủy";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(663, 184);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 27;
            this.btnBrowse.Text = "Duyệt ...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtBrowseimg
            // 
            this.txtBrowseimg.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtBrowseimg.Location = new System.Drawing.Point(377, 184);
            this.txtBrowseimg.Name = "txtBrowseimg";
            this.txtBrowseimg.Size = new System.Drawing.Size(276, 20);
            this.txtBrowseimg.TabIndex = 26;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pictureDV);
            this.groupBox3.Location = new System.Drawing.Point(653, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(90, 140);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hình";
            // 
            // pictureDV
            // 
            this.pictureDV.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureDV.Location = new System.Drawing.Point(5, 13);
            this.pictureDV.Name = "pictureDV";
            this.pictureDV.Size = new System.Drawing.Size(80, 120);
            this.pictureDV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureDV.TabIndex = 0;
            this.pictureDV.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataDoanVien);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtfilter);
            this.groupBox1.Controls.Add(this.btnXuat);
            this.groupBox1.Controls.Add(this.btnLoad);
            this.groupBox1.Location = new System.Drawing.Point(4, 299);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(860, 284);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dữ liệu";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(643, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Tìm theo tên:";
            // 
            // txtfilter
            // 
            this.txtfilter.Location = new System.Drawing.Point(718, 16);
            this.txtfilter.Name = "txtfilter";
            this.txtfilter.Size = new System.Drawing.Size(132, 20);
            this.txtfilter.TabIndex = 3;
            this.txtfilter.TextChanged += new System.EventHandler(this.txtfilter_TextChanged);
            // 
            // btnXuat
            // 
            this.btnXuat.Location = new System.Drawing.Point(129, 13);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(75, 23);
            this.btnXuat.TabIndex = 2;
            this.btnXuat.Text = "Xuất Excel";
            this.btnXuat.UseVisualStyleBackColor = true;
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(48, 13);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Lấy dữ liệu";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // dataDoanVien
            // 
            this.dataDoanVien.AllowUserToAddRows = false;
            this.dataDoanVien.AllowUserToOrderColumns = true;
            this.dataDoanVien.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataDoanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDoanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.HO_TEN,
            this.GIOI_TINH,
            this.LOP,
            this.CHUC_VU,
            this.TRUONG,
            this.NGAY_SINH,
            this.ADDRESS,
            this.DIEN_THOAI,
            this.JOINED,
            this.HINH,
            this.MO_TA,
            this.id});
            this.dataDoanVien.Location = new System.Drawing.Point(6, 42);
            this.dataDoanVien.Name = "dataDoanVien";
            this.dataDoanVien.ReadOnly = true;
            this.dataDoanVien.Size = new System.Drawing.Size(844, 234);
            this.dataDoanVien.TabIndex = 0;
            this.dataDoanVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataDoanVien_CellContentClick);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 35;
            // 
            // HO_TEN
            // 
            this.HO_TEN.DataPropertyName = "HO_TEN";
            this.HO_TEN.HeaderText = "Họ tên";
            this.HO_TEN.Name = "HO_TEN";
            this.HO_TEN.ReadOnly = true;
            this.HO_TEN.Width = 120;
            // 
            // GIOI_TINH
            // 
            this.GIOI_TINH.DataPropertyName = "GIOI_TINH";
            this.GIOI_TINH.FalseValue = "";
            this.GIOI_TINH.HeaderText = "Giới tính";
            this.GIOI_TINH.IndeterminateValue = "";
            this.GIOI_TINH.Name = "GIOI_TINH";
            this.GIOI_TINH.ReadOnly = true;
            this.GIOI_TINH.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.GIOI_TINH.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.GIOI_TINH.TrueValue = "";
            this.GIOI_TINH.Width = 40;
            // 
            // LOP
            // 
            this.LOP.DataPropertyName = "LOP";
            this.LOP.HeaderText = "Lớp";
            this.LOP.Name = "LOP";
            this.LOP.ReadOnly = true;
            this.LOP.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.LOP.Width = 40;
            // 
            // CHUC_VU
            // 
            this.CHUC_VU.DataPropertyName = "CHUC_VU";
            this.CHUC_VU.HeaderText = "Chức vụ";
            this.CHUC_VU.Name = "CHUC_VU";
            this.CHUC_VU.ReadOnly = true;
            this.CHUC_VU.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CHUC_VU.Width = 80;
            // 
            // TRUONG
            // 
            this.TRUONG.DataPropertyName = "TRUONG";
            this.TRUONG.HeaderText = "Trường";
            this.TRUONG.Name = "TRUONG";
            this.TRUONG.ReadOnly = true;
            // 
            // NGAY_SINH
            // 
            this.NGAY_SINH.DataPropertyName = "NGAY_SINH";
            this.NGAY_SINH.HeaderText = "Ngày sinh";
            this.NGAY_SINH.Name = "NGAY_SINH";
            this.NGAY_SINH.ReadOnly = true;
            this.NGAY_SINH.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ADDRESS
            // 
            this.ADDRESS.DataPropertyName = "ADDRESS";
            this.ADDRESS.HeaderText = "Địa chỉ";
            this.ADDRESS.Name = "ADDRESS";
            this.ADDRESS.ReadOnly = true;
            // 
            // DIEN_THOAI
            // 
            this.DIEN_THOAI.DataPropertyName = "DIEN_THOAI";
            this.DIEN_THOAI.HeaderText = "Điện thoại";
            this.DIEN_THOAI.Name = "DIEN_THOAI";
            this.DIEN_THOAI.ReadOnly = true;
            this.DIEN_THOAI.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // JOINED
            // 
            this.JOINED.DataPropertyName = "JOINED";
            this.JOINED.HeaderText = "Ngày vào đoàn";
            this.JOINED.Name = "JOINED";
            this.JOINED.ReadOnly = true;
            // 
            // HINH
            // 
            this.HINH.DataPropertyName = "HINH";
            this.HINH.HeaderText = "Hình";
            this.HINH.Name = "HINH";
            this.HINH.ReadOnly = true;
            this.HINH.Visible = false;
            // 
            // MO_TA
            // 
            this.MO_TA.DataPropertyName = "MO_TA";
            this.MO_TA.HeaderText = "Mô tả";
            this.MO_TA.Name = "MO_TA";
            this.MO_TA.ReadOnly = true;
            this.MO_TA.Width = 150;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.id.Visible = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::CTQLDV.Properties.Resources.wp2555194;
            this.ClientSize = new System.Drawing.Size(884, 606);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(900, 645);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý đoàn viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureDV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDoanVien)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataDoanVien;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.RadioButton chknam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtlop;
        private System.Windows.Forms.Label lbname;
        private System.Windows.Forms.RadioButton chknu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtmota;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtschool;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtperm;
        private System.Windows.Forms.DateTimePicker txtngaysinh;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnXuat;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtBrowseimg;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureDV;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox txtfilter;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbDateJoin;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.DateTimePicker txtJoin;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn HO_TEN;
        private System.Windows.Forms.DataGridViewCheckBoxColumn GIOI_TINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn LOP;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHUC_VU;
        private System.Windows.Forms.DataGridViewTextBoxColumn TRUONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAY_SINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn ADDRESS;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIEN_THOAI;
        private System.Windows.Forms.DataGridViewTextBoxColumn JOINED;
        private System.Windows.Forms.DataGridViewTextBoxColumn HINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MO_TA;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
    }
}

