
namespace NGANHANG
{
    partial class FormThongKeKhachHang
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.lbChiNhanh = new System.Windows.Forms.Label();
            this.cbxChiNhanh = new System.Windows.Forms.ComboBox();
            this.btnInds = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.lbChiNhanh);
            this.panelControl1.Controls.Add(this.cbxChiNhanh);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(748, 139);
            this.panelControl1.TabIndex = 0;
            // 
            // lbChiNhanh
            // 
            this.lbChiNhanh.AutoSize = true;
            this.lbChiNhanh.Location = new System.Drawing.Point(145, 58);
            this.lbChiNhanh.Margin = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.lbChiNhanh.Name = "lbChiNhanh";
            this.lbChiNhanh.Size = new System.Drawing.Size(71, 17);
            this.lbChiNhanh.TabIndex = 3;
            this.lbChiNhanh.Text = "Chi Nhánh";
            // 
            // cbxChiNhanh
            // 
            this.cbxChiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxChiNhanh.FormattingEnabled = true;
            this.cbxChiNhanh.Location = new System.Drawing.Point(308, 54);
            this.cbxChiNhanh.Margin = new System.Windows.Forms.Padding(15, 15, 15, 15);
            this.cbxChiNhanh.Name = "cbxChiNhanh";
            this.cbxChiNhanh.Size = new System.Drawing.Size(303, 24);
            this.cbxChiNhanh.TabIndex = 2;
            this.cbxChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cbxChiNhanh_SelectedIndexChanged);
            // 
            // btnInds
            // 
            this.btnInds.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnInds.Location = new System.Drawing.Point(148, 150);
            this.btnInds.Name = "btnInds";
            this.btnInds.Size = new System.Drawing.Size(146, 46);
            this.btnInds.TabIndex = 1;
            this.btnInds.Text = "In danh sách";
            this.btnInds.UseVisualStyleBackColor = false;
            this.btnInds.Click += new System.EventHandler(this.btnInds_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.Location = new System.Drawing.Point(465, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 46);
            this.button1.TabIndex = 2;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // FormThongKeKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 262);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnInds);
            this.Controls.Add(this.panelControl1);
            this.Name = "FormThongKeKhachHang";
            this.Text = "FormThongKeKhachHang";
            this.Load += new System.EventHandler(this.FormThongKeKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ComboBox cbxChiNhanh;
        private System.Windows.Forms.Label lbChiNhanh;
        private System.Windows.Forms.Button btnInds;
        private System.Windows.Forms.Button button1;
    }
}