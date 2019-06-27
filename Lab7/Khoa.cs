﻿using System;
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
    public partial class frmKhoa : Form
    {
        public frmKhoa()
        {
            InitializeComponent();
        }

        private void KhoaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.khoaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.basicStudentManagementDataSet);

        }

        private void FrmKhoa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'basicStudentManagementDataSet.Khoa' table. You can move, or remove it, as needed.
            this.khoaTableAdapter.Fill(this.basicStudentManagementDataSet.Khoa);

        }
    }
}
