namespace bai1
{
    partial class Form3
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtTT = new System.Windows.Forms.TextBox();
            this.guna2HtmlLabel12 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtTK = new System.Windows.Forms.TextBox();
            this.btnIn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.cbMaNCC = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbMNV = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dtpkNN = new System.Windows.Forms.DateTimePicker();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvPN = new System.Windows.Forms.DataGridView();
            this.MAPN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYNHAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MANCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TONGTIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnTK = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnSua = new Guna.UI2.WinForms.Guna2Button();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.btnCN = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 390);
            this.panel1.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            // 
            // txtTT
            // 
            this.txtTT.Location = new System.Drawing.Point(721, 467);
            this.txtTT.Name = "txtTT";
            this.txtTT.Size = new System.Drawing.Size(180, 20);
            this.txtTT.TabIndex = 19;
            // 
            // guna2HtmlLabel12
            // 
            this.guna2HtmlLabel12.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.guna2HtmlLabel12.Location = new System.Drawing.Point(629, 465);
            this.guna2HtmlLabel12.Name = "guna2HtmlLabel12";
            this.guna2HtmlLabel12.Size = new System.Drawing.Size(69, 22);
            this.guna2HtmlLabel12.TabIndex = 18;
            this.guna2HtmlLabel12.Text = "Tổng tiền";
            // 
            // txtTK
            // 
            this.txtTK.Location = new System.Drawing.Point(120, 245);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(225, 25);
            this.txtTK.TabIndex = 31;
            // 
            // btnIn
            // 
            this.btnIn.CheckedState.Parent = this.btnIn;
            this.btnIn.CustomImages.Parent = this.btnIn;
            this.btnIn.FillColor = System.Drawing.Color.PaleTurquoise;
            this.btnIn.Font = new System.Drawing.Font("Sitka Subheading", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnIn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnIn.HoverState.Parent = this.btnIn;
            this.btnIn.ImageSize = new System.Drawing.Size(30, 30);
            this.btnIn.Location = new System.Drawing.Point(823, 243);
            this.btnIn.Name = "btnIn";
            this.btnIn.ShadowDecoration.Parent = this.btnIn;
            this.btnIn.Size = new System.Drawing.Size(96, 41);
            this.btnIn.TabIndex = 30;
            this.btnIn.Text = "XUẤT";
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.guna2PictureBox1);
            this.guna2GroupBox1.Controls.Add(this.txtTK);
            this.guna2GroupBox1.Controls.Add(this.btnIn);
            this.guna2GroupBox1.Controls.Add(this.btnTK);
            this.guna2GroupBox1.Controls.Add(this.btnXoa);
            this.guna2GroupBox1.Controls.Add(this.btnSua);
            this.guna2GroupBox1.Controls.Add(this.btnThem);
            this.guna2GroupBox1.Controls.Add(this.btnCN);
            this.guna2GroupBox1.Controls.Add(this.cbMaNCC);
            this.guna2GroupBox1.Controls.Add(this.cbMNV);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlLabel6);
            this.guna2GroupBox1.Controls.Add(this.dtpkNN);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlLabel4);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlLabel3);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlLabel2);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Location = new System.Drawing.Point(3, 7);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(967, 308);
            this.guna2GroupBox1.TabIndex = 0;
            this.guna2GroupBox1.Text = "Thông tin phiếu nhập";
            this.guna2GroupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbMaNCC
            // 
            this.cbMaNCC.BackColor = System.Drawing.Color.Transparent;
            this.cbMaNCC.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbMaNCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaNCC.FocusedColor = System.Drawing.Color.Empty;
            this.cbMaNCC.FocusedState.Parent = this.cbMaNCC;
            this.cbMaNCC.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbMaNCC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbMaNCC.FormattingEnabled = true;
            this.cbMaNCC.HoverState.Parent = this.cbMaNCC;
            this.cbMaNCC.ItemHeight = 30;
            this.cbMaNCC.ItemsAppearance.Parent = this.cbMaNCC;
            this.cbMaNCC.Location = new System.Drawing.Point(498, 65);
            this.cbMaNCC.Name = "cbMaNCC";
            this.cbMaNCC.ShadowDecoration.Parent = this.cbMaNCC;
            this.cbMaNCC.Size = new System.Drawing.Size(226, 36);
            this.cbMaNCC.TabIndex = 22;
            // 
            // cbMNV
            // 
            this.cbMNV.BackColor = System.Drawing.Color.Transparent;
            this.cbMNV.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbMNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMNV.FocusedColor = System.Drawing.Color.Empty;
            this.cbMNV.FocusedState.Parent = this.cbMNV;
            this.cbMNV.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbMNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbMNV.FormattingEnabled = true;
            this.cbMNV.HoverState.Parent = this.cbMNV;
            this.cbMNV.ItemHeight = 30;
            this.cbMNV.ItemsAppearance.Parent = this.cbMNV;
            this.cbMNV.Location = new System.Drawing.Point(120, 64);
            this.cbMNV.Name = "cbMNV";
            this.cbMNV.ShadowDecoration.Parent = this.cbMNV;
            this.cbMNV.Size = new System.Drawing.Size(253, 36);
            this.cbMNV.TabIndex = 21;
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(389, 79);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(91, 15);
            this.guna2HtmlLabel6.TabIndex = 8;
            this.guna2HtmlLabel6.Text = "Tên nhà cung cấp";
            // 
            // dtpkNN
            // 
            this.dtpkNN.Location = new System.Drawing.Point(120, 127);
            this.dtpkNN.Name = "dtpkNN";
            this.dtpkNN.Size = new System.Drawing.Size(253, 25);
            this.dtpkNN.TabIndex = 6;
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(15, 185);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(3, 2);
            this.guna2HtmlLabel4.TabIndex = 3;
            this.guna2HtmlLabel4.Text = null;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(29, 79);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(72, 15);
            this.guna2HtmlLabel3.TabIndex = 2;
            this.guna2HtmlLabel3.Text = "Tên nhân viên";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(46, 141);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(55, 15);
            this.guna2HtmlLabel2.TabIndex = 1;
            this.guna2HtmlLabel2.Text = "Ngày nhập";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.dgvPN);
            this.panel2.Controls.Add(this.guna2GroupBox1);
            this.panel2.Controls.Add(this.txtTT);
            this.panel2.Controls.Add(this.guna2HtmlLabel12);
            this.panel2.Location = new System.Drawing.Point(-99, -51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(973, 492);
            this.panel2.TabIndex = 1;
            // 
            // dgvPN
            // 
            this.dgvPN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPN.BackgroundColor = System.Drawing.Color.White;
            this.dgvPN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAPN,
            this.NGAYNHAP,
            this.MaNV,
            this.MANCC,
            this.TONGTIEN});
            this.dgvPN.GridColor = System.Drawing.Color.White;
            this.dgvPN.Location = new System.Drawing.Point(0, 321);
            this.dgvPN.Name = "dgvPN";
            this.dgvPN.Size = new System.Drawing.Size(959, 141);
            this.dgvPN.TabIndex = 9;
            // 
            // MAPN
            // 
            this.MAPN.DataPropertyName = "MAPN";
            this.MAPN.HeaderText = "Mã phiếu nhập";
            this.MAPN.Name = "MAPN";
            // 
            // NGAYNHAP
            // 
            this.NGAYNHAP.DataPropertyName = "NGAYNHAP";
            this.NGAYNHAP.HeaderText = "Ngày nhập";
            this.NGAYNHAP.Name = "NGAYNHAP";
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã nhân viên";
            this.MaNV.Name = "MaNV";
            // 
            // MANCC
            // 
            this.MANCC.DataPropertyName = "MANCC";
            this.MANCC.HeaderText = "Mã nhà cung cấp";
            this.MANCC.Name = "MANCC";
            // 
            // TONGTIEN
            // 
            this.TONGTIEN.DataPropertyName = "TONGTIEN";
            this.TONGTIEN.HeaderText = "Tổng tiền";
            this.TONGTIEN.Name = "TONGTIEN";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Location = new System.Drawing.Point(757, 48);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(207, 178);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 33;
            this.guna2PictureBox1.TabStop = false;
            // 
            // btnTK
            // 
            this.btnTK.CheckedState.Parent = this.btnTK;
            this.btnTK.CustomImages.Parent = this.btnTK;
            this.btnTK.FillColor = System.Drawing.Color.PaleTurquoise;
            this.btnTK.Font = new System.Drawing.Font("Sitka Subheading", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTK.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnTK.HoverState.Parent = this.btnTK;
            this.btnTK.Image = global::bai1.Properties.Resources.search;
            this.btnTK.Location = new System.Drawing.Point(46, 245);
            this.btnTK.Name = "btnTK";
            this.btnTK.ShadowDecoration.Parent = this.btnTK;
            this.btnTK.Size = new System.Drawing.Size(55, 29);
            this.btnTK.TabIndex = 32;
            // 
            // btnXoa
            // 
            this.btnXoa.CheckedState.Parent = this.btnXoa;
            this.btnXoa.CustomImages.Parent = this.btnXoa;
            this.btnXoa.FillColor = System.Drawing.Color.DarkCyan;
            this.btnXoa.Font = new System.Drawing.Font("Sitka Subheading", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.HoverState.Parent = this.btnXoa;
            this.btnXoa.Image = global::bai1.Properties.Resources.deete_321;
            this.btnXoa.ImageSize = new System.Drawing.Size(30, 30);
            this.btnXoa.Location = new System.Drawing.Point(679, 243);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ShadowDecoration.Parent = this.btnXoa;
            this.btnXoa.Size = new System.Drawing.Size(93, 39);
            this.btnXoa.TabIndex = 28;
            this.btnXoa.Text = "XÓA";
            // 
            // btnSua
            // 
            this.btnSua.CheckedState.Parent = this.btnSua;
            this.btnSua.CustomImages.Parent = this.btnSua;
            this.btnSua.FillColor = System.Drawing.Color.DarkCyan;
            this.btnSua.Font = new System.Drawing.Font("Sitka Subheading", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.HoverState.Parent = this.btnSua;
            this.btnSua.Image = global::bai1.Properties.Resources.edit1;
            this.btnSua.Location = new System.Drawing.Point(580, 243);
            this.btnSua.Name = "btnSua";
            this.btnSua.ShadowDecoration.Parent = this.btnSua;
            this.btnSua.Size = new System.Drawing.Size(93, 39);
            this.btnSua.TabIndex = 27;
            this.btnSua.Text = "SỬA";
            // 
            // btnThem
            // 
            this.btnThem.CheckedState.Parent = this.btnThem;
            this.btnThem.CustomImages.Parent = this.btnThem;
            this.btnThem.FillColor = System.Drawing.Color.DarkCyan;
            this.btnThem.Font = new System.Drawing.Font("Sitka Subheading", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.HoverState.Parent = this.btnThem;
            this.btnThem.Image = global::bai1.Properties.Resources.Addchucvu1;
            this.btnThem.ImageSize = new System.Drawing.Size(30, 30);
            this.btnThem.Location = new System.Drawing.Point(481, 243);
            this.btnThem.Name = "btnThem";
            this.btnThem.ShadowDecoration.Parent = this.btnThem;
            this.btnThem.Size = new System.Drawing.Size(93, 39);
            this.btnThem.TabIndex = 26;
            this.btnThem.Text = "THÊM";
            // 
            // btnCN
            // 
            this.btnCN.CheckedState.Parent = this.btnCN;
            this.btnCN.CustomImages.Parent = this.btnCN;
            this.btnCN.FillColor = System.Drawing.Color.DarkCyan;
            this.btnCN.Font = new System.Drawing.Font("Sitka Subheading", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCN.ForeColor = System.Drawing.Color.White;
            this.btnCN.HoverState.Parent = this.btnCN;
            this.btnCN.Image = global::bai1.Properties.Resources.capnhat_321;
            this.btnCN.ImageSize = new System.Drawing.Size(30, 30);
            this.btnCN.Location = new System.Drawing.Point(382, 245);
            this.btnCN.Name = "btnCN";
            this.btnCN.ShadowDecoration.Parent = this.btnCN;
            this.btnCN.Size = new System.Drawing.Size(93, 39);
            this.btnCN.TabIndex = 25;
            this.btnCN.Text = "Refresh";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.panel1.ResumeLayout(false);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvPN;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAPN;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYNHAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TONGTIEN;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.TextBox txtTK;
        private Guna.UI2.WinForms.Guna2Button btnIn;
        private Guna.UI2.WinForms.Guna2Button btnTK;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2Button btnSua;
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private Guna.UI2.WinForms.Guna2Button btnCN;
        private Guna.UI2.WinForms.Guna2ComboBox cbMaNCC;
        private Guna.UI2.WinForms.Guna2ComboBox cbMNV;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private System.Windows.Forms.DateTimePicker dtpkNN;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private System.Windows.Forms.TextBox txtTT;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel12;
        private System.Windows.Forms.Timer timer1;
    }
}