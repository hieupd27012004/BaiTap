namespace _3.GUI.View
{
    partial class Menu1
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
            components = new System.ComponentModel.Container();
            Label label3;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu1));
            panelmanchinh = new Panel();
            groupBox2 = new GroupBox();
            tbt_email = new TextBox();
            label1 = new Label();
            btn_DoiMk = new Button();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            tbt_XacNhanMK = new TextBox();
            tbt_MkMoi = new TextBox();
            tbt_Mk = new TextBox();
            panelMenu = new Panel();
            submenu = new Panel();
            btn_sp = new Button();
            btn_nsx = new Button();
            btn_ms = new Button();
            btn_size = new Button();
            btn_sanpham = new Button();
            button1 = new Button();
            btn_khachhang = new Button();
            btn_hoadon = new Button();
            btn_buy = new Button();
            panelLogo = new Panel();
            label2 = new Label();
            panelHome = new Panel();
            btn_closechildform = new Button();
            lb_home = new Label();
            lb_time = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            label3 = new Label();
            panelmanchinh.SuspendLayout();
            groupBox2.SuspendLayout();
            panelMenu.SuspendLayout();
            submenu.SuspendLayout();
            panelLogo.SuspendLayout();
            panelHome.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(318, 15);
            label3.Name = "label3";
            label3.Size = new Size(901, 54);
            label3.TabIndex = 26;
            label3.Text = "CHÀO MỪNG BẠN ĐÃ ĐẾN VỚI ÁO PHÔNG POLY";
            // 
            // panelmanchinh
            // 
            panelmanchinh.Controls.Add(lb_time);
            panelmanchinh.Controls.Add(label3);
            panelmanchinh.Controls.Add(groupBox2);
            panelmanchinh.Dock = DockStyle.Fill;
            panelmanchinh.Location = new Point(220, 98);
            panelmanchinh.Name = "panelmanchinh";
            panelmanchinh.Size = new Size(1310, 668);
            panelmanchinh.TabIndex = 4;
            panelmanchinh.Paint += panelmanchinh_Paint;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tbt_email);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(btn_DoiMk);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(tbt_XacNhanMK);
            groupBox2.Controls.Add(tbt_MkMoi);
            groupBox2.Controls.Add(tbt_Mk);
            groupBox2.ForeColor = Color.Black;
            groupBox2.Location = new Point(101, 134);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(409, 316);
            groupBox2.TabIndex = 24;
            groupBox2.TabStop = false;
            groupBox2.Text = "Đổi mật khẩu";
            // 
            // tbt_email
            // 
            tbt_email.Location = new Point(183, 56);
            tbt_email.Margin = new Padding(3, 4, 3, 4);
            tbt_email.Name = "tbt_email";
            tbt_email.Size = new Size(188, 27);
            tbt_email.TabIndex = 57;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(26, 59);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 56;
            label1.Text = "Email";
            // 
            // btn_DoiMk
            // 
            btn_DoiMk.ForeColor = Color.Black;
            btn_DoiMk.Location = new Point(183, 269);
            btn_DoiMk.Name = "btn_DoiMk";
            btn_DoiMk.Size = new Size(188, 32);
            btn_DoiMk.TabIndex = 55;
            btn_DoiMk.Text = "Đổi mật khẩu";
            btn_DoiMk.UseVisualStyleBackColor = true;
            btn_DoiMk.Click += btn_DoiMk_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.ForeColor = Color.Black;
            label16.Location = new Point(19, 218);
            label16.Name = "label16";
            label16.Size = new Size(134, 20);
            label16.TabIndex = 54;
            label16.Text = "Xác nhận mật khẩu";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.ForeColor = Color.Black;
            label15.Location = new Point(26, 167);
            label15.Name = "label15";
            label15.Size = new Size(100, 20);
            label15.TabIndex = 53;
            label15.Text = "Mật khẩu mới";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.ForeColor = Color.Black;
            label14.Location = new Point(26, 112);
            label14.Name = "label14";
            label14.Size = new Size(89, 20);
            label14.TabIndex = 49;
            label14.Text = "Mật khẩu cũ";
            // 
            // tbt_XacNhanMK
            // 
            tbt_XacNhanMK.Location = new Point(183, 211);
            tbt_XacNhanMK.Margin = new Padding(3, 4, 3, 4);
            tbt_XacNhanMK.Name = "tbt_XacNhanMK";
            tbt_XacNhanMK.PasswordChar = '*';
            tbt_XacNhanMK.Size = new Size(188, 27);
            tbt_XacNhanMK.TabIndex = 52;
            // 
            // tbt_MkMoi
            // 
            tbt_MkMoi.Location = new Point(183, 160);
            tbt_MkMoi.Margin = new Padding(3, 4, 3, 4);
            tbt_MkMoi.Name = "tbt_MkMoi";
            tbt_MkMoi.PasswordChar = '*';
            tbt_MkMoi.Size = new Size(188, 27);
            tbt_MkMoi.TabIndex = 51;
            // 
            // tbt_Mk
            // 
            tbt_Mk.Location = new Point(183, 109);
            tbt_Mk.Margin = new Padding(3, 4, 3, 4);
            tbt_Mk.Name = "tbt_Mk";
            tbt_Mk.PasswordChar = '*';
            tbt_Mk.Size = new Size(188, 27);
            tbt_Mk.TabIndex = 50;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(51, 51, 76);
            panelMenu.Controls.Add(submenu);
            panelMenu.Controls.Add(btn_sanpham);
            panelMenu.Controls.Add(button1);
            panelMenu.Controls.Add(btn_khachhang);
            panelMenu.Controls.Add(btn_hoadon);
            panelMenu.Controls.Add(btn_buy);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 766);
            panelMenu.TabIndex = 2;
            // 
            // submenu
            // 
            submenu.Controls.Add(btn_sp);
            submenu.Controls.Add(btn_nsx);
            submenu.Controls.Add(btn_ms);
            submenu.Controls.Add(btn_size);
            submenu.Location = new Point(27, 328);
            submenu.Name = "submenu";
            submenu.Size = new Size(246, 276);
            submenu.TabIndex = 9;
            submenu.Visible = false;
            submenu.Paint += submenu_Paint;
            // 
            // btn_sp
            // 
            btn_sp.FlatAppearance.BorderSize = 0;
            btn_sp.FlatStyle = FlatStyle.Flat;
            btn_sp.ForeColor = Color.Gainsboro;
            btn_sp.Location = new Point(3, -2);
            btn_sp.Name = "btn_sp";
            btn_sp.Padding = new Padding(12, 0, 0, 0);
            btn_sp.Size = new Size(193, 60);
            btn_sp.TabIndex = 10;
            btn_sp.Text = "  Sản phẩm";
            btn_sp.TextAlign = ContentAlignment.MiddleLeft;
            btn_sp.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_sp.UseVisualStyleBackColor = true;
            btn_sp.Click += btn_sp_Click;
            // 
            // btn_nsx
            // 
            btn_nsx.FlatAppearance.BorderSize = 0;
            btn_nsx.FlatStyle = FlatStyle.Flat;
            btn_nsx.ForeColor = Color.Gainsboro;
            btn_nsx.ImageAlign = ContentAlignment.MiddleLeft;
            btn_nsx.Location = new Point(3, 124);
            btn_nsx.Name = "btn_nsx";
            btn_nsx.Padding = new Padding(12, 0, 0, 0);
            btn_nsx.Size = new Size(193, 60);
            btn_nsx.TabIndex = 11;
            btn_nsx.Text = "Nhà sản xuất";
            btn_nsx.TextAlign = ContentAlignment.MiddleLeft;
            btn_nsx.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_nsx.UseVisualStyleBackColor = true;
            btn_nsx.Click += btn_nsx_Click;
            // 
            // btn_ms
            // 
            btn_ms.FlatAppearance.BorderSize = 0;
            btn_ms.FlatStyle = FlatStyle.Flat;
            btn_ms.ForeColor = Color.Gainsboro;
            btn_ms.ImageAlign = ContentAlignment.MiddleLeft;
            btn_ms.Location = new Point(3, 190);
            btn_ms.Name = "btn_ms";
            btn_ms.Padding = new Padding(12, 0, 0, 0);
            btn_ms.Size = new Size(193, 60);
            btn_ms.TabIndex = 9;
            btn_ms.Text = "  Màu sắc";
            btn_ms.TextAlign = ContentAlignment.MiddleLeft;
            btn_ms.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_ms.UseVisualStyleBackColor = true;
            btn_ms.Click += btn_ms_Click;
            // 
            // btn_size
            // 
            btn_size.FlatAppearance.BorderSize = 0;
            btn_size.FlatStyle = FlatStyle.Flat;
            btn_size.ForeColor = Color.Gainsboro;
            btn_size.ImageAlign = ContentAlignment.MiddleLeft;
            btn_size.Location = new Point(3, 58);
            btn_size.Name = "btn_size";
            btn_size.Padding = new Padding(12, 0, 0, 0);
            btn_size.Size = new Size(193, 60);
            btn_size.TabIndex = 10;
            btn_size.Text = "  Size";
            btn_size.TextAlign = ContentAlignment.MiddleLeft;
            btn_size.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_size.UseVisualStyleBackColor = true;
            btn_size.Click += btn_size_Click;
            // 
            // btn_sanpham
            // 
            btn_sanpham.Dock = DockStyle.Top;
            btn_sanpham.FlatAppearance.BorderSize = 0;
            btn_sanpham.FlatStyle = FlatStyle.Flat;
            btn_sanpham.ForeColor = Color.Gainsboro;
            btn_sanpham.Image = (Image)resources.GetObject("btn_sanpham.Image");
            btn_sanpham.ImageAlign = ContentAlignment.MiddleLeft;
            btn_sanpham.Location = new Point(0, 260);
            btn_sanpham.Name = "btn_sanpham";
            btn_sanpham.Padding = new Padding(12, 0, 0, 0);
            btn_sanpham.Size = new Size(220, 60);
            btn_sanpham.TabIndex = 8;
            btn_sanpham.Text = "  Sản phẩm";
            btn_sanpham.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_sanpham.UseVisualStyleBackColor = true;
            btn_sanpham.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(51, 51, 76);
            button1.Dock = DockStyle.Bottom;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Gainsboro;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(0, 706);
            button1.Name = "button1";
            button1.Padding = new Padding(12, 0, 0, 0);
            button1.Size = new Size(220, 60);
            button1.TabIndex = 6;
            button1.Text = "Đăng xuất";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btn_khachhang
            // 
            btn_khachhang.Dock = DockStyle.Top;
            btn_khachhang.FlatAppearance.BorderSize = 0;
            btn_khachhang.FlatStyle = FlatStyle.Flat;
            btn_khachhang.ForeColor = Color.Gainsboro;
            btn_khachhang.Image = (Image)resources.GetObject("btn_khachhang.Image");
            btn_khachhang.ImageAlign = ContentAlignment.MiddleLeft;
            btn_khachhang.Location = new Point(0, 200);
            btn_khachhang.Name = "btn_khachhang";
            btn_khachhang.Padding = new Padding(12, 0, 0, 0);
            btn_khachhang.Size = new Size(220, 60);
            btn_khachhang.TabIndex = 2;
            btn_khachhang.Text = "  Khách Hàng";
            btn_khachhang.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_khachhang.UseVisualStyleBackColor = true;
            btn_khachhang.Click += btn_khachhang_Click;
            // 
            // btn_hoadon
            // 
            btn_hoadon.Dock = DockStyle.Top;
            btn_hoadon.FlatAppearance.BorderSize = 0;
            btn_hoadon.FlatStyle = FlatStyle.Flat;
            btn_hoadon.ForeColor = Color.Gainsboro;
            btn_hoadon.Image = (Image)resources.GetObject("btn_hoadon.Image");
            btn_hoadon.ImageAlign = ContentAlignment.MiddleLeft;
            btn_hoadon.Location = new Point(0, 140);
            btn_hoadon.Name = "btn_hoadon";
            btn_hoadon.Padding = new Padding(12, 0, 0, 0);
            btn_hoadon.Size = new Size(220, 60);
            btn_hoadon.TabIndex = 1;
            btn_hoadon.Text = "  Hóa Đơn";
            btn_hoadon.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_hoadon.UseVisualStyleBackColor = true;
            btn_hoadon.Click += btn_hoadon_Click;
            // 
            // btn_buy
            // 
            btn_buy.Dock = DockStyle.Top;
            btn_buy.FlatAppearance.BorderSize = 0;
            btn_buy.FlatStyle = FlatStyle.Flat;
            btn_buy.ForeColor = Color.Gainsboro;
            btn_buy.Image = (Image)resources.GetObject("btn_buy.Image");
            btn_buy.ImageAlign = ContentAlignment.MiddleLeft;
            btn_buy.Location = new Point(0, 80);
            btn_buy.Name = "btn_buy";
            btn_buy.Padding = new Padding(12, 0, 0, 0);
            btn_buy.Size = new Size(220, 60);
            btn_buy.TabIndex = 0;
            btn_buy.Text = "  Bán Hàng";
            btn_buy.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_buy.UseVisualStyleBackColor = true;
            btn_buy.Click += btn_buy_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            panelLogo.Controls.Add(label2);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Padding = new Padding(12, 0, 0, 0);
            panelLogo.Size = new Size(220, 80);
            panelLogo.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(27, 21);
            label2.Name = "label2";
            label2.Size = new Size(170, 20);
            label2.TabIndex = 1;
            label2.Text = "QUẢN LÍ BÁN HÀNG";
            // 
            // panelHome
            // 
            panelHome.BackColor = Color.DeepSkyBlue;
            panelHome.BorderStyle = BorderStyle.FixedSingle;
            panelHome.Controls.Add(btn_closechildform);
            panelHome.Controls.Add(lb_home);
            panelHome.Dock = DockStyle.Top;
            panelHome.Location = new Point(220, 0);
            panelHome.Name = "panelHome";
            panelHome.RightToLeft = RightToLeft.No;
            panelHome.Size = new Size(1310, 98);
            panelHome.TabIndex = 3;
            // 
            // btn_closechildform
            // 
            btn_closechildform.Dock = DockStyle.Left;
            btn_closechildform.FlatAppearance.BorderSize = 0;
            btn_closechildform.FlatStyle = FlatStyle.Flat;
            btn_closechildform.Image = Properties.Resources.icons8_multiply_64;
            btn_closechildform.Location = new Point(0, 0);
            btn_closechildform.Name = "btn_closechildform";
            btn_closechildform.Size = new Size(94, 96);
            btn_closechildform.TabIndex = 0;
            btn_closechildform.UseVisualStyleBackColor = true;
            btn_closechildform.Click += btn_closechildform_Click;
            // 
            // lb_home
            // 
            lb_home.Anchor = AnchorStyles.None;
            lb_home.AutoSize = true;
            lb_home.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lb_home.ForeColor = SystemColors.ButtonHighlight;
            lb_home.Location = new Point(627, 20);
            lb_home.Name = "lb_home";
            lb_home.Size = new Size(95, 31);
            lb_home.TabIndex = 0;
            lb_home.Text = "HOME";
            // 
            // lb_time
            // 
            lb_time.AutoSize = true;
            lb_time.Font = new Font("Segoe UI", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
            lb_time.Location = new Point(836, 102);
            lb_time.Name = "lb_time";
            lb_time.Size = new Size(107, 45);
            lb_time.TabIndex = 27;
            lb_time.Text = "label3";
            // 
            // Menu1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1530, 766);
            Controls.Add(panelmanchinh);
            Controls.Add(panelHome);
            Controls.Add(panelMenu);
            Name = "Menu1";
            Text = "Menu1";
            WindowState = FormWindowState.Maximized;
            Load += Menu1_Load;
            panelmanchinh.ResumeLayout(false);
            panelmanchinh.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panelMenu.ResumeLayout(false);
            submenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            panelHome.ResumeLayout(false);
            panelHome.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelmanchinh;
        private Panel panelMenu;
        private Button btn_sanpham;
        private Button button1;
        private Button btn_khachhang;
        private Button btn_hoadon;
        private Button btn_buy;
        private Panel panelLogo;
        private Label label2;
        private Panel panelHome;
        private Button btn_closechildform;
        private Label lb_home;
        private GroupBox groupBox2;
        private Button btn_DoiMk;
        private Label label16;
        private Label label15;
        private Label label14;
        private TextBox tbt_XacNhanMK;
        private TextBox tbt_MkMoi;
        private TextBox tbt_Mk;
        private TextBox tbt_email;
        private Label label1;
        private Panel submenu;
        private Button btn_nsx;
        private Button btn_size;
        private Button btn_ms;
        private Button btn_sp;
        private Label label3;
        private Label lb_time;
        private System.Windows.Forms.Timer timer1;
    }
}