
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
            this.textsizeSelect = new System.Windows.Forms.NumericUpDown();
            this.redgreenLabel = new System.Windows.Forms.Label();
            this.invertedLabel = new System.Windows.Forms.Label();
            this.grayscaleLabel = new System.Windows.Forms.Label();
            this.darkmodeLabel = new System.Windows.Forms.Label();
            this.boldnessLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textsizeLabel = new System.Windows.Forms.Label();
            this.SETTINGS = new System.Windows.Forms.Label();
            this.blueyellowLabel = new System.Windows.Forms.Label();
            this.darkmodeToggle = new ProjectEcho.SwitchButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textsizeSelect)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.darkmodeToggle);
            this.panel1.Controls.Add(this.blueyellowLabel);
            this.panel1.Controls.Add(this.blueyellowToggle);
            this.panel1.Controls.Add(this.redgreenToggle);
            this.panel1.Controls.Add(this.invertedToggle);
            this.panel1.Controls.Add(this.grayscaleToggle);
            this.panel1.Controls.Add(this.boldnessToggle);
            this.panel1.Controls.Add(this.textsizeSelect);
            this.panel1.Controls.Add(this.redgreenLabel);
            this.panel1.Controls.Add(this.invertedLabel);
            this.panel1.Controls.Add(this.grayscaleLabel);
            this.panel1.Controls.Add(this.darkmodeLabel);
            this.panel1.Controls.Add(this.boldnessLabel);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textsizeLabel);
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
            this.blueyellowToggle.CheckedChanged += new System.EventHandler(this.blueyellowToggle_CheckedChanged);
            // 
            // redgreenToggle
            // 
            this.redgreenToggle.Location = new System.Drawing.Point(304, 165);
            this.redgreenToggle.MinimumSize = new System.Drawing.Size(45, 22);
            this.redgreenToggle.Name = "redgreenToggle";
            this.redgreenToggle.Size = new System.Drawing.Size(52, 22);
            this.redgreenToggle.TabIndex = 26;
            this.redgreenToggle.UseVisualStyleBackColor = true;
            this.redgreenToggle.CheckedChanged += new System.EventHandler(this.redgreenToggle_CheckedChanged);
            // 
            // invertedToggle
            // 
            this.invertedToggle.Location = new System.Drawing.Point(304, 128);
            this.invertedToggle.MinimumSize = new System.Drawing.Size(45, 22);
            this.invertedToggle.Name = "invertedToggle";
            this.invertedToggle.Size = new System.Drawing.Size(52, 22);
            this.invertedToggle.TabIndex = 25;
            this.invertedToggle.UseVisualStyleBackColor = true;
            this.invertedToggle.CheckedChanged += new System.EventHandler(this.invertedToggle_CheckedChanged);
            // 
            // grayscaleToggle
            // 
            this.grayscaleToggle.Location = new System.Drawing.Point(304, 239);
            this.grayscaleToggle.MinimumSize = new System.Drawing.Size(45, 22);
            this.grayscaleToggle.Name = "grayscaleToggle";
            this.grayscaleToggle.Size = new System.Drawing.Size(52, 22);
            this.grayscaleToggle.TabIndex = 24;
            this.grayscaleToggle.UseVisualStyleBackColor = true;
            this.grayscaleToggle.CheckedChanged += new System.EventHandler(this.grayscaleToggle_CheckedChanged);
            // 
            // boldnessToggle
            // 
            this.boldnessToggle.Location = new System.Drawing.Point(304, 55);
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
            this.textsizeSelect.ValueChanged += new System.EventHandler(this.textsizeSelect_ValueChanged);
            // 
            // redgreenLabel
            // 
            this.redgreenLabel.AutoSize = true;
            this.redgreenLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redgreenLabel.Location = new System.Drawing.Point(25, 169);
            this.redgreenLabel.Name = "redgreenLabel";
            this.redgreenLabel.Size = new System.Drawing.Size(99, 18);
            this.redgreenLabel.TabIndex = 18;
            this.redgreenLabel.Text = "RED-GREEN";
            // 
            // invertedLabel
            // 
            this.invertedLabel.AutoSize = true;
            this.invertedLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invertedLabel.Location = new System.Drawing.Point(25, 132);
            this.invertedLabel.Name = "invertedLabel";
            this.invertedLabel.Size = new System.Drawing.Size(82, 18);
            this.invertedLabel.TabIndex = 15;
            this.invertedLabel.Text = "INVERTED";
            // 
            // grayscaleLabel
            // 
            this.grayscaleLabel.AutoSize = true;
            this.grayscaleLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grayscaleLabel.Location = new System.Drawing.Point(25, 243);
            this.grayscaleLabel.Name = "grayscaleLabel";
            this.grayscaleLabel.Size = new System.Drawing.Size(101, 18);
            this.grayscaleLabel.TabIndex = 13;
            this.grayscaleLabel.Text = "GRAY SCALE";
            // 
            // darkmodeLabel
            // 
            this.darkmodeLabel.AutoSize = true;
            this.darkmodeLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.darkmodeLabel.Location = new System.Drawing.Point(25, 206);
            this.darkmodeLabel.Name = "darkmodeLabel";
            this.darkmodeLabel.Size = new System.Drawing.Size(99, 18);
            this.darkmodeLabel.TabIndex = 11;
            this.darkmodeLabel.Text = "DARK MODE";
            // 
            // boldnessLabel
            // 
            this.boldnessLabel.AutoSize = true;
            this.boldnessLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boldnessLabel.Location = new System.Drawing.Point(24, 54);
            this.boldnessLabel.Name = "boldnessLabel";
            this.boldnessLabel.Size = new System.Drawing.Size(90, 18);
            this.boldnessLabel.TabIndex = 9;
            this.boldnessLabel.Text = "BOLDNESS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "COLOR ADJUSTMENT";
            // 
            // textsizeLabel
            // 
            this.textsizeLabel.AutoSize = true;
            this.textsizeLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textsizeLabel.Location = new System.Drawing.Point(24, 16);
            this.textsizeLabel.Name = "textsizeLabel";
            this.textsizeLabel.Size = new System.Drawing.Size(82, 18);
            this.textsizeLabel.TabIndex = 3;
            this.textsizeLabel.Text = "TEXT SIZE";
            // 
            // SETTINGS
            // 
            this.SETTINGS.AutoSize = true;
            this.SETTINGS.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SETTINGS.Location = new System.Drawing.Point(26, 10);
            this.SETTINGS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SETTINGS.Name = "SETTINGS";
            this.SETTINGS.Size = new System.Drawing.Size(97, 20);
            this.SETTINGS.TabIndex = 3;
            this.SETTINGS.Text = "SETTINGS";
            // 
            // blueyellowLabel
            // 
            this.blueyellowLabel.AutoSize = true;
            this.blueyellowLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blueyellowLabel.Location = new System.Drawing.Point(25, 282);
            this.blueyellowLabel.Name = "blueyellowLabel";
            this.blueyellowLabel.Size = new System.Drawing.Size(114, 18);
            this.blueyellowLabel.TabIndex = 28;
            this.blueyellowLabel.Text = "BLUE-YELLOW";
            // 
            // darkmodeToggle
            // 
            this.darkmodeToggle.Location = new System.Drawing.Point(304, 202);
            this.darkmodeToggle.MinimumSize = new System.Drawing.Size(45, 22);
            this.darkmodeToggle.Name = "darkmodeToggle";
            this.darkmodeToggle.Size = new System.Drawing.Size(52, 22);
            this.darkmodeToggle.TabIndex = 29;
            this.darkmodeToggle.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(423, 372);
            this.Controls.Add(this.SETTINGS);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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

        private SwitchButton blueyellowToggle;
        private System.Windows.Forms.Label SETTINGS;
        private SwitchButton redgreenToggle;
        private SwitchButton invertedToggle;
        private SwitchButton grayscaleToggle;
        private SwitchButton boldnessToggle;
        private SwitchButton darkmodeToggle;
        private System.Windows.Forms.NumericUpDown textsizeSelect;
        private System.Windows.Forms.Label redgreenLabel;
        private System.Windows.Forms.Label invertedLabel;
        private System.Windows.Forms.Label grayscaleLabel;
        private System.Windows.Forms.Label darkmodeLabel;
        private System.Windows.Forms.Label boldnessLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label textsizeLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label blueyellowLabel;
    }
}
