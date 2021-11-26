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
    public partial class FrmBaoCao : Form
    {
        public FrmBaoCao()
        {
            InitializeComponent();
        }

        private void FrmBaoCao_Load(object sender, EventArgs e)
        {
            BC_NV bc = new BC_NV();
            bc.SetDatabaseLogon("sa", "Admin1234", "101.96.66.219,8013", "onthi_de1");
            report.ReportSource = bc;
        }
    }
}
