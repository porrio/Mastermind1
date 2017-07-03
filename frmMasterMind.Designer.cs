namespace Mastermind
{
    partial class frmMasterMind
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
            this.btnSpeel = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblResultaat = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTime = new System.Windows.Forms.Label();
            this.grpbNaam = new System.Windows.Forms.GroupBox();
            this.txbNaam = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spelRegelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.singleplayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multiplayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scoreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mastermindDataSet = new Mastermind.MastermindDataSet();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.vraag = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.myPort = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.RemoteIP = new System.Windows.Forms.TextBox();
            this.RemotePort = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnMakeCode = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.scoreTableAdapter = new Mastermind.MastermindDataSetTableAdapters.ScoreTableAdapter();
            this.rbtnMultiCode4 = new WindowsFormsApplication1.RoundButton();
            this.rbtnMultiCode2 = new WindowsFormsApplication1.RoundButton();
            this.rbtnMultiCode3 = new WindowsFormsApplication1.RoundButton();
            this.rbtnMultiCode1 = new WindowsFormsApplication1.RoundButton();
            this.rbtnCode4 = new WindowsFormsApplication1.RoundButton();
            this.rbtnCode3 = new WindowsFormsApplication1.RoundButton();
            this.rbtnCode2 = new WindowsFormsApplication1.RoundButton();
            this.rbtnCode1 = new WindowsFormsApplication1.RoundButton();
            this.speelRij8 = new Mastermind.speelRij();
            this.speelRij7 = new Mastermind.speelRij();
            this.speelRij6 = new Mastermind.speelRij();
            this.speelRij5 = new Mastermind.speelRij();
            this.speelRij4 = new Mastermind.speelRij();
            this.speelRij3 = new Mastermind.speelRij();
            this.speelRij2 = new Mastermind.speelRij();
            this.speelRij1 = new Mastermind.speelRij();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.grpbScore = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Naam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tijd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpbNaam.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scoreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mastermindDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.grpbScore.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSpeel
            // 
            this.btnSpeel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(77)))), ((int)(((byte)(99)))));
            this.btnSpeel.Enabled = false;
            this.btnSpeel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnSpeel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(29)))));
            this.btnSpeel.Location = new System.Drawing.Point(331, 559);
            this.btnSpeel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSpeel.Name = "btnSpeel";
            this.btnSpeel.Size = new System.Drawing.Size(111, 39);
            this.btnSpeel.TabIndex = 8;
            this.btnSpeel.Text = "Play";
            this.btnSpeel.UseVisualStyleBackColor = false;
            this.btnSpeel.Click += new System.EventHandler(this.btnSpeel_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(36, 57);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(32, 29);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(88, 57);
            this.richTextBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(32, 29);
            this.richTextBox2.TabIndex = 10;
            this.richTextBox2.Text = "";
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(147, 57);
            this.richTextBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(32, 29);
            this.richTextBox3.TabIndex = 11;
            this.richTextBox3.Text = "";
            // 
            // richTextBox4
            // 
            this.richTextBox4.Location = new System.Drawing.Point(205, 57);
            this.richTextBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.Size = new System.Drawing.Size(32, 29);
            this.richTextBox4.TabIndex = 12;
            this.richTextBox4.Text = "";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(25, 57);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 57);
            this.panel1.TabIndex = 17;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblResultaat
            // 
            this.lblResultaat.AutoSize = true;
            this.lblResultaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblResultaat.ForeColor = System.Drawing.Color.Black;
            this.lblResultaat.Location = new System.Drawing.Point(339, 47);
            this.lblResultaat.Name = "lblResultaat";
            this.lblResultaat.Size = new System.Drawing.Size(146, 29);
            this.lblResultaat.TabIndex = 18;
            this.lblResultaat.Text = "Mastermind";
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(77)))), ((int)(((byte)(99)))));
            this.btnNew.Enabled = false;
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(29)))));
            this.btnNew.Location = new System.Drawing.Point(331, 606);
            this.btnNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(111, 39);
            this.btnNew.TabIndex = 19;
            this.btnNew.Text = "Nieuw";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(587, 58);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(16, 17);
            this.lblTime.TabIndex = 20;
            this.lblTime.Text = "0";
            // 
            // grpbNaam
            // 
            this.grpbNaam.Controls.Add(this.txbNaam);
            this.grpbNaam.Location = new System.Drawing.Point(325, 165);
            this.grpbNaam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpbNaam.Name = "grpbNaam";
            this.grpbNaam.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpbNaam.Size = new System.Drawing.Size(439, 62);
            this.grpbNaam.TabIndex = 23;
            this.grpbNaam.TabStop = false;
            this.grpbNaam.Text = "Naam";
            this.grpbNaam.Visible = false;
            // 
            // txbNaam
            // 
            this.txbNaam.Location = new System.Drawing.Point(6, 20);
            this.txbNaam.Name = "txbNaam";
            this.txbNaam.Size = new System.Drawing.Size(426, 22);
            this.txbNaam.TabIndex = 0;
            this.txbNaam.Click += new System.EventHandler(this.txbNaam_Click);
            this.txbNaam.TextChanged += new System.EventHandler(this.txbNaam_TextChanged);
            this.txbNaam.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbNaam_KeyDown);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(325, 370);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(229, 22);
            this.dateTimePicker1.TabIndex = 25;
            this.dateTimePicker1.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MaximumSize = new System.Drawing.Size(794, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(776, 28);
            this.menuStrip1.Stretch = false;
            this.menuStrip1.TabIndex = 27;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.AutoSize = false;
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.spelRegelsToolStripMenuItem,
            this.singleplayerToolStripMenuItem,
            this.multiplayerToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(117, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // spelRegelsToolStripMenuItem
            // 
            this.spelRegelsToolStripMenuItem.Name = "spelRegelsToolStripMenuItem";
            this.spelRegelsToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.spelRegelsToolStripMenuItem.Text = "SpelRegels";
            this.spelRegelsToolStripMenuItem.Click += new System.EventHandler(this.spelRegelsToolStripMenuItem_Click);
            // 
            // singleplayerToolStripMenuItem
            // 
            this.singleplayerToolStripMenuItem.Name = "singleplayerToolStripMenuItem";
            this.singleplayerToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.singleplayerToolStripMenuItem.Text = "Singleplayer";
            this.singleplayerToolStripMenuItem.Click += new System.EventHandler(this.singleplayerToolStripMenuItem_Click);
            // 
            // multiplayerToolStripMenuItem
            // 
            this.multiplayerToolStripMenuItem.Name = "multiplayerToolStripMenuItem";
            this.multiplayerToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.multiplayerToolStripMenuItem.Text = "Multiplayer";
            this.multiplayerToolStripMenuItem.Click += new System.EventHandler(this.multiplayerToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // scoreBindingSource
            // 
            this.scoreBindingSource.DataMember = "Score";
            this.scoreBindingSource.DataSource = this.mastermindDataSet;
            // 
            // mastermindDataSet
            // 
            this.mastermindDataSet.DataSetName = "MastermindDataSet";
            this.mastermindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.vraag);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.myPort);
            this.groupBox2.Location = new System.Drawing.Point(323, 409);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(163, 65);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "mijn IP";
            this.groupBox2.Visible = false;
            // 
            // vraag
            // 
            this.vraag.AutoSize = true;
            this.vraag.Location = new System.Drawing.Point(121, 39);
            this.vraag.Name = "vraag";
            this.vraag.Size = new System.Drawing.Size(16, 17);
            this.vraag.TabIndex = 37;
            this.vraag.TabStop = true;
            this.vraag.Text = "?";
            this.vraag.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.vraag_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Poort:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "IP: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "172.0.0.1";
            // 
            // myPort
            // 
            this.myPort.Location = new System.Drawing.Point(67, 37);
            this.myPort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.myPort.MaxLength = 2;
            this.myPort.Name = "myPort";
            this.myPort.Size = new System.Drawing.Size(49, 22);
            this.myPort.TabIndex = 0;
            this.myPort.Text = "8";
            this.myPort.TextChanged += new System.EventHandler(this.myPort_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.RemoteIP);
            this.groupBox3.Controls.Add(this.RemotePort);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(493, 409);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(188, 65);
            this.groupBox3.TabIndex = 34;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "tegenstanderIP";
            this.groupBox3.Visible = false;
            // 
            // RemoteIP
            // 
            this.RemoteIP.Location = new System.Drawing.Point(59, 15);
            this.RemoteIP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RemoteIP.MaxLength = 15;
            this.RemoteIP.Name = "RemoteIP";
            this.RemoteIP.ShortcutsEnabled = false;
            this.RemoteIP.Size = new System.Drawing.Size(124, 22);
            this.RemoteIP.TabIndex = 5;
            this.RemoteIP.Text = "192.168.178.1";
            this.RemoteIP.TextChanged += new System.EventHandler(this.RemoteIP_TextChanged);
            // 
            // RemotePort
            // 
            this.RemotePort.Location = new System.Drawing.Point(59, 39);
            this.RemotePort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RemotePort.MaxLength = 2;
            this.RemotePort.Name = "RemotePort";
            this.RemotePort.Size = new System.Drawing.Size(49, 22);
            this.RemotePort.TabIndex = 4;
            this.RemotePort.Text = "8";
            this.RemotePort.TextChanged += new System.EventHandler(this.RemotePort_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Poort:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "IP: ";
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(689, 417);
            this.Start.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(75, 54);
            this.Start.TabIndex = 35;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Visible = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rbtnMultiCode4);
            this.groupBox4.Controls.Add(this.rbtnMultiCode2);
            this.groupBox4.Controls.Add(this.rbtnMultiCode3);
            this.groupBox4.Controls.Add(this.rbtnMultiCode1);
            this.groupBox4.Location = new System.Drawing.Point(323, 482);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(223, 70);
            this.groupBox4.TabIndex = 36;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Kies een code";
            this.groupBox4.Visible = false;
            // 
            // btnMakeCode
            // 
            this.btnMakeCode.Location = new System.Drawing.Point(552, 495);
            this.btnMakeCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMakeCode.Name = "btnMakeCode";
            this.btnMakeCode.Size = new System.Drawing.Size(75, 54);
            this.btnMakeCode.TabIndex = 37;
            this.btnMakeCode.Text = "Maak code";
            this.btnMakeCode.UseVisualStyleBackColor = true;
            this.btnMakeCode.Visible = false;
            this.btnMakeCode.Click += new System.EventHandler(this.btnMakeCode_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(569, 328);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(10, 22);
            this.textBox1.TabIndex = 39;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // scoreTableAdapter
            // 
            this.scoreTableAdapter.ClearBeforeFill = true;
            // 
            // rbtnMultiCode4
            // 
            this.rbtnMultiCode4.Enabled = false;
            this.rbtnMultiCode4.Location = new System.Drawing.Point(171, 14);
            this.rbtnMultiCode4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtnMultiCode4.Name = "rbtnMultiCode4";
            this.rbtnMultiCode4.Size = new System.Drawing.Size(51, 50);
            this.rbtnMultiCode4.TabIndex = 32;
            this.rbtnMultiCode4.UseVisualStyleBackColor = true;
            this.rbtnMultiCode4.Click += new System.EventHandler(this.rbtnMulticode4_Click);
            // 
            // rbtnMultiCode2
            // 
            this.rbtnMultiCode2.Enabled = false;
            this.rbtnMultiCode2.Location = new System.Drawing.Point(59, 16);
            this.rbtnMultiCode2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtnMultiCode2.Name = "rbtnMultiCode2";
            this.rbtnMultiCode2.Size = new System.Drawing.Size(51, 50);
            this.rbtnMultiCode2.TabIndex = 30;
            this.rbtnMultiCode2.UseVisualStyleBackColor = true;
            this.rbtnMultiCode2.Click += new System.EventHandler(this.rbtnMultiCode2_Click);
            // 
            // rbtnMultiCode3
            // 
            this.rbtnMultiCode3.Enabled = false;
            this.rbtnMultiCode3.Location = new System.Drawing.Point(112, 16);
            this.rbtnMultiCode3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtnMultiCode3.Name = "rbtnMultiCode3";
            this.rbtnMultiCode3.Size = new System.Drawing.Size(51, 50);
            this.rbtnMultiCode3.TabIndex = 31;
            this.rbtnMultiCode3.UseVisualStyleBackColor = true;
            this.rbtnMultiCode3.Click += new System.EventHandler(this.rbtnMultiCode3_Click);
            // 
            // rbtnMultiCode1
            // 
            this.rbtnMultiCode1.Enabled = false;
            this.rbtnMultiCode1.Location = new System.Drawing.Point(5, 14);
            this.rbtnMultiCode1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtnMultiCode1.Name = "rbtnMultiCode1";
            this.rbtnMultiCode1.Size = new System.Drawing.Size(51, 50);
            this.rbtnMultiCode1.TabIndex = 29;
            this.rbtnMultiCode1.UseVisualStyleBackColor = true;
            this.rbtnMultiCode1.Click += new System.EventHandler(this.rbtnMultiCode1_Click);
            // 
            // rbtnCode4
            // 
            this.rbtnCode4.Location = new System.Drawing.Point(193, 43);
            this.rbtnCode4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtnCode4.Name = "rbtnCode4";
            this.rbtnCode4.Size = new System.Drawing.Size(51, 50);
            this.rbtnCode4.TabIndex = 16;
            this.rbtnCode4.UseVisualStyleBackColor = true;
            // 
            // rbtnCode3
            // 
            this.rbtnCode3.Location = new System.Drawing.Point(137, 43);
            this.rbtnCode3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtnCode3.Name = "rbtnCode3";
            this.rbtnCode3.Size = new System.Drawing.Size(51, 50);
            this.rbtnCode3.TabIndex = 15;
            this.rbtnCode3.UseVisualStyleBackColor = true;
            // 
            // rbtnCode2
            // 
            this.rbtnCode2.Location = new System.Drawing.Point(81, 43);
            this.rbtnCode2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtnCode2.Name = "rbtnCode2";
            this.rbtnCode2.Size = new System.Drawing.Size(51, 50);
            this.rbtnCode2.TabIndex = 14;
            this.rbtnCode2.UseVisualStyleBackColor = true;
            // 
            // rbtnCode1
            // 
            this.rbtnCode1.Location = new System.Drawing.Point(25, 43);
            this.rbtnCode1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtnCode1.Name = "rbtnCode1";
            this.rbtnCode1.Size = new System.Drawing.Size(51, 50);
            this.rbtnCode1.TabIndex = 13;
            this.rbtnCode1.UseVisualStyleBackColor = true;
            // 
            // speelRij8
            // 
            this.speelRij8.Enabled = false;
            this.speelRij8.Location = new System.Drawing.Point(12, 107);
            this.speelRij8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.speelRij8.Name = "speelRij8";
            this.speelRij8.Size = new System.Drawing.Size(307, 62);
            this.speelRij8.TabIndex = 7;
            // 
            // speelRij7
            // 
            this.speelRij7.Enabled = false;
            this.speelRij7.Location = new System.Drawing.Point(12, 175);
            this.speelRij7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.speelRij7.Name = "speelRij7";
            this.speelRij7.Size = new System.Drawing.Size(307, 62);
            this.speelRij7.TabIndex = 6;
            // 
            // speelRij6
            // 
            this.speelRij6.Enabled = false;
            this.speelRij6.Location = new System.Drawing.Point(11, 242);
            this.speelRij6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.speelRij6.Name = "speelRij6";
            this.speelRij6.Size = new System.Drawing.Size(307, 62);
            this.speelRij6.TabIndex = 5;
            // 
            // speelRij5
            // 
            this.speelRij5.Enabled = false;
            this.speelRij5.Location = new System.Drawing.Point(11, 311);
            this.speelRij5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.speelRij5.Name = "speelRij5";
            this.speelRij5.Size = new System.Drawing.Size(307, 62);
            this.speelRij5.TabIndex = 4;
            // 
            // speelRij4
            // 
            this.speelRij4.Enabled = false;
            this.speelRij4.Location = new System.Drawing.Point(11, 379);
            this.speelRij4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.speelRij4.Name = "speelRij4";
            this.speelRij4.Size = new System.Drawing.Size(307, 62);
            this.speelRij4.TabIndex = 3;
            // 
            // speelRij3
            // 
            this.speelRij3.Enabled = false;
            this.speelRij3.Location = new System.Drawing.Point(11, 447);
            this.speelRij3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.speelRij3.Name = "speelRij3";
            this.speelRij3.Size = new System.Drawing.Size(307, 62);
            this.speelRij3.TabIndex = 2;
            // 
            // speelRij2
            // 
            this.speelRij2.Enabled = false;
            this.speelRij2.Location = new System.Drawing.Point(11, 514);
            this.speelRij2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.speelRij2.Name = "speelRij2";
            this.speelRij2.Size = new System.Drawing.Size(307, 62);
            this.speelRij2.TabIndex = 1;
            // 
            // speelRij1
            // 
            this.speelRij1.Location = new System.Drawing.Point(12, 583);
            this.speelRij1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.speelRij1.Name = "speelRij1";
            this.speelRij1.Size = new System.Drawing.Size(307, 62);
            this.speelRij1.TabIndex = 0;
            this.speelRij1.BackColorChanged += new System.EventHandler(this.speelRij1_BackColorChanged);
            this.speelRij1.SystemColorsChanged += new System.EventHandler(this.speelRij1_SystemColorsChanged);
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(569, 371);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(10, 22);
            this.textBox2.TabIndex = 40;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(16, 28);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(16, 17);
            this.lblScore.TabIndex = 22;
            this.lblScore.Text = "0";
            // 
            // grpbScore
            // 
            this.grpbScore.Controls.Add(this.lblScore);
            this.grpbScore.Location = new System.Drawing.Point(325, 99);
            this.grpbScore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpbScore.Name = "grpbScore";
            this.grpbScore.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpbScore.Size = new System.Drawing.Size(439, 62);
            this.grpbScore.TabIndex = 21;
            this.grpbScore.TabStop = false;
            this.grpbScore.Text = "Score";
            this.grpbScore.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView2);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(318, 255);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(439, 150);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "highScores";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridView2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView2.Location = new System.Drawing.Point(7, 19);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView2.Size = new System.Drawing.Size(427, 119);
            this.dataGridView2.TabIndex = 25;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Naam";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Score";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Tijd";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Datum";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Naam,
            this.Score,
            this.Tijd,
            this.Datum});
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(7, 19);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView1.Size = new System.Drawing.Size(427, 119);
            this.dataGridView1.TabIndex = 24;
            // 
            // Naam
            // 
            this.Naam.HeaderText = "Naam";
            this.Naam.Name = "Naam";
            this.Naam.ReadOnly = true;
            // 
            // Score
            // 
            this.Score.HeaderText = "Score";
            this.Score.Name = "Score";
            this.Score.ReadOnly = true;
            // 
            // Tijd
            // 
            this.Tijd.HeaderText = "Tijd";
            this.Tijd.Name = "Tijd";
            this.Tijd.ReadOnly = true;
            // 
            // Datum
            // 
            this.Datum.HeaderText = "Datum";
            this.Datum.Name = "Datum";
            this.Datum.ReadOnly = true;
            // 
            // frmMasterMind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(776, 667);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnMakeCode);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.grpbNaam);
            this.Controls.Add(this.grpbScore);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.lblResultaat);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rbtnCode4);
            this.Controls.Add(this.rbtnCode3);
            this.Controls.Add(this.rbtnCode2);
            this.Controls.Add(this.rbtnCode1);
            this.Controls.Add(this.richTextBox4);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnSpeel);
            this.Controls.Add(this.speelRij8);
            this.Controls.Add(this.speelRij7);
            this.Controls.Add(this.speelRij6);
            this.Controls.Add(this.speelRij5);
            this.Controls.Add(this.speelRij4);
            this.Controls.Add(this.speelRij3);
            this.Controls.Add(this.speelRij2);
            this.Controls.Add(this.speelRij1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(794, 714);
            this.MinimumSize = new System.Drawing.Size(794, 714);
            this.Name = "frmMasterMind";
            this.Text = "Mastermind";
            this.Load += new System.EventHandler(this.frmMasterMind_Load);
            this.grpbNaam.ResumeLayout(false);
            this.grpbNaam.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scoreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mastermindDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.grpbScore.ResumeLayout(false);
            this.grpbScore.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private speelRij speelRij1;
        private speelRij speelRij2;
        private speelRij speelRij3;
        private speelRij speelRij4;
        private speelRij speelRij5;
        private speelRij speelRij6;
        private speelRij speelRij7;
        private speelRij speelRij8;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private WindowsFormsApplication1.RoundButton rbtnCode1;
        private WindowsFormsApplication1.RoundButton rbtnCode2;
        private WindowsFormsApplication1.RoundButton rbtnCode3;
        private WindowsFormsApplication1.RoundButton rbtnCode4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblResultaat;
        internal System.Windows.Forms.Button btnSpeel;
        internal System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox grpbNaam;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spelRegelsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem multiplayerToolStripMenuItem;
        private WindowsFormsApplication1.RoundButton rbtnMultiCode1;
        private WindowsFormsApplication1.RoundButton rbtnMultiCode2;
        private WindowsFormsApplication1.RoundButton rbtnMultiCode3;
        private WindowsFormsApplication1.RoundButton rbtnMultiCode4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox myPort;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox RemotePort;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox RemoteIP;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.LinkLabel vraag;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnMakeCode;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem singleplayerToolStripMenuItem;
        private System.Windows.Forms.TextBox txbNaam;
        public System.Windows.Forms.Label lblTime;
        private MastermindDataSet mastermindDataSet;
        private System.Windows.Forms.BindingSource scoreBindingSource;
        private MastermindDataSetTableAdapters.ScoreTableAdapter scoreTableAdapter;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.GroupBox grpbScore;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Score;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tijd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
    }
}

