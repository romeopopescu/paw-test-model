using ST01_3_1107_Popescu_Romeo.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ST01_3_1107_Popescu_Romeo
{
    public partial class Form1 : Form
    {
        private Fleet Fleet {  get; set; }
        public Form1()
        {
            Fleet = new Fleet();
            InitializeComponent();
        }

        private void DisplayTrucks()
        {
            lvTrucks.Items.Clear();
            Fleet.Trucks.Sort();
            foreach(var  truck in Fleet.Trucks)
            {
                ListViewItem item = new ListViewItem(truck.Id.ToString());
                item.SubItems.Add(truck.LicencePlateNumber);
                item.SubItems.Add(truck.RegistrationDate.ToString());
                item.Tag = truck;
                lvTrucks.Items.Add(item);
            }
        }

        private void addTruck_Click(object sender, EventArgs e)
        {
            AddTruckForm addTruckForm = new AddTruckForm();
            Truck truck = new Truck();
            addTruckForm.Truck = truck;
            if (addTruckForm.ShowDialog() == DialogResult.OK)
            {
                Fleet.Trucks.Add(truck);
                DisplayTrucks();
            }
        }

        private void lvTrucks_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            AddTruckForm addTruckForm = new AddTruckForm();

            Truck truck = (Truck)lvTrucks.SelectedItems[0].Tag;

            addTruckForm.Truck = truck;
            if (addTruckForm.ShowDialog() == DialogResult.OK)
            {
                DisplayTrucks();
            }
        }

        private void serializeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fileStream = File.Create(saveFileDialog.FileName))
                {
                    BinaryFormatter binaryFormatter = new BinaryFormatter();
                    binaryFormatter.Serialize(fileStream, Fleet);
                }
            }
        }

        private void deserializeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fileStream = File.OpenRead(openFileDialog.FileName))
                {
                    BinaryFormatter binaryFormatter = new BinaryFormatter();
                    Fleet = (Fleet)binaryFormatter.Deserialize(fileStream);
                    DisplayTrucks();
                }
            }
        }
    }
}
