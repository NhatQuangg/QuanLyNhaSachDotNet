namespace QuanLyNhaSach.Pages
{
    partial class FrmDangNhap
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
            panel1 = new Panel();
            label4 = new Label();
            label1 = new Label();
            label2 = new Label();
            txttendangnhap = new TextBox();
            txtmatkhau = new TextBox();
            btndangnhap = new Button();
            btnMinimize = new FontAwesome.Sharp.IconButton();
            btnClose = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(33, 36, 77);
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(658, 753);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("SFU Jamaica", 34.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(148, 461);
            label4.Name = "label4";
            label4.Size = new Size(328, 82);
            label4.TabIndex = 0;
            label4.Text = "ĐĂNG NHẬP";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(715, 294);
            label1.Name = "label1";
            label1.Size = new Size(205, 38);
            label1.TabIndex = 1;
            label1.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(715, 419);
            label2.Name = "label2";
            label2.Size = new Size(138, 38);
            label2.TabIndex = 2;
            label2.Text = "Mật khẩu";
            // 
            // txttendangnhap
            // 
            txttendangnhap.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txttendangnhap.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            txttendangnhap.Location = new Point(715, 347);
            txttendangnhap.Name = "txttendangnhap";
            txttendangnhap.Size = new Size(492, 43);
            txttendangnhap.TabIndex = 4;
            // 
            // txtmatkhau
            // 
            txtmatkhau.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtmatkhau.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtmatkhau.Location = new Point(715, 465);
            txtmatkhau.Name = "txtmatkhau";
            txtmatkhau.PasswordChar = '*';
            txtmatkhau.Size = new Size(492, 43);
            txtmatkhau.TabIndex = 5;
            // 
            // btndangnhap
            // 
            btndangnhap.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btndangnhap.BackColor = Color.FromArgb(128, 255, 128);
            btndangnhap.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btndangnhap.Location = new Point(715, 555);
            btndangnhap.Name = "btndangnhap";
            btndangnhap.Size = new Size(492, 54);
            btndangnhap.TabIndex = 7;
            btndangnhap.Text = "Đăng nhập";
            btndangnhap.UseVisualStyleBackColor = false;
            btndangnhap.Click += btndangnhap_Click;
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
            btnMinimize.Location = new Point(462, 3);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(63, 29);
            btnMinimize.TabIndex = 10;
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
            btnClose.Location = new Point(531, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(63, 29);
            btnClose.TabIndex = 9;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(33, 36, 77);
            panel2.Controls.Add(btnMinimize);
            panel2.Controls.Add(btnClose);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(658, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(597, 47);
            panel2.TabIndex = 11;
            // 
            // FrmDangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1255, 753);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(btndangnhap);
            Controls.Add(txtmatkhau);
            Controls.Add(txttendangnhap);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "FrmDangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmDangNhap";
            WindowState = FormWindowState.Maximized;
            FormClosing += FrmDangNhap_FormClosing;
            Load += FrmDangNhap_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox txttendangnhap;
        private TextBox txtmatkhau;
        private Label label4;
        private Button btndangnhap;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private FontAwesome.Sharp.IconButton btnClose;
        private Panel panel2;
    }
}