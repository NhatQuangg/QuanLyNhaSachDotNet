namespace QuanLyNhaSach
{
    partial class FrmHome
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHome));
            panelMenu = new Panel();
            btnqlidoanhthu = new FontAwesome.Sharp.IconButton();
            btnqlihoadon = new FontAwesome.Sharp.IconButton();
            btnqlitaikhoan = new FontAwesome.Sharp.IconButton();
            btnqlisanpham = new FontAwesome.Sharp.IconButton();
            btndashboard = new FontAwesome.Sharp.IconButton();
            panelLogo = new Panel();
            btnHome = new PictureBox();
            panelTitleBar = new Panel();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            btnMinimize = new FontAwesome.Sharp.IconButton();
            btnClose = new FontAwesome.Sharp.IconButton();
            lblTitleChildForm = new Label();
            iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            panelDesktop = new Panel();
            label1 = new Label();
            txthoten = new Label();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnHome).BeginInit();
            panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconCurrentChildForm).BeginInit();
            panelDesktop.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(33, 36, 77);
            panelMenu.Controls.Add(btnqlidoanhthu);
            panelMenu.Controls.Add(btnqlihoadon);
            panelMenu.Controls.Add(btnqlitaikhoan);
            panelMenu.Controls.Add(btnqlisanpham);
            panelMenu.Controls.Add(btndashboard);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(250, 753);
            panelMenu.TabIndex = 0;
            // 
            // btnqlidoanhthu
            // 
            btnqlidoanhthu.Dock = DockStyle.Top;
            btnqlidoanhthu.FlatAppearance.BorderSize = 0;
            btnqlidoanhthu.FlatStyle = FlatStyle.Flat;
            btnqlidoanhthu.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnqlidoanhthu.ForeColor = SystemColors.ButtonHighlight;
            btnqlidoanhthu.IconChar = FontAwesome.Sharp.IconChar.DollarSign;
            btnqlidoanhthu.IconColor = Color.Gainsboro;
            btnqlidoanhthu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnqlidoanhthu.IconSize = 32;
            btnqlidoanhthu.ImageAlign = ContentAlignment.MiddleLeft;
            btnqlidoanhthu.Location = new Point(0, 370);
            btnqlidoanhthu.Name = "btnqlidoanhthu";
            btnqlidoanhthu.Padding = new Padding(10, 0, 20, 0);
            btnqlidoanhthu.Size = new Size(250, 60);
            btnqlidoanhthu.TabIndex = 5;
            btnqlidoanhthu.Text = "Quản lý doanh thu";
            btnqlidoanhthu.TextAlign = ContentAlignment.MiddleLeft;
            btnqlidoanhthu.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnqlidoanhthu.UseVisualStyleBackColor = true;
            btnqlidoanhthu.Click += btnqlidoanhthu_Click;
            // 
            // btnqlihoadon
            // 
            btnqlihoadon.Dock = DockStyle.Top;
            btnqlihoadon.FlatAppearance.BorderSize = 0;
            btnqlihoadon.FlatStyle = FlatStyle.Flat;
            btnqlihoadon.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnqlihoadon.ForeColor = SystemColors.ButtonHighlight;
            btnqlihoadon.IconChar = FontAwesome.Sharp.IconChar.FileInvoice;
            btnqlihoadon.IconColor = Color.Gainsboro;
            btnqlihoadon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnqlihoadon.IconSize = 32;
            btnqlihoadon.ImageAlign = ContentAlignment.MiddleLeft;
            btnqlihoadon.Location = new Point(0, 310);
            btnqlihoadon.Name = "btnqlihoadon";
            btnqlihoadon.Padding = new Padding(10, 0, 20, 0);
            btnqlihoadon.Size = new Size(250, 60);
            btnqlihoadon.TabIndex = 4;
            btnqlihoadon.Text = "Quản lý hóa đơn";
            btnqlihoadon.TextAlign = ContentAlignment.MiddleLeft;
            btnqlihoadon.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnqlihoadon.UseVisualStyleBackColor = true;
            btnqlihoadon.Click += btnqlihoadon_Click;
            // 
            // btnqlitaikhoan
            // 
            btnqlitaikhoan.Dock = DockStyle.Top;
            btnqlitaikhoan.FlatAppearance.BorderSize = 0;
            btnqlitaikhoan.FlatStyle = FlatStyle.Flat;
            btnqlitaikhoan.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnqlitaikhoan.ForeColor = SystemColors.ButtonHighlight;
            btnqlitaikhoan.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            btnqlitaikhoan.IconColor = Color.Gainsboro;
            btnqlitaikhoan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnqlitaikhoan.IconSize = 32;
            btnqlitaikhoan.ImageAlign = ContentAlignment.MiddleLeft;
            btnqlitaikhoan.Location = new Point(0, 250);
            btnqlitaikhoan.Name = "btnqlitaikhoan";
            btnqlitaikhoan.Padding = new Padding(10, 0, 20, 0);
            btnqlitaikhoan.Size = new Size(250, 60);
            btnqlitaikhoan.TabIndex = 3;
            btnqlitaikhoan.Text = "Quản lý tài khoản";
            btnqlitaikhoan.TextAlign = ContentAlignment.MiddleLeft;
            btnqlitaikhoan.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnqlitaikhoan.UseVisualStyleBackColor = true;
            btnqlitaikhoan.Click += btnqlitaikhoan_Click;
            // 
            // btnqlisanpham
            // 
            btnqlisanpham.Dock = DockStyle.Top;
            btnqlisanpham.FlatAppearance.BorderSize = 0;
            btnqlisanpham.FlatStyle = FlatStyle.Flat;
            btnqlisanpham.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnqlisanpham.ForeColor = SystemColors.ButtonHighlight;
            btnqlisanpham.IconChar = FontAwesome.Sharp.IconChar.BoxesAlt;
            btnqlisanpham.IconColor = Color.Gainsboro;
            btnqlisanpham.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnqlisanpham.IconSize = 32;
            btnqlisanpham.ImageAlign = ContentAlignment.MiddleLeft;
            btnqlisanpham.Location = new Point(0, 190);
            btnqlisanpham.Name = "btnqlisanpham";
            btnqlisanpham.Padding = new Padding(10, 0, 20, 0);
            btnqlisanpham.Size = new Size(250, 60);
            btnqlisanpham.TabIndex = 2;
            btnqlisanpham.Text = "Quản lý sản phẩm";
            btnqlisanpham.TextAlign = ContentAlignment.MiddleLeft;
            btnqlisanpham.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnqlisanpham.UseVisualStyleBackColor = true;
            btnqlisanpham.Click += btnqlisanpham_Click;
            // 
            // btndashboard
            // 
            btndashboard.Dock = DockStyle.Top;
            btndashboard.FlatAppearance.BorderSize = 0;
            btndashboard.FlatStyle = FlatStyle.Flat;
            btndashboard.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btndashboard.ForeColor = SystemColors.ButtonHighlight;
            btndashboard.IconChar = FontAwesome.Sharp.IconChar.House;
            btndashboard.IconColor = Color.Gainsboro;
            btndashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btndashboard.IconSize = 32;
            btndashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btndashboard.Location = new Point(0, 130);
            btndashboard.Name = "btndashboard";
            btndashboard.Padding = new Padding(10, 0, 20, 0);
            btndashboard.Size = new Size(250, 60);
            btndashboard.TabIndex = 1;
            btndashboard.Text = "Trang tổng quan";
            btndashboard.TextAlign = ContentAlignment.MiddleLeft;
            btndashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            btndashboard.UseVisualStyleBackColor = true;
            btndashboard.Click += btndashboard_Click;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(btnHome);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(250, 130);
            panelLogo.TabIndex = 0;
            // 
            // btnHome
            // 
            btnHome.Image = (Image)resources.GetObject("btnHome.Image");
            btnHome.Location = new Point(23, 7);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(186, 120);
            btnHome.SizeMode = PictureBoxSizeMode.Zoom;
            btnHome.TabIndex = 1;
            btnHome.TabStop = false;
            btnHome.Click += btnHome_Click;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.FromArgb(33, 36, 77);
            panelTitleBar.Controls.Add(iconButton1);
            panelTitleBar.Controls.Add(btnMinimize);
            panelTitleBar.Controls.Add(btnClose);
            panelTitleBar.Controls.Add(lblTitleChildForm);
            panelTitleBar.Controls.Add(iconCurrentChildForm);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(250, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(1005, 75);
            panelTitleBar.TabIndex = 1;
            panelTitleBar.MouseDown += panelTitleBar_MouseDown;
            // 
            // iconButton1
            // 
            iconButton1.Anchor = AnchorStyles.Right;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.ForeColor = SystemColors.ButtonHighlight;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            iconButton1.IconColor = Color.WhiteSmoke;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 25;
            iconButton1.Location = new Point(939, 40);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(63, 29);
            iconButton1.TabIndex = 4;
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Right;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.ForeColor = SystemColors.ButtonHighlight;
            btnMinimize.IconChar = FontAwesome.Sharp.IconChar.Minus;
            btnMinimize.IconColor = Color.WhiteSmoke;
            btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMinimize.IconSize = 25;
            btnMinimize.Location = new Point(870, 3);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(63, 29);
            btnMinimize.TabIndex = 3;
            btnMinimize.UseVisualStyleBackColor = true;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Right;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.ForeColor = SystemColors.ButtonHighlight;
            btnClose.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            btnClose.IconColor = Color.WhiteSmoke;
            btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnClose.IconSize = 25;
            btnClose.Location = new Point(939, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(63, 29);
            btnClose.TabIndex = 2;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // lblTitleChildForm
            // 
            lblTitleChildForm.AutoSize = true;
            lblTitleChildForm.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitleChildForm.ForeColor = SystemColors.ButtonFace;
            lblTitleChildForm.Location = new Point(71, 26);
            lblTitleChildForm.Name = "lblTitleChildForm";
            lblTitleChildForm.Size = new Size(71, 28);
            lblTitleChildForm.TabIndex = 1;
            lblTitleChildForm.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            iconCurrentChildForm.BackColor = Color.FromArgb(33, 36, 77);
            iconCurrentChildForm.ForeColor = SystemColors.ButtonFace;
            iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.House;
            iconCurrentChildForm.IconColor = SystemColors.ButtonFace;
            iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconCurrentChildForm.IconSize = 39;
            iconCurrentChildForm.Location = new Point(16, 20);
            iconCurrentChildForm.Name = "iconCurrentChildForm";
            iconCurrentChildForm.Size = new Size(42, 39);
            iconCurrentChildForm.TabIndex = 0;
            iconCurrentChildForm.TabStop = false;
            // 
            // panelDesktop
            // 
            panelDesktop.BackColor = SystemColors.Control;
            panelDesktop.Controls.Add(label1);
            panelDesktop.Controls.Add(txthoten);
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.Location = new Point(250, 75);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(1005, 678);
            panelDesktop.TabIndex = 4;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Font = new Font("SVN-Aguda", 72F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(188, 169);
            label1.Name = "label1";
            label1.Size = new Size(596, 165);
            label1.TabIndex = 5;
            label1.Text = "Xin chào";
            label1.Resize += label1_Resize;
            // 
            // txthoten
            // 
            txthoten.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txthoten.AutoSize = true;
            txthoten.Font = new Font("SVN-Aguda", 72F, FontStyle.Bold, GraphicsUnit.Point);
            txthoten.Location = new Point(263, 295);
            txthoten.Name = "txthoten";
            txthoten.Size = new Size(447, 165);
            txthoten.TabIndex = 3;
            txthoten.Text = "label4";
            // 
            // FrmHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1255, 753);
            ControlBox = false;
            Controls.Add(panelDesktop);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            Name = "FrmHome";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += FrmHome_Load;
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnHome).EndInit();
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconCurrentChildForm).EndInit();
            panelDesktop.ResumeLayout(false);
            panelDesktop.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private FontAwesome.Sharp.IconButton btndashboard;
        private Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnqlihoadon;
        private FontAwesome.Sharp.IconButton btnqlitaikhoan;
        private FontAwesome.Sharp.IconButton btnqlisanpham;
        private PictureBox btnHome;
        private Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private Label lblTitleChildForm;
        private Panel panelDesktop;
        private FontAwesome.Sharp.IconButton btnqlidoanhthu;
        private FontAwesome.Sharp.IconButton btnClose;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private Label txthoten;
        private Label label1;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}