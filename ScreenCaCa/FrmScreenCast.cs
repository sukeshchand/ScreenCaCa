using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenCaCa
{
    public partial class FrmScreenCast : Form
    {
        public Image PictureBoxImage
        {
            get => picScreenCast.Image;
            set
            {
                picScreenCast.Image = value;
                Application.DoEvents();
            }
        }

        public void RefreshCast()
        {
            Application.DoEvents();
        }

        public bool ShowCursor { get; set; }

        public PictureBoxSizeMode PictureBoxImageSizeMode
        {
            get => picScreenCast.SizeMode;
            set
            {
                picScreenCast.SizeMode = value;
                Application.DoEvents();
            }
        }



        public FrmScreenCast()
        {
            InitializeComponent();
        }

        private void FrmScreenCast_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private FormBorderStyle PreviousFormBorderStyle { set; get; }
        private FormWindowState PreviousWindowState { set; get; }

        public void SetFullScreen()
        {
            if (FormBorderStyle == FormBorderStyle.None && WindowState == FormWindowState.Maximized)
            {
                FormBorderStyle = PreviousFormBorderStyle;
                WindowState = PreviousWindowState;
            }
            else
            {
                PreviousFormBorderStyle = FormBorderStyle;
                PreviousWindowState = WindowState;
                FormBorderStyle = FormBorderStyle.None;
                WindowState = FormWindowState.Maximized;
            }
        }
        private void btnFullScreen_Click(object sender, EventArgs e)
        {
            SetFullScreen();
        }

        private void FrmScreenCast_Load(object sender, EventArgs e)
        {
            PreviousFormBorderStyle = FormBorderStyle;
            PreviousWindowState = WindowState;
        }

        private void PicScreenCast_DoubleClick(object sender, EventArgs e)
        {
            SetFullScreen();
        }

        private void PicScreenCast_Click(object sender, EventArgs e)
        {

        }
    }
}
