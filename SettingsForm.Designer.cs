
namespace ProjectEcho
{
    partial class SettingsForm
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
            this.applyButton = new System.Windows.Forms.Button();
            this.textsizeLabel = new System.Windows.Forms.Label();
            this.textsizeAdjust = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.textsizeAdjust)).BeginInit();
            this.SuspendLayout();
            // 
            // applyButton
            // 
            this.applyButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applyButton.Location = new System.Drawing.Point(99, 152);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(95, 34);
            this.applyButton.TabIndex = 3;
            this.applyButton.Text = "APPLY";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // textsizeLabel
            // 
            this.textsizeLabel.AutoSize = true;
            this.textsizeLabel.BackColor = System.Drawing.Color.Transparent;
            this.textsizeLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textsizeLabel.Location = new System.Drawing.Point(95, 34);
            this.textsizeLabel.Name = "textsizeLabel";
            this.textsizeLabel.Size = new System.Drawing.Size(91, 23);
            this.textsizeLabel.TabIndex = 3;
            this.textsizeLabel.Text = "TEXT SIZE";
            // 
            // textsizeAdjust
            // 
            this.textsizeAdjust.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textsizeAdjust.Location = new System.Drawing.Point(23, 70);
            this.textsizeAdjust.Maximum = 6;
            this.textsizeAdjust.Name = "textsizeAdjust";
            this.textsizeAdjust.Size = new System.Drawing.Size(248, 56);
            this.textsizeAdjust.TabIndex = 4;
            this.textsizeAdjust.TabStop = false;
            this.textsizeAdjust.Scroll += new System.EventHandler(this.textsizeAdjust_Scroll);
            this.textsizeAdjust.ValueChanged += new System.EventHandler(this.textsizeAdjust_ValueChanged);
            // 
            // SettingsForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(293, 198);
            this.Controls.Add(this.textsizeLabel);
            this.Controls.Add(this.textsizeAdjust);
            this.Controls.Add(this.applyButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SettingsForm_FormClosed);
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textsizeAdjust)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.Label textsizeLabel;
        private System.Windows.Forms.TrackBar textsizeAdjust;
    }
}
