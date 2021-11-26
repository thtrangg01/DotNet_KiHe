using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DotNet_KiHe
{
    public partial class FrmDangNhap : Form
    {

        private KetNoi kn;
        public FrmDangNhap()
        {
            InitializeComponent();
            kn = new KetNoi();
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            string username = txt_TDN.Text;
            string password = txt_MK.Text;
            string selectFomat =
                "select * from LOGIN where BINARY_CHECKSUM(MADN) = BINARY_CHECKSUM('{0}') and BINARY_CHECKSUM(MAMK) = BINARY_CHECKSUM('{1}') ";
            string sql = String.Format(selectFomat, username, password);

            // kiểm tra đăng nhập
            bool logedIn = kn.ExcuteReader(sql).Read();



            if (logedIn)
            {

                FrmMain main = new FrmMain();
                main.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Sai thông tin đăng nhập");
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
