
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
            this.forwardButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.returnToMenuButton = new System.Windows.Forms.Button();
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
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlContainerPanel = new System.Windows.Forms.Panel();
            this.mainMenuPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button4 = new System.Windows.Forms.Button();
            this.t3videoLaunchButton = new System.Windows.Forms.Button();
            this.taskThreeList = new System.Windows.Forms.CheckedListBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.taskThreeButton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.taskTwoList = new System.Windows.Forms.CheckedListBox();
            this.button5 = new System.Windows.Forms.Button();
            this.t2videoLaunchButton = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.taskTwoButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.taskOneList = new System.Windows.Forms.CheckedListBox();
            this.button7 = new System.Windows.Forms.Button();
            this.t1videoLaunchButton = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.task1Button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.taskOne = new ProjectEcho.TaskOneUserControl();
            this.taskTwo = new ProjectEcho.TaskTwoUserControl();
            this.taskThree = new ProjectEcho.TaskThreeUserControl();
            this.panel1.SuspendLayout();
            this.titlePanel.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.controlContainerPanel.SuspendLayout();
            this.mainMenuPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.forwardButton);
            this.panel1.Controls.Add(this.backButton);
            this.panel1.Controls.Add(this.returnToMenuButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 676);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1364, 73);
            this.panel1.TabIndex = 10;
            this.panel1.Tag = "changebg2";
            // 
            // forwardButton
            // 
            this.forwardButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.forwardButton.BackColor = System.Drawing.Color.Transparent;
            this.forwardButton.FlatAppearance.BorderSize = 0;
            this.forwardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.forwardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forwardButton.Image = global::ProjectEcho.Properties.Resources.Copy_of_Untitled__8_;
            this.forwardButton.Location = new System.Drawing.Point(1305, 7);
            this.forwardButton.Name = "forwardButton";
            this.forwardButton.Size = new System.Drawing.Size(51, 57);
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
            this.backButton.Location = new System.Drawing.Point(1248, 8);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(51, 55);
            this.backButton.TabIndex = 0;
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Visible = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
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
            this.returnToMenuButton.Location = new System.Drawing.Point(12, 8);
            this.returnToMenuButton.Name = "returnToMenuButton";
            this.returnToMenuButton.Size = new System.Drawing.Size(151, 53);
            this.returnToMenuButton.TabIndex = 2;
            this.returnToMenuButton.UseVisualStyleBackColor = false;
            this.returnToMenuButton.Visible = false;
            this.returnToMenuButton.Click += new System.EventHandler(this.returnToMenuButton_Click);
            // 
            // titlePanel
            // 
            this.titlePanel.AutoSize = true;
            this.titlePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.titlePanel.Controls.Add(this.titleSubtitleLabel);
            this.titlePanel.Controls.Add(this.titleLabel);
            this.titlePanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlePanel.ForeColor = System.Drawing.Color.White;
            this.titlePanel.Location = new System.Drawing.Point(3, 26);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(593, 51);
            this.titlePanel.TabIndex = 0;
            // 
            // titleSubtitleLabel
            // 
            this.titleSubtitleLabel.AutoSize = true;
            this.titleSubtitleLabel.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleSubtitleLabel.Location = new System.Drawing.Point(6, 33);
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
            this.titleLabel.Location = new System.Drawing.Point(4, 5);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
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
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1364, 80);
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
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(1364, 24);
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
            this.recentFilesToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.recentFilesToolStripMenuItem.Text = "Recent Files";
            this.recentFilesToolStripMenuItem.Click += new System.EventHandler(this.recentFilesToolStripMenuItem_Click);
            // 
            // clearLocalFilesToolStripMenuItem
            // 
            this.clearLocalFilesToolStripMenuItem.Name = "clearLocalFilesToolStripMenuItem";
            this.clearLocalFilesToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.clearLocalFilesToolStripMenuItem.Text = "Clear Local Files";
            this.clearLocalFilesToolStripMenuItem.Click += new System.EventHandler(this.clearLocalFilesToolStripMenuItem_Click);
            // 
            // exitApplicationToolStripMenuItem
            // 
            this.exitApplicationToolStripMenuItem.Name = "exitApplicationToolStripMenuItem";
            this.exitApplicationToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
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
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // controlContainerPanel
            // 
            this.controlContainerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.controlContainerPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.controlContainerPanel.BackColor = System.Drawing.Color.White;
            this.controlContainerPanel.Controls.Add(this.mainMenuPanel);
            this.controlContainerPanel.Controls.Add(this.taskOne);
            this.controlContainerPanel.Controls.Add(this.taskTwo);
            this.controlContainerPanel.Controls.Add(this.button1);
            this.controlContainerPanel.Controls.Add(this.taskThree);
            this.controlContainerPanel.Location = new System.Drawing.Point(3, 83);
            this.controlContainerPanel.Name = "controlContainerPanel";
            this.controlContainerPanel.Size = new System.Drawing.Size(1353, 587);
            this.controlContainerPanel.TabIndex = 15;
            // 
            // mainMenuPanel
            // 
            this.mainMenuPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainMenuPanel.Controls.Add(this.tableLayoutPanel1);
            this.mainMenuPanel.Location = new System.Drawing.Point(50, 46);
            this.mainMenuPanel.Name = "mainMenuPanel";
            this.mainMenuPanel.Size = new System.Drawing.Size(534, 388);
            this.mainMenuPanel.TabIndex = 40;
            this.mainMenuPanel.Tag = "panelBW";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(534, 385);
            this.tableLayoutPanel1.TabIndex = 39;
            // 
            // panel5
            // 
            this.panel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel5.Controls.Add(this.tableLayoutPanel2);
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Controls.Add(this.taskThreeButton);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 259);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(528, 123);
            this.panel5.TabIndex = 37;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.button4, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.t3videoLaunchButton, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.taskThreeList, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 48);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(316, 75);
            this.tableLayoutPanel2.TabIndex = 35;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button4.Image = global::ProjectEcho.Properties.Resources.bookIcon;
            this.button4.Location = new System.Drawing.Point(255, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(58, 69);
            this.button4.TabIndex = 1;
            this.button4.Text = "READ THE DOCUMENTATION FOR TASK THREE";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.taskThreeDocuButton_Click);
            // 
            // t3videoLaunchButton
            // 
            this.t3videoLaunchButton.BackColor = System.Drawing.Color.White;
            this.t3videoLaunchButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.t3videoLaunchButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t3videoLaunchButton.ForeColor = System.Drawing.Color.MidnightBlue;
            this.t3videoLaunchButton.Image = global::ProjectEcho.Properties.Resources.videoIcon;
            this.t3videoLaunchButton.Location = new System.Drawing.Point(192, 3);
            this.t3videoLaunchButton.Name = "t3videoLaunchButton";
            this.t3videoLaunchButton.Size = new System.Drawing.Size(57, 69);
            this.t3videoLaunchButton.TabIndex = 0;
            this.t3videoLaunchButton.Text = "WATCH TUTORIAL VIDEO FOR TASK THREE";
            this.t3videoLaunchButton.UseVisualStyleBackColor = false;
            this.t3videoLaunchButton.Click += new System.EventHandler(this.t3videoLaunchButton_Click);
            // 
            // taskThreeList
            // 
            this.taskThreeList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.taskThreeList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.taskThreeList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.taskThreeList.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskThreeList.ForeColor = System.Drawing.Color.White;
            this.taskThreeList.FormattingEnabled = true;
            this.taskThreeList.Location = new System.Drawing.Point(8, 8);
            this.taskThreeList.Margin = new System.Windows.Forms.Padding(8);
            this.taskThreeList.Name = "taskThreeList";
            this.taskThreeList.Size = new System.Drawing.Size(173, 59);
            this.taskThreeList.TabIndex = 2;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel8.Controls.Add(this.label3);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(316, 48);
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
            this.label3.Location = new System.Drawing.Point(16, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(239, 22);
            this.label3.TabIndex = 30;
            this.label3.Text = "TASK THREE: ASSESSING";
            // 
            // taskThreeButton
            // 
            this.taskThreeButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.taskThreeButton.BackColor = System.Drawing.Color.Goldenrod;
            this.taskThreeButton.CausesValidation = false;
            this.taskThreeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.taskThreeButton.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskThreeButton.ForeColor = System.Drawing.Color.White;
            this.taskThreeButton.Image = global::ProjectEcho.Properties.Resources.testIcon;
            this.taskThreeButton.Location = new System.Drawing.Point(316, 0);
            this.taskThreeButton.Name = "taskThreeButton";
            this.taskThreeButton.Size = new System.Drawing.Size(212, 123);
            this.taskThreeButton.TabIndex = 28;
            this.taskThreeButton.Text = "CLICK HERE TO GO TO TASK THREE";
            this.taskThreeButton.UseVisualStyleBackColor = false;
            this.taskThreeButton.Click += new System.EventHandler(this.taskThreeButton_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel4.Controls.Add(this.tableLayoutPanel3);
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.taskTwoButton);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 131);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(528, 122);
            this.panel4.TabIndex = 36;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Controls.Add(this.taskTwoList, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.button5, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.t2videoLaunchButton, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 48);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(316, 74);
            this.tableLayoutPanel3.TabIndex = 36;
            // 
            // taskTwoList
            // 
            this.taskTwoList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.taskTwoList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.taskTwoList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.taskTwoList.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskTwoList.ForeColor = System.Drawing.Color.White;
            this.taskTwoList.FormattingEnabled = true;
            this.taskTwoList.Location = new System.Drawing.Point(8, 8);
            this.taskTwoList.Margin = new System.Windows.Forms.Padding(8);
            this.taskTwoList.Name = "taskTwoList";
            this.taskTwoList.Size = new System.Drawing.Size(173, 58);
            this.taskTwoList.TabIndex = 3;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button5.Image = global::ProjectEcho.Properties.Resources.bookIcon;
            this.button5.Location = new System.Drawing.Point(255, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(58, 68);
            this.button5.TabIndex = 1;
            this.button5.Text = "READ THE DOCUMENTATION FOR TASK TWO";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.taskTwoDocuButton_Click);
            // 
            // t2videoLaunchButton
            // 
            this.t2videoLaunchButton.BackColor = System.Drawing.Color.White;
            this.t2videoLaunchButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.t2videoLaunchButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t2videoLaunchButton.ForeColor = System.Drawing.Color.MidnightBlue;
            this.t2videoLaunchButton.Image = global::ProjectEcho.Properties.Resources.videoIcon;
            this.t2videoLaunchButton.Location = new System.Drawing.Point(192, 3);
            this.t2videoLaunchButton.Name = "t2videoLaunchButton";
            this.t2videoLaunchButton.Size = new System.Drawing.Size(57, 68);
            this.t2videoLaunchButton.TabIndex = 0;
            this.t2videoLaunchButton.Text = "WATCH TUTORIAL VIDEO FOR TASK TWO";
            this.t2videoLaunchButton.UseVisualStyleBackColor = false;
            this.t2videoLaunchButton.Click += new System.EventHandler(this.t2videoLaunchButton_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel7.Controls.Add(this.label2);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(316, 48);
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
            this.label2.Location = new System.Drawing.Point(17, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(269, 22);
            this.label2.TabIndex = 30;
            this.label2.Text = "TASK TWO: IMPLEMENTING";
            // 
            // taskTwoButton
            // 
            this.taskTwoButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.taskTwoButton.BackColor = System.Drawing.Color.Goldenrod;
            this.taskTwoButton.CausesValidation = false;
            this.taskTwoButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.taskTwoButton.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskTwoButton.ForeColor = System.Drawing.Color.White;
            this.taskTwoButton.Image = global::ProjectEcho.Properties.Resources.cameraIcon;
            this.taskTwoButton.Location = new System.Drawing.Point(316, 0);
            this.taskTwoButton.Name = "taskTwoButton";
            this.taskTwoButton.Size = new System.Drawing.Size(212, 122);
            this.taskTwoButton.TabIndex = 27;
            this.taskTwoButton.Text = "CLICK HERE TO GO TO TASK TWO";
            this.taskTwoButton.UseVisualStyleBackColor = false;
            this.taskTwoButton.Click += new System.EventHandler(this.taskTwoButton_Click);
            // 
            // panel3
            // 
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.tableLayoutPanel4);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.task1Button);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(528, 122);
            this.panel3.TabIndex = 35;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.Controls.Add(this.taskOneList, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.button7, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.t1videoLaunchButton, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 48);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(315, 72);
            this.tableLayoutPanel4.TabIndex = 36;
            // 
            // taskOneList
            // 
            this.taskOneList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.taskOneList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.taskOneList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.taskOneList.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskOneList.ForeColor = System.Drawing.Color.White;
            this.taskOneList.FormattingEnabled = true;
            this.taskOneList.Location = new System.Drawing.Point(8, 8);
            this.taskOneList.Margin = new System.Windows.Forms.Padding(8);
            this.taskOneList.Name = "taskOneList";
            this.taskOneList.Size = new System.Drawing.Size(173, 54);
            this.taskOneList.TabIndex = 3;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.White;
            this.button7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button7.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button7.Image = global::ProjectEcho.Properties.Resources.bookIcon;
            this.button7.Location = new System.Drawing.Point(255, 3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(57, 66);
            this.button7.TabIndex = 1;
            this.button7.Text = "READ THE DOCUMENTATION FOR TASK ONE";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.taskOneDocuButton_Click);
            // 
            // t1videoLaunchButton
            // 
            this.t1videoLaunchButton.BackColor = System.Drawing.Color.White;
            this.t1videoLaunchButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.t1videoLaunchButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t1videoLaunchButton.ForeColor = System.Drawing.Color.MidnightBlue;
            this.t1videoLaunchButton.Image = global::ProjectEcho.Properties.Resources.videoIcon;
            this.t1videoLaunchButton.Location = new System.Drawing.Point(192, 3);
            this.t1videoLaunchButton.Name = "t1videoLaunchButton";
            this.t1videoLaunchButton.Size = new System.Drawing.Size(57, 66);
            this.t1videoLaunchButton.TabIndex = 0;
            this.t1videoLaunchButton.Text = "WATCH TUTORIAL VIDEO FOR TASK ONE";
            this.t1videoLaunchButton.UseVisualStyleBackColor = false;
            this.t1videoLaunchButton.Click += new System.EventHandler(this.t1videoLaunchButton_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel6.Controls.Add(this.label1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(315, 48);
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
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 22);
            this.label1.TabIndex = 30;
            this.label1.Text = "TASK ONE: PLANNING";
            // 
            // task1Button
            // 
            this.task1Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.task1Button.BackColor = System.Drawing.Color.Goldenrod;
            this.task1Button.CausesValidation = false;
            this.task1Button.Dock = System.Windows.Forms.DockStyle.Right;
            this.task1Button.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.task1Button.ForeColor = System.Drawing.Color.White;
            this.task1Button.Image = global::ProjectEcho.Properties.Resources.writingIcon;
            this.task1Button.Location = new System.Drawing.Point(315, 0);
            this.task1Button.Name = "task1Button";
            this.task1Button.Size = new System.Drawing.Size(211, 120);
            this.task1Button.TabIndex = 29;
            this.task1Button.Text = "CLICK HERE TO GO TO TASK ONE";
            this.task1Button.UseVisualStyleBackColor = false;
            this.task1Button.Click += new System.EventHandler(this.task1Button_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1475, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 38;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // mainPanel
            // 
            this.mainPanel.AutoSize = true;
            this.mainPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mainPanel.BackColor = System.Drawing.Color.MidnightBlue;
            this.mainPanel.Controls.Add(this.controlContainerPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1364, 749);
            this.mainPanel.TabIndex = 1;
            this.mainPanel.Tag = "";
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // taskOne
            // 
            this.taskOne.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.taskOne.AutoScroll = true;
            this.taskOne.BackColor = System.Drawing.Color.MidnightBlue;
            this.taskOne.Location = new System.Drawing.Point(993, 205);
            this.taskOne.Margin = new System.Windows.Forms.Padding(0);
            this.taskOne.MaximumSize = new System.Drawing.Size(2507, 992);
            this.taskOne.Name = "taskOne";
            this.taskOne.Size = new System.Drawing.Size(263, 150);
            this.taskOne.TabIndex = 16;
            // 
            // taskTwo
            // 
            this.taskTwo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.taskTwo.AutoScroll = true;
            this.taskTwo.AutoSize = true;
            this.taskTwo.BackColor = System.Drawing.Color.MidnightBlue;
            this.taskTwo.Location = new System.Drawing.Point(993, 49);
            this.taskTwo.Margin = new System.Windows.Forms.Padding(0);
            this.taskTwo.Name = "taskTwo";
            this.taskTwo.Size = new System.Drawing.Size(2177, 951);
            this.taskTwo.TabIndex = 17;
            // 
            // taskThree
            // 
            this.taskThree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.taskThree.AutoScroll = true;
            this.taskThree.BackColor = System.Drawing.Color.MidnightBlue;
            this.taskThree.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskThree.Location = new System.Drawing.Point(993, 362);
            this.taskThree.Margin = new System.Windows.Forms.Padding(0);
            this.taskThree.Name = "taskThree";
            this.taskThree.Size = new System.Drawing.Size(263, 147);
            this.taskThree.TabIndex = 17;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1364, 749);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mainPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Education Capstone Checker";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.controlContainerPanel.ResumeLayout(false);
            this.controlContainerPanel.PerformLayout();
            this.mainMenuPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.mainPanel.ResumeLayout(false);
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
        private System.Windows.Forms.Panel controlContainerPanel;
        private System.Windows.Forms.Button task1Button;
        private System.Windows.Forms.Button taskThreeButton;
        private System.Windows.Forms.Button taskTwoButton;
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
        private TaskTwoUserControl taskTwo;
        private TaskThreeUserControl taskThree;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.Panel mainPanel;
        public System.Windows.Forms.Panel mainMenuPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button t3videoLaunchButton;
        private System.Windows.Forms.CheckedListBox taskThreeList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button t2videoLaunchButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button t1videoLaunchButton;
        private System.Windows.Forms.CheckedListBox taskTwoList;
        private System.Windows.Forms.CheckedListBox taskOneList;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
    }
}
