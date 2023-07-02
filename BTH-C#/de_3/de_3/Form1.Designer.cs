namespace de_3
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.lblmasv = new System.Windows.Forms.Label();
            this.lblhoten = new System.Windows.Forms.Label();
            this.lblngaysinh = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnloc = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1_masv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2_hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3_ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4_gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5_noisinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 179;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.splitContainer2.Panel1.Controls.Add(this.dateTimePicker1);
            this.splitContainer2.Panel1.Controls.Add(this.textBox2);
            this.splitContainer2.Panel1.Controls.Add(this.textBox1);
            this.splitContainer2.Panel1.Controls.Add(this.lblngaysinh);
            this.splitContainer2.Panel1.Controls.Add(this.lblhoten);
            this.splitContainer2.Panel1.Controls.Add(this.lblmasv);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.splitContainer2.Panel2.Controls.Add(this.btnloc);
            this.splitContainer2.Panel2.Controls.Add(this.btnsua);
            this.splitContainer2.Panel2.Controls.Add(this.btnxoa);
            this.splitContainer2.Panel2.Controls.Add(this.btnthem);
            this.splitContainer2.Panel2.Controls.Add(this.radioButton2);
            this.splitContainer2.Panel2.Controls.Add(this.radioButton1);
            this.splitContainer2.Panel2.Controls.Add(this.comboBox1);
            this.splitContainer2.Panel2.Controls.Add(this.label2);
            this.splitContainer2.Panel2.Controls.Add(this.label1);
            this.splitContainer2.Size = new System.Drawing.Size(800, 179);
            this.splitContainer2.SplitterDistance = 363;
            this.splitContainer2.TabIndex = 0;
            // 
            // lblmasv
            // 
            this.lblmasv.AutoSize = true;
            this.lblmasv.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmasv.Location = new System.Drawing.Point(12, 18);
            this.lblmasv.Name = "lblmasv";
            this.lblmasv.Size = new System.Drawing.Size(65, 22);
            this.lblmasv.TabIndex = 0;
            this.lblmasv.Text = "Mã SV";
            // 
            // lblhoten
            // 
            this.lblhoten.AutoSize = true;
            this.lblhoten.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhoten.Location = new System.Drawing.Point(12, 75);
            this.lblhoten.Name = "lblhoten";
            this.lblhoten.Size = new System.Drawing.Size(62, 22);
            this.lblhoten.TabIndex = 1;
            this.lblhoten.Text = "Họ tên";
            // 
            // lblngaysinh
            // 
            this.lblngaysinh.AutoSize = true;
            this.lblngaysinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblngaysinh.Location = new System.Drawing.Point(12, 136);
            this.lblngaysinh.Name = "lblngaysinh";
            this.lblngaysinh.Size = new System.Drawing.Size(88, 22);
            this.lblngaysinh.TabIndex = 2;
            this.lblngaysinh.Text = "Ngày sinh";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(110, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(263, 22);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(110, 69);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(263, 22);
            this.textBox2.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(110, 136);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(263, 22);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nơi sinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Giới tính";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(114, 16);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(268, 24);
            this.comboBox1.TabIndex = 4;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(119, 73);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(68, 26);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Nam";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(208, 73);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(56, 26);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Nữ";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // btnthem
            // 
            this.btnthem.BackColor = System.Drawing.Color.Silver;
            this.btnthem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.Location = new System.Drawing.Point(25, 133);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 32);
            this.btnthem.TabIndex = 11;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = false;
            // 
            // btnxoa
            // 
            this.btnxoa.BackColor = System.Drawing.Color.Silver;
            this.btnxoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.Location = new System.Drawing.Point(213, 133);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 32);
            this.btnxoa.TabIndex = 7;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = false;
            // 
            // btnsua
            // 
            this.btnsua.BackColor = System.Drawing.Color.Silver;
            this.btnsua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua.Location = new System.Drawing.Point(119, 133);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 32);
            this.btnsua.TabIndex = 6;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = false;
            // 
            // btnloc
            // 
            this.btnloc.BackColor = System.Drawing.Color.Silver;
            this.btnloc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnloc.Location = new System.Drawing.Point(307, 133);
            this.btnloc.Name = "btnloc";
            this.btnloc.Size = new System.Drawing.Size(75, 32);
            this.btnloc.TabIndex = 8;
            this.btnloc.Text = "Lọc";
            this.btnloc.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1_masv,
            this.Column2_hoten,
            this.Column3_ngaysinh,
            this.Column4_gioitinh,
            this.Column5_noisinh});
            this.dataGridView1.Location = new System.Drawing.Point(0, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(800, 265);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1_masv
            // 
            this.Column1_masv.HeaderText = "Mã SV";
            this.Column1_masv.MinimumWidth = 6;
            this.Column1_masv.Name = "Column1_masv";
            this.Column1_masv.Width = 150;
            // 
            // Column2_hoten
            // 
            this.Column2_hoten.HeaderText = "Họ tên";
            this.Column2_hoten.MinimumWidth = 6;
            this.Column2_hoten.Name = "Column2_hoten";
            this.Column2_hoten.Width = 150;
            // 
            // Column3_ngaysinh
            // 
            this.Column3_ngaysinh.HeaderText = "Ngày sinh";
            this.Column3_ngaysinh.MinimumWidth = 6;
            this.Column3_ngaysinh.Name = "Column3_ngaysinh";
            this.Column3_ngaysinh.Width = 150;
            // 
            // Column4_gioitinh
            // 
            this.Column4_gioitinh.HeaderText = "Giới tính";
            this.Column4_gioitinh.MinimumWidth = 6;
            this.Column4_gioitinh.Name = "Column4_gioitinh";
            this.Column4_gioitinh.Width = 150;
            // 
            // Column5_noisinh
            // 
            this.Column5_noisinh.HeaderText = "Nơi sinh";
            this.Column5_noisinh.MinimumWidth = 6;
            this.Column5_noisinh.Name = "Column5_noisinh";
            this.Column5_noisinh.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblngaysinh;
        private System.Windows.Forms.Label lblhoten;
        private System.Windows.Forms.Label lblmasv;
        private System.Windows.Forms.Button btnloc;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1_masv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2_hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3_ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4_gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5_noisinh;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}

