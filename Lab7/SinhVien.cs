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
    public partial class frmSinhVien : Form
    {
        public frmSinhVien()
        {
            InitializeComponent();
        }

        private void SinhVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sinhVienBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.basicStudentManagementDataSet);

        }

        private void SinhVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'basicStudentManagementDataSet.SinhVien' table. You can move, or remove it, as needed.
            this.sinhVienTableAdapter.Fill(this.basicStudentManagementDataSet.SinhVien);

        }
    }
}
