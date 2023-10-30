using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NGANHANG
{
    public partial class FormMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FormMain()
        {
            InitializeComponent();
            this.IsMdiContainer = true;

            
        }
        public Form checkExist(Type ftype)
        {
            foreach (Form f in MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        private void barBtnDangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = checkExist(typeof(FormLogin)) as FormLogin;
            if (form != null)
                form.Activate();
            else
            {
                FormLogin formLogin = new FormLogin();
                formLogin.MdiParent = this.MdiParent;
                formLogin.Show();
            }
        }

        private void barBtnTaoTaiKhoan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = checkExist(typeof(FormTaoTaiKhoan)) as FormTaoTaiKhoan;
            if (form != null)
                form.Activate();
            else
            {
                FormTaoTaiKhoan formLogin = new FormTaoTaiKhoan();
                formLogin.MdiParent = this.MdiParent;
                formLogin.Show();
            }
        }

        private void btnKhachHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = checkExist(typeof(FormKhachHang));
            if (form != null)
                form.Activate();
            else
            {
                FormKhachHang formKH = new FormKhachHang();
                formKH.MdiParent = this;
                formKH.Show();
            }
        }

        private void barBtnRutTien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = checkExist(typeof(FormGuiRut));
            if (form != null)
                form.Activate();
            else
            {
                FormGuiRut formGR = new FormGuiRut();
                formGR.MdiParent = this;
                formGR.Show();
            }
        }

        private void barBtnChuyenTien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = checkExist(typeof(FormChuyenTien));
            if (form != null)
                form.Activate();
            else
            {
                FormChuyenTien formGR = new FormChuyenTien();
                formGR.MdiParent = this;
                formGR.Show();
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = checkExist(typeof(FormNhanVien));
            if (form != null)
                form.Activate();
            else
            {
                FormNhanVien formGR = new FormNhanVien();
                formGR.MdiParent = this;
                formGR.Show();
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = checkExist(typeof(FrptSaoKeGD));
            if (form != null)
                form.Activate();
            else
            {
                FrptSaoKeGD formGR = new FrptSaoKeGD();
                formGR.MdiParent = this;
                formGR.Show();
            }
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = checkExist(typeof(FormThongKeKhachHang));
            if (form != null)
                form.Activate();
            else
            {
                FormThongKeKhachHang formGR = new FormThongKeKhachHang();
                formGR.MdiParent = this;
                formGR.Show();
            }
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = checkExist(typeof(FormLietKeTaiKhoan));
            if (form != null)
                form.Activate();
            else
            {
                FormLietKeTaiKhoan formGR = new FormLietKeTaiKhoan();
                formGR.MdiParent = this;
                formGR.Show();
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            Form form = checkExist(typeof(FormLogin)) as FormLogin;
            if (form != null)
                form.Activate();
            else
            {
                FormLogin formLogin = new FormLogin();
                formLogin.MdiParent = this.MdiParent;
                formLogin.Show();
            }
        }
    }
}
