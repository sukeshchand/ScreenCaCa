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
            this.chkShowCurser = new System.Windows.Forms.CheckBox();
            this.btnPauseStartScreenCast = new System.Windows.Forms.Button();
            this.btnStopScreenCast = new System.Windows.Forms.Button();
            this.rbZoom = new System.Windows.Forms.RadioButton();
            this.rbNormal = new System.Windows.Forms.RadioButton();
            this.rbStretch = new System.Windows.Forms.RadioButton();
            this.rbCenter = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRefreshRate = new System.Windows.Forms.TextBox();
            this.lblXY = new System.Windows.Forms.Label();
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
            this.btnQuitApp.Location = new System.Drawing.Point(244, 199);
            this.btnQuitApp.Name = "btnQuitApp";
            this.btnQuitApp.Size = new System.Drawing.Size(53, 21);
            this.btnQuitApp.TabIndex = 2;
            this.btnQuitApp.Text = "Quit Screen Ca Ca";
            this.btnQuitApp.UseVisualStyleBackColor = true;
            this.btnQuitApp.Click += new System.EventHandler(this.BtnQuitApp_Click);
            // 
            // gbScreenCast
            // 
            this.gbScreenCast.Controls.Add(this.chkShowCurser);
            this.gbScreenCast.Controls.Add(this.btnPauseStartScreenCast);
            this.gbScreenCast.Controls.Add(this.btnStopScreenCast);
            this.gbScreenCast.Controls.Add(this.rbZoom);
            this.gbScreenCast.Controls.Add(this.rbNormal);
            this.gbScreenCast.Controls.Add(this.rbStretch);
            this.gbScreenCast.Controls.Add(this.rbCenter);
            this.gbScreenCast.Controls.Add(this.label1);
            this.gbScreenCast.Controls.Add(this.txtRefreshRate);
            this.gbScreenCast.Controls.Add(this.btnCastArea);
            this.gbScreenCast.Controls.Add(this.btnCastFullScreen);
            this.gbScreenCast.Location = new System.Drawing.Point(12, 12);
            this.gbScreenCast.Name = "gbScreenCast";
            this.gbScreenCast.Size = new System.Drawing.Size(285, 185);
            this.gbScreenCast.TabIndex = 3;
            this.gbScreenCast.TabStop = false;
            this.gbScreenCast.Text = "Screen Cast";
            // 
            // chkShowCurser
            // 
            this.chkShowCurser.AutoSize = true;
            this.chkShowCurser.Checked = true;
            this.chkShowCurser.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShowCurser.Location = new System.Drawing.Point(198, 129);
            this.chkShowCurser.Name = "chkShowCurser";
            this.chkShowCurser.Size = new System.Drawing.Size(85, 17);
            this.chkShowCurser.TabIndex = 13;
            this.chkShowCurser.Text = "Show cursor";
            this.chkShowCurser.UseVisualStyleBackColor = true;
            this.chkShowCurser.CheckedChanged += new System.EventHandler(this.ChkShowCurser_CheckedChanged);
            // 
            // btnPauseStartScreenCast
            // 
            this.btnPauseStartScreenCast.Location = new System.Drawing.Point(8, 77);
            this.btnPauseStartScreenCast.Name = "btnPauseStartScreenCast";
            this.btnPauseStartScreenCast.Size = new System.Drawing.Size(119, 39);
            this.btnPauseStartScreenCast.TabIndex = 12;
            this.btnPauseStartScreenCast.UseVisualStyleBackColor = true;
            this.btnPauseStartScreenCast.Visible = false;
            this.btnPauseStartScreenCast.Click += new System.EventHandler(this.btnPauseStartScreenCast_Click);
            // 
            // btnStopScreenCast
            // 
            this.btnStopScreenCast.Location = new System.Drawing.Point(156, 77);
            this.btnStopScreenCast.Name = "btnStopScreenCast";
            this.btnStopScreenCast.Size = new System.Drawing.Size(119, 39);
            this.btnStopScreenCast.TabIndex = 11;
            this.btnStopScreenCast.Text = "Stop screen cast";
            this.btnStopScreenCast.UseVisualStyleBackColor = true;
            this.btnStopScreenCast.Visible = false;
            this.btnStopScreenCast.Click += new System.EventHandler(this.btnStopScreenCast_Click);
            // 
            // rbZoom
            // 
            this.rbZoom.AutoSize = true;
            this.rbZoom.Checked = true;
            this.rbZoom.Location = new System.Drawing.Point(199, 154);
            this.rbZoom.Name = "rbZoom";
            this.rbZoom.Size = new System.Drawing.Size(52, 17);
            this.rbZoom.TabIndex = 10;
            this.rbZoom.TabStop = true;
            this.rbZoom.Text = "Zoom";
            this.rbZoom.UseVisualStyleBackColor = true;
            this.rbZoom.CheckedChanged += new System.EventHandler(this.RbZoom_CheckedChanged);
            // 
            // rbNormal
            // 
            this.rbNormal.AutoSize = true;
            this.rbNormal.Location = new System.Drawing.Point(135, 154);
            this.rbNormal.Name = "rbNormal";
            this.rbNormal.Size = new System.Drawing.Size(58, 17);
            this.rbNormal.TabIndex = 9;
            this.rbNormal.Text = "Normal";
            this.rbNormal.UseVisualStyleBackColor = true;
            this.rbNormal.CheckedChanged += new System.EventHandler(this.RbNormal_CheckedChanged);
            // 
            // rbStretch
            // 
            this.rbStretch.AutoSize = true;
            this.rbStretch.Location = new System.Drawing.Point(70, 154);
            this.rbStretch.Name = "rbStretch";
            this.rbStretch.Size = new System.Drawing.Size(59, 17);
            this.rbStretch.TabIndex = 8;
            this.rbStretch.Text = "Stretch";
            this.rbStretch.UseVisualStyleBackColor = true;
            this.rbStretch.CheckedChanged += new System.EventHandler(this.RbStretch_CheckedChanged);
            // 
            // rbCenter
            // 
            this.rbCenter.AutoSize = true;
            this.rbCenter.Location = new System.Drawing.Point(8, 154);
            this.rbCenter.Name = "rbCenter";
            this.rbCenter.Size = new System.Drawing.Size(56, 17);
            this.rbCenter.TabIndex = 7;
            this.rbCenter.Text = "Center";
            this.rbCenter.UseVisualStyleBackColor = true;
            this.rbCenter.CheckedChanged += new System.EventHandler(this.RbCenter_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Refresh rate /sec";
            // 
            // txtRefreshRate
            // 
            this.txtRefreshRate.Location = new System.Drawing.Point(111, 126);
            this.txtRefreshRate.MaxLength = 2;
            this.txtRefreshRate.Name = "txtRefreshRate";
            this.txtRefreshRate.Size = new System.Drawing.Size(84, 20);
            this.txtRefreshRate.TabIndex = 4;
            this.txtRefreshRate.Text = "10";
            this.txtRefreshRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblXY
            // 
            this.lblXY.AutoSize = true;
            this.lblXY.Location = new System.Drawing.Point(320, 235);
            this.lblXY.Name = "lblXY";
            this.lblXY.Size = new System.Drawing.Size(27, 13);
            this.lblXY.TabIndex = 13;
            this.lblXY.Text = "XY: ";
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 224);
            this.Controls.Add(this.lblXY);
            this.Controls.Add(this.gbScreenCast);
            this.Controls.Add(this.btnQuitApp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Screen Ca Ca";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmHome_FormClosing);
            this.Load += new System.EventHandler(this.FrmHome_Load);
            this.gbScreenCast.ResumeLayout(false);
            this.gbScreenCast.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCastFullScreen;
        private System.Windows.Forms.Button btnCastArea;
        private System.Windows.Forms.Button btnQuitApp;
        private System.Windows.Forms.GroupBox gbScreenCast;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRefreshRate;
        private System.Windows.Forms.RadioButton rbCenter;
        private System.Windows.Forms.RadioButton rbNormal;
        private System.Windows.Forms.RadioButton rbStretch;
        private System.Windows.Forms.RadioButton rbZoom;
        private System.Windows.Forms.Button btnPauseStartScreenCast;
        private System.Windows.Forms.Button btnStopScreenCast;
        private System.Windows.Forms.Label lblXY;
        private System.Windows.Forms.CheckBox chkShowCurser;
    }
}