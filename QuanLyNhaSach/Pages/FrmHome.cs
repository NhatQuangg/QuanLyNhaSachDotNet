using FontAwesome.Sharp;
using QuanLyNhaSach.Bo;
using QuanLyNhaSach.DTO;
using QuanLyNhaSach.Pages;
using System.Runtime.InteropServices;
using System.Windows.Media.Imaging;
using System.Xml.Linq;

namespace QuanLyNhaSach
{
    public partial class FrmHome : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        private taikhoanbo tkbo;
        private sanphambo spbo;
        private doanhthubo dtbo;
        long idUser = -1;
        public FrmHome(long iduser)
        {
            InitializeComponent();
            tkbo = new taikhoanbo();
            spbo = new sanphambo();
            dtbo = new doanhthubo();

            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            //Form
            // txthoten.Text = hoten;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            // this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            string un = tkbo.getUserName(iduser);
            txthoten.Text = un;
            idUser = iduser;
        }
        // Structs
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Current Child Form Icon
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Reset();
        }
        private void OpenChildForm(Form childForm, string text)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = text;
        }
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.MediumPurple;
            lblTitleChildForm.Text = "Home";
        }
        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btndashboard_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Reset();
        }

        private void btnqlisanpham_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new FrmQlySanPham(), "Quản lý sản phẩm");
        }

        private void btnqlitaikhoan_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new FrmQlyTaiKhoan(), "Quản lý tài khoản");
        }

        /*        private void btnqlidoanhthu_Click(object sender, EventArgs e)
                {
                    ActivateButton(sender, RGBColors.color4);
                    OpenChildForm(new FrmQlyDoanhThu(), "hihi");
                }*/

        private void FrmHome_Load(object sender, EventArgs e)
        {



        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // Application.Exit();
            this.Hide();
            FrmDangNhap frmDangNhap = new FrmDangNhap();
            frmDangNhap.Show();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnqlihoadon_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new FrmQlyHoaDon(idUser), "Quản lý hóa đơn");
        }

        private void btnqlidoanhthu_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new FrmQlyDoanhThu(), "Quản lý doanh thu");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmDangNhap frmDangNhap = new FrmDangNhap();
            frmDangNhap.Show();
        }

        private void label1_Resize(object sender, EventArgs e)
        {
            int labelWidth = label1.Width;
            int labelHeight = label1.Height;

            int panelWidth = panelDesktop.Width;
            int panelHeight = panelDesktop.Height;

            int x = (panelWidth - labelWidth) / 2;
            int y = (panelHeight - labelHeight) / 2;

            label1.Location = new Point(x, y);
        }
    }
}