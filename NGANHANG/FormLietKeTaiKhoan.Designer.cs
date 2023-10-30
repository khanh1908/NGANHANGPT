
namespace NGANHANG
{
    partial class FormLietKeTaiKhoan
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
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label lblChiNhanh;
            this.dtDenNgay = new System.Windows.Forms.DateTimePicker();
            this.dtTuNgay = new System.Windows.Forms.DateTimePicker();
            this.btnXem = new System.Windows.Forms.Button();
            this.cbxChiNhanh = new System.Windows.Forms.ComboBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.checkbxToanChiNhanh = new System.Windows.Forms.CheckBox();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            lblChiNhanh = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.ForeColor = System.Drawing.SystemColors.Highlight;
            label3.Location = new System.Drawing.Point(253, 53);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(293, 32);
            label3.TabIndex = 17;
            label3.Text = "LIỆT KÊ TÀI KHOẢN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(423, 231);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(96, 25);
            label2.TabIndex = 16;
            label2.Text = "Đến ngày";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(89, 231);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(84, 25);
            label1.TabIndex = 15;
            label1.Text = "Từ ngày";
            // 
            // lblChiNhanh
            // 
            lblChiNhanh.AutoSize = true;
            lblChiNhanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblChiNhanh.Location = new System.Drawing.Point(105, 140);
            lblChiNhanh.Name = "lblChiNhanh";
            lblChiNhanh.Size = new System.Drawing.Size(120, 29);
            lblChiNhanh.TabIndex = 10;
            lblChiNhanh.Text = "Chi nhánh";
            // 
            // dtDenNgay
            // 
            this.dtDenNgay.CustomFormat = "dd/MM/yyyy";
            this.dtDenNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDenNgay.Location = new System.Drawing.Point(534, 231);
            this.dtDenNgay.Name = "dtDenNgay";
            this.dtDenNgay.Size = new System.Drawing.Size(200, 30);
            this.dtDenNgay.TabIndex = 14;
            // 
            // dtTuNgay
            // 
            this.dtTuNgay.CustomFormat = "dd/MM/yyyy";
            this.dtTuNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTuNgay.Location = new System.Drawing.Point(191, 231);
            this.dtTuNgay.Name = "dtTuNgay";
            this.dtTuNgay.Size = new System.Drawing.Size(200, 30);
            this.dtTuNgay.TabIndex = 13;
            // 
            // btnXem
            // 
            this.btnXem.BackColor = System.Drawing.Color.Aqua;
            this.btnXem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXem.ForeColor = System.Drawing.Color.Black;
            this.btnXem.Location = new System.Drawing.Point(201, 319);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(127, 39);
            this.btnXem.TabIndex = 12;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = false;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // cbxChiNhanh
            // 
            this.cbxChiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxChiNhanh.Enabled = false;
            this.cbxChiNhanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxChiNhanh.FormattingEnabled = true;
            this.cbxChiNhanh.Location = new System.Drawing.Point(241, 137);
            this.cbxChiNhanh.Name = "cbxChiNhanh";
            this.cbxChiNhanh.Size = new System.Drawing.Size(214, 33);
            this.cbxChiNhanh.TabIndex = 11;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Black;
            this.btnThoat.Location = new System.Drawing.Point(461, 319);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(127, 39);
            this.btnThoat.TabIndex = 18;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // checkbxToanChiNhanh
            // 
            this.checkbxToanChiNhanh.AutoSize = true;
            this.checkbxToanChiNhanh.Enabled = false;
            this.checkbxToanChiNhanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbxToanChiNhanh.Location = new System.Drawing.Point(514, 144);
            this.checkbxToanChiNhanh.Name = "checkbxToanChiNhanh";
            this.checkbxToanChiNhanh.Size = new System.Drawing.Size(189, 24);
            this.checkbxToanChiNhanh.TabIndex = 19;
            this.checkbxToanChiNhanh.Text = "Xem tất cả chi nhánh";
            this.checkbxToanChiNhanh.UseVisualStyleBackColor = true;
            this.checkbxToanChiNhanh.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // FormLietKeTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 410);
            this.Controls.Add(this.checkbxToanChiNhanh);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(this.dtDenNgay);
            this.Controls.Add(this.dtTuNgay);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(lblChiNhanh);
            this.Controls.Add(this.cbxChiNhanh);
            this.Name = "FormLietKeTaiKhoan";
            this.Text = "FormLietKeTaiKhoan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtDenNgay;
        private System.Windows.Forms.DateTimePicker dtTuNgay;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.ComboBox cbxChiNhanh;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.CheckBox checkbxToanChiNhanh;
    }
}