
namespace Bai4
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMSV = new System.Windows.Forms.TextBox();
            this.txtHT = new System.Windows.Forms.TextBox();
            this.cbxQueQuan = new System.Windows.Forms.ComboBox();
            this.cbxLop = new System.Windows.Forms.ComboBox();
            this.cbxKhoa = new System.Windows.Forms.ComboBox();
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.rdNu = new System.Windows.Forms.RadioButton();
            this.dataGridViewSV = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cbxNS = new System.Windows.Forms.ComboBox();
            this.btnThemNew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã SV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 166);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 230);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giới tính";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(428, 46);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Quê quán";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(428, 106);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Lớp";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(428, 166);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Khoa";
            // 
            // txtMSV
            // 
            this.txtMSV.Location = new System.Drawing.Point(173, 41);
            this.txtMSV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMSV.Name = "txtMSV";
            this.txtMSV.Size = new System.Drawing.Size(132, 22);
            this.txtMSV.TabIndex = 7;
            // 
            // txtHT
            // 
            this.txtHT.Location = new System.Drawing.Point(173, 101);
            this.txtHT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHT.Name = "txtHT";
            this.txtHT.Size = new System.Drawing.Size(132, 22);
            this.txtHT.TabIndex = 8;
            // 
            // cbxQueQuan
            // 
            this.cbxQueQuan.FormattingEnabled = true;
            this.cbxQueQuan.Items.AddRange(new object[] {
            "Hà Nội",
            "Quảng Ninh",
            "Hải Dương",
            "Nam Định",
            "Thanh Hóa"});
            this.cbxQueQuan.Location = new System.Drawing.Point(509, 41);
            this.cbxQueQuan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxQueQuan.Name = "cbxQueQuan";
            this.cbxQueQuan.Size = new System.Drawing.Size(160, 24);
            this.cbxQueQuan.TabIndex = 10;
            // 
            // cbxLop
            // 
            this.cbxLop.FormattingEnabled = true;
            this.cbxLop.Items.AddRange(new object[] {
            "63CNTT1",
            "63CNTT2",
            "63CNTT3",
            "63CNTT4",
            "63CNTTVA",
            "63CNTTNB"});
            this.cbxLop.Location = new System.Drawing.Point(509, 101);
            this.cbxLop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxLop.Name = "cbxLop";
            this.cbxLop.Size = new System.Drawing.Size(160, 24);
            this.cbxLop.TabIndex = 11;
            // 
            // cbxKhoa
            // 
            this.cbxKhoa.FormattingEnabled = true;
            this.cbxKhoa.Items.AddRange(new object[] {
            "CNTT",
            "MT",
            "CK"});
            this.cbxKhoa.Location = new System.Drawing.Point(509, 161);
            this.cbxKhoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxKhoa.Name = "cbxKhoa";
            this.cbxKhoa.Size = new System.Drawing.Size(160, 24);
            this.cbxKhoa.TabIndex = 12;
            // 
            // rdNam
            // 
            this.rdNam.AutoSize = true;
            this.rdNam.Location = new System.Drawing.Point(173, 228);
            this.rdNam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(57, 20);
            this.rdNam.TabIndex = 13;
            this.rdNam.Text = "Nam";
            this.rdNam.UseVisualStyleBackColor = true;
            this.rdNam.CheckedChanged += new System.EventHandler(this.rdNam_CheckedChanged);
            // 
            // rdNu
            // 
            this.rdNu.AutoSize = true;
            this.rdNu.Location = new System.Drawing.Point(255, 228);
            this.rdNu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdNu.Name = "rdNu";
            this.rdNu.Size = new System.Drawing.Size(45, 20);
            this.rdNu.TabIndex = 14;
            this.rdNu.Text = "Nữ";
            this.rdNu.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSV
            // 
            this.dataGridViewSV.AllowUserToAddRows = false;
            this.dataGridViewSV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSV.Location = new System.Drawing.Point(0, 290);
            this.dataGridViewSV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewSV.Name = "dataGridViewSV";
            this.dataGridViewSV.RowHeadersWidth = 51;
            this.dataGridViewSV.Size = new System.Drawing.Size(690, 333);
            this.dataGridViewSV.TabIndex = 15;
            this.dataGridViewSV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSV_CellClick);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(571, 224);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 28);
            this.btnThem.TabIndex = 16;
            this.btnThem.Text = "Hiển thị";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MM/dd/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(176, 162);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(129, 22);
            this.dateTimePicker1.TabIndex = 17;
            this.dateTimePicker1.Value = new System.DateTime(2023, 5, 23, 22, 53, 20, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // cbxNS
            // 
            this.cbxNS.FormattingEnabled = true;
            this.cbxNS.Location = new System.Drawing.Point(173, 161);
            this.cbxNS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxNS.Name = "cbxNS";
            this.cbxNS.Size = new System.Drawing.Size(160, 24);
            this.cbxNS.TabIndex = 9;
            this.cbxNS.SelectedIndexChanged += new System.EventHandler(this.cbxNS_SelectedIndexChanged);
            // 
            // btnThemNew
            // 
            this.btnThemNew.Location = new System.Drawing.Point(331, 228);
            this.btnThemNew.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThemNew.Name = "btnThemNew";
            this.btnThemNew.Size = new System.Drawing.Size(100, 28);
            this.btnThemNew.TabIndex = 18;
            this.btnThemNew.Text = "Thêm";
            this.btnThemNew.UseVisualStyleBackColor = true;
            this.btnThemNew.Click += new System.EventHandler(this.btnThemNew_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 623);
            this.Controls.Add(this.btnThemNew);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dataGridViewSV);
            this.Controls.Add(this.rdNu);
            this.Controls.Add(this.rdNam);
            this.Controls.Add(this.cbxKhoa);
            this.Controls.Add(this.cbxLop);
            this.Controls.Add(this.cbxQueQuan);
            this.Controls.Add(this.cbxNS);
            this.Controls.Add(this.txtHT);
            this.Controls.Add(this.txtMSV);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Nhập thông tin sinh viên";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMSV;
        private System.Windows.Forms.TextBox txtHT;
        private System.Windows.Forms.ComboBox cbxQueQuan;
        private System.Windows.Forms.ComboBox cbxLop;
        private System.Windows.Forms.ComboBox cbxKhoa;
        private System.Windows.Forms.RadioButton rdNam;
        private System.Windows.Forms.RadioButton rdNu;
        private System.Windows.Forms.DataGridView dataGridViewSV;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cbxNS;
        private System.Windows.Forms.Button btnThemNew;
    }
}

