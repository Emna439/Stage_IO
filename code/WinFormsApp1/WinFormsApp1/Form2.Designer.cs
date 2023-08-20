namespace WinFormsApp1
{
    partial class Form2
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
            dataGridView2 = new DataGridView();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label1 = new Label();
            tabControl2 = new TabControl();
            tabPage4 = new TabPage();
            DisableUR = new Button();
            LinkStatus = new Button();
            ClearRestart = new Button();
            EnableUR = new Button();
            tabPage5 = new TabPage();
            DirectRelay = new Button();
            SBORelay = new Button();
            tabPage6 = new TabPage();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button1 = new Button();
            button2 = new Button();
            tabPage7 = new TabPage();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            DeleteMaster = new Button();
            UpdateMaster = new Button();
            AddMaster = new Button();
            LoadMaster = new Button();
            groupBox1 = new GroupBox();
            checkBox1 = new CheckBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            checkBox2 = new CheckBox();
            label9 = new Label();
            label10 = new Label();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            label11 = new Label();
            comboBox4 = new ComboBox();
            button6 = new Button();
            button7 = new Button();
            label12 = new Label();
            comboBox5 = new ComboBox();
            button8 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabControl2.SuspendLayout();
            tabPage4.SuspendLayout();
            tabPage5.SuspendLayout();
            tabPage6.SuspendLayout();
            tabPage3.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(936, 44);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(524, 542);
            dataGridView2.TabIndex = 14;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(12, 6);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1483, 636);
            tabControl1.TabIndex = 15;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridView2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(tabControl2);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1475, 608);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Simulator";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1170, 20);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 16;
            label1.Text = "Point list";
            label1.Click += label1_Click;
            // 
            // tabControl2
            // 
            tabControl2.Controls.Add(tabPage4);
            tabControl2.Controls.Add(tabPage5);
            tabControl2.Controls.Add(tabPage6);
            tabControl2.Controls.Add(tabPage7);
            tabControl2.Location = new Point(16, 20);
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new Size(884, 566);
            tabControl2.TabIndex = 22;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(DisableUR);
            tabPage4.Controls.Add(LinkStatus);
            tabPage4.Controls.Add(ClearRestart);
            tabPage4.Controls.Add(EnableUR);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(876, 538);
            tabPage4.TabIndex = 0;
            tabPage4.Text = "Initialization";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // DisableUR
            // 
            DisableUR.Location = new Point(28, 227);
            DisableUR.Name = "DisableUR";
            DisableUR.Size = new Size(811, 23);
            DisableUR.TabIndex = 26;
            DisableUR.Text = "Disable uncsolicited responses";
            DisableUR.UseVisualStyleBackColor = true;
            // 
            // LinkStatus
            // 
            LinkStatus.Location = new Point(28, 33);
            LinkStatus.Name = "LinkStatus";
            LinkStatus.Size = new Size(811, 23);
            LinkStatus.TabIndex = 23;
            LinkStatus.Text = "Link status";
            LinkStatus.UseVisualStyleBackColor = true;
            // 
            // ClearRestart
            // 
            ClearRestart.Location = new Point(28, 92);
            ClearRestart.Name = "ClearRestart";
            ClearRestart.Size = new Size(811, 23);
            ClearRestart.TabIndex = 24;
            ClearRestart.Text = "Clear Restart";
            ClearRestart.UseVisualStyleBackColor = true;
            // 
            // EnableUR
            // 
            EnableUR.Location = new Point(28, 160);
            EnableUR.Name = "EnableUR";
            EnableUR.Size = new Size(811, 23);
            EnableUR.TabIndex = 25;
            EnableUR.Text = "Enable uncsolicited responses";
            EnableUR.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(DirectRelay);
            tabPage5.Controls.Add(SBORelay);
            tabPage5.Location = new Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(876, 538);
            tabPage5.TabIndex = 1;
            tabPage5.Text = "Controls";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // DirectRelay
            // 
            DirectRelay.Location = new Point(55, 87);
            DirectRelay.Name = "DirectRelay";
            DirectRelay.Size = new Size(758, 23);
            DirectRelay.TabIndex = 24;
            DirectRelay.Text = "Direct relay";
            DirectRelay.UseVisualStyleBackColor = true;
            // 
            // SBORelay
            // 
            SBORelay.Location = new Point(55, 37);
            SBORelay.Name = "SBORelay";
            SBORelay.Size = new Size(758, 23);
            SBORelay.TabIndex = 23;
            SBORelay.Text = "SBO Relay";
            SBORelay.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            tabPage6.Controls.Add(button5);
            tabPage6.Controls.Add(button4);
            tabPage6.Controls.Add(button3);
            tabPage6.Controls.Add(button1);
            tabPage6.Controls.Add(button2);
            tabPage6.Location = new Point(4, 24);
            tabPage6.Name = "tabPage6";
            tabPage6.Padding = new Padding(3);
            tabPage6.Size = new Size(876, 538);
            tabPage6.TabIndex = 2;
            tabPage6.Text = "SAV5";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(112, 367);
            button5.Name = "button5";
            button5.Size = new Size(645, 23);
            button5.TabIndex = 27;
            button5.Text = "Update key authentification";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(112, 289);
            button4.Name = "button4";
            button4.Size = new Size(645, 23);
            button4.TabIndex = 26;
            button4.Text = "Update key change";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(112, 218);
            button3.Name = "button3";
            button3.Size = new Size(645, 23);
            button3.TabIndex = 25;
            button3.Text = "User cetificate";
            button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(112, 95);
            button1.Name = "button1";
            button1.Size = new Size(645, 23);
            button1.TabIndex = 23;
            button1.Text = "Secure key";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(112, 151);
            button2.Name = "button2";
            button2.Size = new Size(645, 23);
            button2.TabIndex = 24;
            button2.Text = "User status change";
            button2.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            tabPage7.Location = new Point(4, 24);
            tabPage7.Name = "tabPage7";
            tabPage7.Padding = new Padding(3);
            tabPage7.Size = new Size(876, 538);
            tabPage7.TabIndex = 3;
            tabPage7.Text = "tabPage7";
            tabPage7.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1475, 608);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Messages";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(textBox4);
            tabPage3.Controls.Add(textBox3);
            tabPage3.Controls.Add(textBox2);
            tabPage3.Controls.Add(textBox1);
            tabPage3.Controls.Add(label8);
            tabPage3.Controls.Add(label7);
            tabPage3.Controls.Add(label6);
            tabPage3.Controls.Add(label5);
            tabPage3.Controls.Add(DeleteMaster);
            tabPage3.Controls.Add(UpdateMaster);
            tabPage3.Controls.Add(AddMaster);
            tabPage3.Controls.Add(LoadMaster);
            tabPage3.Controls.Add(groupBox1);
            tabPage3.Controls.Add(dataGridView1);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1475, 608);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Configure master";
            tabPage3.UseVisualStyleBackColor = true;
            tabPage3.Click += tabPage3_Click;
            // 
            // textBox4
            // 
            textBox4.Enabled = false;
            textBox4.Location = new Point(156, 181);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(403, 23);
            textBox4.TabIndex = 13;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(156, 135);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(403, 23);
            textBox3.TabIndex = 12;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(156, 85);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(403, 23);
            textBox2.TabIndex = 11;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(156, 42);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(403, 23);
            textBox1.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(27, 184);
            label8.Name = "label8";
            label8.Size = new Size(53, 15);
            label8.TabIndex = 9;
            label8.Text = "Group Id";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(27, 138);
            label7.Name = "label7";
            label7.Size = new Size(48, 15);
            label7.TabIndex = 8;
            label7.Text = "Point Id";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 93);
            label6.Name = "label6";
            label6.Size = new Size(62, 15);
            label6.TabIndex = 7;
            label6.Text = "Point Type";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 50);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 6;
            label5.Text = "Point Name";
            label5.Click += label5_Click;
            // 
            // DeleteMaster
            // 
            DeleteMaster.Location = new Point(1307, 553);
            DeleteMaster.Name = "DeleteMaster";
            DeleteMaster.Size = new Size(140, 23);
            DeleteMaster.TabIndex = 5;
            DeleteMaster.Text = "Delete";
            DeleteMaster.UseVisualStyleBackColor = true;
            DeleteMaster.Click += DeleteMaster_Click;
            // 
            // UpdateMaster
            // 
            UpdateMaster.Location = new Point(1061, 553);
            UpdateMaster.Name = "UpdateMaster";
            UpdateMaster.Size = new Size(216, 23);
            UpdateMaster.TabIndex = 4;
            UpdateMaster.Text = "Update";
            UpdateMaster.UseVisualStyleBackColor = true;
            UpdateMaster.Click += UpdateMaster_Click;
            // 
            // AddMaster
            // 
            AddMaster.Location = new Point(885, 553);
            AddMaster.Name = "AddMaster";
            AddMaster.Size = new Size(135, 23);
            AddMaster.TabIndex = 3;
            AddMaster.Text = "Add";
            AddMaster.UseVisualStyleBackColor = true;
            AddMaster.Click += AddMaster_Click;
            // 
            // LoadMaster
            // 
            LoadMaster.Location = new Point(885, 524);
            LoadMaster.Name = "LoadMaster";
            LoadMaster.Size = new Size(562, 23);
            LoadMaster.TabIndex = 2;
            LoadMaster.Text = "Load";
            LoadMaster.UseVisualStyleBackColor = true;
            LoadMaster.Click += LoadMaster_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button8);
            groupBox1.Controls.Add(comboBox5);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(button6);
            groupBox1.Controls.Add(button7);
            groupBox1.Controls.Add(comboBox4);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(textBox6);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(comboBox3);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(25, 210);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(830, 366);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Secure authentification version 5 (SAV5)";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.Location = new Point(15, 40);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(68, 19);
            checkBox1.TabIndex = 16;
            checkBox1.Text = "Enabled";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Shared", "Symmetrical", "Assymetrical" });
            comboBox1.Location = new Point(207, 151);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 6;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Not used", "SHA-256 (serial)", "SHA-256 (net)" });
            comboBox2.Location = new Point(207, 191);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 7;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "AES-256", "AES-128" });
            comboBox3.Location = new Point(207, 230);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(121, 23);
            comboBox3.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 194);
            label3.Name = "label3";
            label3.Size = new Size(89, 15);
            label3.TabIndex = 6;
            label3.Text = "MAC algorithm";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 233);
            label4.Name = "label4";
            label4.Size = new Size(112, 15);
            label4.TabIndex = 7;
            label4.Text = "Key Wrap algorithm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 154);
            label2.Name = "label2";
            label2.Size = new Size(113, 15);
            label2.TabIndex = 16;
            label2.Text = "Key change method";
            label2.Click += label2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(885, 42);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(562, 457);
            dataGridView1.TabIndex = 0;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(15, 65);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(112, 19);
            checkBox2.TabIndex = 17;
            checkBox2.Text = "Agression mode";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(17, 106);
            label9.Name = "label9";
            label9.Size = new Size(142, 15);
            label9.TabIndex = 18;
            label9.Text = "Session key intervals (sec)";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(440, 109);
            label10.Name = "label10";
            label10.Size = new Size(101, 15);
            label10.TabIndex = 19;
            label10.Text = "Session key count";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(207, 106);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(143, 23);
            textBox5.TabIndex = 20;
            textBox5.Text = "900";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(570, 103);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(151, 23);
            textBox6.TabIndex = 21;
            textBox6.Text = "1000";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(17, 274);
            label11.Name = "label11";
            label11.Size = new Size(121, 15);
            label11.TabIndex = 14;
            label11.Text = "Opt. critical functions";
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "Confirm ", "Read", "Immediate freeze", "Immediate freeze (No Ack)", "Freeze and clear", "Freeze and clear (No Ack)", "Freeze with time ", "Freeze with time (No Ack)", "Initialize data to default", "Assign class", "Delay measurement", "Uncolicited messgaes", "Response" });
            comboBox4.Location = new Point(207, 274);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(121, 23);
            comboBox4.TabIndex = 14;
            // 
            // button6
            // 
            button6.Location = new Point(440, 191);
            button6.Name = "button6";
            button6.Size = new Size(358, 23);
            button6.TabIndex = 14;
            button6.Text = "Statistic threshold";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(440, 233);
            button7.Name = "button7";
            button7.Size = new Size(358, 23);
            button7.TabIndex = 15;
            button7.Text = "Manage session keys";
            button7.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(20, 318);
            label12.Name = "label12";
            label12.Size = new Size(65, 15);
            label12.TabIndex = 22;
            label12.Text = "Active user";
            // 
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new Point(207, 318);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(121, 23);
            comboBox5.TabIndex = 23;
            // 
            // button8
            // 
            button8.Location = new Point(440, 317);
            button8.Name = "button8";
            button8.Size = new Size(358, 23);
            button8.TabIndex = 24;
            button8.Text = "Manage Keys";
            button8.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1507, 654);
            Controls.Add(tabControl1);
            Name = "Form2";
            Text = "Master simulation mode";
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabControl2.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            tabPage5.ResumeLayout(false);
            tabPage6.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView2;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label1;
        private TabControl tabControl2;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private TabPage tabPage7;
        private TabPage tabPage3;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private Button UpdateMaster;
        private Button AddMaster;
        private Button LoadMaster;
        private Button DeleteMaster;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private CheckBox checkBox1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private Button LinkStatus;
        private Button ClearRestart;
        private Button EnableUR;
        private Button DisableUR;
        private Button SBORelay;
        private Button DirectRelay;
        private Button button1;
        private Button button2;
        private Button button5;
        private Button button4;
        private Button button3;
        private TextBox textBox6;
        private TextBox textBox5;
        private Label label10;
        private Label label9;
        private CheckBox checkBox2;
        private ComboBox comboBox4;
        private Label label11;
        private Button button6;
        private Button button7;
        private Button button8;
        private ComboBox comboBox5;
        private Label label12;
    }
}