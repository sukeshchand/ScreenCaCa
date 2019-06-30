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

        private void PicScreenCast_Click(object sender, EventArgs e)
        {

        }
    }
}
