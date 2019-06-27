using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7
{
    public partial class frmDiem : Form
    {
        public frmDiem()
        {
            InitializeComponent();
        }

        private void KetQuaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ketQuaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.basicStudentManagementDataSet);

        }

        private void FrmDiem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'basicStudentManagementDataSet.KetQua' table. You can move, or remove it, as needed.
            this.ketQuaTableAdapter.Fill(this.basicStudentManagementDataSet.KetQua);

        }
    }
}
