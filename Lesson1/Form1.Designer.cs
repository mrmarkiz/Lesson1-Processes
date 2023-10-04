namespace Lesson1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnStart = new Button();
            btnStop = new Button();
            myProcess = new System.Diagnostics.Process();
            label1 = new Label();
            label2 = new Label();
            listBoxPrograms = new ListBox();
            listBoxProcesses = new ListBox();
            btnAddProg = new Button();
            listBoxId = new ListBox();
            listBoxStartTime = new ListBox();
            listBoxTimeSpan = new ListBox();
            listBoxThreadsNum = new ListBox();
            btnUpdate = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            comboBoxSort = new ComboBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.Location = new Point(1073, 116);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(94, 29);
            btnStart.TabIndex = 0;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnStop
            // 
            btnStop.Location = new Point(1073, 197);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(94, 29);
            btnStop.TabIndex = 1;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // myProcess
            // 
            myProcess.StartInfo.Domain = "";
            myProcess.StartInfo.LoadUserProfile = false;
            myProcess.StartInfo.Password = null;
            myProcess.StartInfo.StandardErrorEncoding = null;
            myProcess.StartInfo.StandardInputEncoding = null;
            myProcess.StartInfo.StandardOutputEncoding = null;
            myProcess.StartInfo.UserName = "";
            myProcess.SynchronizingObject = this;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(81, 30);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 2;
            label1.Text = "Programs:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(350, 30);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 3;
            label2.Text = "Processes:";
            // 
            // listBoxPrograms
            // 
            listBoxPrograms.FormattingEnabled = true;
            listBoxPrograms.ItemHeight = 20;
            listBoxPrograms.Location = new Point(12, 53);
            listBoxPrograms.Name = "listBoxPrograms";
            listBoxPrograms.Size = new Size(231, 384);
            listBoxPrograms.TabIndex = 4;
            // 
            // listBoxProcesses
            // 
            listBoxProcesses.FormattingEnabled = true;
            listBoxProcesses.HorizontalScrollbar = true;
            listBoxProcesses.ItemHeight = 20;
            listBoxProcesses.Location = new Point(284, 53);
            listBoxProcesses.Name = "listBoxProcesses";
            listBoxProcesses.Size = new Size(207, 384);
            listBoxProcesses.TabIndex = 5;
            listBoxProcesses.Tag = "Name";
            // 
            // btnAddProg
            // 
            btnAddProg.Location = new Point(1073, 45);
            btnAddProg.Name = "btnAddProg";
            btnAddProg.Size = new Size(94, 29);
            btnAddProg.TabIndex = 6;
            btnAddProg.Text = "Add Prog";
            btnAddProg.UseVisualStyleBackColor = true;
            btnAddProg.Click += btnAddProg_Click;
            // 
            // listBoxId
            // 
            listBoxId.FormattingEnabled = true;
            listBoxId.ItemHeight = 20;
            listBoxId.Location = new Point(497, 53);
            listBoxId.Name = "listBoxId";
            listBoxId.Size = new Size(69, 384);
            listBoxId.TabIndex = 7;
            listBoxId.Tag = "Id";
            // 
            // listBoxStartTime
            // 
            listBoxStartTime.FormattingEnabled = true;
            listBoxStartTime.ItemHeight = 20;
            listBoxStartTime.Location = new Point(572, 53);
            listBoxStartTime.Name = "listBoxStartTime";
            listBoxStartTime.Size = new Size(149, 384);
            listBoxStartTime.TabIndex = 7;
            listBoxStartTime.Tag = "StartTime";
            // 
            // listBoxTimeSpan
            // 
            listBoxTimeSpan.FormattingEnabled = true;
            listBoxTimeSpan.ItemHeight = 20;
            listBoxTimeSpan.Location = new Point(727, 53);
            listBoxTimeSpan.Name = "listBoxTimeSpan";
            listBoxTimeSpan.Size = new Size(158, 384);
            listBoxTimeSpan.TabIndex = 7;
            listBoxTimeSpan.Tag = "TimeSpan";
            // 
            // listBoxThreadsNum
            // 
            listBoxThreadsNum.FormattingEnabled = true;
            listBoxThreadsNum.ItemHeight = 20;
            listBoxThreadsNum.Location = new Point(891, 53);
            listBoxThreadsNum.Name = "listBoxThreadsNum";
            listBoxThreadsNum.Size = new Size(102, 384);
            listBoxThreadsNum.TabIndex = 7;
            listBoxThreadsNum.Tag = "Threads";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(1073, 408);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(519, 30);
            label3.Name = "label3";
            label3.Size = new Size(25, 20);
            label3.TabIndex = 9;
            label3.Text = "Id:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(602, 30);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 10;
            label4.Text = "Start time:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(763, 30);
            label5.Name = "label5";
            label5.Size = new Size(80, 20);
            label5.TabIndex = 11;
            label5.Text = "Time span:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(895, 30);
            label6.Name = "label6";
            label6.Size = new Size(97, 20);
            label6.TabIndex = 12;
            label6.Text = "Threads num:";
            // 
            // comboBoxSort
            // 
            comboBoxSort.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSort.FormattingEnabled = true;
            comboBoxSort.Items.AddRange(new object[] { "Name", "Id", "StartTime", "TimeSpan", "Threads" });
            comboBoxSort.Location = new Point(1044, 354);
            comboBoxSort.Name = "comboBoxSort";
            comboBoxSort.Size = new Size(151, 28);
            comboBoxSort.TabIndex = 13;
            comboBoxSort.SelectedIndexChanged += comboBoxSort_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1066, 331);
            label7.Name = "label7";
            label7.Size = new Size(112, 20);
            label7.TabIndex = 14;
            label7.Text = "Sort parameter:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1237, 450);
            Controls.Add(label7);
            Controls.Add(comboBoxSort);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnUpdate);
            Controls.Add(listBoxThreadsNum);
            Controls.Add(listBoxTimeSpan);
            Controls.Add(listBoxStartTime);
            Controls.Add(listBoxId);
            Controls.Add(btnAddProg);
            Controls.Add(listBoxProcesses);
            Controls.Add(listBoxPrograms);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnStop);
            Controls.Add(btnStart);
            Name = "Form1";
            Text = "Form1";
            FormClosed += Form1_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStart;
        private Button btnStop;
        private System.Diagnostics.Process myProcess;
        private Button btnAddProg;
        private ListBox listBoxProcesses;
        private ListBox listBoxPrograms;
        private Label label2;
        private Label label1;
        private ListBox listBoxThreadsNum;
        private ListBox listBoxTimeSpan;
        private ListBox listBoxStartTime;
        private ListBox listBoxId;
        private Button btnUpdate;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private ComboBox comboBoxSort;
        private Label label7;
    }
}