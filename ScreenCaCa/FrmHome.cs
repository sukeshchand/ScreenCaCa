using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Toy.Extensions.Extensions;
namespace ScreenCaCa
{
    public partial class FrmHome : Form
    {
        private const int DefaultRefreshCastInMilliseconds = 200; // refresh in every 200 milliseconds by default
        public FrmScreenCast ScreenCastingForm { get; set; }
        private Thread threadScreenTast;
        public int GetCastRefreshDuration()
        {
            var refreshRate = txtRefreshRate.Text.ToInt();
            if (refreshRate == null)
            {
                return DefaultRefreshCastInMilliseconds;
            }

            refreshRate = 1000 / refreshRate;
            if (refreshRate > 1000 || refreshRate < 50)
            {
                return DefaultRefreshCastInMilliseconds;
            }

            return (int)refreshRate;
        }

        public bool IsScreenCastRunning { get; set; }
        public bool IsScreenCastPaused { get; set; }

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
            }
            catch (Exception)
            {
                // todo log
            }
        }

        private void btnPauseStartScreenCast_Click(object sender, EventArgs e)
        {
            try
            {
                IsScreenCastPaused = !IsScreenCastPaused;
                RefreshCastPauseStartStopButtons();
                Application.DoEvents();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }

        private void BtnCastFullScreen_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    threadScreenTast = new Thread(ScreenCastTask);
                    threadScreenTast.Start();
                    RefreshCastPauseStartStopButtons();
                    Application.DoEvents();
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

        public void RefreshCastPauseStartStopButtons()
        {
            try
            {

                if (IsScreenCastRunning)
                {
                    btnPauseStartScreenCast.Invoke(new Action(() =>
                    {
                        btnPauseStartScreenCast.Visible = true;
                        btnPauseStartScreenCast.Text = IsScreenCastPaused ? "Paused, click to Resume" : "Running, click to Pause";
                    }));

                    btnStopScreenCast.Invoke(new Action(() =>
                    {
                        btnStopScreenCast.Visible = true;
                    }));
                }
                else
                {
                    btnPauseStartScreenCast.Invoke(new Action(() =>
                    {
                        btnPauseStartScreenCast.Visible = false;
                    }));
                    btnStopScreenCast.Invoke(new Action(() =>
                    {
                        btnStopScreenCast.Visible = false;
                    }));
                }
            }
            catch (Exception)
            {
            }

        }

        public void ScreenCastTask()
        {
            if (IsScreenCastRunning)
            {
                return;
            }

            if (ScreenCastingForm != null)
            {
                ScreenCastingForm = null;
            }

            ScreenCastingForm = new FrmScreenCast();
            ScreenCastingForm.FormClosed += (sender, args) =>
            {
                IsScreenCastRunning = false;
                RefreshCastPauseStartStopButtons();
            };

            IsScreenCastRunning = true;
            IsScreenCastPaused = false;
            RefreshCastPauseStartStopButtons();
            ScreenCastingForm.Show();

            while (true)
            {
                if (!IsScreenCastRunning)
                {
                    break;
                }
                try
                {
                    if (!IsScreenCastPaused)
                    {
                        CaptureAndCastScreen();
                    }
                    else
                    {
                        ScreenCastingForm.RefreshCast();
                    }
                }
                catch (Exception)
                {
                }
                Thread.Sleep(GetCastRefreshDuration());
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

        private void RbZoom_CheckedChanged(object sender, EventArgs e)
        {
            ImageSizeModeChanged();
        }

        private void ImageSizeModeChanged()
        {
            if (ScreenCastingForm == null)
            {
                return;
            }

            if (rbCenter.Checked)
            {
                ScreenCastingForm.PictureBoxImageSizeMode = PictureBoxSizeMode.CenterImage;
            }
            else if (rbNormal.Checked)
            {
                ScreenCastingForm.PictureBoxImageSizeMode = PictureBoxSizeMode.Normal;
            }
            else if (rbStretch.Checked)
            {
                ScreenCastingForm.PictureBoxImageSizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (rbZoom.Checked)
            {
                ScreenCastingForm.PictureBoxImageSizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void RbCenter_CheckedChanged(object sender, EventArgs e)
        {
            ImageSizeModeChanged();
        }

        private void RbStretch_CheckedChanged(object sender, EventArgs e)
        {
            ImageSizeModeChanged();
        }

        private void RbNormal_CheckedChanged(object sender, EventArgs e)
        {
            ImageSizeModeChanged();
        }

        private void btnStopScreenCast_Click(object sender, EventArgs e)
        {
            try
            {
                IsScreenCastRunning = false;
                RefreshCastPauseStartStopButtons();

            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }
    }
}
