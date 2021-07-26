namespace Tuition
{
    partial class STPAYSLIP
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.ComboBox();
            this.sTUDENTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mONTHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOURSEIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLASSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pAY1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tUITIONDataSet3 = new Tuition.TUITIONDataSet3();
            this.tUITIONDataSet = new Tuition.TUITIONDataSet();
            this.tUITIONDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tUITIONDataSet2 = new Tuition.TUITIONDataSet2();
            this.tUITIONDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pAY1TableAdapter = new Tuition.TUITIONDataSet3TableAdapters.PAY1TableAdapter();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAY1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tUITIONDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tUITIONDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tUITIONDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tUITIONDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tUITIONDataSet2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sTUDENTIDDataGridViewTextBoxColumn,
            this.nAMEDataGridViewTextBoxColumn,
            this.mONTHDataGridViewTextBoxColumn,
            this.cOURSEIDDataGridViewTextBoxColumn,
            this.cLASSDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pAY1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(37, 138);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(724, 575);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.PeachPuff;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(240, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "STUDENTS PAYMENT DETAILS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(577, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "COURSE_ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(301, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "CLASS";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(146, 94);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(139, 22);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "STUDENT_ID";
            // 
            // textBox2
            // 
            this.textBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.textBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.textBox2.FormattingEnabled = true;
            this.textBox2.Items.AddRange(new object[] {
            "IX",
            "X",
            "XI",
            "XII",
            "XII+"});
            this.textBox2.Location = new System.Drawing.Point(383, 94);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(151, 24);
            this.textBox2.TabIndex = 14;
            this.textBox2.SelectedIndexChanged += new System.EventHandler(this.textBox2_SelectedIndexChanged);
            // 
            // textBox3
            // 
            this.textBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.textBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.textBox3.FormattingEnabled = true;
            this.textBox3.Items.AddRange(new object[] {
            "PHY19",
            "CHE19",
            "BIO19",
            "PCM19",
            "PCB19",
            "PCMB19"});
            this.textBox3.Location = new System.Drawing.Point(681, 94);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(151, 24);
            this.textBox3.TabIndex = 15;
            this.textBox3.SelectedIndexChanged += new System.EventHandler(this.textBox3_SelectedIndexChanged);
            // 
            // sTUDENTIDDataGridViewTextBoxColumn
            // 
            this.sTUDENTIDDataGridViewTextBoxColumn.DataPropertyName = "STUDENT_ID";
            this.sTUDENTIDDataGridViewTextBoxColumn.HeaderText = "STUDENT_ID";
            this.sTUDENTIDDataGridViewTextBoxColumn.Name = "sTUDENTIDDataGridViewTextBoxColumn";
            // 
            // nAMEDataGridViewTextBoxColumn
            // 
            this.nAMEDataGridViewTextBoxColumn.DataPropertyName = "NAME";
            this.nAMEDataGridViewTextBoxColumn.HeaderText = "NAME";
            this.nAMEDataGridViewTextBoxColumn.Name = "nAMEDataGridViewTextBoxColumn";
            // 
            // mONTHDataGridViewTextBoxColumn
            // 
            this.mONTHDataGridViewTextBoxColumn.DataPropertyName = "MONTH";
            this.mONTHDataGridViewTextBoxColumn.HeaderText = "MONTH";
            this.mONTHDataGridViewTextBoxColumn.Name = "mONTHDataGridViewTextBoxColumn";
            // 
            // cOURSEIDDataGridViewTextBoxColumn
            // 
            this.cOURSEIDDataGridViewTextBoxColumn.DataPropertyName = "COURSE_ID";
            this.cOURSEIDDataGridViewTextBoxColumn.HeaderText = "COURSE_ID";
            this.cOURSEIDDataGridViewTextBoxColumn.Name = "cOURSEIDDataGridViewTextBoxColumn";
            // 
            // cLASSDataGridViewTextBoxColumn
            // 
            this.cLASSDataGridViewTextBoxColumn.DataPropertyName = "CLASS";
            this.cLASSDataGridViewTextBoxColumn.HeaderText = "CLASS";
            this.cLASSDataGridViewTextBoxColumn.Name = "cLASSDataGridViewTextBoxColumn";
            // 
            // pAY1BindingSource
            // 
            this.pAY1BindingSource.DataMember = "PAY1";
            this.pAY1BindingSource.DataSource = this.tUITIONDataSet3;
            // 
            // tUITIONDataSet3
            // 
            this.tUITIONDataSet3.DataSetName = "TUITIONDataSet3";
            this.tUITIONDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tUITIONDataSet
            // 
            this.tUITIONDataSet.DataSetName = "TUITIONDataSet";
            this.tUITIONDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tUITIONDataSetBindingSource
            // 
            this.tUITIONDataSetBindingSource.DataSource = this.tUITIONDataSet;
            this.tUITIONDataSetBindingSource.Position = 0;
            // 
            // tUITIONDataSet2
            // 
            this.tUITIONDataSet2.DataSetName = "TUITIONDataSet2";
            this.tUITIONDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tUITIONDataSet2BindingSource
            // 
            this.tUITIONDataSet2BindingSource.DataSource = this.tUITIONDataSet2;
            this.tUITIONDataSet2BindingSource.Position = 0;
            // 
            // pAY1TableAdapter
            // 
            this.pAY1TableAdapter.ClearBeforeFill = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(37, 13);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(38, 17);
            this.linkLabel1.TabIndex = 16;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "back";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // STPAYSLIP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 738);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "STPAYSLIP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "STPAYSLIP";
            this.Load += new System.EventHandler(this.STPAYSLIP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAY1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tUITIONDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tUITIONDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tUITIONDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tUITIONDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tUITIONDataSet2BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource tUITIONDataSet2BindingSource;
        private TUITIONDataSet2 tUITIONDataSet2;
        private TUITIONDataSet tUITIONDataSet;
        private System.Windows.Forms.BindingSource tUITIONDataSetBindingSource;
        private TUITIONDataSet3 tUITIONDataSet3;
        private System.Windows.Forms.BindingSource pAY1BindingSource;
        private TUITIONDataSet3TableAdapters.PAY1TableAdapter pAY1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTUDENTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mONTHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOURSEIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLASSDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox textBox2;
        private System.Windows.Forms.ComboBox textBox3;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}