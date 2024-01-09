namespace QuanLyNhaSach
{
    partial class FrmDangKy
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txthoten = new TextBox();
            txttendangnhap = new TextBox();
            txtmatkhau = new TextBox();
            btndangky = new Button();
            label5 = new Label();
            linkdangnhap = new LinkLabel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(335, 573);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SFU Jamaica", 34.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(49, 214);
            label1.Name = "label1";
            label1.Size = new Size(260, 82);
            label1.TabIndex = 0;
            label1.Text = "ĐĂNG KÝ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(403, 75);
            label2.Name = "label2";
            label2.Size = new Size(75, 28);
            label2.TabIndex = 1;
            label2.Text = "Họ tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(403, 163);
            label3.Name = "label3";
            label3.Size = new Size(148, 28);
            label3.TabIndex = 2;
            label3.Text = "Tên đăng nhập";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(403, 264);
            label4.Name = "label4";
            label4.Size = new Size(98, 28);
            label4.TabIndex = 3;
            label4.Text = "Mật khẩu";
            // 
            // txthoten
            // 
            txthoten.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txthoten.Location = new Point(403, 110);
            txthoten.Name = "txthoten";
            txthoten.Size = new Size(268, 34);
            txthoten.TabIndex = 4;
            // 
            // txttendangnhap
            // 
            txttendangnhap.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txttendangnhap.Location = new Point(403, 201);
            txttendangnhap.Name = "txttendangnhap";
            txttendangnhap.Size = new Size(268, 34);
            txttendangnhap.TabIndex = 5;
            // 
            // txtmatkhau
            // 
            txtmatkhau.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtmatkhau.Location = new Point(403, 302);
            txtmatkhau.Name = "txtmatkhau";
            txtmatkhau.Size = new Size(268, 34);
            txtmatkhau.TabIndex = 6;
            // 
            // btndangky
            // 
            btndangky.BackColor = Color.FromArgb(128, 255, 128);
            btndangky.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btndangky.Location = new Point(403, 357);
            btndangky.Name = "btndangky";
            btndangky.Size = new Size(268, 39);
            btndangky.TabIndex = 7;
            btndangky.Text = "Đăng ký";
            btndangky.UseVisualStyleBackColor = false;
            btndangky.Click += btndangky_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(421, 419);
            label5.Name = "label5";
            label5.Size = new Size(143, 20);
            label5.TabIndex = 8;
            label5.Text = "Bạn đã có tài khoản?";
            // 
            // linkdangnhap
            // 
            linkdangnhap.AutoSize = true;
            linkdangnhap.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            linkdangnhap.Location = new Point(570, 419);
            linkdangnhap.Name = "linkdangnhap";
            linkdangnhap.Size = new Size(80, 20);
            linkdangnhap.TabIndex = 9;
            linkdangnhap.TabStop = true;
            linkdangnhap.Text = "Đăng nhập";
            linkdangnhap.LinkClicked += linkdangnhap_LinkClicked;
            // 
            // FrmDangKy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(735, 573);
            Controls.Add(linkdangnhap);
            Controls.Add(label5);
            Controls.Add(btndangky);
            Controls.Add(txtmatkhau);
            Controls.Add(txttendangnhap);
            Controls.Add(txthoten);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "FrmDangKy";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmDangKy";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txthoten;
        private TextBox txttendangnhap;
        private TextBox txtmatkhau;
        private Button btndangky;
        private Label label5;
        private LinkLabel linkdangnhap;
    }
}