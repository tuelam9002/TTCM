namespace bai1
{
    partial class Form9
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.paneldanhmuc = new System.Windows.Forms.FlowLayoutPanel();
            this.panelhinhanh = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.cbHoa = new Guna.UI2.WinForms.Guna2ComboBox();
            this.nupconut = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.txttien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ca = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.txthoadon = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtdongia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtgiamgia = new System.Windows.Forms.TextBox();
            this.MAHOA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENHOA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xoa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupconut)).BeginInit();
            this.ca.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.paneldanhmuc);
            this.panel1.Controls.Add(this.panelhinhanh);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(565, 450);
            this.panel1.TabIndex = 4;
            // 
            // paneldanhmuc
            // 
            this.paneldanhmuc.AutoScroll = true;
            this.paneldanhmuc.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.paneldanhmuc.Location = new System.Drawing.Point(3, 424);
            this.paneldanhmuc.Name = "paneldanhmuc";
            this.paneldanhmuc.Size = new System.Drawing.Size(547, 57);
            this.paneldanhmuc.TabIndex = 2;
            // 
            // panelhinhanh
            // 
            this.panelhinhanh.AutoScroll = true;
            this.panelhinhanh.BackColor = System.Drawing.Color.White;
            this.panelhinhanh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelhinhanh.Location = new System.Drawing.Point(0, 0);
            this.panelhinhanh.Name = "panelhinhanh";
            this.panelhinhanh.Size = new System.Drawing.Size(550, 423);
            this.panelhinhanh.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 15);
            this.label4.TabIndex = 50;
            this.label4.Text = "Số lượng:";
            // 
            // cbHoa
            // 
            this.cbHoa.BackColor = System.Drawing.Color.Transparent;
            this.cbHoa.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbHoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHoa.FocusedColor = System.Drawing.Color.Empty;
            this.cbHoa.FocusedState.Parent = this.cbHoa;
            this.cbHoa.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbHoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbHoa.FormattingEnabled = true;
            this.cbHoa.HoverState.Parent = this.cbHoa;
            this.cbHoa.ItemHeight = 30;
            this.cbHoa.ItemsAppearance.Parent = this.cbHoa;
            this.cbHoa.Location = new System.Drawing.Point(122, 52);
            this.cbHoa.Name = "cbHoa";
            this.cbHoa.ShadowDecoration.Parent = this.cbHoa;
            this.cbHoa.Size = new System.Drawing.Size(180, 36);
            this.cbHoa.TabIndex = 49;
            // 
            // nupconut
            // 
            this.nupconut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nupconut.Location = new System.Drawing.Point(122, 117);
            this.nupconut.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nupconut.Name = "nupconut";
            this.nupconut.Size = new System.Drawing.Size(88, 20);
            this.nupconut.TabIndex = 35;
            this.nupconut.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 429);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "%";
            // 
            // txttien
            // 
            this.txttien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txttien.Location = new System.Drawing.Point(116, 425);
            this.txttien.Name = "txttien";
            this.txttien.ReadOnly = true;
            this.txttien.Size = new System.Drawing.Size(78, 20);
            this.txttien.TabIndex = 28;
            this.txttien.Text = "0";
            this.txttien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 394);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 26);
            this.label1.TabIndex = 32;
            this.label1.Text = " Tổng Tiền ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ca
            // 
            this.ca.BackColor = System.Drawing.Color.White;
            this.ca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ca.Controls.Add(this.label4);
            this.ca.Controls.Add(this.cbHoa);
            this.ca.Controls.Add(this.label8);
            this.ca.Controls.Add(this.txthoadon);
            this.ca.Controls.Add(this.label6);
            this.ca.Controls.Add(this.txtdongia);
            this.ca.Controls.Add(this.label3);
            this.ca.Controls.Add(this.nupconut);
            this.ca.Controls.Add(this.label2);
            this.ca.Controls.Add(this.txttien);
            this.ca.Controls.Add(this.label1);
            this.ca.Controls.Add(this.txtgiamgia);
            this.ca.Dock = System.Windows.Forms.DockStyle.Right;
            this.ca.Location = new System.Drawing.Point(363, 0);
            this.ca.Name = "ca";
            this.ca.Size = new System.Drawing.Size(437, 450);
            this.ca.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(44, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 15);
            this.label8.TabIndex = 48;
            this.label8.Text = "Tên hoa:";
            // 
            // txthoadon
            // 
            this.txthoadon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txthoadon.Enabled = false;
            this.txthoadon.Location = new System.Drawing.Point(144, 20);
            this.txthoadon.Name = "txthoadon";
            this.txthoadon.Size = new System.Drawing.Size(78, 20);
            this.txthoadon.TabIndex = 44;
            this.txthoadon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(38, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 15);
            this.label6.TabIndex = 43;
            this.label6.Text = "Số Hóa Đơn :";
            // 
            // txtdongia
            // 
            this.txtdongia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtdongia.BackColor = System.Drawing.Color.White;
            this.txtdongia.Enabled = false;
            this.txtdongia.Location = new System.Drawing.Point(122, 77);
            this.txtdongia.Name = "txtdongia";
            this.txtdongia.ReadOnly = true;
            this.txtdongia.Size = new System.Drawing.Size(77, 20);
            this.txtdongia.TabIndex = 40;
            this.txtdongia.Text = "0";
            this.txtdongia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 15);
            this.label3.TabIndex = 39;
            this.label3.Text = "Đơn giá :";
            // 
            // txtgiamgia
            // 
            this.txtgiamgia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtgiamgia.Location = new System.Drawing.Point(21, 426);
            this.txtgiamgia.Name = "txtgiamgia";
            this.txtgiamgia.Size = new System.Drawing.Size(73, 20);
            this.txtgiamgia.TabIndex = 30;
            this.txtgiamgia.Text = "0";
            // 
            // MAHOA
            // 
            this.MAHOA.DataPropertyName = "MAHOA";
            this.MAHOA.HeaderText = "Mã hoa";
            this.MAHOA.Name = "MAHOA";
            this.MAHOA.ReadOnly = true;
            this.MAHOA.Visible = false;
            // 
            // TENHOA
            // 
            this.TENHOA.DataPropertyName = "TENHOA";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.TENHOA.DefaultCellStyle = dataGridViewCellStyle1;
            this.TENHOA.HeaderText = "Tên Hoa";
            this.TENHOA.Name = "TENHOA";
            this.TENHOA.ReadOnly = true;
            this.TENHOA.Width = 80;
            // 
            // soluong
            // 
            this.soluong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.soluong.DataPropertyName = "soluong";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.soluong.DefaultCellStyle = dataGridViewCellStyle2;
            this.soluong.HeaderText = "S.Lượng";
            this.soluong.Name = "soluong";
            this.soluong.ReadOnly = true;
            // 
            // dongia
            // 
            this.dongia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dongia.DataPropertyName = "dongia";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dongia.DefaultCellStyle = dataGridViewCellStyle3;
            this.dongia.HeaderText = "Đ.Giá";
            this.dongia.Name = "dongia";
            this.dongia.ReadOnly = true;
            // 
            // thanhtien
            // 
            this.thanhtien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.thanhtien.DataPropertyName = "thanhtien";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.thanhtien.DefaultCellStyle = dataGridViewCellStyle4;
            this.thanhtien.HeaderText = "T.Tiền";
            this.thanhtien.Name = "thanhtien";
            this.thanhtien.ReadOnly = true;
            // 
            // xoa
            // 
            this.xoa.DataPropertyName = "xoa";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Red;
            this.xoa.DefaultCellStyle = dataGridViewCellStyle5;
            this.xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.xoa.HeaderText = "   Xóa";
            this.xoa.Name = "xoa";
            this.xoa.ReadOnly = true;
            this.xoa.Text = "Xóa";
            this.xoa.UseColumnTextForButtonValue = true;
            this.xoa.Width = 60;
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ca);
            this.Name = "Form9";
            this.Text = "Form9";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nupconut)).EndInit();
            this.ca.ResumeLayout(false);
            this.ca.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel paneldanhmuc;
        private System.Windows.Forms.FlowLayoutPanel panelhinhanh;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox cbHoa;
        private System.Windows.Forms.NumericUpDown nupconut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel ca;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txthoadon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtdongia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtgiamgia;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAHOA;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENHOA;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn dongia;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhtien;
        private System.Windows.Forms.DataGridViewButtonColumn xoa;
    }
}