﻿namespace ScreenCaCa
{
    partial class FrmHome
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
            this.btnCastFullScreen = new System.Windows.Forms.Button();
            this.btnCastArea = new System.Windows.Forms.Button();
            this.btnQuitApp = new System.Windows.Forms.Button();
            this.gbScreenCast = new System.Windows.Forms.GroupBox();
            this.btnPauseStartScreenCast = new System.Windows.Forms.Button();
            this.btnStopScreenCast = new System.Windows.Forms.Button();
            this.txtRefreshRate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbScreenCast.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCastFullScreen
            // 
            this.btnCastFullScreen.Location = new System.Drawing.Point(8, 32);
            this.btnCastFullScreen.Name = "btnCastFullScreen";
            this.btnCastFullScreen.Size = new System.Drawing.Size(119, 39);
            this.btnCastFullScreen.TabIndex = 0;
            this.btnCastFullScreen.Text = "Cast full screen";
            this.btnCastFullScreen.UseVisualStyleBackColor = true;
            this.btnCastFullScreen.Click += new System.EventHandler(this.BtnCastFullScreen_Click);
            // 
            // btnCastArea
            // 
            this.btnCastArea.Location = new System.Drawing.Point(156, 32);
            this.btnCastArea.Name = "btnCastArea";
            this.btnCastArea.Size = new System.Drawing.Size(119, 39);
            this.btnCastArea.TabIndex = 1;
            this.btnCastArea.Text = "Cast area";
            this.btnCastArea.UseVisualStyleBackColor = true;
            this.btnCastArea.Click += new System.EventHandler(this.BtnCastArea_Click);
            // 
            // btnQuitApp
            // 
            this.btnQuitApp.Location = new System.Drawing.Point(178, 280);
            this.btnQuitApp.Name = "btnQuitApp";
            this.btnQuitApp.Size = new System.Drawing.Size(119, 39);
            this.btnQuitApp.TabIndex = 2;
            this.btnQuitApp.Text = "Quit Screen Ca Ca";
            this.btnQuitApp.UseVisualStyleBackColor = true;
            // 
            // gbScreenCast
            // 
            this.gbScreenCast.Controls.Add(this.label1);
            this.gbScreenCast.Controls.Add(this.txtRefreshRate);
            this.gbScreenCast.Controls.Add(this.btnStopScreenCast);
            this.gbScreenCast.Controls.Add(this.btnPauseStartScreenCast);
            this.gbScreenCast.Controls.Add(this.btnCastArea);
            this.gbScreenCast.Controls.Add(this.btnCastFullScreen);
            this.gbScreenCast.Location = new System.Drawing.Point(12, 25);
            this.gbScreenCast.Name = "gbScreenCast";
            this.gbScreenCast.Size = new System.Drawing.Size(285, 249);
            this.gbScreenCast.TabIndex = 3;
            this.gbScreenCast.TabStop = false;
            this.gbScreenCast.Text = "Screen Cast";
            // 
            // btnPauseStartScreenCast
            // 
            this.btnPauseStartScreenCast.Location = new System.Drawing.Point(8, 96);
            this.btnPauseStartScreenCast.Name = "btnPauseStartScreenCast";
            this.btnPauseStartScreenCast.Size = new System.Drawing.Size(119, 39);
            this.btnPauseStartScreenCast.TabIndex = 2;
            this.btnPauseStartScreenCast.Text = "Pause screen cast";
            this.btnPauseStartScreenCast.UseVisualStyleBackColor = true;
            this.btnPauseStartScreenCast.Click += new System.EventHandler(this.BtnPauseStartScreenCast_Click);
            // 
            // btnStopScreenCast
            // 
            this.btnStopScreenCast.Location = new System.Drawing.Point(156, 96);
            this.btnStopScreenCast.Name = "btnStopScreenCast";
            this.btnStopScreenCast.Size = new System.Drawing.Size(119, 39);
            this.btnStopScreenCast.TabIndex = 3;
            this.btnStopScreenCast.Text = "Stop screen cast";
            this.btnStopScreenCast.UseVisualStyleBackColor = true;
            // 
            // txtRefreshRate
            // 
            this.txtRefreshRate.Location = new System.Drawing.Point(114, 157);
            this.txtRefreshRate.MaxLength = 2;
            this.txtRefreshRate.Name = "txtRefreshRate";
            this.txtRefreshRate.Size = new System.Drawing.Size(84, 20);
            this.txtRefreshRate.TabIndex = 4;
            this.txtRefreshRate.Text = "10";
            this.txtRefreshRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Refresh rate /sec";
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 325);
            this.Controls.Add(this.gbScreenCast);
            this.Controls.Add(this.btnQuitApp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Screen Ca Ca";
            this.Load += new System.EventHandler(this.FrmHome_Load);
            this.gbScreenCast.ResumeLayout(false);
            this.gbScreenCast.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCastFullScreen;
        private System.Windows.Forms.Button btnCastArea;
        private System.Windows.Forms.Button btnQuitApp;
        private System.Windows.Forms.GroupBox gbScreenCast;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRefreshRate;
        private System.Windows.Forms.Button btnStopScreenCast;
        private System.Windows.Forms.Button btnPauseStartScreenCast;
    }
}