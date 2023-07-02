namespace BTH7_DatabaseConnection
{
    partial class frmxemdiem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmxemdiem));
            this.lblmaso = new System.Windows.Forms.Label();
            this.lbltensv = new System.Windows.Forms.Label();
            this.lblkhoa = new System.Windows.Forms.Label();
            this.cbomaso = new System.Windows.Forms.ComboBox();
            this.cbotensv = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnxem = new System.Windows.Forms.Button();
            this.dataGridView_xemdiem = new System.Windows.Forms.DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_xemdiem)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblmaso
            // 
            this.lblmaso.AutoSize = true;
            this.lblmaso.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmaso.Location = new System.Drawing.Point(37, 55);
            this.lblmaso.Name = "lblmaso";
            this.lblmaso.Size = new System.Drawing.Size(59, 22);
            this.lblmaso.TabIndex = 0;
            this.lblmaso.Text = "Mã số";
            // 
            // lbltensv
            // 
            this.lbltensv.AutoSize = true;
            this.lbltensv.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltensv.Location = new System.Drawing.Point(37, 108);
            this.lbltensv.Name = "lbltensv";
            this.lbltensv.Size = new System.Drawing.Size(69, 22);
            this.lbltensv.TabIndex = 0;
            this.lbltensv.Text = "Tên SV";
            // 
            // lblkhoa
            // 
            this.lblkhoa.AutoSize = true;
            this.lblkhoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblkhoa.Location = new System.Drawing.Point(37, 164);
            this.lblkhoa.Name = "lblkhoa";
            this.lblkhoa.Size = new System.Drawing.Size(52, 22);
            this.lblkhoa.TabIndex = 0;
            this.lblkhoa.Text = "Khoa";
            // 
            // cbomaso
            // 
            this.cbomaso.FormattingEnabled = true;
            this.cbomaso.Location = new System.Drawing.Point(154, 53);
            this.cbomaso.Name = "cbomaso";
            this.cbomaso.Size = new System.Drawing.Size(179, 24);
            this.cbomaso.TabIndex = 1;
            // 
            // cbotensv
            // 
            this.cbotensv.FormattingEnabled = true;
            this.cbotensv.Location = new System.Drawing.Point(154, 106);
            this.cbotensv.Name = "cbotensv";
            this.cbotensv.Size = new System.Drawing.Size(245, 24);
            this.cbotensv.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(154, 163);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(179, 22);
            this.textBox1.TabIndex = 2;
            // 
            // btnxem
            // 
            this.btnxem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxem.Location = new System.Drawing.Point(450, 157);
            this.btnxem.Name = "btnxem";
            this.btnxem.Size = new System.Drawing.Size(99, 36);
            this.btnxem.TabIndex = 3;
            this.btnxem.Text = "Xem";
            this.btnxem.UseVisualStyleBackColor = true;
            // 
            // dataGridView_xemdiem
            // 
            this.dataGridView_xemdiem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_xemdiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_xemdiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_xemdiem.Location = new System.Drawing.Point(42, 208);
            this.dataGridView_xemdiem.Name = "dataGridView_xemdiem";
            this.dataGridView_xemdiem.RowHeadersWidth = 51;
            this.dataGridView_xemdiem.RowTemplate.Height = 24;
            this.dataGridView_xemdiem.Size = new System.Drawing.Size(527, 310);
            this.dataGridView_xemdiem.TabIndex = 4;
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
            this.toolStrip1.Size = new System.Drawing.Size(610, 27);
            this.toolStrip1.TabIndex = 5;
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
            // frmxemdiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 530);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridView_xemdiem);
            this.Controls.Add(this.btnxem);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cbotensv);
            this.Controls.Add(this.cbomaso);
            this.Controls.Add(this.lblkhoa);
            this.Controls.Add(this.lbltensv);
            this.Controls.Add(this.lblmaso);
            this.Name = "frmxemdiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xem điểm";
            this.Load += new System.EventHandler(this.xemdiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_xemdiem)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblmaso;
        private System.Windows.Forms.Label lbltensv;
        private System.Windows.Forms.Label lblkhoa;
        private System.Windows.Forms.ComboBox cbomaso;
        private System.Windows.Forms.ComboBox cbotensv;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnxem;
        private System.Windows.Forms.DataGridView dataGridView_xemdiem;
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