﻿namespace QLHomeStay_App
{
    partial class frm_CTHD
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
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label15 = new System.Windows.Forms.Label();
            this.tabSearchNV = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_dv = new System.Windows.Forms.Button();
            this.cbo_dv = new System.Windows.Forms.ComboBox();
            this.btn_dong = new System.Windows.Forms.Button();
            this.cbo_mahoadon = new System.Windows.Forms.ComboBox();
            this.btn_them = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_giamgia = new System.Windows.Forms.TextBox();
            this.txt_tongtien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_capnhat = new System.Windows.Forms.Button();
            this.tabNV = new System.Windows.Forms.TabControl();
            this.txt_maCTHD = new System.Windows.Forms.TextBox();
            this.tabSearchNV.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabNV.SuspendLayout();
            this.SuspendLayout();
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "idnv";
            this.Column5.HeaderText = "ID Nhân viên";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "luong";
            this.Column1.HeaderText = "Lương";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "iduser";
            this.Column6.HeaderText = "ID User";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "hotennv";
            this.Column7.HeaderText = "Họ tên";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 125;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "sdt";
            this.Column8.HeaderText = "SĐT";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "chucvu";
            this.Column3.HeaderText = "Chức vụ";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "diachi";
            this.Column2.HeaderText = "Địa chỉ";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.label15.Location = new System.Drawing.Point(521, 69);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(164, 25);
            this.label15.TabIndex = 64;
            this.label15.Text = "Chi tiết hóa đơn";
            // 
            // tabSearchNV
            // 
            this.tabSearchNV.BackColor = System.Drawing.Color.White;
            this.tabSearchNV.Controls.Add(this.label15);
            this.tabSearchNV.Controls.Add(this.groupBox2);
            this.tabSearchNV.Location = new System.Drawing.Point(4, 4);
            this.tabSearchNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabSearchNV.Name = "tabSearchNV";
            this.tabSearchNV.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabSearchNV.Size = new System.Drawing.Size(1736, 787);
            this.tabSearchNV.TabIndex = 1;
            this.tabSearchNV.Text = "CHI TIẾT HÓA ĐƠN";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_dv);
            this.groupBox2.Controls.Add(this.cbo_dv);
            this.groupBox2.Controls.Add(this.btn_dong);
            this.groupBox2.Controls.Add(this.cbo_mahoadon);
            this.groupBox2.Controls.Add(this.btn_them);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt_maCTHD);
            this.groupBox2.Controls.Add(this.txt_giamgia);
            this.groupBox2.Controls.Add(this.txt_tongtien);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btn_capnhat);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(305, 128);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(618, 607);
            this.groupBox2.TabIndex = 63;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chi tiết";
            // 
            // btn_dv
            // 
            this.btn_dv.Location = new System.Drawing.Point(553, 230);
            this.btn_dv.Name = "btn_dv";
            this.btn_dv.Size = new System.Drawing.Size(33, 24);
            this.btn_dv.TabIndex = 146;
            this.btn_dv.Text = "+";
            this.btn_dv.UseVisualStyleBackColor = true;
            this.btn_dv.Click += new System.EventHandler(this.btn_dv_Click);
            // 
            // cbo_dv
            // 
            this.cbo_dv.FormattingEnabled = true;
            this.cbo_dv.Location = new System.Drawing.Point(231, 228);
            this.cbo_dv.Name = "cbo_dv";
            this.cbo_dv.Size = new System.Drawing.Size(300, 30);
            this.cbo_dv.TabIndex = 145;
            // 
            // btn_dong
            // 
            this.btn_dong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_dong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_dong.ForeColor = System.Drawing.Color.White;
            this.btn_dong.Location = new System.Drawing.Point(409, 508);
            this.btn_dong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_dong.Name = "btn_dong";
            this.btn_dong.Size = new System.Drawing.Size(133, 51);
            this.btn_dong.TabIndex = 144;
            this.btn_dong.Text = "Đóng";
            this.btn_dong.UseVisualStyleBackColor = false;
            // 
            // cbo_mahoadon
            // 
            this.cbo_mahoadon.FormattingEnabled = true;
            this.cbo_mahoadon.Location = new System.Drawing.Point(231, 111);
            this.cbo_mahoadon.Name = "cbo_mahoadon";
            this.cbo_mahoadon.Size = new System.Drawing.Size(300, 30);
            this.cbo_mahoadon.TabIndex = 76;
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.btn_them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_them.ForeColor = System.Drawing.Color.White;
            this.btn_them.Location = new System.Drawing.Point(90, 508);
            this.btn_them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(133, 52);
            this.btn_them.TabIndex = 74;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.label4.Location = new System.Drawing.Point(67, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 25);
            this.label4.TabIndex = 72;
            this.label4.Text = "Mã hóa đơn:";
            // 
            // txt_giamgia
            // 
            this.txt_giamgia.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_giamgia.Location = new System.Drawing.Point(231, 288);
            this.txt_giamgia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_giamgia.Name = "txt_giamgia";
            this.txt_giamgia.Size = new System.Drawing.Size(300, 32);
            this.txt_giamgia.TabIndex = 69;
            // 
            // txt_tongtien
            // 
            this.txt_tongtien.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_tongtien.Location = new System.Drawing.Point(231, 354);
            this.txt_tongtien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_tongtien.Name = "txt_tongtien";
            this.txt_tongtien.Size = new System.Drawing.Size(300, 32);
            this.txt_tongtien.TabIndex = 69;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.label3.Location = new System.Drawing.Point(76, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 25);
            this.label3.TabIndex = 68;
            this.label3.Text = "Tổng tiền :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.label2.Location = new System.Drawing.Point(81, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 68;
            this.label2.Text = "Giảm giá:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.label1.Location = new System.Drawing.Point(76, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 25);
            this.label1.TabIndex = 68;
            this.label1.Text = "Mã dịch vụ:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.label7.Location = new System.Drawing.Point(81, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 25);
            this.label7.TabIndex = 68;
            this.label7.Text = "Mã CTHD:";
            // 
            // btn_capnhat
            // 
            this.btn_capnhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.btn_capnhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_capnhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_capnhat.ForeColor = System.Drawing.Color.White;
            this.btn_capnhat.Location = new System.Drawing.Point(247, 509);
            this.btn_capnhat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_capnhat.Name = "btn_capnhat";
            this.btn_capnhat.Size = new System.Drawing.Size(133, 51);
            this.btn_capnhat.TabIndex = 61;
            this.btn_capnhat.Text = "Cập nhật";
            this.btn_capnhat.UseVisualStyleBackColor = false;
            // 
            // tabNV
            // 
            this.tabNV.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabNV.Controls.Add(this.tabSearchNV);
            this.tabNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tabNV.Location = new System.Drawing.Point(-286, -38);
            this.tabNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabNV.Name = "tabNV";
            this.tabNV.SelectedIndex = 0;
            this.tabNV.Size = new System.Drawing.Size(1744, 820);
            this.tabNV.TabIndex = 10;
            // 
            // txt_maCTHD
            // 
            this.txt_maCTHD.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_maCTHD.Location = new System.Drawing.Point(231, 169);
            this.txt_maCTHD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_maCTHD.Name = "txt_maCTHD";
            this.txt_maCTHD.Size = new System.Drawing.Size(300, 32);
            this.txt_maCTHD.TabIndex = 69;
            // 
            // frm_CTHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 733);
            this.Controls.Add(this.tabNV);
            this.Name = "frm_CTHD";
            this.Text = "CHI TIẾT HÓA ĐƠN";
            this.tabSearchNV.ResumeLayout(false);
            this.tabSearchNV.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabNV.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TabPage tabSearchNV;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbo_dv;
        private System.Windows.Forms.Button btn_dong;
        private System.Windows.Forms.ComboBox cbo_mahoadon;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_giamgia;
        private System.Windows.Forms.TextBox txt_tongtien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_capnhat;
        private System.Windows.Forms.TabControl tabNV;
        private System.Windows.Forms.Button btn_dv;
        private System.Windows.Forms.TextBox txt_maCTHD;
    }
}