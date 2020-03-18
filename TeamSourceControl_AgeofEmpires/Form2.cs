using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamSourceControl_AgeofEmpires
{
    public partial class frmEditArmy : Form
    {
        public object selectedArmy;

        public frmEditArmy(object selectedArmy)
        {
            InitializeComponent();
            this.selectedArmy = selectedArmy;
        }

        private void frmEditArmy_Load(object sender, EventArgs e)
        {
            txtArmyName.Text = selectedArmy.ToString();
        }

        private void btnConfirmEdit_Click(object sender, EventArgs e)
        {

        }
    }
}
