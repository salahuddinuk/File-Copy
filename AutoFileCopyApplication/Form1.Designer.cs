namespace AutoFileCopyApplication
{
    partial class Form1
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
            if (disposing && (components != null))
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txt_FileName = new System.Windows.Forms.TextBox();
            this.txt_InputPath = new System.Windows.Forms.TextBox();
            this.txt_OutputPath = new System.Windows.Forms.TextBox();
            this.lbl_FileName = new System.Windows.Forms.Label();
            this.lbl_InputPath = new System.Windows.Forms.Label();
            this.lbl_OutputPath = new System.Windows.Forms.Label();
            this.lb_Status = new System.Windows.Forms.ListBox();
            this.btn_Start = new System.Windows.Forms.Button();
            this.btn_DialogInput = new System.Windows.Forms.Button();
            this.btn_DialogOutput = new System.Windows.Forms.Button();
            this.folderBrowserDialog_Input = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialog_Output = new System.Windows.Forms.FolderBrowserDialog();
            this.lb_Error = new System.Windows.Forms.ListBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // txt_FileName
            // 
            this.txt_FileName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_FileName.Enabled = false;
            this.txt_FileName.Location = new System.Drawing.Point(109, 18);
            this.txt_FileName.Name = "txt_FileName";
            this.txt_FileName.Size = new System.Drawing.Size(260, 20);
            this.txt_FileName.TabIndex = 0;
            this.txt_FileName.Text = "*.bak";
            // 
            // txt_InputPath
            // 
            this.txt_InputPath.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_InputPath.Enabled = false;
            this.txt_InputPath.Location = new System.Drawing.Point(109, 44);
            this.txt_InputPath.Name = "txt_InputPath";
            this.txt_InputPath.ReadOnly = true;
            this.txt_InputPath.Size = new System.Drawing.Size(260, 20);
            this.txt_InputPath.TabIndex = 1;
            // 
            // txt_OutputPath
            // 
            this.txt_OutputPath.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_OutputPath.Enabled = false;
            this.txt_OutputPath.Location = new System.Drawing.Point(109, 71);
            this.txt_OutputPath.Name = "txt_OutputPath";
            this.txt_OutputPath.ReadOnly = true;
            this.txt_OutputPath.Size = new System.Drawing.Size(260, 20);
            this.txt_OutputPath.TabIndex = 2;
            // 
            // lbl_FileName
            // 
            this.lbl_FileName.AutoSize = true;
            this.lbl_FileName.Location = new System.Drawing.Point(19, 21);
            this.lbl_FileName.Name = "lbl_FileName";
            this.lbl_FileName.Size = new System.Drawing.Size(54, 13);
            this.lbl_FileName.TabIndex = 3;
            this.lbl_FileName.Text = "File Name";
            // 
            // lbl_InputPath
            // 
            this.lbl_InputPath.AutoSize = true;
            this.lbl_InputPath.Location = new System.Drawing.Point(19, 47);
            this.lbl_InputPath.Name = "lbl_InputPath";
            this.lbl_InputPath.Size = new System.Drawing.Size(56, 13);
            this.lbl_InputPath.TabIndex = 4;
            this.lbl_InputPath.Text = "Input Path";
            // 
            // lbl_OutputPath
            // 
            this.lbl_OutputPath.AutoSize = true;
            this.lbl_OutputPath.Location = new System.Drawing.Point(19, 78);
            this.lbl_OutputPath.Name = "lbl_OutputPath";
            this.lbl_OutputPath.Size = new System.Drawing.Size(64, 13);
            this.lbl_OutputPath.TabIndex = 5;
            this.lbl_OutputPath.Text = "Output Path";
            // 
            // lb_Status
            // 
            this.lb_Status.FormattingEnabled = true;
            this.lb_Status.Location = new System.Drawing.Point(22, 105);
            this.lb_Status.Name = "lb_Status";
            this.lb_Status.Size = new System.Drawing.Size(476, 290);
            this.lb_Status.TabIndex = 6;
            // 
            // btn_Start
            // 
            this.btn_Start.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Start.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_Start.Location = new System.Drawing.Point(414, 18);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(84, 74);
            this.btn_Start.TabIndex = 7;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = false;
            this.btn_Start.Visible = false;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // btn_DialogInput
            // 
            this.btn_DialogInput.Enabled = false;
            this.btn_DialogInput.Location = new System.Drawing.Point(370, 43);
            this.btn_DialogInput.Name = "btn_DialogInput";
            this.btn_DialogInput.Size = new System.Drawing.Size(26, 22);
            this.btn_DialogInput.TabIndex = 9;
            this.btn_DialogInput.Text = "...";
            this.btn_DialogInput.UseVisualStyleBackColor = true;
            this.btn_DialogInput.Click += new System.EventHandler(this.btn_DialogInput_Click);
            // 
            // btn_DialogOutput
            // 
            this.btn_DialogOutput.Enabled = false;
            this.btn_DialogOutput.Location = new System.Drawing.Point(370, 70);
            this.btn_DialogOutput.Name = "btn_DialogOutput";
            this.btn_DialogOutput.Size = new System.Drawing.Size(26, 22);
            this.btn_DialogOutput.TabIndex = 10;
            this.btn_DialogOutput.Text = "...";
            this.btn_DialogOutput.UseVisualStyleBackColor = true;
            this.btn_DialogOutput.Click += new System.EventHandler(this.btn_DialogOutput_Click);
            // 
            // lb_Error
            // 
            this.lb_Error.BackColor = System.Drawing.Color.NavajoWhite;
            this.lb_Error.FormattingEnabled = true;
            this.lb_Error.Location = new System.Drawing.Point(22, 399);
            this.lb_Error.Name = "lb_Error";
            this.lb_Error.Size = new System.Drawing.Size(476, 43);
            this.lb_Error.TabIndex = 11;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipText = "Minimize to tray";
            this.notifyIcon1.BalloonTipTitle = "SQL Backup File Copier";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "SQL Backup File Copier";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 464);
            this.Controls.Add(this.lb_Error);
            this.Controls.Add(this.btn_DialogOutput);
            this.Controls.Add(this.btn_DialogInput);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.lb_Status);
            this.Controls.Add(this.lbl_OutputPath);
            this.Controls.Add(this.lbl_InputPath);
            this.Controls.Add(this.lbl_FileName);
            this.Controls.Add(this.txt_OutputPath);
            this.Controls.Add(this.txt_InputPath);
            this.Controls.Add(this.txt_FileName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(538, 503);
            this.Name = "Form1";
            this.Text = "SQL Backup File Copier";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_FileName;
        private System.Windows.Forms.TextBox txt_InputPath;
        private System.Windows.Forms.TextBox txt_OutputPath;
        private System.Windows.Forms.Label lbl_FileName;
        private System.Windows.Forms.Label lbl_InputPath;
        private System.Windows.Forms.Label lbl_OutputPath;
        private System.Windows.Forms.ListBox lb_Status;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Button btn_DialogInput;
        private System.Windows.Forms.Button btn_DialogOutput;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog_Input;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog_Output;
        private System.Windows.Forms.ListBox lb_Error;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

