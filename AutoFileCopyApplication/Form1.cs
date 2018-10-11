using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoFileCopyApplication
{
    public partial class Form1 : Form
    {
        bool hidden = false;
        System.Windows.Forms.Timer timer1;
        bool isTimerStartFirst = true;
        bool isFileCopied = false;
        DateTime firstStarted = DateTime.Now;
        Int32 timeMiliseconds = 6000;
        static bool isPathFromFile = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            try
            {
                if (isPathFromFile == false)
                {
                    using (StreamWriter writetext = new StreamWriter("readpath.txt"))
                    {
                        writetext.WriteLine(txt_FileName.Text);
                        writetext.WriteLine(txt_InputPath.Text);
                        writetext.WriteLine(txt_OutputPath.Text);
                    }
                }

                //if (txt_FileName.Text != "" && txt_InputPath.Text != "" && txt_OutputPath.Text != "")
                if (txt_FileName.Text != "" && txt_InputPath.Text != "" && txt_OutputPath.Text != "")
                {
                }
                else
                {
                    string error = (txt_FileName.Text == "") ? "Enter File Name \n" : "";
                    error += (txt_InputPath.Text == "") ? "Select Input Path \n" : "";
                    error += (txt_OutputPath.Text == "") ? "Select Output Path \n" : "";
                    MessageBox.Show(error, "Error");

                }
            }
            catch (Exception ex)
            {
                ErrorLog(ex.Message, "Start Button");
            }
        }
        private void StartCopy()
        {
            try
            {
                lb_Status.Items.Add("---------------------------------");
                lb_Status.Items.Add(DateTime.Now + " - Checking for files...");
                DirectoryInfo dir = new DirectoryInfo(txt_InputPath.Text);
                FileInfo[] files = dir.GetFiles(txt_FileName.Text);
                int fileCount = 0;
                Thread t = new Thread(new ThreadStart(delegate
                {
                    foreach (FileInfo f in files)
                    {
                        this.Invoke((MethodInvoker)delegate
                        {
                            lb_Error.BackColor = Color.Green;
                        });
                        string name = f.Name;
                        string dateTime = f.LastWriteTime.ToString("dd/MM/yyyy HH:mm:ss");
                        DateTime lastTime = DateTime.ParseExact(dateTime, "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
                        DateTime fileDate = lastTime;
                        DateTime systemDate = DateTime.Now;
                        TimeSpan time = systemDate - fileDate;

                        if (time.TotalHours < 2)
                        //if (time.TotalDays < 20)
                        {
                            this.Invoke((MethodInvoker)delegate
                            {
                                lb_Status.Items.Add(DateTime.Now + " - Copying started...");
                            });
                            //CopyFile(name, txt_InputPath.Text, txt_OutputPath.Text);
                            File.Copy(txt_InputPath.Text + "\\" + name, txt_OutputPath.Text + "\\" + name, true);                            
                            this.Invoke((MethodInvoker)delegate
                            {
                                lb_Status.Items.Add(DateTime.Now + " - " + name + " - copied successfully");
                                using (StreamWriter writetext = new StreamWriter("copiedfiles.txt", true))
                                {
                                    writetext.WriteLine(DateTime.Now + " - File: " + name + " copied successfully");
                                }
                                lb_Status.Items.Add(DateTime.Now + " - Copying ended...");
                                lb_Status.Items.Add("---------------------------------");
                            });
                            this.Invoke((MethodInvoker)delegate
                            {
                                fileCount++;
                            });
                        }                       
                    }
                    this.Invoke((MethodInvoker)delegate
                    {
                        lb_Error.BackColor = Color.Honeydew;
                        lb_Status.Items.Add("--------------waiting-------------");
                    });
                    Thread.Sleep(timeMiliseconds);
                }));
                
                t.IsBackground = true;
                t.Start();

                if (fileCount == 0)
                    isFileCopied = false;
                else
                    isFileCopied = true;

                SetTimerInterval();
                TimeSpan timeSpan = TimeSpan.FromMilliseconds(timeMiliseconds);
                lb_Status.Items.Add("Next File Check in " + timeSpan.TotalHours.ToString() + " Hours.");
                lb_Status.Items.Add("---------------------------------");
            }
            catch (Exception ex)
            {
                ErrorLog(ex.Message, "Copy Thread");
            }
        }
        private string CopyFile(string fileName, string inputPath, string outputPath)
        {
            string returnMessage = "";
            try
            {

               


            }
            catch (Exception ex)
            {
                ErrorLog(ex.Message, "Copy File");
                returnMessage = "Error: " + ex.Message;
            }
            return returnMessage;
        }

        private void btn_DialogInput_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = folderBrowserDialog_Input.ShowDialog();
                if (result == DialogResult.OK)
                {
                    //
                    // The user selected a folder and pressed the OK button.
                    // We print the number of files found.
                    //
                    txt_InputPath.Text = folderBrowserDialog_Input.SelectedPath.ToString();
                    //string[] files = Directory.GetFiles(folderBrowserDialog_Input.SelectedPath);
                    //MessageBox.Show("Files found: " + files.Length.ToString(), "Message");
                }
            }
            catch (Exception ex)
            {
                ErrorLog(ex.Message, "Input Dialog");
            }
        }

        private void btn_DialogOutput_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = folderBrowserDialog_Output.ShowDialog();
                if (result == DialogResult.OK)
                {
                    //
                    // The user selected a folder and pressed the OK button.
                    // We print the number of files found.
                    //
                    txt_OutputPath.Text = folderBrowserDialog_Output.SelectedPath.ToString();
                    //string[] files = Directory.GetFiles(folderBrowserDialog_Input.SelectedPath);
                    //MessageBox.Show("Files found: " + files.Length.ToString(), "Message");
                }
            }
            catch (Exception ex)
            {
                ErrorLog(ex.Message, "Output Dialog");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {            

            this.ShowInTaskbar = false;         

            try
            {
                const Int32 BufferSize = 128;
                using (var fileStream = File.OpenRead("readpath.txt"))
                using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, BufferSize))
                {
                    String line;
                    int counter = 0;
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        if (counter == 0)
                            txt_FileName.Text = line;
                        else if (counter == 1)
                            txt_InputPath.Text = line;
                        else if (counter == 2)
                            txt_OutputPath.Text = line;

                        counter++;
                    }
                    if (counter == 2)
                        isPathFromFile = true;
                    // Process line                    
                }
                InitTimer();
            }
            catch (Exception ex)
            {
                lb_Error.Items.Clear();
                ErrorLog(ex.Message, "Form Load");
            }
        }


        private void ErrorLog(string exception, string level)
        {
            lb_Error.Items.Insert(0, DateTime.Now + " - Level: " + level + " - Exception: " + exception);
            using (StreamWriter writetext = new StreamWriter("error.txt"))
            {
                writetext.WriteLine(DateTime.Now + " - Level: " + level + " - Exception: " + exception);
            }
        }
        public void InitTimer()
        {
            StartCopy();
            timer1 = new System.Windows.Forms.Timer();
            timer1.Tick += new EventHandler(timer1_Tick);

            timer1.Interval = timeMiliseconds;
            //timer1.Interval = (isTimerStartFirst == true) ? 200 : 60000; // in miliseconds
            timer1.Start();
        }

        private void SetTimerInterval()
        {
            //timeMiliseconds = (isFileCopied != true) ? 60000 * 30 : (60000 * 60) * 12; // 60000 miliseconds = 1 min 
            timeMiliseconds = (60000 * 60)*2; // 60000 miliseconds = 1 min             
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            StartCopy();

            if (lb_Status.Items.Count > 1500)
            {
                lb_Status.Items.Clear();
                lb_Status.Items.Add(DateTime.Now + " - Log cleared");
            }
        }


        private void notifyIcon1_Click(object sender, EventArgs e)
        {

        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ShowInTaskbar = true;
            notifyIcon1.Visible = true;
            WindowState = FormWindowState.Normal;
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            ShowInTaskbar = true;
            notifyIcon1.Visible = true;
            WindowState = FormWindowState.Normal;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                ShowInTaskbar = false;
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(300);
            }
        }
    }
}