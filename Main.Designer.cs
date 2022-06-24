namespace EndAssignment
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.ButtonSave = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lblNationality = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblDOB = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.Pname = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblDist = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblDistance = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonPoints = new System.Windows.Forms.Button();
            this.buttonWinner = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.contextMenuStrip1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonSave
            // 
            this.ButtonSave.Location = new System.Drawing.Point(23, 285);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(139, 31);
            this.ButtonSave.TabIndex = 6;
            this.ButtonSave.Text = "Save Record";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.openToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(120, 76);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(119, 24);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(119, 24);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(119, 24);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // tabControl2
            // 
            this.tabControl2.ContextMenuStrip = this.contextMenuStrip1;
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage1);
            this.tabControl2.Location = new System.Drawing.Point(12, 12);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(590, 420);
            this.tabControl2.TabIndex = 9;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lblNationality);
            this.tabPage3.Controls.Add(this.textBox3);
            this.tabPage3.Controls.Add(this.textBox2);
            this.tabPage3.Controls.Add(this.lblDOB);
            this.tabPage3.Controls.Add(this.textBox1);
            this.tabPage3.Controls.Add(this.lblNumber);
            this.tabPage3.Controls.Add(this.lblName);
            this.tabPage3.Controls.Add(this.Pname);
            this.tabPage3.Controls.Add(this.ButtonSave);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(582, 391);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Player";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lblNationality
            // 
            this.lblNationality.AutoSize = true;
            this.lblNationality.Location = new System.Drawing.Point(20, 211);
            this.lblNationality.Name = "lblNationality";
            this.lblNationality.Size = new System.Drawing.Size(105, 16);
            this.lblNationality.TabIndex = 13;
            this.lblNationality.Text = "Insert Nationality";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(23, 230);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(240, 22);
            this.textBox3.TabIndex = 12;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(23, 168);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(240, 22);
            this.textBox2.TabIndex = 11;
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(20, 149);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(109, 16);
            this.lblDOB.TabIndex = 10;
            this.lblDOB.Text = "Insert Player Age";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(23, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(240, 22);
            this.textBox1.TabIndex = 9;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(20, 28);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(132, 16);
            this.lblNumber.TabIndex = 8;
            this.lblNumber.Text = "Insert Player Number";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(20, 87);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(121, 16);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Insert Player Name";
            // 
            // Pname
            // 
            this.Pname.Location = new System.Drawing.Point(23, 106);
            this.Pname.Name = "Pname";
            this.Pname.Size = new System.Drawing.Size(240, 22);
            this.Pname.TabIndex = 1;
            this.Pname.TextChanged += new System.EventHandler(this.Name_TextChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.ContextMenuStrip = this.contextMenuStrip1;
            this.tabPage4.Controls.Add(this.dateTimePicker1);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Controls.Add(this.comboBox2);
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Controls.Add(this.button1);
            this.tabPage4.Controls.Add(this.lblDist);
            this.tabPage4.Controls.Add(this.comboBox1);
            this.tabPage4.Controls.Add(this.lblDistance);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(582, 391);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Race";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "mm:ss:hh";
            this.dateTimePicker1.Location = new System.Drawing.Point(31, 205);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(224, 22);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Insert Time ";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(31, 60);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(224, 24);
            this.comboBox2.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Select Player";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 272);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 35);
            this.button1.TabIndex = 8;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblDist
            // 
            this.lblDist.AutoSize = true;
            this.lblDist.Location = new System.Drawing.Point(28, 111);
            this.lblDist.Name = "lblDist";
            this.lblDist.Size = new System.Drawing.Size(140, 16);
            this.lblDist.TabIndex = 7;
            this.lblDist.Text = "Select Race Distance ";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "500 ",
            "1500",
            "5000",
            "10000"});
            this.comboBox1.Location = new System.Drawing.Point(31, 130);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(224, 24);
            this.comboBox1.TabIndex = 6;
            // 
            // lblDistance
            // 
            this.lblDistance.AutoSize = true;
            this.lblDistance.Location = new System.Drawing.Point(28, 61);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(0, 16);
            this.lblDistance.TabIndex = 5;
            this.lblDistance.Click += new System.EventHandler(this.lblDistance_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.buttonPoints);
            this.tabPage1.Controls.Add(this.buttonWinner);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(582, 391);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Championship";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(258, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(258, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonPoints
            // 
            this.buttonPoints.Location = new System.Drawing.Point(158, 208);
            this.buttonPoints.Name = "buttonPoints";
            this.buttonPoints.Size = new System.Drawing.Size(253, 27);
            this.buttonPoints.TabIndex = 1;
            this.buttonPoints.Text = "Get Points of the Winner";
            this.buttonPoints.UseVisualStyleBackColor = true;
            this.buttonPoints.Click += new System.EventHandler(this.buttonPoints_Click);
            // 
            // buttonWinner
            // 
            this.buttonWinner.Location = new System.Drawing.Point(158, 41);
            this.buttonWinner.Name = "buttonWinner";
            this.buttonWinner.Size = new System.Drawing.Size(253, 31);
            this.buttonWinner.TabIndex = 0;
            this.buttonWinner.Text = "Get Winner of the Championship";
            this.buttonWinner.UseVisualStyleBackColor = true;
            this.buttonWinner.Click += new System.EventHandler(this.buttonWinner_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 442);
            this.Controls.Add(this.tabControl2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.Resize += new System.EventHandler(this.Main_Resize);
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox Pname;
        private System.Windows.Forms.Label lblDistance;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblNationality;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblDist;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button buttonPoints;
        private System.Windows.Forms.Button buttonWinner;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

