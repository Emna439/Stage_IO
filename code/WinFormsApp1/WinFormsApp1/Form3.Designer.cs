
namespace WinFormsApp1
{
    partial class Form3
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
            components = new System.ComponentModel.Container();
            tabControl1 = new TabControl();
            tabPage3 = new TabPage();
            label5 = new Label();
            dataGridView2 = new DataGridView();
            groupBox2 = new GroupBox();
            button3 = new Button();
            button2 = new Button();
            tabPage2 = new TabPage();
            tabPage1 = new TabPage();
            comboBox4 = new ComboBox();
            label10 = new Label();
            textBox4 = new TextBox();
            label9 = new Label();
            groupBox1 = new GroupBox();
            checkBox1 = new CheckBox();
            comboBox3 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label1 = new Label();
            UpgradeRTU = new Button();
            dataGridView1 = new DataGridView();
            DelRTU = new Button();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            AddRTU = new Button();
            label2 = new Label();
            button1 = new Button();
            label3 = new Label();
            checkBox2 = new CheckBox();
            label11 = new Label();
            label12 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            comboBox5 = new ComboBox();
            comboBox6 = new ComboBox();
            label13 = new Label();
            label14 = new Label();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            tabControl1.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBox2.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.AllowDrop = true;
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.RightToLeft = RightToLeft.No;
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1489, 639);
            tabControl1.TabIndex = 18;
            // 
            // tabPage3
            // 
            tabPage3.AutoScroll = true;
            tabPage3.Controls.Add(label5);
            tabPage3.Controls.Add(dataGridView2);
            tabPage3.Controls.Add(groupBox2);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1481, 601);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "RTU Simulator";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1131, 16);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 20;
            label5.Text = "Point list";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(811, 40);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(664, 551);
            dataGridView2.TabIndex = 19;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(button2);
            groupBox2.Location = new Point(26, 26);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(766, 357);
            groupBox2.TabIndex = 23;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // button3
            // 
            button3.Location = new Point(27, 96);
            button3.Name = "button3";
            button3.Size = new Size(684, 23);
            button3.TabIndex = 22;
            button3.Text = "Stop communication";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(27, 56);
            button2.Name = "button2";
            button2.Size = new Size(684, 23);
            button2.TabIndex = 21;
            button2.Text = "Start communication";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Start_Communication_Click;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1481, 601);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Messages";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(comboBox4);
            tabPage1.Controls.Add(label10);
            tabPage1.Controls.Add(textBox4);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(UpgradeRTU);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Controls.Add(DelRTU);
            tabPage1.Controls.Add(textBox3);
            tabPage1.Controls.Add(textBox2);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(AddRTU);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(label3);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1481, 611);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Configure RTU";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "Analog input", "Analog output status", "Binary input", "Binary counter", "Binary output status" });
            comboBox4.Location = new Point(135, 231);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(354, 23);
            comboBox4.TabIndex = 36;
            comboBox4.SelectedIndexChanged += comboBox4_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(34, 234);
            label10.Name = "label10";
            label10.Size = new Size(61, 15);
            label10.TabIndex = 35;
            label10.Text = "Input type";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(135, 176);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(354, 23);
            textBox4.TabIndex = 34;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(34, 184);
            label9.Name = "label9";
            label9.Size = new Size(73, 15);
            label9.TabIndex = 30;
            label9.Text = "First point id";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button6);
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(textBox7);
            groupBox1.Controls.Add(textBox6);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(comboBox5);
            groupBox1.Controls.Add(comboBox6);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(comboBox3);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Location = new Point(18, 260);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(797, 345);
            groupBox1.TabIndex = 29;
            groupBox1.TabStop = false;
            groupBox1.Text = "Secure authentification version 5 (SAV5)";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.Location = new Point(27, 33);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(68, 19);
            checkBox1.TabIndex = 30;
            checkBox1.Text = "Enabled";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(180, 200);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(121, 23);
            comboBox3.TabIndex = 33;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(180, 164);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 32;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "shared" });
            comboBox1.Location = new Point(180, 127);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 31;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(30, 200);
            label8.Name = "label8";
            label8.Size = new Size(112, 15);
            label8.TabIndex = 30;
            label8.Text = "Key Wrap algorithm";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(30, 167);
            label7.Name = "label7";
            label7.Size = new Size(89, 15);
            label7.TabIndex = 30;
            label7.Text = "MAC algorithm";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 130);
            label6.Name = "label6";
            label6.Size = new Size(113, 15);
            label6.TabIndex = 19;
            label6.Text = "Key change method";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1117, 15);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 17;
            label1.Text = "RTUs";
            label1.Click += label1_Click;
            // 
            // UpgradeRTU
            // 
            UpgradeRTU.Location = new Point(1035, 552);
            UpgradeRTU.Name = "UpgradeRTU";
            UpgradeRTU.Size = new Size(202, 23);
            UpgradeRTU.TabIndex = 21;
            UpgradeRTU.Text = "update RTU";
            UpgradeRTU.UseVisualStyleBackColor = true;
            UpgradeRTU.Click += UpgradeRTU_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(836, 45);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(600, 452);
            dataGridView1.TabIndex = 13;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // DelRTU
            // 
            DelRTU.Location = new Point(1269, 552);
            DelRTU.Name = "DelRTU";
            DelRTU.Size = new Size(167, 23);
            DelRTU.TabIndex = 20;
            DelRTU.Text = "delete RTU";
            DelRTU.UseVisualStyleBackColor = true;
            DelRTU.Click += DelRTU_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(135, 129);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(354, 23);
            textBox3.TabIndex = 27;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(135, 80);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(354, 23);
            textBox2.TabIndex = 26;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(135, 29);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(354, 23);
            textBox1.TabIndex = 25;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 83);
            label4.Name = "label4";
            label4.Size = new Size(17, 15);
            label4.TabIndex = 24;
            label4.Text = "Id";
            // 
            // AddRTU
            // 
            AddRTU.Location = new Point(836, 552);
            AddRTU.Name = "AddRTU";
            AddRTU.Size = new Size(167, 23);
            AddRTU.TabIndex = 19;
            AddRTU.Text = "Add RTU";
            AddRTU.UseVisualStyleBackColor = true;
            AddRTU.Click += AddRTU_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 29);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 22;
            label2.Text = "Name";
            label2.Click += label2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(836, 523);
            button1.Name = "button1";
            button1.Size = new Size(600, 23);
            button1.TabIndex = 14;
            button1.Text = "Load";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 132);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 23;
            label3.Text = "Protocol";
            label3.Click += label3_Click;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(27, 58);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(112, 19);
            checkBox2.TabIndex = 37;
            checkBox2.Text = "Agression mode";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(30, 235);
            label11.Name = "label11";
            label11.Size = new Size(121, 15);
            label11.TabIndex = 37;
            label11.Text = "Opt. critical functions";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(30, 276);
            label12.Name = "label12";
            label12.Size = new Size(65, 15);
            label12.TabIndex = 38;
            label12.Text = "Active user";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new Point(180, 235);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(121, 23);
            comboBox5.TabIndex = 20;
            // 
            // comboBox6
            // 
            comboBox6.FormattingEnabled = true;
            comboBox6.Location = new Point(180, 273);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new Size(121, 23);
            comboBox6.TabIndex = 21;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(32, 94);
            label13.Name = "label13";
            label13.Size = new Size(142, 15);
            label13.TabIndex = 37;
            label13.Text = "Session key intervals (sec)";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(415, 94);
            label14.Name = "label14";
            label14.Size = new Size(101, 15);
            label14.TabIndex = 39;
            label14.Text = "Session key count";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(180, 91);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(171, 23);
            textBox6.TabIndex = 38;
            textBox6.Text = "900";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(522, 91);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(171, 23);
            textBox7.TabIndex = 38;
            textBox7.Text = "1000";
            // 
            // button4
            // 
            button4.Location = new Point(415, 145);
            button4.Name = "button4";
            button4.Size = new Size(278, 23);
            button4.TabIndex = 40;
            button4.Text = "Statistic threshold";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(415, 183);
            button5.Name = "button5";
            button5.Size = new Size(278, 23);
            button5.TabIndex = 41;
            button5.Text = "Manage session keys";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(415, 273);
            button6.Name = "button6";
            button6.Size = new Size(278, 23);
            button6.TabIndex = 42;
            button6.Text = "Manage keys";
            button6.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1501, 651);
            Controls.Add(tabControl1);
            Name = "Form3";
            Text = "RTU simulation mode";
            tabControl1.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBox2.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Label label1;
        private Button UpgradeRTU;
        private DataGridView dataGridView1;
        private Button DelRTU;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label4;
        private Button AddRTU;
        private Label label2;
        private Button button1;
        private Label label3;
        private Label label5;
        private DataGridView dataGridView2;
        private GroupBox groupBox1;
        private Label label6;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label8;
        private Label label7;
        private CheckBox checkBox1;
        private ComboBox comboBox4;
        private Label label10;
        private TextBox textBox4;
        private Label label9;
        private Button button2;
        private Button button3;
        private GroupBox groupBox2;
        private CheckBox checkBox2;
        private Label label12;
        private Label label11;
        private Label label13;
        private ComboBox comboBox5;
        private ComboBox comboBox6;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox textBox6;
        private Label label14;
        private TextBox textBox7;
        private Button button5;
        private Button button4;
        private Button button6;

        public Button Button2 { get => button2; set => button2 = value; }
    }
}