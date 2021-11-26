using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotNet_KiHe
{
    public partial class FrmPhongGD : Form
    {

        private KetNoi kn;
        public FrmPhongGD()
        {
            InitializeComponent();
            kn = new KetNoi();
        }

        private void FrmPhongGD_Load(object sender, EventArgs e)
        {
            LoadDataToForm();
            BindingData();
        }

        private void LoadDataToForm()
        {
            data_PhongBan.DataSource = kn.GetDataTable("select * from PHONGGD");

            BindingData();
        }

        private void BindingData()
        {

            txt_maphong.Clear();
            txt_maphong.DataBindings.Clear();
            txt_maphong.DataBindings.Add("Text", data_PhongBan.DataSource, "MAPHONG");

            txt_tenphong.Clear();
            txt_tenphong.DataBindings.Clear();
            txt_tenphong.DataBindings.Add("Text", data_PhongBan.DataSource, "TENPHONG");

        
            txt_diachi.Clear();
            txt_diachi.DataBindings.Clear();
            txt_diachi.DataBindings.Add("Text", data_PhongBan.DataSource, "DIADIEM");

            txt_sdt.Clear();
            txt_sdt.DataBindings.Clear();
            txt_sdt.DataBindings.Add("Text", data_PhongBan.DataSource, "DIENTHOAI");

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            txt_maphong.Text = " ";
            txt_tenphong.Text = " ";
            txt_diachi.Text = " ";
            txt_sdt.Text = " ";
            btn_Luu.Enabled = true;
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            string maphong = txt_maphong.Text;
            string tenphong = txt_tenphong.Text;
            string diadiem = txt_diachi.Text;
            string sdt = txt_sdt.Text;

            // kiểm tra trùng mã sv;
            string check_sql = "select * from PHONGGD where MAPHONG = '{0}'";
            bool msv_exsist = kn.ExcuteReader(String.Format(check_sql, maphong)).Read();

            if (msv_exsist)
            {
                MessageBox.Show("Phòng ban đã tồn tại!", "Message");
                return;
            }

            string prepare =
                "insert into PHONGGD values ('{0}', '{1}', '{2}', '{3}');";
            string sql = String.Format(prepare, maphong, tenphong, diadiem, sdt);

            try
            {
                kn.Excute(sql);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            LoadDataToForm();
            btn_Luu.Enabled = false;
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string maphong = txt_maphong.Text;
            string tenphong = txt_tenphong.Text;
            string diadiem = txt_diachi.Text;
            string sdt = txt_sdt.Text;


            string prepapre =
                "update PHONGGD set TENPHONG = '{0}', DIADIEM = '{1}', DIENTHOAI='{2}' where MAPHONG='{3}' ;";

            string sql = String.Format(prepapre, tenphong, diadiem, sdt, maphong);

            try
            {
                kn.Excute(sql);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            LoadDataToForm();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string maphong = txt_maphong.Text;
            string prepare = "delete from PHONGGD where MAPHONG = '{0}'";
            string sql = String.Format(prepare, maphong);

            DialogResult confirmDialogResult = MessageBox.Show("Bạn muốn xóa phòng ban với mã phòng là " + maphong);
            if (confirmDialogResult == DialogResult.OK)
            {
                try
                {
                    kn.Excute(sql);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
            LoadDataToForm();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
