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
    public partial class FrmTimKiem : Form
    {

        private KetNoi kn;
        public FrmTimKiem()
        {
            InitializeComponent();
            kn = new KetNoi();
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            string maPhong = txt_maphong.Text;
           

            string sql =
                "select * from PHONGGD where MAPHONG = '{0}'";


            data_TimKiem.DataSource = kn.GetDataTable(String.Format(sql, maPhong));
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
