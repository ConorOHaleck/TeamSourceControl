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
    public partial class frmArmies : Form
    {
        public frmArmies()
        {
            InitializeComponent();
        }

        private void BtnAddArmy_Click(object sender, EventArgs e)
        {
            Army army = new Army()
            {
                ArmyName = txtAddArmy.Text
            };

            ArmyDb.Add(army);
            MessageBox.Show($"{army.ArmyName} added");
            UpdateComboBox();
        }

        private void FrmArmies_Load(object sender, EventArgs e)
        {
            UpdateComboBox();
        }

        private void UpdateComboBox()
        {
            cbArmies.Items.Clear();

            List<Army> allArmies = ArmyDb.GetAllArmies();

            if (allArmies.Count > 0)
            {
                cbArmies.Enabled = true;

                for (int i = 0; i < allArmies.Count; i++)
                {
                    cbArmies.Items.Add(allArmies[i].ArmyName);
                }
            }
            else
            {
                cbArmies.Enabled = false;
            }
        }

        private void btnDeleteArmy_Click(object sender, EventArgs e)
        {
            Army selectedArmy = ArmyDb.GetArmy((string) cbArmies.SelectedItem);

            using (ConfirmDialog dialog = new ConfirmDialog())
            {
                dialog.ShowDialog();

                if (dialog.DialogResult == DialogResult.Yes)
                {
                    ArmyDb.Delete(selectedArmy);
                    UpdateComboBox();
                }
            }
        }
    }
}
