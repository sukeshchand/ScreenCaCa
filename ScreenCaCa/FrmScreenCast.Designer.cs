namespace ScreenCaCa
{
    partial class FrmScreenCast
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
            this.btnFullScreen = new System.Windows.Forms.Button();
            this.picScreenCast = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picScreenCast)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFullScreen
            // 
            this.btnFullScreen.Location = new System.Drawing.Point(713, 415);
            this.btnFullScreen.Name = "btnFullScreen";
            this.btnFullScreen.Size = new System.Drawing.Size(75, 23);
            this.btnFullScreen.TabIndex = 0;
            this.btnFullScreen.Text = "Full screen";
            this.btnFullScreen.UseVisualStyleBackColor = true;
            // 
            // picScreenCast
            // 
            this.picScreenCast.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picScreenCast.Location = new System.Drawing.Point(0, 0);
            this.picScreenCast.Name = "picScreenCast";
            this.picScreenCast.Size = new System.Drawing.Size(800, 450);
            this.picScreenCast.TabIndex = 1;
            this.picScreenCast.TabStop = false;
            this.picScreenCast.Click += new System.EventHandler(this.PicScreenCast_Click);
            // 
            // FrmScreenCast
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFullScreen);
            this.Controls.Add(this.picScreenCast);
            this.Name = "FrmScreenCast";
            this.Text = "Screen cast";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmScreenCast_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.picScreenCast)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFullScreen;
        private System.Windows.Forms.PictureBox picScreenCast;
    }
}