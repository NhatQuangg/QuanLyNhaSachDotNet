namespace QuanLyNhaSach.Pages
{
    partial class FrmQlyTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQlyTaiKhoan));
            label1 = new Label();
            txthoten = new TextBox();
            label2 = new Label();
            txttendangnhap = new TextBox();
            label3 = new Label();
            txtmatkhau = new TextBox();
            panel1 = new Panel();
            dgvTaiKhoan = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            hotenDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tendangnhapDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            matkhauDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            taikhoanDTOBindingSource = new BindingSource(components);
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            txtAmount = new ToolStripStatusLabel();
            toolStrip1 = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            btnTKDelete = new ToolStripButton();
            btnTKUpdate = new ToolStripButton();
            btnTKAdd = new ToolStripButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTaiKhoan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)taikhoanDTOBindingSource).BeginInit();
            statusStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 26);
            label1.Name = "label1";
            label1.Size = new Size(75, 28);
            label1.TabIndex = 3;
            label1.Text = "Họ tên";
            // 
            // txthoten
            // 
            txthoten.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txthoten.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txthoten.Location = new Point(184, 23);
            txthoten.Name = "txthoten";
            txthoten.Size = new Size(354, 34);
            txthoten.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 83);
            label2.Name = "label2";
            label2.Size = new Size(148, 28);
            label2.TabIndex = 5;
            label2.Text = "Tên đăng nhập";
            // 
            // txttendangnhap
            // 
            txttendangnhap.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txttendangnhap.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txttendangnhap.Location = new Point(184, 80);
            txttendangnhap.Name = "txttendangnhap";
            txttendangnhap.Size = new Size(354, 34);
            txttendangnhap.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 137);
            label3.Name = "label3";
            label3.Size = new Size(98, 28);
            label3.TabIndex = 7;
            label3.Text = "Mật khẩu";
            // 
            // txtmatkhau
            // 
            txtmatkhau.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtmatkhau.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtmatkhau.Location = new Point(184, 134);
            txtmatkhau.Name = "txtmatkhau";
            txtmatkhau.Size = new Size(354, 34);
            txtmatkhau.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(dgvTaiKhoan);
            panel1.Controls.Add(statusStrip1);
            panel1.Controls.Add(toolStrip1);
            panel1.Location = new Point(12, 253);
            panel1.Name = "panel1";
            panel1.Size = new Size(955, 345);
            panel1.TabIndex = 9;
            // 
            // dgvTaiKhoan
            // 
            dgvTaiKhoan.AutoGenerateColumns = false;
            dgvTaiKhoan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTaiKhoan.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, hotenDataGridViewTextBoxColumn, tendangnhapDataGridViewTextBoxColumn, matkhauDataGridViewTextBoxColumn });
            dgvTaiKhoan.DataSource = taikhoanDTOBindingSource;
            dgvTaiKhoan.Dock = DockStyle.Fill;
            dgvTaiKhoan.Location = new Point(0, 30);
            dgvTaiKhoan.Name = "dgvTaiKhoan";
            dgvTaiKhoan.RowHeadersWidth = 51;
            dgvTaiKhoan.RowTemplate.Height = 29;
            dgvTaiKhoan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTaiKhoan.Size = new Size(955, 286);
            dgvTaiKhoan.TabIndex = 0;
            dgvTaiKhoan.CellClick += dgvTaiKhoan_CellClick;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Width = 50;
            // 
            // hotenDataGridViewTextBoxColumn
            // 
            hotenDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            hotenDataGridViewTextBoxColumn.DataPropertyName = "hoten";
            hotenDataGridViewTextBoxColumn.HeaderText = "Họ tên";
            hotenDataGridViewTextBoxColumn.MinimumWidth = 6;
            hotenDataGridViewTextBoxColumn.Name = "hotenDataGridViewTextBoxColumn";
            // 
            // tendangnhapDataGridViewTextBoxColumn
            // 
            tendangnhapDataGridViewTextBoxColumn.DataPropertyName = "tendangnhap";
            tendangnhapDataGridViewTextBoxColumn.HeaderText = "Tên đăng nhập";
            tendangnhapDataGridViewTextBoxColumn.MinimumWidth = 6;
            tendangnhapDataGridViewTextBoxColumn.Name = "tendangnhapDataGridViewTextBoxColumn";
            tendangnhapDataGridViewTextBoxColumn.Width = 200;
            // 
            // matkhauDataGridViewTextBoxColumn
            // 
            matkhauDataGridViewTextBoxColumn.DataPropertyName = "matkhau";
            matkhauDataGridViewTextBoxColumn.HeaderText = "Mật khẩu";
            matkhauDataGridViewTextBoxColumn.MinimumWidth = 6;
            matkhauDataGridViewTextBoxColumn.Name = "matkhauDataGridViewTextBoxColumn";
            matkhauDataGridViewTextBoxColumn.Width = 200;
            // 
            // taikhoanDTOBindingSource
            // 
            taikhoanDTOBindingSource.DataSource = typeof(DTO.taikhoanDTO);
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, txtAmount });
            statusStrip1.Location = new Point(0, 316);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(955, 29);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(151, 23);
            toolStripStatusLabel1.Text = "Tổng số tài khoản:";
            // 
            // txtAmount
            // 
            txtAmount.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(19, 23);
            txtAmount.Text = "0";
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabel1, btnTKDelete, btnTKUpdate, btnTKAdd });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(955, 30);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(167, 27);
            toolStripLabel1.Text = "Danh sách tài khoản";
            // 
            // btnTKDelete
            // 
            btnTKDelete.Alignment = ToolStripItemAlignment.Right;
            btnTKDelete.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnTKDelete.Image = (Image)resources.GetObject("btnTKDelete.Image");
            btnTKDelete.ImageTransparentColor = Color.Magenta;
            btnTKDelete.Name = "btnTKDelete";
            btnTKDelete.Size = new Size(64, 27);
            btnTKDelete.Text = "Xóa";
            btnTKDelete.Click += btnTKDelete_Click;
            // 
            // btnTKUpdate
            // 
            btnTKUpdate.Alignment = ToolStripItemAlignment.Right;
            btnTKUpdate.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnTKUpdate.Image = (Image)resources.GetObject("btnTKUpdate.Image");
            btnTKUpdate.ImageTransparentColor = Color.Magenta;
            btnTKUpdate.Name = "btnTKUpdate";
            btnTKUpdate.Size = new Size(104, 27);
            btnTKUpdate.Text = "Cập nhật";
            btnTKUpdate.Click += btnTKUpdate_Click;
            // 
            // btnTKAdd
            // 
            btnTKAdd.Alignment = ToolStripItemAlignment.Right;
            btnTKAdd.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnTKAdd.Image = (Image)resources.GetObject("btnTKAdd.Image");
            btnTKAdd.ImageTransparentColor = Color.Magenta;
            btnTKAdd.Name = "btnTKAdd";
            btnTKAdd.Size = new Size(77, 27);
            btnTKAdd.Text = "Thêm";
            btnTKAdd.Click += btnTKAdd_Click;
            // 
            // FrmQlyTaiKhoan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(979, 610);
            Controls.Add(panel1);
            Controls.Add(txtmatkhau);
            Controls.Add(label3);
            Controls.Add(txttendangnhap);
            Controls.Add(label2);
            Controls.Add(txthoten);
            Controls.Add(label1);
            Name = "FrmQlyTaiKhoan";
            Text = "FrmQlyTaiKhoan";
            Load += FrmQlyTaiKhoan_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTaiKhoan).EndInit();
            ((System.ComponentModel.ISupportInitialize)taikhoanDTOBindingSource).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnThem;
        private Button btnCapNhat;
        private Button btnXoa;
        private Label label1;
        private TextBox txthoten;
        private Label label2;
        private TextBox txttendangnhap;
        private Label label3;
        private TextBox txtmatkhau;
        private Panel panel1;
        private DataGridView dgvTaiKhoan;
        private BindingSource taikhoanDTOBindingSource;
        private ToolStrip toolStrip1;
        private ToolStripLabel toolStripLabel1;
        private ToolStripButton btnTKAdd;
        private ToolStripButton btnTKUpdate;
        private ToolStripButton btnTKDelete;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn hotenDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tendangnhapDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn matkhauDataGridViewTextBoxColumn;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel txtAmount;
    }
}