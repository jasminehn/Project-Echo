using System.IO;
namespace ProjectEcho
{
    partial class VideoPlayerControl
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
            if(disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VideoPlayerControl));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.vlcControl1 = new Vlc.DotNet.Forms.VlcControl();
            this.timePositionBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.volumeBar = new XComponent.SliderBar.MACTrackBar();
            this.playPauseButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.vlcControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timePositionBar)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 518);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(717, 20);
            this.textBox1.TabIndex = 9;
            // 
            // vlcControl1
            // 
            this.vlcControl1.BackColor = System.Drawing.Color.Black;
            this.vlcControl1.Location = new System.Drawing.Point(3, 3);
            this.vlcControl1.Name = "vlcControl1";
            this.vlcControl1.Size = new System.Drawing.Size(718, 426);
            this.vlcControl1.Spu = -1;
            this.vlcControl1.TabIndex = 5;
            this.vlcControl1.Text = "vlcControl1";
            this.vlcControl1.VlcLibDirectory = ((System.IO.DirectoryInfo)(resources.GetObject("vlcControl1.VlcLibDirectory")));
            this.vlcControl1.VlcMediaplayerOptions = null;
            // 
            // timePositionBar
            // 
            this.timePositionBar.Location = new System.Drawing.Point(3, 437);
            this.timePositionBar.Name = "timePositionBar";
            this.timePositionBar.Size = new System.Drawing.Size(668, 45);
            this.timePositionBar.TabIndex = 10;
            this.timePositionBar.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(677, 437);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "00:00";
            // 
            // volumeBar
            // 
            this.volumeBar.BackColor = System.Drawing.Color.Transparent;
            this.volumeBar.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.volumeBar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volumeBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.volumeBar.IndentHeight = 6;
            this.volumeBar.Location = new System.Drawing.Point(401, 468);
            this.volumeBar.Maximum = 10;
            this.volumeBar.Minimum = 0;
            this.volumeBar.Name = "volumeBar";
            this.volumeBar.Size = new System.Drawing.Size(141, 28);
            this.volumeBar.TabIndex = 12;
            this.volumeBar.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.volumeBar.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(146)))), ((int)(((byte)(148)))));
            this.volumeBar.TickHeight = 4;
            this.volumeBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.volumeBar.TrackerColor = System.Drawing.Color.MidnightBlue;
            this.volumeBar.TrackerSize = new System.Drawing.Size(16, 16);
            this.volumeBar.TrackLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.volumeBar.TrackLineHeight = 3;
            this.volumeBar.TrackLineSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.volumeBar.Value = 0;
            // 
            // playPauseButton
            // 
            this.playPauseButton.FlatAppearance.BorderSize = 0;
            this.playPauseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playPauseButton.Image = global::ProjectEcho.Properties.Resources.playButtonImage;
            this.playPauseButton.Location = new System.Drawing.Point(329, 453);
            this.playPauseButton.Name = "playPauseButton";
            this.playPauseButton.Size = new System.Drawing.Size(66, 59);
            this.playPauseButton.TabIndex = 7;
            this.playPauseButton.UseVisualStyleBackColor = true;
            this.playPauseButton.Click += new System.EventHandler(this.playPauseButton_Click);
            // 
            // VideoPlayerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.volumeBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.playPauseButton);
            this.Controls.Add(this.vlcControl1);
            this.Controls.Add(this.timePositionBar);
            this.Name = "VideoPlayerControl";
            this.Size = new System.Drawing.Size(723, 541);
            //vlcControl1.VlcLibDirectory = new DirectoryInfo("C:\\Users\\365ye\\OneDrive\\Desktop\\libvlc\\win-x32");
            vlcControl1.VlcLibDirectory = new DirectoryInfo("C:\\Users\\365ye\\OneDrive\\Documents\\GitHub\\Project-Echo\\libvlc\\win-x32");
            ((System.ComponentModel.ISupportInitialize)(this.vlcControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timePositionBar)).EndInit();

            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button playPauseButton;
        private Vlc.DotNet.Forms.VlcControl vlcControl1;
        private System.Windows.Forms.TrackBar timePositionBar;
        private System.Windows.Forms.Label label1;
        private XComponent.SliderBar.MACTrackBar volumeBar;
    }
}
