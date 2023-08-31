namespace IBroker
{
    partial class DashBoard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSearchBar = new System.Windows.Forms.TextBox();
            this.lblLogo = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CaseDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastUpdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tracking_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Update = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblshow = new System.Windows.Forms.Label();
            this.lblRecent = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDashboard = new System.Windows.Forms.Label();
            this.tblCases = new System.Windows.Forms.TableLayoutPanel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tblUnassigned = new System.Windows.Forms.TableLayoutPanel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.tblTask = new System.Windows.Forms.TableLayoutPanel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.pnlCases = new System.Windows.Forms.Label();
            this.pnlUnassign = new System.Windows.Forms.Panel();
            this.lblUnassigned = new System.Windows.Forms.Label();
            this.pnlTask = new System.Windows.Forms.Panel();
            this.lblTask = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel9.SuspendLayout();
            this.tblCases.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel15.SuspendLayout();
            this.tblTask.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel8.SuspendLayout();
            this.pnlUnassign.SuspendLayout();
            this.pnlTask.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button10);
            this.panel1.Controls.Add(this.txtSearchBar);
            this.panel1.Controls.Add(this.lblLogo);
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1824, 76);
            this.panel1.TabIndex = 0;
            // 
            // txtSearchBar
            // 
            this.txtSearchBar.Location = new System.Drawing.Point(312, 24);
            this.txtSearchBar.Name = "txtSearchBar";
            this.txtSearchBar.Size = new System.Drawing.Size(350, 26);
            this.txtSearchBar.TabIndex = 2;
            this.txtSearchBar.Text = "Search";
            this.txtSearchBar.TextChanged += new System.EventHandler(this.txtSearchBar_TextChanged);
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.Location = new System.Drawing.Point(52, 24);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(93, 37);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "Logo";
            // 
            // btnLogOut
            // 
            this.btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
            this.btnLogOut.Location = new System.Drawing.Point(1758, 11);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(54, 52);
            this.btnLogOut.TabIndex = 0;
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.button8_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Controls.Add(this.button4);
            this.flowLayoutPanel1.Controls.Add(this.button5);
            this.flowLayoutPanel1.Controls.Add(this.button6);
            this.flowLayoutPanel1.Controls.Add(this.button7);
            this.flowLayoutPanel1.Controls.Add(this.button8);
            this.flowLayoutPanel1.Controls.Add(this.button9);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 76);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(306, 974);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(306, 94);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(113, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Power User";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(113, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(3, 103);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(303, 65);
            this.button2.TabIndex = 1;
            this.button2.Text = "   Dashboard";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(3, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(303, 70);
            this.button1.TabIndex = 0;
            this.button1.Text = "   Manage Registration";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(3, 250);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(303, 53);
            this.button3.TabIndex = 2;
            this.button3.Text = "Manage E-Forms";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(3, 309);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(303, 58);
            this.button4.TabIndex = 2;
            this.button4.Text = "Manage Case";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(3, 373);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(303, 69);
            this.button5.TabIndex = 2;
            this.button5.Text = "    Manage Business Rules";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(3, 448);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(303, 58);
            this.button6.TabIndex = 2;
            this.button6.Text = "Manage Partner";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(3, 512);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(303, 64);
            this.button7.TabIndex = 3;
            this.button7.Text = "Manage Product";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(312, 76);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1512, 974);
            this.panel3.TabIndex = 1;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel7.Controls.Add(this.panel15);
            this.panel7.Controls.Add(this.panel16);
            this.panel7.Controls.Add(this.panel9);
            this.panel7.Controls.Add(this.lblDashboard);
            this.panel7.Controls.Add(this.tblCases);
            this.panel7.Controls.Add(this.tblUnassigned);
            this.panel7.Controls.Add(this.tblTask);
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Controls.Add(this.pnlUnassign);
            this.panel7.Controls.Add(this.pnlTask);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1512, 974);
            this.panel7.TabIndex = 4;
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel16.Controls.Add(this.dataGridView1);
            this.panel16.Controls.Add(this.label19);
            this.panel16.Controls.Add(this.textBox2);
            this.panel16.Controls.Add(this.label18);
            this.panel16.Controls.Add(this.textBox1);
            this.panel16.Controls.Add(this.lblshow);
            this.panel16.Controls.Add(this.lblRecent);
            this.panel16.Location = new System.Drawing.Point(32, 253);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(1446, 649);
            this.panel16.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 50;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CaseDescription,
            this.Status,
            this.LastUpdate,
            this.Tracking_ID,
            this.Edit,
            this.Update});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(28, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.RowHeadersWidth = 100;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView1.Size = new System.Drawing.Size(1390, 515);
            this.dataGridView1.TabIndex = 6;
            // 
            // CaseDescription
            // 
            this.CaseDescription.HeaderText = "User";
            this.CaseDescription.MinimumWidth = 8;
            this.CaseDescription.Name = "CaseDescription";
            this.CaseDescription.Width = 150;
            // 
            // Status
            // 
            this.Status.HeaderText = "Case Description";
            this.Status.MinimumWidth = 8;
            this.Status.Name = "Status";
            this.Status.Width = 150;
            // 
            // LastUpdate
            // 
            this.LastUpdate.HeaderText = "Status";
            this.LastUpdate.MinimumWidth = 8;
            this.LastUpdate.Name = "LastUpdate";
            this.LastUpdate.Width = 150;
            // 
            // Tracking_ID
            // 
            this.Tracking_ID.HeaderText = "Last Update";
            this.Tracking_ID.MinimumWidth = 8;
            this.Tracking_ID.Name = "Tracking_ID";
            this.Tracking_ID.Width = 150;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Tracking ID";
            this.Edit.MinimumWidth = 8;
            this.Edit.Name = "Edit";
            this.Edit.Width = 150;
            // 
            // Update
            // 
            this.Update.HeaderText = "Edit";
            this.Update.MinimumWidth = 8;
            this.Update.Name = "Update";
            this.Update.Width = 150;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label19.Location = new System.Drawing.Point(1109, 59);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(71, 20);
            this.label19.TabIndex = 5;
            this.label19.Text = "Search:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1195, 53);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(223, 26);
            this.textBox2.TabIndex = 4;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label18.Location = new System.Drawing.Point(143, 59);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(64, 20);
            this.label18.TabIndex = 3;
            this.label18.Text = "entries";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(83, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(47, 26);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "  10";
            // 
            // lblshow
            // 
            this.lblshow.AutoSize = true;
            this.lblshow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblshow.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblshow.Location = new System.Drawing.Point(24, 59);
            this.lblshow.Name = "lblshow";
            this.lblshow.Size = new System.Drawing.Size(53, 20);
            this.lblshow.TabIndex = 1;
            this.lblshow.Text = "Show";
            // 
            // lblRecent
            // 
            this.lblRecent.AutoSize = true;
            this.lblRecent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecent.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblRecent.Location = new System.Drawing.Point(24, 18);
            this.lblRecent.Name = "lblRecent";
            this.lblRecent.Size = new System.Drawing.Size(122, 20);
            this.lblRecent.TabIndex = 0;
            this.lblRecent.Text = "Recent Cases";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel9.Controls.Add(this.label5);
            this.panel9.Controls.Add(this.label4);
            this.panel9.Location = new System.Drawing.Point(51, 119);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(144, 100);
            this.panel9.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(35, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "500";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(35, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "All";
            // 
            // lblDashboard
            // 
            this.lblDashboard.AutoSize = true;
            this.lblDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboard.Location = new System.Drawing.Point(26, 16);
            this.lblDashboard.Name = "lblDashboard";
            this.lblDashboard.Size = new System.Drawing.Size(117, 25);
            this.lblDashboard.TabIndex = 0;
            this.lblDashboard.Text = "Dashboard";
            // 
            // tblCases
            // 
            this.tblCases.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tblCases.ColumnCount = 3;
            this.tblCases.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.9638F));
            this.tblCases.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.0362F));
            this.tblCases.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 142F));
            this.tblCases.Controls.Add(this.panel11, 2, 0);
            this.tblCases.Controls.Add(this.panel10, 1, 0);
            this.tblCases.Location = new System.Drawing.Point(54, 119);
            this.tblCases.Name = "tblCases";
            this.tblCases.RowCount = 1;
            this.tblCases.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblCases.Size = new System.Drawing.Size(470, 100);
            this.tblCases.TabIndex = 2;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel11.Controls.Add(this.label8);
            this.panel11.Controls.Add(this.label9);
            this.panel11.Location = new System.Drawing.Point(330, 3);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(122, 91);
            this.panel11.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(35, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "200";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(25, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Closed";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel10.Controls.Add(this.label6);
            this.panel10.Controls.Add(this.label7);
            this.panel10.Location = new System.Drawing.Point(160, 3);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(157, 91);
            this.panel10.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(32, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "300";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(32, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Active";
            // 
            // tblUnassigned
            // 
            this.tblUnassigned.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tblUnassigned.ColumnCount = 1;
            this.tblUnassigned.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblUnassigned.Location = new System.Drawing.Point(1043, 119);
            this.tblUnassigned.Name = "tblUnassigned";
            this.tblUnassigned.RowCount = 1;
            this.tblUnassigned.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblUnassigned.Size = new System.Drawing.Size(435, 100);
            this.tblUnassigned.TabIndex = 4;
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel15.Controls.Add(this.label16);
            this.panel15.Controls.Add(this.label17);
            this.panel15.Location = new System.Drawing.Point(1170, 119);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(174, 91);
            this.panel15.TabIndex = 8;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(77, 43);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(18, 20);
            this.label16.TabIndex = 1;
            this.label16.Text = "5";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label17.Location = new System.Drawing.Point(3, 11);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(164, 20);
            this.label17.TabIndex = 0;
            this.label17.Text = "All Unassigned Cases";
            // 
            // tblTask
            // 
            this.tblTask.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tblTask.ColumnCount = 3;
            this.tblTask.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.86997F));
            this.tblTask.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.13003F));
            this.tblTask.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tblTask.Controls.Add(this.panel14, 2, 0);
            this.tblTask.Controls.Add(this.panel13, 1, 0);
            this.tblTask.Controls.Add(this.panel12, 0, 0);
            this.tblTask.Location = new System.Drawing.Point(550, 119);
            this.tblTask.Name = "tblTask";
            this.tblTask.RowCount = 1;
            this.tblTask.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblTask.Size = new System.Drawing.Size(464, 100);
            this.tblTask.TabIndex = 3;
            this.tblTask.Paint += new System.Windows.Forms.PaintEventHandler(this.tblTask_Paint);
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel14.Controls.Add(this.label14);
            this.panel14.Controls.Add(this.label15);
            this.panel14.Location = new System.Drawing.Point(326, 3);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(135, 91);
            this.panel14.TabIndex = 7;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(44, 43);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(18, 20);
            this.label14.TabIndex = 1;
            this.label14.Text = "5";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label15.Location = new System.Drawing.Point(17, 11);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 20);
            this.label15.TabIndex = 0;
            this.label15.Text = "Awaiting";
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel12.Controls.Add(this.label10);
            this.panel12.Controls.Add(this.label11);
            this.panel12.Location = new System.Drawing.Point(3, 3);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(118, 91);
            this.panel12.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(54, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 20);
            this.label10.TabIndex = 1;
            this.label10.Text = "25";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(34, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "My Own";
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel13.Controls.Add(this.label12);
            this.panel13.Controls.Add(this.label13);
            this.panel13.Location = new System.Drawing.Point(177, 3);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(113, 91);
            this.panel13.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(46, 43);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 20);
            this.label12.TabIndex = 1;
            this.label12.Text = "14";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Location = new System.Drawing.Point(3, 11);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 20);
            this.label13.TabIndex = 0;
            this.label13.Text = "My Assigned";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel8.Controls.Add(this.pnlCases);
            this.panel8.Location = new System.Drawing.Point(51, 62);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(473, 40);
            this.panel8.TabIndex = 0;
            // 
            // pnlCases
            // 
            this.pnlCases.AutoSize = true;
            this.pnlCases.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlCases.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlCases.Location = new System.Drawing.Point(23, 7);
            this.pnlCases.Name = "pnlCases";
            this.pnlCases.Size = new System.Drawing.Size(69, 25);
            this.pnlCases.TabIndex = 0;
            this.pnlCases.Text = "Cases";
            // 
            // pnlUnassign
            // 
            this.pnlUnassign.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlUnassign.Controls.Add(this.lblUnassigned);
            this.pnlUnassign.Location = new System.Drawing.Point(1043, 62);
            this.pnlUnassign.Name = "pnlUnassign";
            this.pnlUnassign.Size = new System.Drawing.Size(435, 40);
            this.pnlUnassign.TabIndex = 1;
            // 
            // lblUnassigned
            // 
            this.lblUnassigned.AutoSize = true;
            this.lblUnassigned.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnassigned.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUnassigned.Location = new System.Drawing.Point(25, 7);
            this.lblUnassigned.Name = "lblUnassigned";
            this.lblUnassigned.Size = new System.Drawing.Size(178, 25);
            this.lblUnassigned.TabIndex = 0;
            this.lblUnassigned.Text = "Unassigned Cases";
            // 
            // pnlTask
            // 
            this.pnlTask.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlTask.Controls.Add(this.lblTask);
            this.pnlTask.Location = new System.Drawing.Point(550, 62);
            this.pnlTask.Name = "pnlTask";
            this.pnlTask.Size = new System.Drawing.Size(464, 40);
            this.pnlTask.TabIndex = 1;
            // 
            // lblTask
            // 
            this.lblTask.AutoSize = true;
            this.lblTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTask.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTask.Location = new System.Drawing.Point(24, 7);
            this.lblTask.Name = "lblTask";
            this.lblTask.Size = new System.Drawing.Size(88, 25);
            this.lblTask.TabIndex = 0;
            this.lblTask.Text = "My Task";
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(3, 582);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(303, 64);
            this.button8.TabIndex = 4;
            this.button8.Text = "Manage Party";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Image = ((System.Drawing.Image)(resources.GetObject("button9.Image")));
            this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.Location = new System.Drawing.Point(3, 652);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(303, 64);
            this.button9.TabIndex = 5;
            this.button9.Text = "Manage User";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Image = ((System.Drawing.Image)(resources.GetObject("button10.Image")));
            this.button10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10.Location = new System.Drawing.Point(1569, 6);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(183, 67);
            this.button10.TabIndex = 3;
            this.button10.Text = "           User Name";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1824, 1050);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "DashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "DashBoard";
            this.Load += new System.EventHandler(this.DashBoard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.tblCases.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.tblTask.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.pnlUnassign.ResumeLayout(false);
            this.pnlUnassign.PerformLayout();
            this.pnlTask.ResumeLayout(false);
            this.pnlTask.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.TextBox txtSearchBar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CaseDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tracking_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Update;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblshow;
        private System.Windows.Forms.Label lblRecent;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.TableLayoutPanel tblCases;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TableLayoutPanel tblUnassigned;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TableLayoutPanel tblTask;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label pnlCases;
        private System.Windows.Forms.Panel pnlUnassign;
        private System.Windows.Forms.Label lblUnassigned;
        private System.Windows.Forms.Panel pnlTask;
        private System.Windows.Forms.Label lblTask;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
    }
}