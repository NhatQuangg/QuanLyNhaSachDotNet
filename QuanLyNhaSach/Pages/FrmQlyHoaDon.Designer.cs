namespace QuanLyNhaSach.Pages
{
    partial class FrmQlyHoaDon
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
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            panel1 = new Panel();
            dgvDetailProducts = new DataGridView();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            chitiethoadonDTOBindingSource1 = new BindingSource(components);
            toolStrip1 = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            toolStripLabel2 = new ToolStripLabel();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            txttongsanpham = new ToolStripStatusLabel();
            chitiethoadonDTOBindingSource = new BindingSource(components);
            label6 = new Label();
            txttongtien = new Label();
            cbbMaHoaDon = new ComboBox();
            btnAddHD = new Button();
            label2 = new Label();
            txtmnv = new Label();
            txtngaytao = new Label();
            txthoten = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetailProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chitiethoadonDTOBindingSource1).BeginInit();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chitiethoadonDTOBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(45, 48);
            label1.Name = "label1";
            label1.Size = new Size(127, 28);
            label1.TabIndex = 0;
            label1.Text = "Mã hóa đơn:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(547, 48);
            label4.Name = "label4";
            label4.Size = new Size(141, 28);
            label4.TabIndex = 3;
            label4.Text = "Mã nhân viên:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(547, 111);
            label5.Name = "label5";
            label5.Size = new Size(145, 28);
            label5.TabIndex = 4;
            label5.Text = "Tên nhân viên:";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(dgvDetailProducts);
            panel1.Controls.Add(toolStrip1);
            panel1.Controls.Add(statusStrip1);
            panel1.Location = new Point(12, 228);
            panel1.Name = "panel1";
            panel1.Size = new Size(955, 295);
            panel1.TabIndex = 10;
            // 
            // dgvDetailProducts
            // 
            dgvDetailProducts.AutoGenerateColumns = false;
            dgvDetailProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetailProducts.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5 });
            dgvDetailProducts.DataSource = chitiethoadonDTOBindingSource1;
            dgvDetailProducts.Dock = DockStyle.Fill;
            dgvDetailProducts.Location = new Point(0, 26);
            dgvDetailProducts.Name = "dgvDetailProducts";
            dgvDetailProducts.RowHeadersWidth = 51;
            dgvDetailProducts.RowTemplate.Height = 29;
            dgvDetailProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetailProducts.Size = new Size(955, 240);
            dgvDetailProducts.TabIndex = 0;
            dgvDetailProducts.CellFormatting += dgvDetailProducts_CellFormatting;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "id_sanpham";
            dataGridViewTextBoxColumn2.HeaderText = "Mã sản phẩm";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn3.DataPropertyName = "tensanpham";
            dataGridViewTextBoxColumn3.HeaderText = "Tên sản phẩm";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "soluong";
            dataGridViewTextBoxColumn1.HeaderText = "Số lượng";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "dongia";
            dataGridViewTextBoxColumn4.HeaderText = "Đơn giá";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "thanhtien";
            dataGridViewTextBoxColumn5.HeaderText = "Thành tiền";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.Width = 125;
            // 
            // chitiethoadonDTOBindingSource1
            // 
            chitiethoadonDTOBindingSource1.DataSource = typeof(DTO.chitiethoadonDTO);
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabel1, toolStripLabel2 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(955, 26);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(134, 23);
            toolStripLabel1.Text = "Chi tiết hóa đơn";
            // 
            // toolStripLabel2
            // 
            toolStripLabel2.Alignment = ToolStripItemAlignment.Right;
            toolStripLabel2.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            toolStripLabel2.Name = "toolStripLabel2";
            toolStripLabel2.Size = new Size(89, 23);
            toolStripLabel2.Text = "Đơn vị: VNĐ";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, txttongsanpham });
            statusStrip1.Location = new Point(0, 266);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(955, 29);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(132, 23);
            toolStripStatusLabel1.Text = "Tổng mặt hàng:";
            // 
            // txttongsanpham
            // 
            txttongsanpham.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txttongsanpham.Name = "txttongsanpham";
            txttongsanpham.Size = new Size(19, 23);
            txttongsanpham.Text = "0";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(797, 526);
            label6.Name = "label6";
            label6.Size = new Size(105, 28);
            label6.TabIndex = 11;
            label6.Text = "Tổng tiền:";
            // 
            // txttongtien
            // 
            txttongtien.Anchor = AnchorStyles.Bottom;
            txttongtien.AutoSize = true;
            txttongtien.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txttongtien.ForeColor = Color.Red;
            txttongtien.Location = new Point(903, 526);
            txttongtien.Name = "txttongtien";
            txttongtien.Size = new Size(23, 28);
            txttongtien.TabIndex = 12;
            txttongtien.Text = "0";
            // 
            // cbbMaHoaDon
            // 
            cbbMaHoaDon.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbMaHoaDon.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbbMaHoaDon.FormattingEnabled = true;
            cbbMaHoaDon.Location = new Point(193, 45);
            cbbMaHoaDon.Name = "cbbMaHoaDon";
            cbbMaHoaDon.Size = new Size(272, 36);
            cbbMaHoaDon.TabIndex = 0;
            cbbMaHoaDon.SelectedIndexChanged += cbbMaHoaDon_SelectedIndexChanged;
            // 
            // btnAddHD
            // 
            btnAddHD.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddHD.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddHD.Location = new Point(670, 187);
            btnAddHD.Name = "btnAddHD";
            btnAddHD.Size = new Size(140, 35);
            btnAddHD.TabIndex = 4;
            btnAddHD.Text = "Thêm hóa đơn";
            btnAddHD.UseVisualStyleBackColor = true;
            btnAddHD.Click += btnAddHD_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(45, 111);
            label2.Name = "label2";
            label2.Size = new Size(99, 28);
            label2.TabIndex = 18;
            label2.Text = "Ngày tạo:";
            // 
            // txtmnv
            // 
            txtmnv.AutoSize = true;
            txtmnv.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtmnv.Location = new Point(695, 48);
            txtmnv.Name = "txtmnv";
            txtmnv.Size = new Size(66, 28);
            txtmnv.TabIndex = 1;
            txtmnv.Text = "label3";
            // 
            // txtngaytao
            // 
            txtngaytao.AutoSize = true;
            txtngaytao.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtngaytao.Location = new Point(193, 111);
            txtngaytao.Name = "txtngaytao";
            txtngaytao.Size = new Size(66, 28);
            txtngaytao.TabIndex = 2;
            txtngaytao.Text = "label3";
            // 
            // txthoten
            // 
            txthoten.AutoSize = true;
            txthoten.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txthoten.Location = new Point(695, 111);
            txthoten.Name = "txthoten";
            txthoten.Size = new Size(66, 28);
            txthoten.TabIndex = 19;
            txthoten.Text = "label3";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(827, 187);
            button1.Name = "button1";
            button1.Size = new Size(140, 35);
            button1.TabIndex = 20;
            button1.Text = "Xuất hóa đơn";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FrmQlyHoaDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(979, 572);
            Controls.Add(button1);
            Controls.Add(txthoten);
            Controls.Add(txtngaytao);
            Controls.Add(txtmnv);
            Controls.Add(label2);
            Controls.Add(btnAddHD);
            Controls.Add(cbbMaHoaDon);
            Controls.Add(txttongtien);
            Controls.Add(label6);
            Controls.Add(panel1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Name = "FrmQlyHoaDon";
            Text = "Quản lý hóa đơn";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetailProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)chitiethoadonDTOBindingSource1).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chitiethoadonDTOBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label4;
        private Label label5;
        private Panel panel1;
        private DataGridView dgvDetailProducts;
        private StatusStrip statusStrip1;
        private ToolStrip toolStrip1;
        private ToolStripLabel toolStripLabel1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel txttongsanpham;
        private Label label6;
        private Label txttongtien;
        private DataGridViewTextBoxColumn idsanphamDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tensanphamDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn soluongDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dongiaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn thanhtienDataGridViewTextBoxColumn;
        private BindingSource chitiethoadonDTOBindingSource;
        private BindingSource chitiethoadonDTOBindingSource1;
        private ComboBox cbbMaHoaDon;
        private Button btnAddHD;
        private Button button2;
        private Label label2;
        private Label txtmnv;
        private Label txtngaytao;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private ToolStripLabel toolStripLabel2;
        private Label txthoten;
        private Button button1;
    }
}