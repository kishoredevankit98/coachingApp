namespace Tuition
{
    partial class ADD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ADD));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.NEW = new System.Windows.Forms.TabPage();
            this.DOB = new System.Windows.Forms.DateTimePicker();
            this.label19 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.fname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.clss = new System.Windows.Forms.ComboBox();
            this.course = new System.Windows.Forms.ComboBox();
            this.mobile = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UPDATE = new System.Windows.Forms.TabPage();
            this.errorSt = new System.Windows.Forms.Label();
            this.dobu = new System.Windows.Forms.DateTimePicker();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.DEL = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sTUDENTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLASSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOURSEIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mOBILEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMAILIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTRECORDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tUITIONDataSet = new Tuition.TUITIONDataSet();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.s_id = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.sT_RECORDTableAdapter = new Tuition.TUITIONDataSetTableAdapters.ST_RECORDTableAdapter();
            this.tabControl1.SuspendLayout();
            this.NEW.SuspendLayout();
            this.UPDATE.SuspendLayout();
            this.DEL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTRECORDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tUITIONDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "BACK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.NEW);
            this.tabControl1.Controls.Add(this.UPDATE);
            this.tabControl1.Controls.Add(this.DEL);
            this.tabControl1.Location = new System.Drawing.Point(5, 42);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(860, 648);
            this.tabControl1.TabIndex = 1;
            // 
            // NEW
            // 
            this.NEW.BackColor = System.Drawing.Color.Tan;
            this.NEW.Controls.Add(this.DOB);
            this.NEW.Controls.Add(this.label19);
            this.NEW.Controls.Add(this.email);
            this.NEW.Controls.Add(this.label8);
            this.NEW.Controls.Add(this.fname);
            this.NEW.Controls.Add(this.label6);
            this.NEW.Controls.Add(this.button3);
            this.NEW.Controls.Add(this.button2);
            this.NEW.Controls.Add(this.clss);
            this.NEW.Controls.Add(this.course);
            this.NEW.Controls.Add(this.mobile);
            this.NEW.Controls.Add(this.name);
            this.NEW.Controls.Add(this.label5);
            this.NEW.Controls.Add(this.label4);
            this.NEW.Controls.Add(this.label3);
            this.NEW.Controls.Add(this.label2);
            this.NEW.Controls.Add(this.label1);
            this.NEW.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NEW.ForeColor = System.Drawing.Color.Navy;
            this.NEW.Location = new System.Drawing.Point(4, 25);
            this.NEW.Name = "NEW";
            this.NEW.Padding = new System.Windows.Forms.Padding(3);
            this.NEW.Size = new System.Drawing.Size(852, 619);
            this.NEW.TabIndex = 0;
            this.NEW.Text = "NEW ENTRY";
            this.NEW.Click += new System.EventHandler(this.NEW_Click);
            // 
            // DOB
            // 
            this.DOB.AllowDrop = true;
            this.DOB.CalendarMonthBackground = System.Drawing.Color.LightSalmon;
            this.DOB.CalendarTitleBackColor = System.Drawing.Color.Salmon;
            this.DOB.CalendarTrailingForeColor = System.Drawing.Color.Lime;
            this.DOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DOB.Location = new System.Drawing.Point(395, 277);
            this.DOB.Name = "DOB";
            this.DOB.Size = new System.Drawing.Size(178, 27);
            this.DOB.TabIndex = 17;
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.Coral;
            this.label19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label19.Location = new System.Drawing.Point(134, 280);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(152, 33);
            this.label19.TabIndex = 16;
            this.label19.Text = "DATE OF BIRTH";
            // 
            // email
            // 
            this.email.AccessibleRole = System.Windows.Forms.AccessibleRole.Link;
            this.email.AllowDrop = true;
            this.email.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.email.Location = new System.Drawing.Point(395, 401);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(178, 27);
            this.email.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Coral;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(134, 404);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 33);
            this.label8.TabIndex = 14;
            this.label8.Text = "EMAIL ID";
            // 
            // fname
            // 
            this.fname.AllowDrop = true;
            this.fname.BackColor = System.Drawing.SystemColors.MenuBar;
            this.fname.Location = new System.Drawing.Point(395, 344);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(178, 27);
            this.fname.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Coral;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(134, 347);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 33);
            this.label6.TabIndex = 12;
            this.label6.Text = "FATHER\'S NAME";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Orange;
            this.button3.Location = new System.Drawing.Point(395, 478);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 28);
            this.button3.TabIndex = 11;
            this.button3.Text = "RESET";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Chartreuse;
            this.button2.Location = new System.Drawing.Point(292, 478);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 28);
            this.button2.TabIndex = 10;
            this.button2.Text = "SUBMIT";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // clss
            // 
            this.clss.AllowDrop = true;
            this.clss.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clss.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clss.FormattingEnabled = true;
            this.clss.Items.AddRange(new object[] {
            "IX",
            "X",
            "XI",
            "XII",
            "XII+"});
            this.clss.Location = new System.Drawing.Point(395, 111);
            this.clss.Name = "clss";
            this.clss.Size = new System.Drawing.Size(178, 28);
            this.clss.TabIndex = 9;
            // 
            // course
            // 
            this.course.AllowDrop = true;
            this.course.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.course.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.course.FormattingEnabled = true;
            this.course.Items.AddRange(new object[] {
            "PHY19",
            "CHE19",
            "MTH19",
            "BIO19",
            "PCM19",
            "PCB19",
            "PCMB19"});
            this.course.Location = new System.Drawing.Point(395, 158);
            this.course.Name = "course";
            this.course.Size = new System.Drawing.Size(178, 28);
            this.course.TabIndex = 8;
            // 
            // mobile
            // 
            this.mobile.AllowDrop = true;
            this.mobile.BackColor = System.Drawing.SystemColors.Menu;
            this.mobile.Location = new System.Drawing.Point(395, 215);
            this.mobile.Name = "mobile";
            this.mobile.Size = new System.Drawing.Size(178, 27);
            this.mobile.TabIndex = 7;
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.SystemColors.MenuBar;
            this.name.Location = new System.Drawing.Point(395, 62);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(178, 27);
            this.name.TabIndex = 5;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Coral;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(134, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 33);
            this.label5.TabIndex = 4;
            this.label5.Text = "CLASS";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Coral;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(134, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 33);
            this.label4.TabIndex = 3;
            this.label4.Text = "COURSE ID";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Coral;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(134, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "MOBILE NUMBER";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Coral;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(134, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "FULL NAME";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(225, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "NEW STUDENT ENTRY";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UPDATE
            // 
            this.UPDATE.BackColor = System.Drawing.Color.LightBlue;
            this.UPDATE.Controls.Add(this.errorSt);
            this.UPDATE.Controls.Add(this.dobu);
            this.UPDATE.Controls.Add(this.label18);
            this.UPDATE.Controls.Add(this.textBox5);
            this.UPDATE.Controls.Add(this.label7);
            this.UPDATE.Controls.Add(this.textBox6);
            this.UPDATE.Controls.Add(this.label11);
            this.UPDATE.Controls.Add(this.comboBox3);
            this.UPDATE.Controls.Add(this.comboBox4);
            this.UPDATE.Controls.Add(this.textBox7);
            this.UPDATE.Controls.Add(this.textBox9);
            this.UPDATE.Controls.Add(this.label12);
            this.UPDATE.Controls.Add(this.label13);
            this.UPDATE.Controls.Add(this.label14);
            this.UPDATE.Controls.Add(this.label15);
            this.UPDATE.Controls.Add(this.button4);
            this.UPDATE.Controls.Add(this.button5);
            this.UPDATE.Controls.Add(this.textBox4);
            this.UPDATE.Controls.Add(this.label9);
            this.UPDATE.Controls.Add(this.label10);
            this.UPDATE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.UPDATE.Location = new System.Drawing.Point(4, 25);
            this.UPDATE.Name = "UPDATE";
            this.UPDATE.Padding = new System.Windows.Forms.Padding(3);
            this.UPDATE.Size = new System.Drawing.Size(852, 619);
            this.UPDATE.TabIndex = 1;
            this.UPDATE.Text = " UPDATE";
            // 
            // errorSt
            // 
            this.errorSt.BackColor = System.Drawing.Color.Transparent;
            this.errorSt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F);
            this.errorSt.ForeColor = System.Drawing.Color.Red;
            this.errorSt.Location = new System.Drawing.Point(586, 79);
            this.errorSt.Name = "errorSt";
            this.errorSt.Size = new System.Drawing.Size(260, 25);
            this.errorSt.TabIndex = 37;
            this.errorSt.Text = "*";
            // 
            // dobu
            // 
            this.dobu.Location = new System.Drawing.Point(389, 337);
            this.dobu.MaxDate = new System.DateTime(2019, 7, 12, 0, 0, 0, 0);
            this.dobu.Name = "dobu";
            this.dobu.Size = new System.Drawing.Size(191, 27);
            this.dobu.TabIndex = 36;
            this.dobu.Value = new System.DateTime(2019, 7, 12, 0, 0, 0, 0);
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.LightCoral;
            this.label18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label18.Location = new System.Drawing.Point(144, 337);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(184, 34);
            this.label18.TabIndex = 35;
            this.label18.Text = "DATE OF BIRTH: ";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(389, 468);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(191, 27);
            this.textBox5.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.LightCoral;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(144, 471);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(184, 31);
            this.label7.TabIndex = 33;
            this.label7.Text = "EMAIL ID";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(389, 400);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(191, 27);
            this.textBox6.TabIndex = 32;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.LightCoral;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Location = new System.Drawing.Point(144, 403);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(197, 37);
            this.label11.TabIndex = 31;
            this.label11.Text = "FATHER\'S NAME";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // comboBox3
            // 
            this.comboBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "IX",
            "X",
            "XI",
            "XII+"});
            this.comboBox3.Location = new System.Drawing.Point(389, 166);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(191, 28);
            this.comboBox3.TabIndex = 30;
            // 
            // comboBox4
            // 
            this.comboBox4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "PHY19",
            "CHE19",
            "MTH19",
            "PCM19",
            "PCB19",
            "PCMB19"});
            this.comboBox4.Location = new System.Drawing.Point(389, 221);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(191, 28);
            this.comboBox4.TabIndex = 29;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(389, 277);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(191, 27);
            this.textBox7.TabIndex = 28;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(389, 123);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(191, 27);
            this.textBox9.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.LightCoral;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Location = new System.Drawing.Point(144, 169);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(184, 33);
            this.label12.TabIndex = 26;
            this.label12.Text = "CLASS";
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.LightCoral;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label13.Location = new System.Drawing.Point(144, 224);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(184, 33);
            this.label13.TabIndex = 25;
            this.label13.Text = "COURSE CODE";
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.LightCoral;
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label14.Location = new System.Drawing.Point(144, 280);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(184, 31);
            this.label14.TabIndex = 24;
            this.label14.Text = "MOBILE NUMBER";
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.LightCoral;
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label15.Location = new System.Drawing.Point(144, 123);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(184, 31);
            this.label15.TabIndex = 23;
            this.label15.Text = "FULL NAME";
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button4.Location = new System.Drawing.Point(326, 560);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(93, 34);
            this.button4.TabIndex = 22;
            this.button4.Text = "RESET";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button5.Location = new System.Drawing.Point(197, 560);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(93, 34);
            this.button5.TabIndex = 21;
            this.button5.Text = "SUBMIT";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox4.Location = new System.Drawing.Point(389, 77);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(191, 27);
            this.textBox4.TabIndex = 17;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.LightCoral;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(144, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(184, 34);
            this.label9.TabIndex = 13;
            this.label9.Text = "STUDENT ID";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.CadetBlue;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.Location = new System.Drawing.Point(322, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(245, 37);
            this.label10.TabIndex = 12;
            this.label10.Text = "UPDATE";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // DEL
            // 
            this.DEL.BackColor = System.Drawing.Color.Wheat;
            this.DEL.Controls.Add(this.dataGridView1);
            this.DEL.Controls.Add(this.button10);
            this.DEL.Controls.Add(this.button9);
            this.DEL.Controls.Add(this.s_id);
            this.DEL.Controls.Add(this.label17);
            this.DEL.Controls.Add(this.label16);
            this.DEL.Location = new System.Drawing.Point(4, 25);
            this.DEL.Name = "DEL";
            this.DEL.Padding = new System.Windows.Forms.Padding(3);
            this.DEL.Size = new System.Drawing.Size(852, 619);
            this.DEL.TabIndex = 2;
            this.DEL.Text = "DELETE RECORD";
            this.DEL.Click += new System.EventHandler(this.DEL_Click);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Yellow;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sTUDENTIDDataGridViewTextBoxColumn,
            this.nAMEDataGridViewTextBoxColumn,
            this.cLASSDataGridViewTextBoxColumn,
            this.cOURSEIDDataGridViewTextBoxColumn,
            this.mOBILEDataGridViewTextBoxColumn,
            this.fNAMEDataGridViewTextBoxColumn,
            this.eMAILIDDataGridViewTextBoxColumn,
            this.dOBDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sTRECORDBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 139);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(843, 77);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // sTUDENTIDDataGridViewTextBoxColumn
            // 
            this.sTUDENTIDDataGridViewTextBoxColumn.DataPropertyName = "STUDENT_ID";
            this.sTUDENTIDDataGridViewTextBoxColumn.HeaderText = "STUDENT_ID";
            this.sTUDENTIDDataGridViewTextBoxColumn.Name = "sTUDENTIDDataGridViewTextBoxColumn";
            this.sTUDENTIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nAMEDataGridViewTextBoxColumn
            // 
            this.nAMEDataGridViewTextBoxColumn.DataPropertyName = "NAME";
            this.nAMEDataGridViewTextBoxColumn.HeaderText = "NAME";
            this.nAMEDataGridViewTextBoxColumn.Name = "nAMEDataGridViewTextBoxColumn";
            // 
            // cLASSDataGridViewTextBoxColumn
            // 
            this.cLASSDataGridViewTextBoxColumn.DataPropertyName = "CLASS";
            this.cLASSDataGridViewTextBoxColumn.HeaderText = "CLASS";
            this.cLASSDataGridViewTextBoxColumn.Name = "cLASSDataGridViewTextBoxColumn";
            // 
            // cOURSEIDDataGridViewTextBoxColumn
            // 
            this.cOURSEIDDataGridViewTextBoxColumn.DataPropertyName = "COURSE_ID";
            this.cOURSEIDDataGridViewTextBoxColumn.HeaderText = "COURSE_ID";
            this.cOURSEIDDataGridViewTextBoxColumn.Name = "cOURSEIDDataGridViewTextBoxColumn";
            // 
            // mOBILEDataGridViewTextBoxColumn
            // 
            this.mOBILEDataGridViewTextBoxColumn.DataPropertyName = "MOBILE";
            this.mOBILEDataGridViewTextBoxColumn.HeaderText = "MOBILE";
            this.mOBILEDataGridViewTextBoxColumn.Name = "mOBILEDataGridViewTextBoxColumn";
            // 
            // fNAMEDataGridViewTextBoxColumn
            // 
            this.fNAMEDataGridViewTextBoxColumn.DataPropertyName = "F_NAME";
            this.fNAMEDataGridViewTextBoxColumn.HeaderText = "F_NAME";
            this.fNAMEDataGridViewTextBoxColumn.Name = "fNAMEDataGridViewTextBoxColumn";
            // 
            // eMAILIDDataGridViewTextBoxColumn
            // 
            this.eMAILIDDataGridViewTextBoxColumn.DataPropertyName = "EMAIL_ID";
            this.eMAILIDDataGridViewTextBoxColumn.HeaderText = "EMAIL_ID";
            this.eMAILIDDataGridViewTextBoxColumn.Name = "eMAILIDDataGridViewTextBoxColumn";
            // 
            // dOBDataGridViewTextBoxColumn
            // 
            this.dOBDataGridViewTextBoxColumn.DataPropertyName = "DOB";
            this.dOBDataGridViewTextBoxColumn.HeaderText = "DOB";
            this.dOBDataGridViewTextBoxColumn.Name = "dOBDataGridViewTextBoxColumn";
            // 
            // sTRECORDBindingSource
            // 
            this.sTRECORDBindingSource.DataMember = "ST_RECORD";
            this.sTRECORDBindingSource.DataSource = this.tUITIONDataSet;
            // 
            // tUITIONDataSet
            // 
            this.tUITIONDataSet.DataSetName = "TUITIONDataSet";
            this.tUITIONDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button10.Location = new System.Drawing.Point(377, 364);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(105, 44);
            this.button10.TabIndex = 4;
            this.button10.Text = "CANCEL";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button9.Location = new System.Drawing.Point(235, 364);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(91, 44);
            this.button9.TabIndex = 3;
            this.button9.Text = "DELETE";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // s_id
            // 
            this.s_id.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.s_id.Location = new System.Drawing.Point(198, 83);
            this.s_id.Name = "s_id";
            this.s_id.Size = new System.Drawing.Size(167, 22);
            this.s_id.TabIndex = 2;
            this.s_id.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label17.Location = new System.Drawing.Point(52, 83);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(91, 17);
            this.label17.TabIndex = 1;
            this.label17.Text = "STUDENT ID";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label16.Location = new System.Drawing.Point(285, 15);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(197, 25);
            this.label16.TabIndex = 0;
            this.label16.Text = "DELETE A RECORD";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(662, 696);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 2;
            this.button7.Text = "OK";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(757, 696);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 3;
            this.button8.Text = "CANCEL";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // sT_RECORDTableAdapter
            // 
            this.sT_RECORDTableAdapter.ClearBeforeFill = true;
            // 
            // ADD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 731);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button1);
            this.Name = "ADD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADD/UPDATE STUDENT";
            this.Load += new System.EventHandler(this.ADD_Load);
            this.tabControl1.ResumeLayout(false);
            this.NEW.ResumeLayout(false);
            this.NEW.PerformLayout();
            this.UPDATE.ResumeLayout(false);
            this.UPDATE.PerformLayout();
            this.DEL.ResumeLayout(false);
            this.DEL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTRECORDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tUITIONDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage NEW;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage UPDATE;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox clss;
        private System.Windows.Forms.ComboBox course;
        private System.Windows.Forms.TextBox mobile;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox fname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TabPage DEL;
        private System.Windows.Forms.TextBox s_id;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DateTimePicker dobu;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DataGridView dataGridView1;
        private TUITIONDataSet tUITIONDataSet;
        private System.Windows.Forms.BindingSource sTRECORDBindingSource;
        private TUITIONDataSetTableAdapters.ST_RECORDTableAdapter sT_RECORDTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTUDENTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLASSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOURSEIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mOBILEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMAILIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DateTimePicker DOB;
        private System.Windows.Forms.Label errorSt;
    }
}