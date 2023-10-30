
namespace NGANHANG
{
    partial class FrptSaoKeGD
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
            System.Windows.Forms.Label sOTKLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            this.dS = new NGANHANG.DS();
            this.tKChuyenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tKChuyenTableAdapter = new NGANHANG.DSTableAdapters.TKChuyenTableAdapter();
            this.tableAdapterManager = new NGANHANG.DSTableAdapters.TableAdapterManager();
            this.cbxSoTK = new System.Windows.Forms.ComboBox();
            this.btnSaoKe = new System.Windows.Forms.Button();
            this.dtTuNgay = new System.Windows.Forms.DateTimePicker();
            this.dtDenNgay = new System.Windows.Forms.DateTimePicker();
            sOTKLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tKChuyenBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sOTKLabel
            // 
            sOTKLabel.AutoSize = true;
            sOTKLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sOTKLabel.Location = new System.Drawing.Point(64, 113);
            sOTKLabel.Name = "sOTKLabel";
            sOTKLabel.Size = new System.Drawing.Size(121, 25);
            sOTKLabel.TabIndex = 2;
            sOTKLabel.Text = "Số tài khoản";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(48, 204);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(84, 25);
            label1.TabIndex = 7;
            label1.Text = "Từ ngày";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(382, 204);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(96, 25);
            label2.TabIndex = 8;
            label2.Text = "Đến ngày";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.ForeColor = System.Drawing.SystemColors.Highlight;
            label3.Location = new System.Drawing.Point(240, 34);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(287, 32);
            label3.TabIndex = 9;
            label3.Text = "SAO KÊ GIAO DỊCH";
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tKChuyenBindingSource
            // 
            this.tKChuyenBindingSource.DataMember = "TKChuyen";
            this.tKChuyenBindingSource.DataSource = this.dS;
            // 
            // tKChuyenTableAdapter
            // 
            this.tKChuyenTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.GD_CHUYENTIENTableAdapter = null;
            this.tableAdapterManager.GD_GOIRUTTableAdapter = null;
            this.tableAdapterManager.KhachHangTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.TaiKhoanTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = NGANHANG.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cbxSoTK
            // 
            this.cbxSoTK.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tKChuyenBindingSource, "SOTK", true));
            this.cbxSoTK.DataSource = this.tKChuyenBindingSource;
            this.cbxSoTK.DisplayMember = "SOTK";
            this.cbxSoTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSoTK.FormattingEnabled = true;
            this.cbxSoTK.Location = new System.Drawing.Point(200, 110);
            this.cbxSoTK.Name = "cbxSoTK";
            this.cbxSoTK.Size = new System.Drawing.Size(171, 33);
            this.cbxSoTK.TabIndex = 3;
            this.cbxSoTK.ValueMember = "SOTK";
            // 
            // btnSaoKe
            // 
            this.btnSaoKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSaoKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaoKe.ForeColor = System.Drawing.Color.Black;
            this.btnSaoKe.Location = new System.Drawing.Point(436, 106);
            this.btnSaoKe.Name = "btnSaoKe";
            this.btnSaoKe.Size = new System.Drawing.Size(127, 39);
            this.btnSaoKe.TabIndex = 4;
            this.btnSaoKe.Text = "Sao kê";
            this.btnSaoKe.UseVisualStyleBackColor = false;
            this.btnSaoKe.Click += new System.EventHandler(this.btnSaoKe_Click);
            // 
            // dtTuNgay
            // 
            this.dtTuNgay.CustomFormat = "dd/MM/yyyy";
            this.dtTuNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTuNgay.Location = new System.Drawing.Point(150, 204);
            this.dtTuNgay.Name = "dtTuNgay";
            this.dtTuNgay.Size = new System.Drawing.Size(200, 30);
            this.dtTuNgay.TabIndex = 5;
            // 
            // dtDenNgay
            // 
            this.dtDenNgay.CustomFormat = "dd/MM/yyyy";
            this.dtDenNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDenNgay.Location = new System.Drawing.Point(495, 204);
            this.dtDenNgay.Name = "dtDenNgay";
            this.dtDenNgay.Size = new System.Drawing.Size(139, 30);
            this.dtDenNgay.TabIndex = 6;
            // 
            // FrptSaoKeGD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 283);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(this.dtDenNgay);
            this.Controls.Add(this.dtTuNgay);
            this.Controls.Add(this.btnSaoKe);
            this.Controls.Add(sOTKLabel);
            this.Controls.Add(this.cbxSoTK);
            this.Name = "FrptSaoKeGD";
            this.Text = "FormSaoKeGD";
            this.Load += new System.EventHandler(this.FormSaoKeGD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tKChuyenBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DS dS;
        private System.Windows.Forms.BindingSource tKChuyenBindingSource;
        private DSTableAdapters.TKChuyenTableAdapter tKChuyenTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cbxSoTK;
        private System.Windows.Forms.Button btnSaoKe;
        private System.Windows.Forms.DateTimePicker dtTuNgay;
        private System.Windows.Forms.DateTimePicker dtDenNgay;
    }
}