
namespace ProjectEcho
{
    partial class mainMenuUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainMenuUserControl));
            this.mainMenuPanel = new System.Windows.Forms.Panel();
            this.reviewList = new System.Windows.Forms.CheckedListBox();
            this.taskThreeList = new System.Windows.Forms.CheckedListBox();
            this.taskTwoList = new System.Windows.Forms.CheckedListBox();
            this.taskOneList = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.task1Button = new System.Windows.Forms.Button();
            this.taskThreeButton = new System.Windows.Forms.Button();
            this.taskTwoButton = new System.Windows.Forms.Button();
            this.taskOneButton = new System.Windows.Forms.Button();
            this.mainMenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuPanel
            // 
            this.mainMenuPanel.Controls.Add(this.reviewList);
            this.mainMenuPanel.Controls.Add(this.taskThreeList);
            this.mainMenuPanel.Controls.Add(this.taskTwoList);
            this.mainMenuPanel.Controls.Add(this.taskOneList);
            this.mainMenuPanel.Controls.Add(this.label3);
            this.mainMenuPanel.Controls.Add(this.task1Button);
            this.mainMenuPanel.Controls.Add(this.taskThreeButton);
            this.mainMenuPanel.Controls.Add(this.taskTwoButton);
            this.mainMenuPanel.Controls.Add(this.taskOneButton);
            this.mainMenuPanel.Location = new System.Drawing.Point(8, 8);
            this.mainMenuPanel.Name = "mainMenuPanel";
            this.mainMenuPanel.Size = new System.Drawing.Size(958, 460);
            this.mainMenuPanel.TabIndex = 3;
            // 
            // reviewList
            // 
            this.reviewList.Enabled = false;
            this.reviewList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reviewList.FormattingEnabled = true;
            this.reviewList.Location = new System.Drawing.Point(718, 233);
            this.reviewList.Name = "reviewList";
            this.reviewList.Size = new System.Drawing.Size(193, 94);
            this.reviewList.TabIndex = 16;
            // 
            // taskThreeList
            // 
            this.taskThreeList.Enabled = false;
            this.taskThreeList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskThreeList.FormattingEnabled = true;
            this.taskThreeList.Location = new System.Drawing.Point(495, 233);
            this.taskThreeList.Name = "taskThreeList";
            this.taskThreeList.Size = new System.Drawing.Size(193, 94);
            this.taskThreeList.TabIndex = 15;
            // 
            // taskTwoList
            // 
            this.taskTwoList.Enabled = false;
            this.taskTwoList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskTwoList.FormattingEnabled = true;
            this.taskTwoList.Location = new System.Drawing.Point(272, 233);
            this.taskTwoList.Name = "taskTwoList";
            this.taskTwoList.Size = new System.Drawing.Size(193, 94);
            this.taskTwoList.TabIndex = 14;
            // 
            // taskOneList
            // 
            this.taskOneList.Enabled = false;
            this.taskOneList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskOneList.FormattingEnabled = true;
            this.taskOneList.Location = new System.Drawing.Point(49, 233);
            this.taskOneList.Name = "taskOneList";
            this.taskOneList.Size = new System.Drawing.Size(193, 94);
            this.taskOneList.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(868, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // task1Button
            // 
            this.task1Button.BackColor = System.Drawing.Color.Goldenrod;
            this.task1Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.task1Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.task1Button.Location = new System.Drawing.Point(49, 50);
            this.task1Button.Name = "task1Button";
            this.task1Button.Size = new System.Drawing.Size(193, 134);
            this.task1Button.TabIndex = 7;
            this.task1Button.Text = "Task One: Planning";
            this.task1Button.UseVisualStyleBackColor = false;
            this.task1Button.Click += new System.EventHandler(this.task1Button_Click);
            // 
            // taskThreeButton
            // 
            this.taskThreeButton.BackColor = System.Drawing.Color.Goldenrod;
            this.taskThreeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.taskThreeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskThreeButton.Location = new System.Drawing.Point(495, 50);
            this.taskThreeButton.Name = "taskThreeButton";
            this.taskThreeButton.Size = new System.Drawing.Size(193, 134);
            this.taskThreeButton.TabIndex = 6;
            this.taskThreeButton.Text = "Task Three: Assessing";
            this.taskThreeButton.UseVisualStyleBackColor = false;
            // 
            // taskTwoButton
            // 
            this.taskTwoButton.BackColor = System.Drawing.Color.Goldenrod;
            this.taskTwoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.taskTwoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskTwoButton.Location = new System.Drawing.Point(272, 50);
            this.taskTwoButton.Name = "taskTwoButton";
            this.taskTwoButton.Size = new System.Drawing.Size(193, 134);
            this.taskTwoButton.TabIndex = 5;
            this.taskTwoButton.Text = "Task Two:   Implementing";
            this.taskTwoButton.UseVisualStyleBackColor = false;
            // 
            // taskOneButton
            // 
            this.taskOneButton.BackColor = System.Drawing.Color.GhostWhite;
            this.taskOneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.taskOneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskOneButton.Location = new System.Drawing.Point(718, 50);
            this.taskOneButton.Name = "taskOneButton";
            this.taskOneButton.Size = new System.Drawing.Size(193, 134);
            this.taskOneButton.TabIndex = 1;
            this.taskOneButton.Text = "Review";
            this.taskOneButton.UseVisualStyleBackColor = false;
            // 
            // mainMenuUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainMenuPanel);
            this.Name = "mainMenuUserControl";
            this.Size = new System.Drawing.Size(958, 460);
            this.mainMenuPanel.ResumeLayout(false);
            this.mainMenuPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainMenuPanel;
        private System.Windows.Forms.CheckedListBox reviewList;
        private System.Windows.Forms.CheckedListBox taskThreeList;
        private System.Windows.Forms.CheckedListBox taskTwoList;
        private System.Windows.Forms.CheckedListBox taskOneList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button task1Button;
        private System.Windows.Forms.Button taskThreeButton;
        private System.Windows.Forms.Button taskTwoButton;
        private System.Windows.Forms.Button taskOneButton;
    }
}
