namespace BTH7_DatabaseConnection
{
    partial class frmthongtinsv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmthongtinsv));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.copyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.pasteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.lblmaso = new System.Windows.Forms.Label();
            this.lblhoten = new System.Windows.Forms.Label();
            this.lblngaysinh = new System.Windows.Forms.Label();
            this.lblgioitinh = new System.Windows.Forms.Label();
            this.lbldiachi = new System.Windows.Forms.Label();
            this.lbldienthoai = new System.Windows.Forms.Label();
            this.lblmakhoa = new System.Windows.Forms.Label();
            this.txtmaso = new System.Windows.Forms.TextBox();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.txtKhoa = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dataGridView_Nhapthongtinsv = new System.Windows.Forms.DataGridView();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Nhapthongtinsv)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.openToolStripButton,
            this.saveToolStripButton,
            this.printToolStripButton,
            this.toolStripSeparator,
            this.cutToolStripButton,
            this.copyToolStripButton,
            this.pasteToolStripButton,
            this.toolStripSeparator1,
            this.helpToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(970, 31);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(29, 28);
            this.newToolStripButton.Text = "&New";
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.openToolStripButton.Text = "&Open";
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.saveToolStripButton.Text = "&Save";
            // 
            // printToolStripButton
            // 
            this.printToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripButton.Image")));
            this.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripButton.Name = "printToolStripButton";
            this.printToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.printToolStripButton.Text = "&Print";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // cutToolStripButton
            // 
            this.cutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cutToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripButton.Image")));
            this.cutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripButton.Name = "cutToolStripButton";
            this.cutToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.cutToolStripButton.Text = "C&ut";
            // 
            // copyToolStripButton
            // 
            this.copyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripButton.Image")));
            this.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripButton.Name = "copyToolStripButton";
            this.copyToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.copyToolStripButton.Text = "&Copy";
            // 
            // pasteToolStripButton
            // 
            this.pasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pasteToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripButton.Image")));
            this.pasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripButton.Name = "pasteToolStripButton";
            this.pasteToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.pasteToolStripButton.Text = "&Paste";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.helpToolStripButton.Text = "He&lp";
            // 
            // lblmaso
            // 
            this.lblmaso.AutoSize = true;
            this.lblmaso.Location = new System.Drawing.Point(26, 53);
            this.lblmaso.Name = "lblmaso";
            this.lblmaso.Size = new System.Drawing.Size(49, 16);
            this.lblmaso.TabIndex = 1;
            this.lblmaso.Text = "Ma So ";
            // 
            // lblhoten
            // 
            this.lblhoten.AutoSize = true;
            this.lblhoten.Location = new System.Drawing.Point(26, 98);
            this.lblhoten.Name = "lblhoten";
            this.lblhoten.Size = new System.Drawing.Size(52, 16);
            this.lblhoten.TabIndex = 1;
            this.lblhoten.Text = "Ho Ten";
            // 
            // lblngaysinh
            // 
            this.lblngaysinh.AutoSize = true;
            this.lblngaysinh.Location = new System.Drawing.Point(26, 142);
            this.lblngaysinh.Name = "lblngaysinh";
            this.lblngaysinh.Size = new System.Drawing.Size(69, 16);
            this.lblngaysinh.TabIndex = 1;
            this.lblngaysinh.Text = "Ngay Sinh";
            // 
            // lblgioitinh
            // 
            this.lblgioitinh.AutoSize = true;
            this.lblgioitinh.Location = new System.Drawing.Point(26, 193);
            this.lblgioitinh.Name = "lblgioitinh";
            this.lblgioitinh.Size = new System.Drawing.Size(54, 16);
            this.lblgioitinh.TabIndex = 1;
            this.lblgioitinh.Text = "Gioi tinh";
            // 
            // lbldiachi
            // 
            this.lbldiachi.AutoSize = true;
            this.lbldiachi.Location = new System.Drawing.Point(408, 56);
            this.lbldiachi.Name = "lbldiachi";
            this.lbldiachi.Size = new System.Drawing.Size(48, 16);
            this.lbldiachi.TabIndex = 1;
            this.lbldiachi.Text = "Dia chi";
            // 
            // lbldienthoai
            // 
            this.lbldienthoai.AutoSize = true;
            this.lbldienthoai.Location = new System.Drawing.Point(408, 101);
            this.lbldienthoai.Name = "lbldienthoai";
            this.lbldienthoai.Size = new System.Drawing.Size(73, 16);
            this.lbldienthoai.TabIndex = 1;
            this.lbldienthoai.Text = "Dien Thoai";
            // 
            // lblmakhoa
            // 
            this.lblmakhoa.AutoSize = true;
            this.lblmakhoa.Location = new System.Drawing.Point(408, 145);
            this.lblmakhoa.Name = "lblmakhoa";
            this.lblmakhoa.Size = new System.Drawing.Size(60, 16);
            this.lblmakhoa.TabIndex = 1;
            this.lblmakhoa.Text = "Ma Khoa";
            // 
            // txtmaso
            // 
            this.txtmaso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtmaso.Location = new System.Drawing.Point(112, 47);
            this.txtmaso.Name = "txtmaso";
            this.txtmaso.Size = new System.Drawing.Size(227, 22);
            this.txtmaso.TabIndex = 2;
            // 
            // txthoten
            // 
            this.txthoten.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txthoten.Location = new System.Drawing.Point(112, 92);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(227, 22);
            this.txthoten.TabIndex = 2;
            // 
            // txtsdt
            // 
            this.txtsdt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsdt.Location = new System.Drawing.Point(505, 98);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(216, 22);
            this.txtsdt.TabIndex = 2;
            // 
            // txtdiachi
            // 
            this.txtdiachi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdiachi.Location = new System.Drawing.Point(505, 50);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(216, 22);
            this.txtdiachi.TabIndex = 2;
            // 
            // txtKhoa
            // 
            this.txtKhoa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKhoa.Location = new System.Drawing.Point(505, 142);
            this.txtKhoa.Name = "txtKhoa";
            this.txtKhoa.Size = new System.Drawing.Size(216, 22);
            this.txtKhoa.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(112, 135);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(227, 22);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(112, 188);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(18, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // dataGridView_Nhapthongtinsv
            // 
            this.dataGridView_Nhapthongtinsv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Nhapthongtinsv.Location = new System.Drawing.Point(29, 223);
            this.dataGridView_Nhapthongtinsv.Name = "dataGridView_Nhapthongtinsv";
            this.dataGridView_Nhapthongtinsv.RowHeadersWidth = 51;
            this.dataGridView_Nhapthongtinsv.RowTemplate.Height = 24;
            this.dataGridView_Nhapthongtinsv.Size = new System.Drawing.Size(911, 274);
            this.dataGridView_Nhapthongtinsv.TabIndex = 5;
            this.dataGridView_Nhapthongtinsv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Nhapthongtinsv_CellClick);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(819, 47);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(121, 29);
            this.btnthem.TabIndex = 6;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(819, 98);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(121, 29);
            this.btnsua.TabIndex = 6;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(819, 142);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(121, 29);
            this.btnxoa.TabIndex = 6;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // frmthongtinsv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 509);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.dataGridView_Nhapthongtinsv);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtKhoa);
            this.Controls.Add(this.txtdiachi);
            this.Controls.Add(this.txtsdt);
            this.Controls.Add(this.txthoten);
            this.Controls.Add(this.txtmaso);
            this.Controls.Add(this.lblgioitinh);
            this.Controls.Add(this.lblmakhoa);
            this.Controls.Add(this.lblngaysinh);
            this.Controls.Add(this.lbldienthoai);
            this.Controls.Add(this.lblhoten);
            this.Controls.Add(this.lbldiachi);
            this.Controls.Add(this.lblmaso);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmthongtinsv";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin sinh viên";
            this.Load += new System.EventHandler(this.frmthongtinsv_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Nhapthongtinsv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton printToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton cutToolStripButton;
        private System.Windows.Forms.ToolStripButton copyToolStripButton;
        private System.Windows.Forms.ToolStripButton pasteToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.Label lblmaso;
        private System.Windows.Forms.Label lblhoten;
        private System.Windows.Forms.Label lblngaysinh;
        private System.Windows.Forms.Label lblgioitinh;
        private System.Windows.Forms.Label lbldiachi;
        private System.Windows.Forms.Label lbldienthoai;
        private System.Windows.Forms.Label lblmakhoa;
        private System.Windows.Forms.TextBox txtmaso;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.TextBox txtKhoa;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DataGridView dataGridView_Nhapthongtinsv;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
    }
}