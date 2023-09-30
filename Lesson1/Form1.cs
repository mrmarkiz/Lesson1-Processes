using System.Diagnostics;

namespace Lesson1
{
    public partial class Form1 : Form
    {
        List<string> Progs;
        public Form1()
        {
            Progs = new List<string>()
            {
                "calc.exe",
                "notepad.exe",
                "mspaint.exe"
            };
            InitializeComponent();
            myProcess.StartInfo = new System.Diagnostics.ProcessStartInfo();
            updateProcesses();
            updatePrograms();
        }

        private void updateProcesses()
        {
            listBoxProcesses.Items.Clear();
            var processes = Process.GetProcesses().ToList();
            processes.Sort(procsComparer);
            foreach (var process in processes)
            {
                listBoxProcesses.Items.Add(process.ProcessName);
            }
        }

        private int procsComparer(Process pr1, Process pr2)
        {
            return string.Compare(pr1.ProcessName, pr2.ProcessName);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (listBoxPrograms.SelectedIndex != -1)
            {
                try
                {
                    myProcess.Kill();
                    myProcess.CloseMainWindow();
                    myProcess.Close();
                }
                catch
                {

                }
                myProcess.StartInfo = new ProcessStartInfo(Progs[listBoxPrograms.SelectedIndex]);
                myProcess.Start();
                updateProcesses();
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (listBoxProcesses.SelectedIndex != -1)
            {
                try
                {
                    string processName = listBoxProcesses.SelectedItem.ToString();
                    foreach (var process in Process.GetProcessesByName(processName))
                    {
                        process.Kill();
                    }
                    MessageBox.Show($"process {processName} killed");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error occured: {ex.Message}");
                }
                updateProcesses();
            }
        }

        private void btnAddProg_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "*.exe|*.exe";
            var result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                Progs.Add(dialog.FileName);
                updatePrograms();
            }
        }

        private void updatePrograms()
        {
            listBoxPrograms.Items.Clear();
            foreach (var program in Progs)
            {
                listBoxPrograms.Items.Add(program.Split("\\").Last());
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}