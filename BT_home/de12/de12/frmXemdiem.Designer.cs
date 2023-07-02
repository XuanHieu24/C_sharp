namespace de12
{
    partial class frmXemdiem
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
            this.lbltensv = new System.Windows.Forms.Label();
            this.lblKhoa = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.txtKhoa = new System.Windows.Forms.TextBox();
            this.btnXem = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblmasv
            // 
            this.lblmasv.AutoSize = true;
            this.lblmasv.Location = new System.Drawing.Point(86, 43);
            this.lblmasv.Name = "lblmasv";
            this.lblmasv.Size = new System.Drawing.Size(47, 16);
            this.lblmasv.TabIndex = 0;
            this.lblmasv.Text = "Mã SV";
            // 
            // lbltensv
            // 
            this.lbltensv.AutoSize = true;
            this.lbltensv.Location = new System.Drawing.Point(86, 94);
            this.lbltensv.Name = "lbltensv";
            this.lbltensv.Size = new System.Drawing.Size(52, 16);
            this.lbltensv.TabIndex = 0;
            this.lbltensv.Text = "Tên SV";
            // 
            // lblKhoa
            // 
            this.lblKhoa.AutoSize = true;
            this.lblKhoa.Location = new System.Drawing.Point(86, 150);
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.Size = new System.Drawing.Size(38, 16);
            this.lblKhoa.TabIndex = 0;
            this.lblKhoa.Text = "Khoa";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(164, 43);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(212, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(164, 91);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(212, 24);
            this.comboBox2.TabIndex = 1;
            // 
            // txtKhoa
            // 
            this.txtKhoa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKhoa.Location = new System.Drawing.Point(164, 143);
            this.txtKhoa.Name = "txtKhoa";
            this.txtKhoa.Size = new System.Drawing.Size(212, 22);
            this.txtKhoa.TabIndex = 2;
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(460, 137);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(97, 33);
            this.btnXem.TabIndex = 3;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 200);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(593, 324);
            this.dataGridView1.TabIndex = 4;
            // 
            // frmXemdiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(617, 536);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.txtKhoa);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblKhoa);
            this.Controls.Add(this.lbltensv);
            this.Controls.Add(this.lblmasv);
            this.Name = "frmXemdiem";
            this.Text = "frmXemdiem";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblmasv;
        private System.Windows.Forms.Label lbltensv;
        private System.Windows.Forms.Label lblKhoa;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox txtKhoa;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}