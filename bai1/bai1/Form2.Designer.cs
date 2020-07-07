namespace bai1
{
    partial class Form2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbNV = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvKH = new Guna.UI2.WinForms.Guna2DataGridView();
            this.mAKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tENKHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIACHIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nGAYSINHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Xoa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.kHACHHANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sHOPHOATHUTRANGDataSet1 = new bai1.SHOPHOATHUTRANGDataSet1();
            this.txtSDTKH = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDCKH = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTKH = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpkNSKH = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTKKH = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.kHACHHANGTableAdapter = new bai1.SHOPHOATHUTRANGDataSet1TableAdapters.KHACHHANGTableAdapter();
            this.bntXoaKH = new Guna.UI2.WinForms.Guna2Button();
            this.bntSuaKH = new Guna.UI2.WinForms.Guna2Button();
            this.bntTemKH = new Guna.UI2.WinForms.Guna2Button();
            this.btnRefreshKH = new Guna.UI2.WinForms.Guna2Button();
            this.btnTKKH = new Guna.UI2.WinForms.Guna2Button();
            this.btnDong = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sHOPHOATHUTRANGDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDong);
            this.panel1.Controls.Add(this.cbNV);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(981, 72);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cbNV
            // 
            this.cbNV.BackColor = System.Drawing.Color.Transparent;
            this.cbNV.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNV.FocusedColor = System.Drawing.Color.Empty;
            this.cbNV.FocusedState.Parent = this.cbNV;
            this.cbNV.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbNV.FormattingEnabled = true;
            this.cbNV.HoverState.Parent = this.cbNV;
            this.cbNV.ItemHeight = 30;
            this.cbNV.ItemsAppearance.Parent = this.cbNV;
            this.cbNV.Location = new System.Drawing.Point(712, 20);
            this.cbNV.Name = "cbNV";
            this.cbNV.ShadowDecoration.Parent = this.cbNV;
            this.cbNV.Size = new System.Drawing.Size(140, 36);
            this.cbNV.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(627, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Theo người tạo";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.dgvKH);
            this.panel2.Controls.Add(this.txtSDTKH);
            this.panel2.Controls.Add(this.txtDCKH);
            this.panel2.Controls.Add(this.txtTKH);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.dtpkNSKH);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.bntXoaKH);
            this.panel2.Controls.Add(this.bntSuaKH);
            this.panel2.Controls.Add(this.bntTemKH);
            this.panel2.Controls.Add(this.btnRefreshKH);
            this.panel2.Controls.Add(this.btnTKKH);
            this.panel2.Controls.Add(this.txtTKKH);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(12, 81);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(971, 434);
            this.panel2.TabIndex = 1;
            // 
            // dgvKH
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvKH.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvKH.AutoGenerateColumns = false;
            this.dgvKH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKH.BackgroundColor = System.Drawing.Color.White;
            this.dgvKH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvKH.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvKH.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKH.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvKH.ColumnHeadersHeight = 21;
            this.dgvKH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mAKHDataGridViewTextBoxColumn,
            this.tENKHDataGridViewTextBoxColumn,
            this.dIACHIDataGridViewTextBoxColumn,
            this.sDTDataGridViewTextBoxColumn,
            this.nGAYSINHDataGridViewTextBoxColumn,
            this.Xoa});
            this.dgvKH.DataSource = this.kHACHHANGBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKH.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvKH.EnableHeadersVisualStyles = false;
            this.dgvKH.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvKH.Location = new System.Drawing.Point(435, 88);
            this.dgvKH.Name = "dgvKH";
            this.dgvKH.RowHeadersVisible = false;
            this.dgvKH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKH.Size = new System.Drawing.Size(533, 311);
            this.dgvKH.TabIndex = 38;
            this.dgvKH.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvKH.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvKH.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvKH.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvKH.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvKH.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvKH.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvKH.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvKH.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvKH.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvKH.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvKH.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvKH.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvKH.ThemeStyle.HeaderStyle.Height = 21;
            this.dgvKH.ThemeStyle.ReadOnly = false;
            this.dgvKH.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvKH.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvKH.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvKH.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvKH.ThemeStyle.RowsStyle.Height = 22;
            this.dgvKH.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvKH.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvKH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKH_CellContentClick);
            // 
            // mAKHDataGridViewTextBoxColumn
            // 
            this.mAKHDataGridViewTextBoxColumn.DataPropertyName = "MAKH";
            this.mAKHDataGridViewTextBoxColumn.HeaderText = "MAKH";
            this.mAKHDataGridViewTextBoxColumn.Name = "mAKHDataGridViewTextBoxColumn";
            // 
            // tENKHDataGridViewTextBoxColumn
            // 
            this.tENKHDataGridViewTextBoxColumn.DataPropertyName = "TENKH";
            this.tENKHDataGridViewTextBoxColumn.HeaderText = "TENKH";
            this.tENKHDataGridViewTextBoxColumn.Name = "tENKHDataGridViewTextBoxColumn";
            // 
            // dIACHIDataGridViewTextBoxColumn
            // 
            this.dIACHIDataGridViewTextBoxColumn.DataPropertyName = "DIACHI";
            this.dIACHIDataGridViewTextBoxColumn.HeaderText = "DIACHI";
            this.dIACHIDataGridViewTextBoxColumn.Name = "dIACHIDataGridViewTextBoxColumn";
            // 
            // sDTDataGridViewTextBoxColumn
            // 
            this.sDTDataGridViewTextBoxColumn.DataPropertyName = "SDT";
            this.sDTDataGridViewTextBoxColumn.HeaderText = "SDT";
            this.sDTDataGridViewTextBoxColumn.Name = "sDTDataGridViewTextBoxColumn";
            // 
            // nGAYSINHDataGridViewTextBoxColumn
            // 
            this.nGAYSINHDataGridViewTextBoxColumn.DataPropertyName = "NGAYSINH";
            this.nGAYSINHDataGridViewTextBoxColumn.HeaderText = "NGAYSINH";
            this.nGAYSINHDataGridViewTextBoxColumn.Name = "nGAYSINHDataGridViewTextBoxColumn";
            // 
            // Xoa
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.NullValue = "Xóa";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Xoa.DefaultCellStyle = dataGridViewCellStyle3;
            this.Xoa.HeaderText = "Xóa";
            this.Xoa.Name = "Xoa";
            // 
            // kHACHHANGBindingSource
            // 
            this.kHACHHANGBindingSource.DataMember = "KHACHHANG";
            this.kHACHHANGBindingSource.DataSource = this.sHOPHOATHUTRANGDataSet1;
            // 
            // sHOPHOATHUTRANGDataSet1
            // 
            this.sHOPHOATHUTRANGDataSet1.DataSetName = "SHOPHOATHUTRANGDataSet1";
            this.sHOPHOATHUTRANGDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtSDTKH
            // 
            this.txtSDTKH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSDTKH.DefaultText = "";
            this.txtSDTKH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSDTKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSDTKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSDTKH.DisabledState.Parent = this.txtSDTKH;
            this.txtSDTKH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSDTKH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSDTKH.FocusedState.Parent = this.txtSDTKH;
            this.txtSDTKH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSDTKH.HoverState.Parent = this.txtSDTKH;
            this.txtSDTKH.Location = new System.Drawing.Point(96, 223);
            this.txtSDTKH.Name = "txtSDTKH";
            this.txtSDTKH.PasswordChar = '\0';
            this.txtSDTKH.PlaceholderText = "";
            this.txtSDTKH.SelectedText = "";
            this.txtSDTKH.ShadowDecoration.Parent = this.txtSDTKH;
            this.txtSDTKH.Size = new System.Drawing.Size(200, 36);
            this.txtSDTKH.TabIndex = 36;
            this.txtSDTKH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSDTKH_KeyPress);
            // 
            // txtDCKH
            // 
            this.txtDCKH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDCKH.DefaultText = "";
            this.txtDCKH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDCKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDCKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDCKH.DisabledState.Parent = this.txtDCKH;
            this.txtDCKH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDCKH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDCKH.FocusedState.Parent = this.txtDCKH;
            this.txtDCKH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDCKH.HoverState.Parent = this.txtDCKH;
            this.txtDCKH.Location = new System.Drawing.Point(96, 160);
            this.txtDCKH.Name = "txtDCKH";
            this.txtDCKH.PasswordChar = '\0';
            this.txtDCKH.PlaceholderText = "";
            this.txtDCKH.SelectedText = "";
            this.txtDCKH.ShadowDecoration.Parent = this.txtDCKH;
            this.txtDCKH.Size = new System.Drawing.Size(200, 36);
            this.txtDCKH.TabIndex = 35;
            // 
            // txtTKH
            // 
            this.txtTKH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTKH.DefaultText = "";
            this.txtTKH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTKH.DisabledState.Parent = this.txtTKH;
            this.txtTKH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTKH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTKH.FocusedState.Parent = this.txtTKH;
            this.txtTKH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTKH.HoverState.Parent = this.txtTKH;
            this.txtTKH.Location = new System.Drawing.Point(96, 88);
            this.txtTKH.Name = "txtTKH";
            this.txtTKH.PasswordChar = '\0';
            this.txtTKH.PlaceholderText = "";
            this.txtTKH.SelectedText = "";
            this.txtTKH.ShadowDecoration.Parent = this.txtTKH;
            this.txtTKH.Size = new System.Drawing.Size(200, 36);
            this.txtTKH.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(111, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Số điện thoại";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(111, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Địa chỉ";
            // 
            // dtpkNSKH
            // 
            this.dtpkNSKH.CheckedState.Parent = this.dtpkNSKH;
            this.dtpkNSKH.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpkNSKH.HoverState.Parent = this.dtpkNSKH;
            this.dtpkNSKH.Location = new System.Drawing.Point(88, 288);
            this.dtpkNSKH.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpkNSKH.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpkNSKH.Name = "dtpkNSKH";
            this.dtpkNSKH.ShadowDecoration.Parent = this.dtpkNSKH;
            this.dtpkNSKH.Size = new System.Drawing.Size(200, 36);
            this.dtpkNSKH.TabIndex = 22;
            this.dtpkNSKH.Value = new System.DateTime(2020, 7, 3, 13, 33, 13, 50);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(168, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Sinh nhật";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(111, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Tên khách hàng";
            // 
            // txtTKKH
            // 
            this.txtTKKH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTKKH.DefaultText = "";
            this.txtTKKH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTKKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTKKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTKKH.DisabledState.Parent = this.txtTKKH;
            this.txtTKKH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTKKH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTKKH.FocusedState.Parent = this.txtTKKH;
            this.txtTKKH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTKKH.HoverState.Parent = this.txtTKKH;
            this.txtTKKH.Location = new System.Drawing.Point(87, 13);
            this.txtTKKH.Name = "txtTKKH";
            this.txtTKKH.PasswordChar = '\0';
            this.txtTKKH.PlaceholderText = "";
            this.txtTKKH.SelectedText = "";
            this.txtTKKH.ShadowDecoration.Parent = this.txtTKKH;
            this.txtTKKH.Size = new System.Drawing.Size(200, 36);
            this.txtTKKH.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Điều kiện lọc";
            // 
            // kHACHHANGTableAdapter
            // 
            this.kHACHHANGTableAdapter.ClearBeforeFill = true;
            // 
            // bntXoaKH
            // 
            this.bntXoaKH.CheckedState.Parent = this.bntXoaKH;
            this.bntXoaKH.CustomImages.Parent = this.bntXoaKH;
            this.bntXoaKH.FillColor = System.Drawing.Color.White;
            this.bntXoaKH.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bntXoaKH.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.bntXoaKH.HoverState.Parent = this.bntXoaKH;
            this.bntXoaKH.Image = global::bai1.Properties.Resources.deete_321;
            this.bntXoaKH.Location = new System.Drawing.Point(761, 12);
            this.bntXoaKH.Name = "bntXoaKH";
            this.bntXoaKH.ShadowDecoration.Parent = this.bntXoaKH;
            this.bntXoaKH.Size = new System.Drawing.Size(93, 39);
            this.bntXoaKH.TabIndex = 6;
            this.bntXoaKH.Text = "XÓA";
            this.bntXoaKH.Click += new System.EventHandler(this.bntXoaKH_Click);
            // 
            // bntSuaKH
            // 
            this.bntSuaKH.CheckedState.Parent = this.bntSuaKH;
            this.bntSuaKH.CustomImages.Parent = this.bntSuaKH;
            this.bntSuaKH.FillColor = System.Drawing.Color.White;
            this.bntSuaKH.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bntSuaKH.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.bntSuaKH.HoverState.Parent = this.bntSuaKH;
            this.bntSuaKH.Image = global::bai1.Properties.Resources.edit1;
            this.bntSuaKH.Location = new System.Drawing.Point(662, 12);
            this.bntSuaKH.Name = "bntSuaKH";
            this.bntSuaKH.ShadowDecoration.Parent = this.bntSuaKH;
            this.bntSuaKH.Size = new System.Drawing.Size(93, 39);
            this.bntSuaKH.TabIndex = 5;
            this.bntSuaKH.Text = "SỬA";
            this.bntSuaKH.Click += new System.EventHandler(this.bntSuaKH_Click);
            // 
            // bntTemKH
            // 
            this.bntTemKH.CheckedState.Parent = this.bntTemKH;
            this.bntTemKH.CustomImages.Parent = this.bntTemKH;
            this.bntTemKH.FillColor = System.Drawing.Color.White;
            this.bntTemKH.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bntTemKH.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.bntTemKH.HoverState.Parent = this.bntTemKH;
            this.bntTemKH.Image = global::bai1.Properties.Resources.Addchucvu1;
            this.bntTemKH.Location = new System.Drawing.Point(563, 12);
            this.bntTemKH.Name = "bntTemKH";
            this.bntTemKH.ShadowDecoration.Parent = this.bntTemKH;
            this.bntTemKH.Size = new System.Drawing.Size(93, 39);
            this.bntTemKH.TabIndex = 4;
            this.bntTemKH.Text = "THÊM";
            this.bntTemKH.Click += new System.EventHandler(this.bntTemKH_Click);
            // 
            // btnRefreshKH
            // 
            this.btnRefreshKH.CheckedState.Parent = this.btnRefreshKH;
            this.btnRefreshKH.CustomImages.Parent = this.btnRefreshKH;
            this.btnRefreshKH.FillColor = System.Drawing.Color.White;
            this.btnRefreshKH.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnRefreshKH.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnRefreshKH.HoverState.Parent = this.btnRefreshKH;
            this.btnRefreshKH.Image = global::bai1.Properties.Resources.capnhat_321;
            this.btnRefreshKH.Location = new System.Drawing.Point(464, 12);
            this.btnRefreshKH.Name = "btnRefreshKH";
            this.btnRefreshKH.ShadowDecoration.Parent = this.btnRefreshKH;
            this.btnRefreshKH.Size = new System.Drawing.Size(93, 39);
            this.btnRefreshKH.TabIndex = 3;
            this.btnRefreshKH.Text = "Refresh";
            // 
            // btnTKKH
            // 
            this.btnTKKH.CheckedState.Parent = this.btnTKKH;
            this.btnTKKH.CustomImages.Parent = this.btnTKKH;
            this.btnTKKH.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTKKH.ForeColor = System.Drawing.Color.White;
            this.btnTKKH.HoverState.Parent = this.btnTKKH;
            this.btnTKKH.Image = global::bai1.Properties.Resources.search1;
            this.btnTKKH.Location = new System.Drawing.Point(293, 12);
            this.btnTKKH.Name = "btnTKKH";
            this.btnTKKH.ShadowDecoration.Parent = this.btnTKKH;
            this.btnTKKH.Size = new System.Drawing.Size(115, 39);
            this.btnTKKH.TabIndex = 2;
            this.btnTKKH.Text = "Lọc dữ liệu";
            this.btnTKKH.Click += new System.EventHandler(this.btnTKKH_Click);
            // 
            // btnDong
            // 
            this.btnDong.CheckedState.Parent = this.btnDong;
            this.btnDong.CustomImages.Parent = this.btnDong;
            this.btnDong.FillColor = System.Drawing.Color.White;
            this.btnDong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDong.ForeColor = System.Drawing.Color.Black;
            this.btnDong.HoverState.Parent = this.btnDong;
            this.btnDong.Image = global::bai1.Properties.Resources.denied2;
            this.btnDong.Location = new System.Drawing.Point(858, 20);
            this.btnDong.Name = "btnDong";
            this.btnDong.ShadowDecoration.Parent = this.btnDong;
            this.btnDong.Size = new System.Drawing.Size(115, 36);
            this.btnDong.TabIndex = 3;
            this.btnDong.Text = "ĐÓNG";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Image = global::bai1.Properties.Resources.qlyNhanVien;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(169, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH KHÁCH HÀNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(995, 519);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sHOPHOATHUTRANGDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnDong;
        private Guna.UI2.WinForms.Guna2ComboBox cbNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btnTKKH;
        private Guna.UI2.WinForms.Guna2TextBox txtTKKH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpkNSKH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2Button bntXoaKH;
        private Guna.UI2.WinForms.Guna2Button bntSuaKH;
        private Guna.UI2.WinForms.Guna2Button bntTemKH;
        private Guna.UI2.WinForms.Guna2Button btnRefreshKH;
        private Guna.UI2.WinForms.Guna2TextBox txtSDTKH;
        private Guna.UI2.WinForms.Guna2TextBox txtDCKH;
        private Guna.UI2.WinForms.Guna2TextBox txtTKH;
        private Guna.UI2.WinForms.Guna2DataGridView dgvKH;
        private SHOPHOATHUTRANGDataSet1 sHOPHOATHUTRANGDataSet1;
        private System.Windows.Forms.BindingSource kHACHHANGBindingSource;
        private SHOPHOATHUTRANGDataSet1TableAdapters.KHACHHANGTableAdapter kHACHHANGTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIACHIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nGAYSINHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Xoa;
    }
}