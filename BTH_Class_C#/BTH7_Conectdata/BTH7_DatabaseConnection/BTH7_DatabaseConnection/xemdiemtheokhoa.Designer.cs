namespace BTH7_DatabaseConnection
{
    partial class xemdiemtheokhoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(xemdiemtheokhoa));
            this.lblmakhoa = new System.Windows.Forms.Label();
            this.lbltenkhoa = new System.Windows.Forms.Label();
            this.cbomakhoa = new System.Windows.Forms.ComboBox();
            this.cbotenkhoa = new System.Windows.Forms.ComboBox();
            this.btnxem = new System.Windows.Forms.Button();
            this.dataGridView_xemdiemtheokhoa = new System.Windows.Forms.DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_xemdiemtheokhoa)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblmakhoa
            // 
            this.lblmakhoa.AutoSize = true;
            this.lblmakhoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmakhoa.Location = new System.Drawing.Point(25, 65);
            this.lblmakhoa.Name = "lblmakhoa";
            this.lblmakhoa.Size = new System.Drawing.Size(78, 22);
            this.lblmakhoa.TabIndex = 0;
            this.lblmakhoa.Text = "Mã khoa";
            // 
            // lbltenkhoa
            // 
            this.lbltenkhoa.AutoSize = true;
            this.lbltenkhoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltenkhoa.Location = new System.Drawing.Point(25, 113);
            this.lbltenkhoa.Name = "lbltenkhoa";
            this.lbltenkhoa.Size = new System.Drawing.Size(82, 22);
            this.lbltenkhoa.TabIndex = 0;
            this.lbltenkhoa.Text = "Tên khoa";
            // 
            // cbomakhoa
            // 
            this.cbomakhoa.FormattingEnabled = true;
            this.cbomakhoa.Location = new System.Drawing.Point(150, 62);
            this.cbomakhoa.Name = "cbomakhoa";
            this.cbomakhoa.Size = new System.Drawing.Size(189, 24);
            this.cbomakhoa.TabIndex = 1;
            // 
            // cbotenkhoa
            // 
            this.cbotenkhoa.FormattingEnabled = true;
            this.cbotenkhoa.Location = new System.Drawing.Point(150, 111);
            this.cbotenkhoa.Name = "cbotenkhoa";
            this.cbotenkhoa.Size = new System.Drawing.Size(267, 24);
            this.cbotenkhoa.TabIndex = 1;
            // 
            // btnxem
            // 
            this.btnxem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxem.Location = new System.Drawing.Point(508, 107);
            this.btnxem.Name = "btnxem";
            this.btnxem.Size = new System.Drawing.Size(99, 36);
            this.btnxem.TabIndex = 2;
            this.btnxem.Text = "Xem";
            this.btnxem.UseVisualStyleBackColor = true;
            // 
            // dataGridView_xemdiemtheokhoa
            // 
            this.dataGridView_xemdiemtheokhoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_xemdiemtheokhoa.Location = new System.Drawing.Point(29, 158);
            this.dataGridView_xemdiemtheokhoa.Name = "dataGridView_xemdiemtheokhoa";
            this.dataGridView_xemdiemtheokhoa.RowHeadersWidth = 51;
            this.dataGridView_xemdiemtheokhoa.RowTemplate.Height = 24;
            this.dataGridView_xemdiemtheokhoa.Size = new System.Drawing.Size(744, 362);
            this.dataGridView_xemdiemtheokhoa.TabIndex = 3;
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
            this.toolStrip1.Size = new System.Drawing.Size(800, 27);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(29, 24);
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
            // xemdiemtheokhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 532);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridView_xemdiemtheokhoa);
            this.Controls.Add(this.btnxem);
            this.Controls.Add(this.cbotenkhoa);
            this.Controls.Add(this.cbomakhoa);
            this.Controls.Add(this.lbltenkhoa);
            this.Controls.Add(this.lblmakhoa);
            this.Name = "xemdiemtheokhoa";
            this.Text = "Xem điểm theo khoa";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_xemdiemtheokhoa)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblmakhoa;
        private System.Windows.Forms.Label lbltenkhoa;
        private System.Windows.Forms.ComboBox cbomakhoa;
        private System.Windows.Forms.ComboBox cbotenkhoa;
        private System.Windows.Forms.Button btnxem;
        private System.Windows.Forms.DataGridView dataGridView_xemdiemtheokhoa;
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
    }
}