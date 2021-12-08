
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textsizeAdjust = new System.Windows.Forms.TrackBar();
            this.switchButton = new ProjectEcho.SwitchButton();
            this.boldnessToggle = new ProjectEcho.SwitchButton();
            this.darkmodeLabel = new System.Windows.Forms.Label();
            this.textsizeLabel = new System.Windows.Forms.Label();
            this.boldnessLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.applyButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textsizeAdjust)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(3, 43);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(338, 181);
            this.panel1.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.26688F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.73312F));
            this.tableLayoutPanel1.Controls.Add(this.textsizeAdjust, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.switchButton, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.boldnessToggle, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.darkmodeLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textsizeLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.boldnessLabel, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 22);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(321, 142);
            this.tableLayoutPanel1.TabIndex = 32;
            // 
            // textsizeAdjust
            // 
            this.textsizeAdjust.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textsizeAdjust.Location = new System.Drawing.Point(159, 3);
            this.textsizeAdjust.Maximum = 6;
            this.textsizeAdjust.Name = "textsizeAdjust";
            this.textsizeAdjust.Size = new System.Drawing.Size(159, 39);
            this.textsizeAdjust.TabIndex = 4;
            this.textsizeAdjust.TabStop = false;
            this.textsizeAdjust.Scroll += new System.EventHandler(this.textsizeAdjust_Scroll);
            this.textsizeAdjust.ValueChanged += new System.EventHandler(this.textsizeAdjust_ValueChanged);
            // 
            // switchButton
            // 
            this.switchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.switchButton.Location = new System.Drawing.Point(266, 93);
            this.switchButton.MinimumSize = new System.Drawing.Size(45, 22);
            this.switchButton.Name = "switchButton";
            this.switchButton.Size = new System.Drawing.Size(52, 22);
            this.switchButton.TabIndex = 29;
            this.switchButton.UseVisualStyleBackColor = true;
            this.switchButton.CheckedChanged += new System.EventHandler(this.switchButton_Click);
            // 
            // boldnessToggle
            // 
            this.boldnessToggle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.boldnessToggle.Location = new System.Drawing.Point(266, 48);
            this.boldnessToggle.MinimumSize = new System.Drawing.Size(45, 22);
            this.boldnessToggle.Name = "boldnessToggle";
            this.boldnessToggle.Size = new System.Drawing.Size(52, 22);
            this.boldnessToggle.TabIndex = 23;
            this.boldnessToggle.UseVisualStyleBackColor = true;
            this.boldnessToggle.CheckedChanged += new System.EventHandler(this.boldnessToggle_CheckedChanged);
            // 
            // darkmodeLabel
            // 
            this.darkmodeLabel.AutoSize = true;
            this.darkmodeLabel.BackColor = System.Drawing.Color.Transparent;
            this.darkmodeLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.darkmodeLabel.Location = new System.Drawing.Point(3, 90);
            this.darkmodeLabel.Name = "darkmodeLabel";
            this.darkmodeLabel.Size = new System.Drawing.Size(108, 21);
            this.darkmodeLabel.TabIndex = 11;
            this.darkmodeLabel.Text = "DARK MODE";
            // 
            // textsizeLabel
            // 
            this.textsizeLabel.AutoSize = true;
            this.textsizeLabel.BackColor = System.Drawing.Color.Transparent;
            this.textsizeLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textsizeLabel.Location = new System.Drawing.Point(3, 0);
            this.textsizeLabel.Name = "textsizeLabel";
            this.textsizeLabel.Size = new System.Drawing.Size(78, 21);
            this.textsizeLabel.TabIndex = 3;
            this.textsizeLabel.Text = "TEXT SIZE";
            // 
            // boldnessLabel
            // 
            this.boldnessLabel.AutoSize = true;
            this.boldnessLabel.BackColor = System.Drawing.Color.Transparent;
            this.boldnessLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boldnessLabel.Location = new System.Drawing.Point(3, 45);
            this.boldnessLabel.Name = "boldnessLabel";
            this.boldnessLabel.Size = new System.Drawing.Size(89, 21);
            this.boldnessLabel.TabIndex = 9;
            this.boldnessLabel.Text = "BOLDNESS";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(129, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 22);
            this.label3.TabIndex = 31;
            this.label3.Text = "SETTINGS";
            // 
            // applyButton
            // 
            this.applyButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applyButton.Location = new System.Drawing.Point(234, 231);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(95, 34);
            this.applyButton.TabIndex = 3;
            this.applyButton.Text = "SAVE";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(347, 277);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textsizeAdjust)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
