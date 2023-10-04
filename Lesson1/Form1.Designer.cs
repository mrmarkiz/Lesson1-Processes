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
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.Location = new Point(1073, 219);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(94, 29);
            btnStart.TabIndex = 0;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnStop
            // 
            btnStop.Location = new Point(1073, 400);
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
            label1.Location = new Point(81, 9);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 2;
            label1.Text = "Programs:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(331, 9);
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
            // 
            // listBoxStartTime
            // 
            listBoxStartTime.FormattingEnabled = true;
            listBoxStartTime.ItemHeight = 20;
            listBoxStartTime.Location = new Point(572, 53);
            listBoxStartTime.Name = "listBoxStartTime";
            listBoxStartTime.Size = new Size(149, 384);
            listBoxStartTime.TabIndex = 7;
            // 
            // listBoxTimeSpan
            // 
            listBoxTimeSpan.FormattingEnabled = true;
            listBoxTimeSpan.ItemHeight = 20;
            listBoxTimeSpan.Location = new Point(727, 53);
            listBoxTimeSpan.Name = "listBoxTimeSpan";
            listBoxTimeSpan.Size = new Size(158, 384);
            listBoxTimeSpan.TabIndex = 7;
            // 
            // listBoxThreadsNum
            // 
            listBoxThreadsNum.FormattingEnabled = true;
            listBoxThreadsNum.ItemHeight = 20;
            listBoxThreadsNum.Location = new Point(891, 53);
            listBoxThreadsNum.Name = "listBoxThreadsNum";
            listBoxThreadsNum.Size = new Size(102, 384);
            listBoxThreadsNum.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1518, 450);
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
    }
}