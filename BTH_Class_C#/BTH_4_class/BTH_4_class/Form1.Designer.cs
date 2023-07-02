namespace BTH_4_class
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
            this.lblmasv = new System.Windows.Forms.Label();
            this.lblkhoa = new System.Windows.Forms.Label();
            this.lbllop = new System.Windows.Forms.Label();
            this.lblquequan = new System.Windows.Forms.Label();
            this.lblgioitinh = new System.Windows.Forms.Label();
            this.lblngaysinh = new System.Windows.Forms.Label();
            this.lblhoten = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.rbtnnam = new System.Windows.Forms.RadioButton();
            this.rbtnnu = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.btnthem = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            // lblkhoa
            // 
            this.lblkhoa.AutoSize = true;
            this.lblkhoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblkhoa.Location = new System.Drawing.Point(399, 97);
            this.lblkhoa.Name = "lblkhoa";
            this.lblkhoa.Size = new System.Drawing.Size(52, 22);
            this.lblkhoa.TabIndex = 4;
            this.lblkhoa.Text = "Khoa";
            this.lblkhoa.Click += new System.EventHandler(this.label5_Click);
            // 
            // lbllop
            // 
            this.lbllop.AutoSize = true;
            this.lbllop.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllop.Location = new System.Drawing.Point(399, 58);
            this.lbllop.Name = "lbllop";
            this.lbllop.Size = new System.Drawing.Size(42, 22);
            this.lbllop.TabIndex = 5;
            this.lbllop.Text = "Lớp";
            // 
            // lblquequan
            // 
            this.lblquequan.AutoSize = true;
            this.lblquequan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblquequan.Location = new System.Drawing.Point(399, 18);
            this.lblquequan.Name = "lblquequan";
            this.lblquequan.Size = new System.Drawing.Size(84, 22);
            this.lblquequan.TabIndex = 6;
            this.lblquequan.Text = "Quê quán";
            this.lblquequan.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblgioitinh
            // 
            this.lblgioitinh.AutoSize = true;
            this.lblgioitinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgioitinh.Location = new System.Drawing.Point(12, 147);
            this.lblgioitinh.Name = "lblgioitinh";
            this.lblgioitinh.Size = new System.Drawing.Size(81, 22);
            this.lblgioitinh.TabIndex = 7;
            this.lblgioitinh.Text = "Giới tính";
            // 
            // lblngaysinh
            // 
            this.lblngaysinh.AutoSize = true;
            this.lblngaysinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblngaysinh.Location = new System.Drawing.Point(12, 97);
            this.lblngaysinh.Name = "lblngaysinh";
            this.lblngaysinh.Size = new System.Drawing.Size(88, 22);
            this.lblngaysinh.TabIndex = 8;
            this.lblngaysinh.Text = "Ngày sinh";
            // 
            // lblhoten
            // 
            this.lblhoten.AutoSize = true;
            this.lblhoten.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhoten.Location = new System.Drawing.Point(12, 58);
            this.lblhoten.Name = "lblhoten";
            this.lblhoten.Size = new System.Drawing.Size(62, 22);
            this.lblhoten.TabIndex = 9;
            this.lblhoten.Text = "Họ tên";
            this.lblhoten.Click += new System.EventHandler(this.label10_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(114, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(244, 22);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "bui van dat";
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(114, 58);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(244, 22);
            this.textBox2.TabIndex = 11;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(114, 96);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(244, 27);
            this.dateTimePicker1.TabIndex = 12;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // rbtnnam
            // 
            this.rbtnnam.AutoSize = true;
            this.rbtnnam.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnnam.Location = new System.Drawing.Point(114, 148);
            this.rbtnnam.Name = "rbtnnam";
            this.rbtnnam.Size = new System.Drawing.Size(68, 26);
            this.rbtnnam.TabIndex = 13;
            this.rbtnnam.TabStop = true;
            this.rbtnnam.Text = "Nam";
            this.rbtnnam.UseVisualStyleBackColor = true;
            // 
            // rbtnnu
            // 
            this.rbtnnu.AutoSize = true;
            this.rbtnnu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnnu.Location = new System.Drawing.Point(189, 149);
            this.rbtnnu.Name = "rbtnnu";
            this.rbtnnu.Size = new System.Drawing.Size(56, 26);
            this.rbtnnu.TabIndex = 14;
            this.rbtnnu.TabStop = true;
            this.rbtnnu.Text = "Nữ";
            this.rbtnnu.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(489, 16);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(244, 24);
            this.comboBox1.TabIndex = 15;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(489, 56);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(244, 24);
            this.comboBox2.TabIndex = 16;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(489, 94);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(244, 24);
            this.comboBox3.TabIndex = 17;
            // 
            // btnthem
            // 
            this.btnthem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnthem.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.Location = new System.Drawing.Point(459, 137);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(110, 32);
            this.btnthem.TabIndex = 18;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 195);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(751, 294);
            this.dataGridView1.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(751, 488);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.rbtnnu);
            this.Controls.Add(this.rbtnnam);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblhoten);
            this.Controls.Add(this.lblngaysinh);
            this.Controls.Add(this.lblgioitinh);
            this.Controls.Add(this.lblquequan);
            this.Controls.Add(this.lbllop);
            this.Controls.Add(this.lblkhoa);
            this.Controls.Add(this.lblmasv);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập thông tin sinh viên";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblmasv;
        private System.Windows.Forms.Label lblkhoa;
        private System.Windows.Forms.Label lbllop;
        private System.Windows.Forms.Label lblquequan;
        private System.Windows.Forms.Label lblgioitinh;
        private System.Windows.Forms.Label lblngaysinh;
        private System.Windows.Forms.Label lblhoten;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton rbtnnam;
        private System.Windows.Forms.RadioButton rbtnnu;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

