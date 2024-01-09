namespace QuanLyNhaSach.Pages
{
    partial class FrmChiTietHD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChiTietHD));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtSoLuong = new TextBox();
            cbbTensanpham = new ComboBox();
            panel1 = new Panel();
            dgvCTSP = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tensanphamDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            soluongmua = new DataGridViewTextBoxColumn();
            dongiaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            thanhtien = new DataGridViewTextBoxColumn();
            sanphamDTOBindingSource = new BindingSource(components);
            toolStrip1 = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            btnXoa = new ToolStripButton();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            txtTongTien = new ToolStripStatusLabel();
            btnNhap = new Button();
            btnTaoHD = new Button();
            label4 = new Label();
            toolTip1 = new ToolTip(components);
            txtSLCon = new Label();
            txtDonGia = new Label();
            txthoten = new Label();
            label5 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCTSP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sanphamDTOBindingSource).BeginInit();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(16, 29);
            label1.Name = "label1";
            label1.Size = new Size(139, 28);
            label1.TabIndex = 0;
            label1.Text = "Tên sản phẩm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(16, 134);
            label2.Name = "label2";
            label2.Size = new Size(99, 28);
            label2.TabIndex = 1;
            label2.Text = "Số lượng:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(16, 84);
            label3.Name = "label3";
            label3.Size = new Size(88, 28);
            label3.TabIndex = 2;
            label3.Text = "Đơn giá:";
            // 
            // txtSoLuong
            // 
            txtSoLuong.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtSoLuong.Location = new Point(168, 134);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(151, 31);
            txtSoLuong.TabIndex = 0;
            txtSoLuong.KeyPress += txtSoLuong_KeyPress;
            // 
            // cbbTensanpham
            // 
            cbbTensanpham.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbTensanpham.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            cbbTensanpham.FormattingEnabled = true;
            cbbTensanpham.Location = new Point(168, 29);
            cbbTensanpham.Name = "cbbTensanpham";
            cbbTensanpham.Size = new Size(413, 33);
            cbbTensanpham.TabIndex = 0;
            cbbTensanpham.SelectedIndexChanged += cbbTensanpham_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(dgvCTSP);
            panel1.Controls.Add(toolStrip1);
            panel1.Controls.Add(statusStrip1);
            panel1.Location = new Point(16, 238);
            panel1.Name = "panel1";
            panel1.Size = new Size(772, 231);
            panel1.TabIndex = 6;
            // 
            // dgvCTSP
            // 
            dgvCTSP.AutoGenerateColumns = false;
            dgvCTSP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCTSP.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, tensanphamDataGridViewTextBoxColumn, soluongmua, dongiaDataGridViewTextBoxColumn, thanhtien });
            dgvCTSP.DataSource = sanphamDTOBindingSource;
            dgvCTSP.Dock = DockStyle.Fill;
            dgvCTSP.Location = new Point(0, 32);
            dgvCTSP.Name = "dgvCTSP";
            dgvCTSP.RowHeadersWidth = 51;
            dgvCTSP.RowTemplate.Height = 29;
            dgvCTSP.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCTSP.Size = new Size(772, 168);
            dgvCTSP.TabIndex = 0;
            dgvCTSP.CellFormatting += dgvCTSP_CellFormatting;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "id";
            idDataGridViewTextBoxColumn.HeaderText = "Mã sản phẩm";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Width = 125;
            // 
            // tensanphamDataGridViewTextBoxColumn
            // 
            tensanphamDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tensanphamDataGridViewTextBoxColumn.DataPropertyName = "tensanpham";
            tensanphamDataGridViewTextBoxColumn.HeaderText = "Tên sản phẩm";
            tensanphamDataGridViewTextBoxColumn.MinimumWidth = 6;
            tensanphamDataGridViewTextBoxColumn.Name = "tensanphamDataGridViewTextBoxColumn";
            // 
            // soluongmua
            // 
            soluongmua.DataPropertyName = "soluongmua";
            soluongmua.HeaderText = "Số lượng";
            soluongmua.MinimumWidth = 6;
            soluongmua.Name = "soluongmua";
            soluongmua.Width = 125;
            // 
            // dongiaDataGridViewTextBoxColumn
            // 
            dongiaDataGridViewTextBoxColumn.DataPropertyName = "dongia";
            dongiaDataGridViewTextBoxColumn.HeaderText = "Đơn giá";
            dongiaDataGridViewTextBoxColumn.MinimumWidth = 6;
            dongiaDataGridViewTextBoxColumn.Name = "dongiaDataGridViewTextBoxColumn";
            dongiaDataGridViewTextBoxColumn.Width = 125;
            // 
            // thanhtien
            // 
            thanhtien.DataPropertyName = "thanhtien";
            thanhtien.HeaderText = "Thành tiền";
            thanhtien.MinimumWidth = 6;
            thanhtien.Name = "thanhtien";
            thanhtien.Width = 125;
            // 
            // sanphamDTOBindingSource
            // 
            sanphamDTOBindingSource.DataSource = typeof(DTO.sanphamDTO);
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabel1, btnXoa });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(772, 32);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(179, 29);
            toolStripLabel1.Text = "Danh sách sản phẩm";
            // 
            // btnXoa
            // 
            btnXoa.Alignment = ToolStripItemAlignment.Right;
            btnXoa.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnXoa.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnXoa.Image = (Image)resources.GetObject("btnXoa.Image");
            btnXoa.ImageTransparentColor = Color.Magenta;
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(47, 29);
            btnXoa.Text = "Xóa";
            btnXoa.Click += btnXoa_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, txtTongTien });
            statusStrip1.Location = new Point(0, 200);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(772, 31);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(93, 25);
            toolStripStatusLabel1.Text = "Tổng tiền";
            // 
            // txtTongTien
            // 
            txtTongTien.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(22, 25);
            txtTongTien.Text = "0";
            // 
            // btnNhap
            // 
            btnNhap.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnNhap.Location = new Point(623, 28);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(125, 32);
            btnNhap.TabIndex = 2;
            btnNhap.Text = "Nhập";
            btnNhap.UseVisualStyleBackColor = true;
            btnNhap.Click += btnNhap_Click;
            // 
            // btnTaoHD
            // 
            btnTaoHD.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnTaoHD.Location = new Point(623, 81);
            btnTaoHD.Name = "btnTaoHD";
            btnTaoHD.Size = new Size(125, 34);
            btnTaoHD.TabIndex = 3;
            btnTaoHD.Text = "Tạo hóa đơn";
            btnTaoHD.UseVisualStyleBackColor = true;
            btnTaoHD.Click += btnTaoHD_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(365, 134);
            label4.Name = "label4";
            label4.Size = new Size(138, 28);
            label4.TabIndex = 9;
            label4.Text = "Số lượng còn:";
            // 
            // txtSLCon
            // 
            txtSLCon.AutoSize = true;
            txtSLCon.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtSLCon.Location = new Point(522, 137);
            txtSLCon.Name = "txtSLCon";
            txtSLCon.Size = new Size(106, 25);
            txtSLCon.TabIndex = 4;
            txtSLCon.Text = "soluongcon";
            // 
            // txtDonGia
            // 
            txtDonGia.AutoSize = true;
            txtDonGia.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtDonGia.Location = new Point(168, 87);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(68, 25);
            txtDonGia.TabIndex = 1;
            txtDonGia.Text = "dongia";
            // 
            // txthoten
            // 
            txthoten.AutoSize = true;
            txthoten.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txthoten.Location = new Point(168, 193);
            txthoten.Name = "txthoten";
            txthoten.Size = new Size(118, 25);
            txthoten.TabIndex = 10;
            txthoten.Text = "tên nhân viên";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(16, 190);
            label5.Name = "label5";
            label5.Size = new Size(113, 28);
            label5.TabIndex = 11;
            label5.Text = "Người bán:";
            // 
            // FrmChiTietHD
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 481);
            Controls.Add(label5);
            Controls.Add(txthoten);
            Controls.Add(txtDonGia);
            Controls.Add(txtSLCon);
            Controls.Add(label4);
            Controls.Add(btnTaoHD);
            Controls.Add(btnNhap);
            Controls.Add(panel1);
            Controls.Add(cbbTensanpham);
            Controls.Add(txtSoLuong);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmChiTietHD";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmChiTietHD";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCTSP).EndInit();
            ((System.ComponentModel.ISupportInitialize)sanphamDTOBindingSource).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtSoLuong;
        private ComboBox cbbTensanpham;
        private Panel panel1;
        private DataGridView dgvCTSP;
        private Button btnNhap;
        private Button btnTaoHD;
        private Label label4;
        private BindingSource sanphamDTOBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tensanphamDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn soluongmua;
        private DataGridViewTextBoxColumn dongiaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn thanhtien;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel txtTongTien;
        private ToolStrip toolStrip1;
        private ToolStripLabel toolStripLabel1;
        private ToolTip toolTip1;
        private ToolStripButton btnXoa;
        private Label txtSLCon;
        private Label txtDonGia;
        private Label txthoten;
        private Label label5;
    }
}