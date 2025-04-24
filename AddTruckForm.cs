using ST01_3_1107_Popescu_Romeo.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ST01_3_1107_Popescu_Romeo
{
    public partial class AddTruckForm : Form
    {
        public Truck Truck {  get; set; }
        public AddTruckForm()
        {
            InitializeComponent();
        }

        private void saveTruckBtn_Click(object sender, EventArgs e)
        {
            if (Truck != null)
            {
                Truck.Id = (int) truckIdNum.Value;
                Truck.LicencePlateNumber = truckLicenceTV.Text;
                Truck.RegistrationDate = dateTimePicker1.Value;
            }
        }

        private void AddTruckForm_Load(object sender, EventArgs e)
        {
            if (Truck != null)
            {
                truckIdNum.Value = Truck.Id;
                truckLicenceTV.Text = Truck.LicencePlateNumber;
                dateTimePicker1.Value = Truck.RegistrationDate;
            }
        }

        private void truckLicenceTV_Validating(object sender, CancelEventArgs e)
        {
            if (!(truckLicenceTV.Text.Length >= 6 && truckLicenceTV.Text.Length <= 9)) 
            {
                e.Cancel = true;
                errorProvider1.SetError((Control)sender, "Invalid license plate number");
            }
            
        }

        private void truckIdNum_Validating(object sender, CancelEventArgs e)
        {
            if (truckIdNum.Value >= 100)
            {
                e.Cancel = true;
                errorProvider1.SetError((Control)sender, "Invalid id, must be under 100");
            }
        }

        private void dateTimePicker1_Validating(object sender, CancelEventArgs e)
        {
            if (dateTimePicker1.Value > DateTime.Now)
            {
                e.Cancel = true;
                errorProvider1.SetError((Control)sender, "Invalid date, must be in the past");
            }
        }
    }
}
