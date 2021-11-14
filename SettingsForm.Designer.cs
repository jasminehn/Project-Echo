
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
            this.label1 = new System.Windows.Forms.Label();
            this.switchButton = new ProjectEcho.SwitchButton();
            this.boldnessToggle = new ProjectEcho.SwitchButton();
            this.textsizeSelect = new System.Windows.Forms.NumericUpDown();
            this.darkmodeLabel = new System.Windows.Forms.Label();
            this.boldnessLabel = new System.Windows.Forms.Label();
            this.textsizeLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textsizeSelect)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.switchButton);
            this.panel1.Controls.Add(this.boldnessToggle);
            this.panel1.Controls.Add(this.textsizeSelect);
            this.panel1.Controls.Add(this.darkmodeLabel);
            this.panel1.Controls.Add(this.boldnessLabel);
            this.panel1.Controls.Add(this.textsizeLabel);
            this.panel1.Location = new System.Drawing.Point(18, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 212);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(214, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 25);
            this.label1.TabIndex = 30;
            this.label1.Text = "+";
            // 
            // switchButton
            // 
            this.switchButton.Location = new System.Drawing.Point(236, 156);
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
            // textsizeSelect
            // 
            this.textsizeSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textsizeSelect.Location = new System.Drawing.Point(237, 41);
            this.textsizeSelect.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.textsizeSelect.Name = "textsizeSelect";
            this.textsizeSelect.Size = new System.Drawing.Size(52, 27);
            this.textsizeSelect.TabIndex = 21;
            this.textsizeSelect.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textsizeSelect.ValueChanged += new System.EventHandler(this.textsizeSelect_ValueChanged);
            // 
            // darkmodeLabel
            // 
            this.darkmodeLabel.AutoSize = true;
            this.darkmodeLabel.BackColor = System.Drawing.Color.Transparent;
            this.darkmodeLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.darkmodeLabel.Location = new System.Drawing.Point(24, 161);
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
            // SettingsForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(347, 231);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textsizeSelect)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private SwitchButton boldnessToggle;
        private SwitchButton switchButton;
        private System.Windows.Forms.NumericUpDown textsizeSelect;
        private System.Windows.Forms.Label darkmodeLabel;
        private System.Windows.Forms.Label boldnessLabel;
        private System.Windows.Forms.Label textsizeLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}
