
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
            this.blueyellowToggle = new ProjectEcho.SwitchButton();
            this.redgreenToggle = new ProjectEcho.SwitchButton();
            this.invertedToggle = new ProjectEcho.SwitchButton();
            this.grayscaleToggle = new ProjectEcho.SwitchButton();
            this.boldnessToggle = new ProjectEcho.SwitchButton();
            this.switchButton1 = new ProjectEcho.SwitchButton();
            this.textsizeSelect = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SETTINGS = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textsizeSelect)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.blueyellowToggle);
            this.panel1.Controls.Add(this.redgreenToggle);
            this.panel1.Controls.Add(this.invertedToggle);
            this.panel1.Controls.Add(this.grayscaleToggle);
            this.panel1.Controls.Add(this.boldnessToggle);
            this.panel1.Controls.Add(this.switchButton1);
            this.panel1.Controls.Add(this.textsizeSelect);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(18, 33);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(386, 329);
            this.panel1.TabIndex = 2;
            // 
            // blueyellowToggle
            // 
            this.blueyellowToggle.Location = new System.Drawing.Point(304, 278);
            this.blueyellowToggle.MinimumSize = new System.Drawing.Size(45, 22);
            this.blueyellowToggle.Name = "blueyellowToggle";
            this.blueyellowToggle.Size = new System.Drawing.Size(52, 22);
            this.blueyellowToggle.TabIndex = 27;
            this.blueyellowToggle.UseVisualStyleBackColor = true;
            // 
            // redgreenToggle
            // 
            this.redgreenToggle.Location = new System.Drawing.Point(304, 165);
            this.redgreenToggle.MinimumSize = new System.Drawing.Size(45, 22);
            this.redgreenToggle.Name = "redgreenToggle";
            this.redgreenToggle.Size = new System.Drawing.Size(52, 22);
            this.redgreenToggle.TabIndex = 26;
            this.redgreenToggle.UseVisualStyleBackColor = true;
            // 
            // invertedToggle
            // 
            this.invertedToggle.Location = new System.Drawing.Point(304, 128);
            this.invertedToggle.MinimumSize = new System.Drawing.Size(45, 22);
            this.invertedToggle.Name = "invertedToggle";
            this.invertedToggle.Size = new System.Drawing.Size(52, 22);
            this.invertedToggle.TabIndex = 25;
            this.invertedToggle.UseVisualStyleBackColor = true;
            // 
            // grayscaleToggle
            // 
            this.grayscaleToggle.Location = new System.Drawing.Point(304, 239);
            this.grayscaleToggle.MinimumSize = new System.Drawing.Size(45, 22);
            this.grayscaleToggle.Name = "grayscaleToggle";
            this.grayscaleToggle.Size = new System.Drawing.Size(52, 22);
            this.grayscaleToggle.TabIndex = 24;
            this.grayscaleToggle.UseVisualStyleBackColor = true;
            // 
            // boldnessToggle
            // 
            this.boldnessToggle.Location = new System.Drawing.Point(304, 55);
            this.boldnessToggle.MinimumSize = new System.Drawing.Size(45, 22);
            this.boldnessToggle.Name = "boldnessToggle";
            this.boldnessToggle.Size = new System.Drawing.Size(52, 22);
            this.boldnessToggle.TabIndex = 23;
            this.boldnessToggle.UseVisualStyleBackColor = true;
            // 
            // switchButton1
            // 
            this.switchButton1.Location = new System.Drawing.Point(304, 202);
            this.switchButton1.MinimumSize = new System.Drawing.Size(45, 22);
            this.switchButton1.Name = "switchButton1";
            this.switchButton1.Size = new System.Drawing.Size(52, 22);
            this.switchButton1.TabIndex = 22;
            this.switchButton1.UseVisualStyleBackColor = true;
            // 
            // textsizeSelect
            // 
            this.textsizeSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textsizeSelect.Location = new System.Drawing.Point(283, 16);
            this.textsizeSelect.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.textsizeSelect.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.textsizeSelect.Name = "textsizeSelect";
            this.textsizeSelect.Size = new System.Drawing.Size(73, 23);
            this.textsizeSelect.TabIndex = 21;
            this.textsizeSelect.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textsizeSelect.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(25, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "RED-GREEN";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 282);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "BLUE-YELLOW";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "INVERTED";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "GRAY SCALE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "DARK MODE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "BOLDNESS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "COLOR ADJUSTMENT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "TEXT SIZE";
            // 
            // SETTINGS
            // 
            this.SETTINGS.AutoSize = true;
            this.SETTINGS.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SETTINGS.Location = new System.Drawing.Point(26, 10);
            this.SETTINGS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SETTINGS.Name = "SETTINGS";
            this.SETTINGS.Size = new System.Drawing.Size(76, 19);
            this.SETTINGS.TabIndex = 3;
            this.SETTINGS.Text = "SETTINGS";
            // 
            // SettingsForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(423, 372);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SETTINGS);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textsizeSelect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private SwitchButton blueyellowToggle;
        private SwitchButton redgreenToggle;
        private SwitchButton invertedToggle;
        private SwitchButton grayscaleToggle;
        private SwitchButton boldnessToggle;
        private SwitchButton switchButton1;
        private System.Windows.Forms.NumericUpDown textsizeSelect;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label SETTINGS;
    }
}
