using System.Diagnostics;
using System.Linq;

namespace Lesson1
{
    public partial class Form1 : Form
    {
        List<string> Progs;
        string sortParameter = null;
        public Form1()
        {
            Progs = new List<string>()
            {
                "calc.exe",
                "notepad.exe",
                "mspaint.exe"
            };
            InitializeComponent();
            comboBoxSort.SelectedIndex = 0;
            myProcess.StartInfo = new System.Diagnostics.ProcessStartInfo();
            updateProcesses();
            updatePrograms();
        }

        private void updateProcesses()
        {
            listBoxProcesses.Items.Clear();
            listBoxId.Items.Clear();
            listBoxStartTime.Items.Clear();
            listBoxTimeSpan.Items.Clear();
            listBoxThreadsNum.Items.Clear();

            var processesList = Process.GetProcesses().ToList();
            if (sortParameter != null)
            {
                switch (sortParameter)
                {
                    case "Name":
                        processesList.Sort(procsNameComparer);
                        break;
                    case "Id":
                        processesList.Sort(procsIdComparer);
                        break;
                    case "StartTime":
                        processesList.Sort(procsStartTimeComparer);
                        break;
                    case "TimeSpan":
                        processesList.Sort(procsTimeSpanComparer);
                        break;
                    case "Threads":
                        processesList.Sort(procsThreadsComparer);
                        break;

                }
            }
            var processes = processesList.DistinctBy(proc => proc.ProcessName).ToDictionary(proc => proc.ProcessName);

            foreach (var process in processes)
            {
                int n = processesList.Count(proc => proc.ProcessName == process.Value.ProcessName);
                if (n > 1)
                {
                    listBoxProcesses.Items.Add($"{process.Value.ProcessName}({n})");
                }
                else
                {
                    listBoxProcesses.Items.Add(process.Value.ProcessName);

                    listBoxId.Items.Add(process.Value.Id);
                    try
                    {
                        listBoxStartTime.Items.Add(process.Value.StartTime);
                    }
                    catch
                    {
                        listBoxStartTime.Items.Add("Unkonwn");
                    }
                    try
                    {
                        listBoxTimeSpan.Items.Add(process.Value.UserProcessorTime);
                    }
                    catch
                    {
                        listBoxTimeSpan.Items.Add("Unknown");
                    }
                    listBoxThreadsNum.Items.Add(process.Value.Threads.Count);
                }

            }
        }

        private int procsNameComparer(Process pr1, Process pr2)
        {
            return string.Compare(pr1.ProcessName, pr2.ProcessName);
        }

        private int procsIdComparer(Process pr1, Process pr2)
        {
            if (pr1.Id > pr2.Id)
            {
                return 1;
            }
            else if (pr1.Id < pr2.Id)
            {
                return -1;
            }
            return 0;
        }

        //needed optimization
        private int procsStartTimeComparer(Process pr1, Process pr2)
        {
            DateTime t1, t2;
            bool hasFirst = true, hasSecond = true;
            try
            {
                t1 = pr1.StartTime;
            }
            catch
            {
                t1 = new DateTime();
                hasFirst = false;
            }
            try
            {
                t2 = pr2.StartTime;
            }
            catch
            {
                t2 = new DateTime();
                hasSecond = false;
            }
            if (!hasSecond && !hasFirst)
                return 0;
            if (!hasSecond)
                return 1;
            if (!hasFirst)
                return -1;
            return DateTime.Compare(t1, t2);
        }

        //needed optimization
        private int procsTimeSpanComparer(Process pr1, Process pr2)
        {
            TimeSpan t1, t2;
            bool hasFirst = true, hasSecond = true;
            try
            {
                t1 = pr1.UserProcessorTime;
            }
            catch
            {
                t1 = new TimeSpan();
                hasFirst = false;
            }
            try
            {
                t2 = pr2.UserProcessorTime;
            }
            catch
            {
                t2 = new TimeSpan();
                hasSecond = false;
            }
            if (!hasSecond && !hasFirst)
                return 0;
            if (!hasSecond)
                return 1;
            if (!hasFirst)
                return -1;
            return TimeSpan.Compare(t1, t2);
        }
        private int procsThreadsComparer(Process pr1, Process pr2)
        {
            if (pr1.Threads.Count > pr2.Threads.Count)
            {
                return 1;
            }
            else if (pr1.Threads.Count < pr2.Threads.Count)
            {
                return -1;
            }
            return 0;
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
                    string processName;
                    if (listBoxProcesses.SelectedItem.ToString().Contains('('))
                    {
                        processName = listBoxProcesses.SelectedItem.ToString().Split('(')[0];
                    }
                    else
                    {
                        processName = listBoxProcesses.SelectedItem.ToString();
                    }
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updateProcesses();
        }

        private void comboBoxSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            sortParameter = comboBoxSort.SelectedItem.ToString();
        }
    }
}