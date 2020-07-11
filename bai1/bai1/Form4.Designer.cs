namespace bai1
{
    partial class Form4
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.btnSua = new System.Windows.Forms.Button();
            this.hOABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hinhanh = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hinhanh)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.hOABindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(29, 245);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(743, 189);
            this.dataGridView1.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(40, 145);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 7;
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialog1";
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(311, 206);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 8;
            this.btnSua.Text = "Update";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // hOABindingSource
            // 
            this.hOABindingSource.DataMember = "HOA";
            // 
            // hinhanh
            // 
            this.hinhanh.Location = new System.Drawing.Point(489, 17);
            this.hinhanh.Name = "hinhanh";
            this.hinhanh.Size = new System.Drawing.Size(159, 176);
            this.hinhanh.TabIndex = 6;
            this.hinhanh.TabStop = false;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.hinhanh);
            this.Controls.Add(this.btnSua);
            this.Name = "Form4";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hinhanh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource hOABindingSource;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox hinhanh;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.Button btnSua;
    }
}