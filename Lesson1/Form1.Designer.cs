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
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.Location = new Point(553, 226);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(94, 29);
            btnStart.TabIndex = 0;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnStop
            // 
            btnStop.Location = new Point(553, 407);
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
            label2.Location = new Point(365, 9);
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
            listBoxProcesses.ItemHeight = 20;
            listBoxProcesses.Location = new Point(284, 53);
            listBoxProcesses.Name = "listBoxProcesses";
            listBoxProcesses.Size = new Size(231, 384);
            listBoxProcesses.TabIndex = 5;
            // 
            // btnAddProg
            // 
            btnAddProg.Location = new Point(553, 52);
            btnAddProg.Name = "btnAddProg";
            btnAddProg.Size = new Size(94, 29);
            btnAddProg.TabIndex = 6;
            btnAddProg.Text = "Add Prog";
            btnAddProg.UseVisualStyleBackColor = true;
            btnAddProg.Click += btnAddProg_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 450);
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
    }
}