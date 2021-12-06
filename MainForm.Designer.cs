
namespace ProjectEcho
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.textsizeLabel = new System.Windows.Forms.Label();
            this.textsizeAdjust = new System.Windows.Forms.TrackBar();
            this.returnToMenuButton = new System.Windows.Forms.Button();
            this.forwardButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.titleSubtitleLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recentFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearLocalFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.taskThreeButton = new System.Windows.Forms.Button();
            this.taskThreeList = new System.Windows.Forms.CheckedListBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.taskTwoButton = new System.Windows.Forms.Button();
            this.taskTwoList = new System.Windows.Forms.CheckedListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.task1Button = new System.Windows.Forms.Button();
            this.taskOneList = new System.Windows.Forms.CheckedListBox();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.taskOne = new ProjectEcho.TaskOneUserControl();
            this.taskTwoUserControl1 = new ProjectEcho.TaskTwoUserControl();
            this.taskThreeUserControl1 = new ProjectEcho.TaskThreeUserControl();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textsizeAdjust)).BeginInit();
            this.titlePanel.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.mainMenuPanel.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.textsizeLabel);
            this.panel1.Controls.Add(this.textsizeAdjust);
            this.panel1.Controls.Add(this.returnToMenuButton);
            this.panel1.Controls.Add(this.forwardButton);
            this.panel1.Controls.Add(this.backButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 961);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1924, 100);
            this.panel1.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(360, 39);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 38;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textsizeLabel
            // 
            this.textsizeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textsizeLabel.AutoSize = true;
            this.textsizeLabel.BackColor = System.Drawing.Color.Transparent;
            this.textsizeLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textsizeLabel.Location = new System.Drawing.Point(779, 39);
            this.textsizeLabel.Name = "textsizeLabel";
            this.textsizeLabel.Size = new System.Drawing.Size(78, 21);
            this.textsizeLabel.TabIndex = 37;
            this.textsizeLabel.Text = "TEXT SIZE";
            // 
            // textsizeAdjust
            // 
            this.textsizeAdjust.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textsizeAdjust.Location = new System.Drawing.Point(896, 32);
            this.textsizeAdjust.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textsizeAdjust.Maximum = 6;
            this.textsizeAdjust.Name = "textsizeAdjust";
            this.textsizeAdjust.Size = new System.Drawing.Size(251, 45);
            this.textsizeAdjust.TabIndex = 36;
            this.textsizeAdjust.Scroll += new System.EventHandler(this.textsizeAdjust_Scroll);
            // 
            // returnToMenuButton
            // 
            this.returnToMenuButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.returnToMenuButton.BackColor = System.Drawing.Color.Transparent;
            this.returnToMenuButton.BackgroundImage = global::ProjectEcho.Properties.Resources.Copy_of_Copy_of_Copy_of_Copy_of_Copy_of_Untitled__1_;
            this.returnToMenuButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.returnToMenuButton.FlatAppearance.BorderSize = 0;
            this.returnToMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnToMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnToMenuButton.Location = new System.Drawing.Point(16, 20);
            this.returnToMenuButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.returnToMenuButton.Name = "returnToMenuButton";
            this.returnToMenuButton.Size = new System.Drawing.Size(201, 65);
            this.returnToMenuButton.TabIndex = 2;
            this.returnToMenuButton.UseVisualStyleBackColor = false;
            this.returnToMenuButton.Visible = false;
            this.returnToMenuButton.Click += new System.EventHandler(this.returnToMenuButton_Click);
            // 
            // forwardButton
            // 
            this.forwardButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.forwardButton.BackColor = System.Drawing.Color.Transparent;
            this.forwardButton.FlatAppearance.BorderSize = 0;
            this.forwardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.forwardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forwardButton.Image = global::ProjectEcho.Properties.Resources.Copy_of_Untitled__8_;
            this.forwardButton.Location = new System.Drawing.Point(1845, 4);
            this.forwardButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.forwardButton.Name = "forwardButton";
            this.forwardButton.Size = new System.Drawing.Size(68, 68);
            this.forwardButton.TabIndex = 1;
            this.forwardButton.UseVisualStyleBackColor = false;
            this.forwardButton.Click += new System.EventHandler(this.forwardButton_Click);
            // 
            // backButton
            // 
            this.backButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.backButton.BackColor = System.Drawing.Color.Transparent;
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Image = global::ProjectEcho.Properties.Resources.Copy_of_Untitled__9_;
            this.backButton.Location = new System.Drawing.Point(1769, 4);
            this.backButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(68, 68);
            this.backButton.TabIndex = 0;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Visible = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // titlePanel
            // 
            this.titlePanel.AutoSize = true;
            this.titlePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.titlePanel.Controls.Add(this.titleSubtitleLabel);
            this.titlePanel.Controls.Add(this.titleLabel);
            this.titlePanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlePanel.ForeColor = System.Drawing.Color.White;
            this.titlePanel.Location = new System.Drawing.Point(4, 32);
            this.titlePanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(596, 59);
            this.titlePanel.TabIndex = 0;
            // 
            // titleSubtitleLabel
            // 
            this.titleSubtitleLabel.AutoSize = true;
            this.titleSubtitleLabel.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleSubtitleLabel.Location = new System.Drawing.Point(8, 41);
            this.titleSubtitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleSubtitleLabel.Name = "titleSubtitleLabel";
            this.titleSubtitleLabel.Size = new System.Drawing.Size(584, 18);
            this.titleSubtitleLabel.TabIndex = 1;
            this.titleSubtitleLabel.Text = "Please complete the following tasks. Click each button and complete the subtasks." +
    "";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(5, 6);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(144, 30);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "WELCOME";
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.MidnightBlue;
            this.headerPanel.Controls.Add(this.titlePanel);
            this.headerPanel.Controls.Add(this.menuStrip1);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1924, 98);
            this.headerPanel.TabIndex = 35;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(1924, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recentFilesToolStripMenuItem,
            this.clearLocalFilesToolStripMenuItem,
            this.exitApplicationToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // recentFilesToolStripMenuItem
            // 
            this.recentFilesToolStripMenuItem.Name = "recentFilesToolStripMenuItem";
            this.recentFilesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.recentFilesToolStripMenuItem.Text = "Recent Files";
            // 
            // clearLocalFilesToolStripMenuItem
            // 
            this.clearLocalFilesToolStripMenuItem.Name = "clearLocalFilesToolStripMenuItem";
            this.clearLocalFilesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clearLocalFilesToolStripMenuItem.Text = "Clear Local Files";
            // 
            // exitApplicationToolStripMenuItem
            // 
            this.exitApplicationToolStripMenuItem.Name = "exitApplicationToolStripMenuItem";
            this.exitApplicationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitApplicationToolStripMenuItem.Text = "Exit Application";
            this.exitApplicationToolStripMenuItem.Click += new System.EventHandler(this.exitApplicationToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // mainMenuPanel
            // 
            this.mainMenuPanel.BackColor = System.Drawing.Color.White;
            this.mainMenuPanel.Controls.Add(this.button1);
            this.mainMenuPanel.Controls.Add(this.panel5);
            this.mainMenuPanel.Controls.Add(this.panel4);
            this.mainMenuPanel.Controls.Add(this.panel3);
            this.mainMenuPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.mainMenuPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mainMenuPanel.Name = "mainMenuPanel";
            this.mainMenuPanel.Size = new System.Drawing.Size(1924, 1061);
            this.mainMenuPanel.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1967, 256);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 38;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.AutoSize = true;
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Controls.Add(this.taskThreeButton);
            this.panel5.Controls.Add(this.taskThreeList);
            this.panel5.Location = new System.Drawing.Point(17, 647);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1891, 249);
            this.panel5.TabIndex = 37;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel8.Controls.Add(this.label3);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1608, 59);
            this.panel8.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(21, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(239, 22);
            this.label3.TabIndex = 30;
            this.label3.Text = "TASK THREE: ASSESSING";
            // 
            // taskThreeButton
            // 
            this.taskThreeButton.BackColor = System.Drawing.Color.White;
            this.taskThreeButton.CausesValidation = false;
            this.taskThreeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.taskThreeButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskThreeButton.ForeColor = System.Drawing.Color.Navy;
            this.taskThreeButton.Location = new System.Drawing.Point(1608, 0);
            this.taskThreeButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.taskThreeButton.Name = "taskThreeButton";
            this.taskThreeButton.Size = new System.Drawing.Size(283, 249);
            this.taskThreeButton.TabIndex = 28;
            this.taskThreeButton.Text = "CLICK HERE TO GO TO TASK THREE";
            this.taskThreeButton.UseVisualStyleBackColor = false;
            this.taskThreeButton.Click += new System.EventHandler(this.taskThreeButton_Click);
            // 
            // taskThreeList
            // 
            this.taskThreeList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.taskThreeList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.taskThreeList.CausesValidation = false;
            this.taskThreeList.Enabled = false;
            this.taskThreeList.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskThreeList.ForeColor = System.Drawing.Color.White;
            this.taskThreeList.FormattingEnabled = true;
            this.taskThreeList.Location = new System.Drawing.Point(27, 80);
            this.taskThreeList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.taskThreeList.Name = "taskThreeList";
            this.taskThreeList.Size = new System.Drawing.Size(481, 132);
            this.taskThreeList.TabIndex = 33;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.AutoSize = true;
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.taskTwoButton);
            this.panel4.Controls.Add(this.taskTwoList);
            this.panel4.Location = new System.Drawing.Point(16, 375);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1892, 249);
            this.panel4.TabIndex = 36;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel7.Controls.Add(this.label2);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1609, 59);
            this.panel7.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(23, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(269, 22);
            this.label2.TabIndex = 30;
            this.label2.Text = "TASK TWO: IMPLEMENTING";
            // 
            // taskTwoButton
            // 
            this.taskTwoButton.BackColor = System.Drawing.Color.White;
            this.taskTwoButton.CausesValidation = false;
            this.taskTwoButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.taskTwoButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskTwoButton.ForeColor = System.Drawing.Color.MidnightBlue;
            this.taskTwoButton.Location = new System.Drawing.Point(1609, 0);
            this.taskTwoButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.taskTwoButton.Name = "taskTwoButton";
            this.taskTwoButton.Size = new System.Drawing.Size(283, 249);
            this.taskTwoButton.TabIndex = 27;
            this.taskTwoButton.Text = "CLICK HERE TO GO TO TASK TWO";
            this.taskTwoButton.UseVisualStyleBackColor = false;
            this.taskTwoButton.Click += new System.EventHandler(this.taskTwoButton_Click);
            // 
            // taskTwoList
            // 
            this.taskTwoList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.taskTwoList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.taskTwoList.CausesValidation = false;
            this.taskTwoList.Enabled = false;
            this.taskTwoList.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskTwoList.ForeColor = System.Drawing.Color.White;
            this.taskTwoList.FormattingEnabled = true;
            this.taskTwoList.Location = new System.Drawing.Point(24, 80);
            this.taskTwoList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.taskTwoList.Name = "taskTwoList";
            this.taskTwoList.Size = new System.Drawing.Size(492, 132);
            this.taskTwoList.TabIndex = 32;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.AutoSize = true;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.task1Button);
            this.panel3.Controls.Add(this.taskOneList);
            this.panel3.Location = new System.Drawing.Point(16, 106);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1891, 248);
            this.panel3.TabIndex = 35;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel6.Controls.Add(this.label1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1608, 59);
            this.panel6.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 22);
            this.label1.TabIndex = 30;
            this.label1.Text = "TASK ONE: PLANNING";
            // 
            // task1Button
            // 
            this.task1Button.BackColor = System.Drawing.Color.White;
            this.task1Button.CausesValidation = false;
            this.task1Button.Dock = System.Windows.Forms.DockStyle.Right;
            this.task1Button.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.task1Button.ForeColor = System.Drawing.Color.MidnightBlue;
            this.task1Button.Location = new System.Drawing.Point(1608, 0);
            this.task1Button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.task1Button.Name = "task1Button";
            this.task1Button.Size = new System.Drawing.Size(281, 246);
            this.task1Button.TabIndex = 29;
            this.task1Button.Text = "CLICK HERE TO GO TO TASK ONE";
            this.task1Button.UseVisualStyleBackColor = false;
            this.task1Button.Click += new System.EventHandler(this.task1Button_Click);
            // 
            // taskOneList
            // 
            this.taskOneList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.taskOneList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.taskOneList.CausesValidation = false;
            this.taskOneList.Enabled = false;
            this.taskOneList.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskOneList.ForeColor = System.Drawing.Color.White;
            this.taskOneList.FormattingEnabled = true;
            this.taskOneList.Location = new System.Drawing.Point(23, 80);
            this.taskOneList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.taskOneList.Name = "taskOneList";
            this.taskOneList.Size = new System.Drawing.Size(496, 84);
            this.taskOneList.TabIndex = 31;
            // 
            // mainPanel
            // 
            this.mainPanel.AutoSize = true;
            this.mainPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mainPanel.BackColor = System.Drawing.Color.White;
            this.mainPanel.Controls.Add(this.mainMenuPanel);
            this.mainPanel.Controls.Add(this.taskOne);
            this.mainPanel.Controls.Add(this.taskTwoUserControl1);
            this.mainPanel.Controls.Add(this.taskThreeUserControl1);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1924, 1061);
            this.mainPanel.TabIndex = 1;
            // 
            // taskOne
            // 
            this.taskOne.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.taskOne.AutoSize = true;
            this.taskOne.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.taskOne.BackColor = System.Drawing.Color.MidnightBlue;
            this.taskOne.Location = new System.Drawing.Point(0, 76);
            this.taskOne.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.taskOne.Name = "taskOne";
            this.taskOne.Size = new System.Drawing.Size(835, 251);
            this.taskOne.TabIndex = 16;
            // 
            // taskTwoUserControl1
            // 
            this.taskTwoUserControl1.AutoSize = true;
            this.taskTwoUserControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.taskTwoUserControl1.BackColor = System.Drawing.Color.MidnightBlue;
            this.taskTwoUserControl1.Location = new System.Drawing.Point(0, 98);
            this.taskTwoUserControl1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.taskTwoUserControl1.Name = "taskTwoUserControl1";
            this.taskTwoUserControl1.Size = new System.Drawing.Size(3360, 1189);
            this.taskTwoUserControl1.TabIndex = 17;
            // 
            // taskThreeUserControl1
            // 
            this.taskThreeUserControl1.AutoSize = true;
            this.taskThreeUserControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.taskThreeUserControl1.BackColor = System.Drawing.Color.MidnightBlue;
            this.taskThreeUserControl1.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskThreeUserControl1.Location = new System.Drawing.Point(0, 98);
            this.taskThreeUserControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.taskThreeUserControl1.Name = "taskThreeUserControl1";
            this.taskThreeUserControl1.Size = new System.Drawing.Size(1887, 810);
            this.taskThreeUserControl1.TabIndex = 17;
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mainPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Education Capstone Checker";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textsizeAdjust)).EndInit();
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.mainMenuPanel.ResumeLayout(false);
            this.mainMenuPanel.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label titleSubtitleLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button returnToMenuButton;
        private System.Windows.Forms.Button forwardButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Panel mainMenuPanel;
        private System.Windows.Forms.CheckedListBox taskThreeList;
        private System.Windows.Forms.CheckedListBox taskTwoList;
        private System.Windows.Forms.CheckedListBox taskOneList;
        private System.Windows.Forms.Button task1Button;
        private System.Windows.Forms.Button taskThreeButton;
        private System.Windows.Forms.Button taskTwoButton;
        private System.Windows.Forms.Panel mainPanel;
        private TaskOneUserControl taskOne;
        private System.Windows.Forms.ToolStripMenuItem recentFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearLocalFilesToolStripMenuItem;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private TaskTwoUserControl taskTwoUserControl1;
        private TaskThreeUserControl taskThreeUserControl1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TrackBar textsizeAdjust;
        private System.Windows.Forms.Label textsizeLabel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
    }
}
