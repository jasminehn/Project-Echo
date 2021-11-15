
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.darkmodeLabel = new System.Windows.Forms.Label();
            this.boldnessLabel = new System.Windows.Forms.Label();
            this.textsizeLabel = new System.Windows.Forms.Label();
            this.applyButton = new System.Windows.Forms.Button();
            this.textsizeAdjust = new System.Windows.Forms.TrackBar();
            this.switchButton = new ProjectEcho.SwitchButton();
            this.boldnessToggle = new ProjectEcho.SwitchButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textsizeAdjust)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.textsizeAdjust);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.switchButton);
            this.panel1.Controls.Add(this.boldnessToggle);
            this.panel1.Controls.Add(this.darkmodeLabel);
            this.panel1.Controls.Add(this.boldnessLabel);
            this.panel1.Controls.Add(this.textsizeLabel);
            this.panel1.Location = new System.Drawing.Point(18, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 212);
            this.panel1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 28);
            this.label3.TabIndex = 31;
            this.label3.Text = "SETTINGS";
            // 
            // darkmodeLabel
            // 
            this.darkmodeLabel.AutoSize = true;
            this.darkmodeLabel.BackColor = System.Drawing.Color.Transparent;
            this.darkmodeLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.darkmodeLabel.Location = new System.Drawing.Point(24, 160);
            this.darkmodeLabel.Name = "darkmodeLabel";
            this.darkmodeLabel.Size = new System.Drawing.Size(118, 23);
            this.darkmodeLabel.TabIndex = 11;
            this.darkmodeLabel.Text = "Dark Mode";
            // 
            // boldnessLabel
            // 
            this.boldnessLabel.AutoSize = true;
            this.boldnessLabel.BackColor = System.Drawing.Color.Transparent;
            this.boldnessLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boldnessLabel.Location = new System.Drawing.Point(24, 100);
            this.boldnessLabel.Name = "boldnessLabel";
            this.boldnessLabel.Size = new System.Drawing.Size(94, 23);
            this.boldnessLabel.TabIndex = 9;
            this.boldnessLabel.Text = "Boldness";
            // 
            // textsizeLabel
            // 
            this.textsizeLabel.AutoSize = true;
            this.textsizeLabel.BackColor = System.Drawing.Color.Transparent;
            this.textsizeLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textsizeLabel.Location = new System.Drawing.Point(24, 42);
            this.textsizeLabel.Name = "textsizeLabel";
            this.textsizeLabel.Size = new System.Drawing.Size(89, 23);
            this.textsizeLabel.TabIndex = 3;
            this.textsizeLabel.Text = "Text Size";
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(126, 231);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(95, 34);
            this.applyButton.TabIndex = 3;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // textsizeAdjust
            // 
            this.textsizeAdjust.Location = new System.Drawing.Point(147, 38);
            this.textsizeAdjust.Name = "textsizeAdjust";
            this.textsizeAdjust.Size = new System.Drawing.Size(142, 56);
            this.textsizeAdjust.TabIndex = 4;
            this.textsizeAdjust.TabStop = false;
            this.textsizeAdjust.Scroll += new System.EventHandler(this.textsizeAdjust_Scroll);
            // 
            // switchButton
            // 
            this.switchButton.Location = new System.Drawing.Point(237, 161);
            this.switchButton.MinimumSize = new System.Drawing.Size(45, 22);
            this.switchButton.Name = "switchButton";
            this.switchButton.Size = new System.Drawing.Size(52, 22);
            this.switchButton.TabIndex = 29;
            this.switchButton.UseVisualStyleBackColor = true;
            this.switchButton.CheckedChanged += new System.EventHandler(this.switchButton_Click);
            // 
            // boldnessToggle
            // 
            this.boldnessToggle.Location = new System.Drawing.Point(237, 100);
            this.boldnessToggle.MinimumSize = new System.Drawing.Size(45, 22);
            this.boldnessToggle.Name = "boldnessToggle";
            this.boldnessToggle.Size = new System.Drawing.Size(52, 22);
            this.boldnessToggle.TabIndex = 23;
            this.boldnessToggle.UseVisualStyleBackColor = true;
            this.boldnessToggle.CheckedChanged += new System.EventHandler(this.boldnessToggle_CheckedChanged);
            // 
            // SettingsForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(347, 277);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textsizeAdjust)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private SwitchButton boldnessToggle;
        private SwitchButton switchButton;
        private System.Windows.Forms.Label darkmodeLabel;
        private System.Windows.Forms.Label boldnessLabel;
        private System.Windows.Forms.Label textsizeLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.TrackBar textsizeAdjust;
    }
}
