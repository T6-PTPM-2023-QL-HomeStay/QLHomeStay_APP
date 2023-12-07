﻿using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHomeStay_App.GUI
{
    public partial class frm_TrangChu : DevExpress.XtraEditors.XtraForm
    {
        public frm_TrangChu()
        {
            InitializeComponent();
        }
        private Form activeForm = null;
        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            childForm.FormBorderStyle = FormBorderStyle.None;
            guna2Panel1.Controls.Add(childForm);
            guna2Panel1.Tag = childForm;
            tieude.Text = childForm.Text;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btn_qlnv_Click(object sender, EventArgs e)
        {
            frmQLNV nv = new frmQLNV();
            openChildForm(nv);
        }

        private void btn_qlkh_Click(object sender, EventArgs e)
        {
            frmQLKH kh = new frmQLKH();
            openChildForm(kh);
        }

        private void btnQLPhong_Click(object sender, EventArgs e)
        {
            frmQLPhong phong = new frmQLPhong();
            openChildForm(phong);
        }

        private void btnQLKM_Click(object sender, EventArgs e)
        {
            frmQLKM km = new frmQLKM();
            openChildForm(km);
        }

        private void btnQLDV_Click(object sender, EventArgs e)
        {
            frmQLDV dv = new frmQLDV();
            openChildForm(dv);
        }

        private void btnQLDG_Click(object sender, EventArgs e)
        {
            frmQLDG dg = new frmQLDG();
            openChildForm(dg);
        }

        private void btnQLTK_Click(object sender, EventArgs e)
        {
            frmQLTK tk = new frmQLTK();
            openChildForm(tk);
        }

        private void btnQLHD_Click(object sender, EventArgs e)
        {
            frmQLHD hd = new frmQLHD();
            openChildForm(hd);
        }
    }
}