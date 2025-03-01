namespace QuanLyQuanAn1
{
    partial class frmtable
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.flbtable = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thứcĂnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doanhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3 = new System.Windows.Forms.Panel();
            this.mudsoluong = new System.Windows.Forms.NumericUpDown();
            this.btnthem = new System.Windows.Forms.Button();
            this.cmbmon = new System.Windows.Forms.ComboBox();
            this.cmbloai = new System.Windows.Forms.ComboBox();
            this.lblmon = new System.Windows.Forms.Label();
            this.lblloai = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lsvthucdon = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbdoiban = new System.Windows.Forms.ComboBox();
            this.btndoiban = new System.Windows.Forms.Button();
            this.mudgiamgia = new System.Windows.Forms.NumericUpDown();
            this.btngiamgia = new System.Windows.Forms.Button();
            this.btnThanhtoan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mudsoluong)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mudgiamgia)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.flbtable);
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip1);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel3);
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(899, 565);
            this.splitContainer1.SplitterDistance = 517;
            this.splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(142, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Danh sách bàn";
            // 
            // flbtable
            // 
            this.flbtable.Location = new System.Drawing.Point(0, 69);
            this.flbtable.Name = "flbtable";
            this.flbtable.Size = new System.Drawing.Size(518, 493);
            this.flbtable.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.thôngTinToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(517, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.thứcĂnToolStripMenuItem,
            this.doanhMụcToolStripMenuItem,
            this.tàiKhoảnToolStripMenuItem});
            this.openToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(59, 26);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.adminToolStripMenuItem.Text = "Doanh thu";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // thứcĂnToolStripMenuItem
            // 
            this.thứcĂnToolStripMenuItem.Name = "thứcĂnToolStripMenuItem";
            this.thứcĂnToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.thứcĂnToolStripMenuItem.Text = "Thực đơn";
            this.thứcĂnToolStripMenuItem.Click += new System.EventHandler(this.thứcĂnToolStripMenuItem_Click);
            // 
            // doanhMụcToolStripMenuItem
            // 
            this.doanhMụcToolStripMenuItem.Name = "doanhMụcToolStripMenuItem";
            this.doanhMụcToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.doanhMụcToolStripMenuItem.Text = "Doanh mục";
            this.doanhMụcToolStripMenuItem.Click += new System.EventHandler(this.doanhMụcToolStripMenuItem_Click);
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.tàiKhoảnToolStripMenuItem.Text = "Tài khoản";
            this.tàiKhoảnToolStripMenuItem.Click += new System.EventHandler(this.tàiKhoảnToolStripMenuItem_Click);
            // 
            // thôngTinToolStripMenuItem
            // 
            this.thôngTinToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.thôngTinToolStripMenuItem.Name = "thôngTinToolStripMenuItem";
            this.thôngTinToolStripMenuItem.Size = new System.Drawing.Size(86, 26);
            this.thôngTinToolStripMenuItem.Text = "Thông tin";
            this.thôngTinToolStripMenuItem.Click += new System.EventHandler(this.thôngTinToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(91, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.mudsoluong);
            this.panel3.Controls.Add(this.btnthem);
            this.panel3.Controls.Add(this.cmbmon);
            this.panel3.Controls.Add(this.cmbloai);
            this.panel3.Controls.Add(this.lblmon);
            this.panel3.Controls.Add(this.lblloai);
            this.panel3.Location = new System.Drawing.Point(3, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(375, 80);
            this.panel3.TabIndex = 2;
            // 
            // mudsoluong
            // 
            this.mudsoluong.Location = new System.Drawing.Point(270, 28);
            this.mudsoluong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.mudsoluong.Name = "mudsoluong";
            this.mudsoluong.Size = new System.Drawing.Size(73, 25);
            this.mudsoluong.TabIndex = 5;
            this.mudsoluong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mudsoluong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnthem
            // 
            this.btnthem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnthem.Location = new System.Drawing.Point(178, 10);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(87, 68);
            this.btnthem.TabIndex = 4;
            this.btnthem.Text = "Thêm món";
            this.btnthem.UseVisualStyleBackColor = true;
            // 
            // cmbmon
            // 
            this.cmbmon.FormattingEnabled = true;
            this.cmbmon.Location = new System.Drawing.Point(66, 52);
            this.cmbmon.Name = "cmbmon";
            this.cmbmon.Size = new System.Drawing.Size(106, 25);
            this.cmbmon.TabIndex = 3;
            // 
            // cmbloai
            // 
            this.cmbloai.FormattingEnabled = true;
            this.cmbloai.Location = new System.Drawing.Point(66, 4);
            this.cmbloai.Name = "cmbloai";
            this.cmbloai.Size = new System.Drawing.Size(106, 25);
            this.cmbloai.TabIndex = 2;
            // 
            // lblmon
            // 
            this.lblmon.AutoSize = true;
            this.lblmon.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblmon.Location = new System.Drawing.Point(21, 55);
            this.lblmon.Name = "lblmon";
            this.lblmon.Size = new System.Drawing.Size(38, 17);
            this.lblmon.TabIndex = 1;
            this.lblmon.Text = "Món:";
            // 
            // lblloai
            // 
            this.lblloai.AutoSize = true;
            this.lblloai.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblloai.Location = new System.Drawing.Point(21, 8);
            this.lblloai.Name = "lblloai";
            this.lblloai.Size = new System.Drawing.Size(35, 17);
            this.lblloai.TabIndex = 0;
            this.lblloai.Text = "Loại:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lsvthucdon);
            this.panel2.Location = new System.Drawing.Point(2, 96);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(376, 375);
            this.panel2.TabIndex = 1;
            // 
            // lsvthucdon
            // 
            this.lsvthucdon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lsvthucdon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvthucdon.HideSelection = false;
            this.lsvthucdon.Location = new System.Drawing.Point(0, 0);
            this.lsvthucdon.Name = "lsvthucdon";
            this.lsvthucdon.Size = new System.Drawing.Size(376, 375);
            this.lsvthucdon.TabIndex = 0;
            this.lsvthucdon.UseCompatibleStateImageBehavior = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbdoiban);
            this.panel1.Controls.Add(this.btndoiban);
            this.panel1.Controls.Add(this.mudgiamgia);
            this.panel1.Controls.Add(this.btngiamgia);
            this.panel1.Controls.Add(this.btnThanhtoan);
            this.panel1.Location = new System.Drawing.Point(3, 466);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(392, 99);
            this.panel1.TabIndex = 0;
            // 
            // cmbdoiban
            // 
            this.cmbdoiban.FormattingEnabled = true;
            this.cmbdoiban.Location = new System.Drawing.Point(33, 63);
            this.cmbdoiban.Name = "cmbdoiban";
            this.cmbdoiban.Size = new System.Drawing.Size(70, 25);
            this.cmbdoiban.TabIndex = 4;
            // 
            // btndoiban
            // 
            this.btndoiban.Location = new System.Drawing.Point(33, 11);
            this.btndoiban.Name = "btndoiban";
            this.btndoiban.Size = new System.Drawing.Size(70, 46);
            this.btndoiban.TabIndex = 3;
            this.btndoiban.Text = "Đổi bàn";
            this.btndoiban.UseVisualStyleBackColor = true;
            // 
            // mudgiamgia
            // 
            this.mudgiamgia.Location = new System.Drawing.Point(155, 55);
            this.mudgiamgia.Name = "mudgiamgia";
            this.mudgiamgia.Size = new System.Drawing.Size(93, 25);
            this.mudgiamgia.TabIndex = 2;
            this.mudgiamgia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btngiamgia
            // 
            this.btngiamgia.Location = new System.Drawing.Point(155, 11);
            this.btngiamgia.Name = "btngiamgia";
            this.btngiamgia.Size = new System.Drawing.Size(93, 38);
            this.btngiamgia.TabIndex = 1;
            this.btngiamgia.Text = "Giảm giá(%)";
            this.btngiamgia.UseVisualStyleBackColor = true;
            // 
            // btnThanhtoan
            // 
            this.btnThanhtoan.Location = new System.Drawing.Point(285, 3);
            this.btnThanhtoan.Name = "btnThanhtoan";
            this.btnThanhtoan.Size = new System.Drawing.Size(91, 91);
            this.btnThanhtoan.TabIndex = 0;
            this.btnThanhtoan.Text = "Thanh toán";
            this.btnThanhtoan.UseVisualStyleBackColor = true;
            // 
            // frmtable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 565);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmtable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tang chủ";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mudsoluong)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mudgiamgia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.ComboBox cmbmon;
        private System.Windows.Forms.ComboBox cmbloai;
        private System.Windows.Forms.Label lblmon;
        private System.Windows.Forms.Label lblloai;
        private System.Windows.Forms.Button btndoiban;
        private System.Windows.Forms.NumericUpDown mudgiamgia;
        private System.Windows.Forms.Button btngiamgia;
        private System.Windows.Forms.Button btnThanhtoan;
        private System.Windows.Forms.NumericUpDown mudsoluong;
        private System.Windows.Forms.FlowLayoutPanel flbtable;
        private System.Windows.Forms.ComboBox cmbdoiban;
        private System.Windows.Forms.ListView lsvthucdon;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thứcĂnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doanhMụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}