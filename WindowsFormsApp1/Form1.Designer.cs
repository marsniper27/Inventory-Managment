namespace WindowsFormsApp1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Reports = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Monthly = new System.Windows.Forms.Button();
            this.Weekly = new System.Windows.Forms.Button();
            this.TwoWeeks = new System.Windows.Forms.Button();
            this.DownEquipment = new System.Windows.Forms.Button();
            this.OutByTeam = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SaveReport = new System.Windows.Forms.Button();
            this.PrintReport = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DataManagment = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.AddEmployee = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.IDCardTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.FirstName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Team = new System.Windows.Forms.Label();
            this.Role = new System.Windows.Forms.Label();
            this.IDCard = new System.Windows.Forms.Label();
            this.SubmitEmployee = new System.Windows.Forms.Button();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.TeamListBox = new System.Windows.Forms.ListBox();
            this.RoleListBox = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.Reports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.DataManagment.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.AddEmployee.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Reports);
            this.tabControl1.Controls.Add(this.DataManagment);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // Reports
            // 
            this.Reports.Controls.Add(this.splitContainer1);
            this.Reports.Location = new System.Drawing.Point(4, 29);
            this.Reports.Name = "Reports";
            this.Reports.Padding = new System.Windows.Forms.Padding(3);
            this.Reports.Size = new System.Drawing.Size(792, 417);
            this.Reports.TabIndex = 1;
            this.Reports.Text = "Reports";
            this.Reports.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.flowLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(786, 411);
            this.splitContainer1.SplitterDistance = 151;
            this.splitContainer1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.Monthly);
            this.flowLayoutPanel1.Controls.Add(this.Weekly);
            this.flowLayoutPanel1.Controls.Add(this.TwoWeeks);
            this.flowLayoutPanel1.Controls.Add(this.DownEquipment);
            this.flowLayoutPanel1.Controls.Add(this.OutByTeam);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(151, 411);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // Monthly
            // 
            this.Monthly.AutoSize = true;
            this.Monthly.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Monthly.Location = new System.Drawing.Point(3, 3);
            this.Monthly.Name = "Monthly";
            this.Monthly.Size = new System.Drawing.Size(149, 30);
            this.Monthly.TabIndex = 0;
            this.Monthly.Text = "Monthly Report";
            this.Monthly.UseVisualStyleBackColor = true;
            this.Monthly.Click += new System.EventHandler(this.Monthly_Click);
            // 
            // Weekly
            // 
            this.Weekly.AutoSize = true;
            this.Weekly.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Weekly.Location = new System.Drawing.Point(3, 39);
            this.Weekly.Name = "Weekly";
            this.Weekly.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Weekly.Size = new System.Drawing.Size(149, 30);
            this.Weekly.TabIndex = 1;
            this.Weekly.Text = "Weekly Report";
            this.Weekly.UseVisualStyleBackColor = true;
            this.Weekly.Click += new System.EventHandler(this.Weekly_Click);
            // 
            // TwoWeeks
            // 
            this.TwoWeeks.AutoSize = true;
            this.TwoWeeks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TwoWeeks.Location = new System.Drawing.Point(3, 75);
            this.TwoWeeks.Name = "TwoWeeks";
            this.TwoWeeks.Size = new System.Drawing.Size(149, 30);
            this.TwoWeeks.TabIndex = 2;
            this.TwoWeeks.Text = "Out < Two Weeks";
            this.TwoWeeks.UseVisualStyleBackColor = true;
            this.TwoWeeks.Click += new System.EventHandler(this.TwoWeeks_Click);
            // 
            // DownEquipment
            // 
            this.DownEquipment.AutoSize = true;
            this.DownEquipment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DownEquipment.Location = new System.Drawing.Point(3, 111);
            this.DownEquipment.Name = "DownEquipment";
            this.DownEquipment.Size = new System.Drawing.Size(149, 30);
            this.DownEquipment.TabIndex = 3;
            this.DownEquipment.Text = "Down Equipment";
            this.DownEquipment.UseVisualStyleBackColor = true;
            this.DownEquipment.Click += new System.EventHandler(this.DownEquipment_click);
            // 
            // OutByTeam
            // 
            this.OutByTeam.AutoSize = true;
            this.OutByTeam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OutByTeam.Location = new System.Drawing.Point(3, 147);
            this.OutByTeam.Name = "OutByTeam";
            this.OutByTeam.Size = new System.Drawing.Size(149, 30);
            this.OutByTeam.TabIndex = 4;
            this.OutByTeam.Text = "Out By Team";
            this.OutByTeam.UseVisualStyleBackColor = true;
            this.OutByTeam.Click += new System.EventHandler(this.OutByTeam_click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.SaveReport, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.PrintReport, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(631, 411);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // SaveReport
            // 
            this.SaveReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveReport.Location = new System.Drawing.Point(3, 354);
            this.SaveReport.Name = "SaveReport";
            this.SaveReport.Size = new System.Drawing.Size(309, 54);
            this.SaveReport.TabIndex = 0;
            this.SaveReport.Text = "Save Report";
            this.SaveReport.UseVisualStyleBackColor = true;
            this.SaveReport.Click += new System.EventHandler(this.SaveReport_Click);
            // 
            // PrintReport
            // 
            this.PrintReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PrintReport.Location = new System.Drawing.Point(318, 354);
            this.PrintReport.Name = "PrintReport";
            this.PrintReport.Size = new System.Drawing.Size(310, 54);
            this.PrintReport.TabIndex = 1;
            this.PrintReport.Text = "Print Report";
            this.PrintReport.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridView1, 2);
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(625, 345);
            this.dataGridView1.TabIndex = 2;
            // 
            // DataManagment
            // 
            this.DataManagment.Controls.Add(this.tabControl2);
            this.DataManagment.Location = new System.Drawing.Point(4, 29);
            this.DataManagment.Name = "DataManagment";
            this.DataManagment.Padding = new System.Windows.Forms.Padding(3);
            this.DataManagment.Size = new System.Drawing.Size(792, 417);
            this.DataManagment.TabIndex = 0;
            this.DataManagment.Text = "Data Managment";
            this.DataManagment.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.AddEmployee);
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(3, 3);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(786, 411);
            this.tabControl2.TabIndex = 0;
            // 
            // AddEmployee
            // 
            this.AddEmployee.Controls.Add(this.tableLayoutPanel2);
            this.AddEmployee.Location = new System.Drawing.Point(4, 29);
            this.AddEmployee.Name = "AddEmployee";
            this.AddEmployee.Padding = new System.Windows.Forms.Padding(3);
            this.AddEmployee.Size = new System.Drawing.Size(778, 378);
            this.AddEmployee.TabIndex = 0;
            this.AddEmployee.Text = "Add Employee";
            this.AddEmployee.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.IDCardTextBox, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.LastNameTextBox, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.FirstName, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.Team, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.Role, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.IDCard, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.SubmitEmployee, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.FirstNameTextBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.TeamListBox, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.RoleListBox, 1, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(772, 372);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // IDCardTextBox
            // 
            this.IDCardTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.IDCardTextBox.Location = new System.Drawing.Point(103, 284);
            this.IDCardTextBox.Name = "IDCardTextBox";
            this.IDCardTextBox.Size = new System.Drawing.Size(213, 26);
            this.IDCardTextBox.TabIndex = 10;
            this.IDCardTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LastNameTextBox.Location = new System.Drawing.Point(103, 86);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(213, 26);
            this.LastNameTextBox.TabIndex = 7;
            this.LastNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FirstName.Location = new System.Drawing.Point(3, 0);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(94, 66);
            this.FirstName.TabIndex = 0;
            this.FirstName.Text = "First Name:";
            this.FirstName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 66);
            this.label1.TabIndex = 1;
            this.label1.Text = "Last Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Team
            // 
            this.Team.AutoSize = true;
            this.Team.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Team.Location = new System.Drawing.Point(3, 132);
            this.Team.Name = "Team";
            this.Team.Size = new System.Drawing.Size(94, 66);
            this.Team.TabIndex = 2;
            this.Team.Text = "Team:";
            this.Team.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Role
            // 
            this.Role.AutoSize = true;
            this.Role.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Role.Location = new System.Drawing.Point(3, 198);
            this.Role.Name = "Role";
            this.Role.Size = new System.Drawing.Size(94, 66);
            this.Role.TabIndex = 3;
            this.Role.Text = "Role:";
            this.Role.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IDCard
            // 
            this.IDCard.AutoSize = true;
            this.IDCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IDCard.Location = new System.Drawing.Point(3, 264);
            this.IDCard.Name = "IDCard";
            this.IDCard.Size = new System.Drawing.Size(94, 66);
            this.IDCard.TabIndex = 4;
            this.IDCard.Text = "ID Card:";
            this.IDCard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SubmitEmployee
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.SubmitEmployee, 2);
            this.SubmitEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SubmitEmployee.Location = new System.Drawing.Point(3, 333);
            this.SubmitEmployee.Name = "SubmitEmployee";
            this.SubmitEmployee.Size = new System.Drawing.Size(766, 36);
            this.SubmitEmployee.TabIndex = 11;
            this.SubmitEmployee.Text = "Submit";
            this.SubmitEmployee.UseVisualStyleBackColor = true;
            this.SubmitEmployee.Click += new System.EventHandler(this.SubmitEmployee_Click);
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.FirstNameTextBox.Location = new System.Drawing.Point(103, 20);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(213, 26);
            this.FirstNameTextBox.TabIndex = 6;
            this.FirstNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TeamListBox
            // 
            this.TeamListBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.TeamListBox.FormattingEnabled = true;
            this.TeamListBox.ItemHeight = 20;
            this.TeamListBox.Items.AddRange(new object[] {
            "Four Kings",
            "Light House",
            "Ignite",
            "Infinity",
            "Fenix",
            "IGT Moncton"});
            this.TeamListBox.Location = new System.Drawing.Point(103, 135);
            this.TeamListBox.Name = "TeamListBox";
            this.TeamListBox.Size = new System.Drawing.Size(213, 60);
            this.TeamListBox.TabIndex = 8;
            // 
            // RoleListBox
            // 
            this.RoleListBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.RoleListBox.FormattingEnabled = true;
            this.RoleListBox.ItemHeight = 20;
            this.RoleListBox.Items.AddRange(new object[] {
            "Tester",
            "Lead",
            "Backup"});
            this.RoleListBox.Location = new System.Drawing.Point(103, 201);
            this.RoleListBox.Name = "RoleListBox";
            this.RoleListBox.Size = new System.Drawing.Size(213, 60);
            this.RoleListBox.TabIndex = 9;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(778, 378);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.Reports.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.DataManagment.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.AddEmployee.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage DataManagment;
        private System.Windows.Forms.TabPage Reports;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button SaveReport;
        private System.Windows.Forms.Button PrintReport;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button Monthly;
        private System.Windows.Forms.Button Weekly;
        private System.Windows.Forms.Button TwoWeeks;
        private System.Windows.Forms.Button DownEquipment;
        private System.Windows.Forms.Button OutByTeam;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage AddEmployee;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Team;
        private System.Windows.Forms.Label Role;
        private System.Windows.Forms.Label IDCard;
        private System.Windows.Forms.Button SubmitEmployee;
        private System.Windows.Forms.TextBox IDCardTextBox;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.ListBox TeamListBox;
        private System.Windows.Forms.ListBox RoleListBox;
    }
}

