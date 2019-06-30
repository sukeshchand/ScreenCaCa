using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenCaCa
{
    public partial class FrmHome : Form
    {
        public FrmScreenCast ScreenCastingForm { get; set; }
        public bool IsScreenCasting { get; set; }
        public FrmHome()
        {
            InitializeComponent();
        }

        private void FrmHome_Load(object sender, EventArgs e)
        {
            try
            {
                btnCastArea.Enabled = true;
                btnCastFullScreen.Enabled = true;

                btnPauseStartScreenCast.Visible = false;
                btnStopScreenCast.Visible = false;
            }
            catch (Exception exception)
            {
                // todo log
            }
        }

        private void BtnPauseStartScreenCast_Click(object sender, EventArgs e)
        {

        }

        private void BtnCastFullScreen_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {

                    var thread = new Thread(ScreenCastTask);
                    thread.Start();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.ToString());
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }

        public void ScreenCastTask()
        {
            if (IsScreenCasting) return;
            if (ScreenCastingForm == null)
            {
                ScreenCastingForm = new FrmScreenCast();
            }
            IsScreenCasting = true;
            ScreenCastingForm.Show();
            while (true)
            {
                if (!IsScreenCasting)
                {
                    break;
                }

                try
                {
                    CaptureAndCastScreen();

                }
                catch (Exception e)
                {
                }
                System.Threading.Thread.Sleep(100);
            }
        }

        public void CaptureAndCastScreen()
        {

            Image img = null;
            using (var bitmap = new Bitmap(500, 500))
            {

                using (var g = Graphics.FromImage(bitmap))
                {

                    g.CopyFromScreen(new Point(0, 0), new Point(0, 0), new Size(500, 500));
                }

                img = (Image)(bitmap.Clone());
            }

            ScreenCastingForm.PictureBoxImage = img;
        }


        private void BtnCastArea_Click(object sender, EventArgs e)
        {

        }
    }
}
