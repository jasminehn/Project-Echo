
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
            this.SETTINGS = new System.Windows.Forms.Label();
            this.textsizeSelect = new System.Windows.Forms.NumericUpDown();
            this.boldSwitch = new System.Windows.Forms.Button();
            this.redgreenSwitch = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.blueyellowSwitch = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grayscaleSwitch = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.invertedSwitch = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.darkModeSwitch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.darkModeSwitch1 = new ProjectEcho.ToggleControls();
            this.boldSwitch1 = new ProjectEcho.ToggleControls();
            this.toggleControls1 = new ProjectEcho.ToggleControls();
            this.toggleControls2 = new ProjectEcho.ToggleControls();
            this.toggleControls3 = new ProjectEcho.ToggleControls();
            this.toggleControls4 = new ProjectEcho.ToggleControls();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textsizeSelect)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.toggleControls4);
            this.panel1.Controls.Add(this.toggleControls3);
            this.panel1.Controls.Add(this.toggleControls2);
            this.panel1.Controls.Add(this.toggleControls1);
            this.panel1.Controls.Add(this.boldSwitch1);
            this.panel1.Controls.Add(this.darkModeSwitch1);
            this.panel1.Controls.Add(this.SETTINGS);
            this.panel1.Controls.Add(this.textsizeSelect);
            this.panel1.Controls.Add(this.boldSwitch);
            this.panel1.Controls.Add(this.redgreenSwitch);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.blueyellowSwitch);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.grayscaleSwitch);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.invertedSwitch);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.darkModeSwitch);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(16, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(386, 421);
            this.panel1.TabIndex = 0;
            // 
            // SETTINGS
            // 
            this.SETTINGS.AutoSize = true;
            this.SETTINGS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SETTINGS.Location = new System.Drawing.Point(143, 8);
            this.SETTINGS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SETTINGS.Name = "SETTINGS";
            this.SETTINGS.Size = new System.Drawing.Size(97, 20);
            this.SETTINGS.TabIndex = 1;
            this.SETTINGS.Text = "SETTINGS";
            // 
            // textsizeSelect
            // 
            this.textsizeSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textsizeSelect.Location = new System.Drawing.Point(35, 172);
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
            this.textsizeSelect.Size = new System.Drawing.Size(85, 23);
            this.textsizeSelect.TabIndex = 21;
            this.textsizeSelect.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textsizeSelect.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.textsizeSelect.ValueChanged += new System.EventHandler(this.textsizeSelect_SelectedItemChanged);
            // 
            // boldSwitch
            // 
            this.boldSwitch.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.boldSwitch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boldSwitch.Location = new System.Drawing.Point(213, 163);
            this.boldSwitch.Name = "boldSwitch";
            this.boldSwitch.Size = new System.Drawing.Size(50, 30);
            this.boldSwitch.TabIndex = 20;
            this.boldSwitch.UseVisualStyleBackColor = false;
            this.boldSwitch.Click += new System.EventHandler(this.boldSwitch_Click);
            // 
            // redgreenSwitch
            // 
            this.redgreenSwitch.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.redgreenSwitch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.redgreenSwitch.Location = new System.Drawing.Point(29, 356);
            this.redgreenSwitch.Name = "redgreenSwitch";
            this.redgreenSwitch.Size = new System.Drawing.Size(50, 30);
            this.redgreenSwitch.TabIndex = 19;
            this.redgreenSwitch.UseVisualStyleBackColor = false;
            this.redgreenSwitch.Click += new System.EventHandler(this.redgreenSwitch_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(85, 359);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 18);
            this.label8.TabIndex = 18;
            this.label8.Text = "Red-Green";
            // 
            // blueyellowSwitch
            // 
            this.blueyellowSwitch.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.blueyellowSwitch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.blueyellowSwitch.Location = new System.Drawing.Point(214, 356);
            this.blueyellowSwitch.Name = "blueyellowSwitch";
            this.blueyellowSwitch.Size = new System.Drawing.Size(50, 30);
            this.blueyellowSwitch.TabIndex = 17;
            this.blueyellowSwitch.UseVisualStyleBackColor = false;
            this.blueyellowSwitch.Click += new System.EventHandler(this.blueyellowSwitch_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(270, 359);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 18);
            this.label7.TabIndex = 16;
            this.label7.Text = "Blue-Yellow";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(85, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "Inverted";
            // 
            // grayscaleSwitch
            // 
            this.grayscaleSwitch.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grayscaleSwitch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grayscaleSwitch.Location = new System.Drawing.Point(214, 293);
            this.grayscaleSwitch.Name = "grayscaleSwitch";
            this.grayscaleSwitch.Size = new System.Drawing.Size(50, 30);
            this.grayscaleSwitch.TabIndex = 14;
            this.grayscaleSwitch.UseVisualStyleBackColor = false;
            this.grayscaleSwitch.Click += new System.EventHandler(this.grayscaleSwitch_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(270, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "Gray Scale";
            // 
            // invertedSwitch
            // 
            this.invertedSwitch.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.invertedSwitch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.invertedSwitch.Location = new System.Drawing.Point(29, 293);
            this.invertedSwitch.Name = "invertedSwitch";
            this.invertedSwitch.Size = new System.Drawing.Size(50, 30);
            this.invertedSwitch.TabIndex = 12;
            this.invertedSwitch.UseVisualStyleBackColor = false;
            this.invertedSwitch.Click += new System.EventHandler(this.invertedSwitch_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(85, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Dark Mode";
            // 
            // darkModeSwitch
            // 
            this.darkModeSwitch.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.darkModeSwitch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.darkModeSwitch.Location = new System.Drawing.Point(32, 71);
            this.darkModeSwitch.Name = "darkModeSwitch";
            this.darkModeSwitch.Size = new System.Drawing.Size(50, 30);
            this.darkModeSwitch.TabIndex = 10;
            this.darkModeSwitch.UseVisualStyleBackColor = false;
            this.darkModeSwitch.Click += new System.EventHandler(this.switchButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(269, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Boldness";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Color Adjustments";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Text Size";
            // 
            // darkModeSwitch1
            // 
            this.darkModeSwitch1.AutoSize = true;
            this.darkModeSwitch1.BackColor = System.Drawing.Color.White;
            this.darkModeSwitch1.Location = new System.Drawing.Point(35, 43);
            this.darkModeSwitch1.MinimumSize = new System.Drawing.Size(45, 22);
            this.darkModeSwitch1.Name = "darkModeSwitch1";
            this.darkModeSwitch1.OffBackColor1 = System.Drawing.Color.Gray;
            this.darkModeSwitch1.OffToggleColor1 = System.Drawing.Color.Gainsboro;
            this.darkModeSwitch1.OnBackColor1 = System.Drawing.Color.MediumSlateBlue;
            this.darkModeSwitch1.OnToggleColor1 = System.Drawing.Color.WhiteSmoke;
            this.darkModeSwitch1.Size = new System.Drawing.Size(45, 22);
            this.darkModeSwitch1.TabIndex = 22;
            this.darkModeSwitch1.UseVisualStyleBackColor = false;
            // 
            // boldSwitch1
            // 
            this.boldSwitch1.AutoSize = true;
            this.boldSwitch1.BackColor = System.Drawing.Color.White;
            this.boldSwitch1.Location = new System.Drawing.Point(213, 135);
            this.boldSwitch1.MinimumSize = new System.Drawing.Size(45, 22);
            this.boldSwitch1.Name = "boldSwitch1";
            this.boldSwitch1.OffBackColor1 = System.Drawing.Color.Gray;
            this.boldSwitch1.OffToggleColor1 = System.Drawing.Color.Gainsboro;
            this.boldSwitch1.OnBackColor1 = System.Drawing.Color.MediumSlateBlue;
            this.boldSwitch1.OnToggleColor1 = System.Drawing.Color.WhiteSmoke;
            this.boldSwitch1.Size = new System.Drawing.Size(45, 22);
            this.boldSwitch1.TabIndex = 23;
            this.boldSwitch1.UseVisualStyleBackColor = false;
            // 
            // toggleControls1
            // 
            this.toggleControls1.AutoSize = true;
            this.toggleControls1.BackColor = System.Drawing.Color.White;
            this.toggleControls1.Location = new System.Drawing.Point(-4, 301);
            this.toggleControls1.MinimumSize = new System.Drawing.Size(45, 22);
            this.toggleControls1.Name = "toggleControls1";
            this.toggleControls1.OffBackColor1 = System.Drawing.Color.Gray;
            this.toggleControls1.OffToggleColor1 = System.Drawing.Color.Gainsboro;
            this.toggleControls1.OnBackColor1 = System.Drawing.Color.MediumSlateBlue;
            this.toggleControls1.OnToggleColor1 = System.Drawing.Color.WhiteSmoke;
            this.toggleControls1.Size = new System.Drawing.Size(45, 22);
            this.toggleControls1.TabIndex = 24;
            this.toggleControls1.UseVisualStyleBackColor = false;
            // 
            // toggleControls2
            // 
            this.toggleControls2.AutoSize = true;
            this.toggleControls2.BackColor = System.Drawing.Color.White;
            this.toggleControls2.Location = new System.Drawing.Point(185, 292);
            this.toggleControls2.MinimumSize = new System.Drawing.Size(45, 22);
            this.toggleControls2.Name = "toggleControls2";
            this.toggleControls2.OffBackColor1 = System.Drawing.Color.Gray;
            this.toggleControls2.OffToggleColor1 = System.Drawing.Color.Gainsboro;
            this.toggleControls2.OnBackColor1 = System.Drawing.Color.MediumSlateBlue;
            this.toggleControls2.OnToggleColor1 = System.Drawing.Color.WhiteSmoke;
            this.toggleControls2.Size = new System.Drawing.Size(45, 22);
            this.toggleControls2.TabIndex = 25;
            this.toggleControls2.UseVisualStyleBackColor = false;
            // 
            // toggleControls3
            // 
            this.toggleControls3.AutoSize = true;
            this.toggleControls3.BackColor = System.Drawing.Color.White;
            this.toggleControls3.Location = new System.Drawing.Point(0, 361);
            this.toggleControls3.MinimumSize = new System.Drawing.Size(45, 22);
            this.toggleControls3.Name = "toggleControls3";
            this.toggleControls3.OffBackColor1 = System.Drawing.Color.Gray;
            this.toggleControls3.OffToggleColor1 = System.Drawing.Color.Gainsboro;
            this.toggleControls3.OnBackColor1 = System.Drawing.Color.MediumSlateBlue;
            this.toggleControls3.OnToggleColor1 = System.Drawing.Color.WhiteSmoke;
            this.toggleControls3.Size = new System.Drawing.Size(45, 22);
            this.toggleControls3.TabIndex = 26;
            this.toggleControls3.UseVisualStyleBackColor = false;
            // 
            // toggleControls4
            // 
            this.toggleControls4.AutoSize = true;
            this.toggleControls4.BackColor = System.Drawing.Color.White;
            this.toggleControls4.Location = new System.Drawing.Point(195, 364);
            this.toggleControls4.MinimumSize = new System.Drawing.Size(45, 22);
            this.toggleControls4.Name = "toggleControls4";
            this.toggleControls4.OffBackColor1 = System.Drawing.Color.Gray;
            this.toggleControls4.OffToggleColor1 = System.Drawing.Color.Gainsboro;
            this.toggleControls4.OnBackColor1 = System.Drawing.Color.MediumSlateBlue;
            this.toggleControls4.OnToggleColor1 = System.Drawing.Color.WhiteSmoke;
            this.toggleControls4.Size = new System.Drawing.Size(45, 22);
            this.toggleControls4.TabIndex = 27;
            this.toggleControls4.UseVisualStyleBackColor = false;
            // 
            // SettingsForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(423, 428);
            this.Controls.Add(this.panel1);
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

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label SETTINGS;
        private System.Windows.Forms.NumericUpDown textsizeSelect;
        private System.Windows.Forms.Button boldSwitch;
        private System.Windows.Forms.Button redgreenSwitch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button blueyellowSwitch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button grayscaleSwitch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button invertedSwitch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button darkModeSwitch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private ToggleControls toggleControls4;
        private ToggleControls toggleControls3;
        private ToggleControls toggleControls2;
        private ToggleControls toggleControls1;
        private ToggleControls boldSwitch1;
        private ToggleControls darkModeSwitch1;
    }
}
