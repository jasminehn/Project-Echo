
namespace ProjectEcho
{
    partial class TaskOneGuide
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.videoPlayerControl1 = new ProjectEcho.VideoPlayerControl();
            this.videoPlayerControl2 = new ProjectEcho.VideoPlayerControl();
            this.SuspendLayout();
            // 
            // videoPlayerControl1
            // 
            this.videoPlayerControl1.BackColor = System.Drawing.Color.MidnightBlue;
            this.videoPlayerControl1.ForeColor = System.Drawing.Color.Lavender;
            this.videoPlayerControl1.Location = new System.Drawing.Point(644, 12);
            this.videoPlayerControl1.Name = "videoPlayerControl1";
            this.videoPlayerControl1.Size = new System.Drawing.Size(591, 512);
            this.videoPlayerControl1.TabIndex = 5;
            // 
            // videoPlayerControl2
            // 
            this.videoPlayerControl2.BackColor = System.Drawing.Color.MidnightBlue;
            this.videoPlayerControl2.ForeColor = System.Drawing.Color.Lavender;
            this.videoPlayerControl2.Location = new System.Drawing.Point(328, 43);
            this.videoPlayerControl2.Name = "videoPlayerControl2";
            this.videoPlayerControl2.Size = new System.Drawing.Size(591, 492);
            this.videoPlayerControl2.TabIndex = 5;
            // 
            // TaskOneGuide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1247, 577);
            this.Controls.Add(this.videoPlayerControl2);
            this.Name = "TaskOneGuide";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.TaskOneGuide_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private VideoPlayerControl videoPlayerControl1;
        private VideoPlayerControl videoPlayerControl2;
    }
}