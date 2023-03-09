using SchoolManagementSystem.form.equipment.classequipment;
using SchoolManagementSystem.form.equipment.labequipment;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem.form.equipment
{
    public partial class EquipmentForm : Form
    {
        public EquipmentForm()
        {
            InitializeComponent();
        }

        private void labequipBtn_Click(object sender, EventArgs e)
        {
            LabEquipmentDetailForm labEquipmentDetailForm = new LabEquipmentDetailForm();
            labEquipmentDetailForm.ShowDialog(this);
        }

        private void classequipBtn_Click(object sender, EventArgs e)
        {
            ClassEquipmentDetailForm classEquipmentDetailForm = new ClassEquipmentDetailForm();
            classEquipmentDetailForm.ShowDialog(this);
        }
    }
}
