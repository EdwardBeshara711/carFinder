using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace carFinder
{
    public partial class Form1 : Form
    {
        private readonly CarDataEntities carDataEntities;

        public Form1()
        {
            InitializeComponent();
            carDataEntities = new CarDataEntities();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            var carDriveType = carDataEntities.ebLists
                .Select(dt => new { drive = dt.drive })
                .Distinct()
                .ToList();

            cbDriveType.DisplayMember = "drive";
            cbDriveType.ValueMember = "drive";
            cbDriveType.DataSource = carDriveType;

            
        }
        private void cbDriveType_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedDriveType = cbDriveType.GetItemText(cbDriveType.SelectedValue);

            //MessageBox.Show($"{selectedDriveType + selectedDriveType.GetType()}");
            

            var carTrans = carDataEntities.ebLists
                .Where(ct => ct.drive == selectedDriveType)
                .Select(ct => new { trany = ct.trany })
                .Distinct()
                .OrderBy(ct => ct.trany)
                .ToList();

            cbTransmission.DisplayMember = "trany";
            cbTransmission.ValueMember = "id";
            cbTransmission.DataSource = carTrans;


        }

        private void cbTransmission_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedDriveType = cbDriveType.GetItemText(cbDriveType.SelectedValue);
            var selectedTransmission = cbTransmission.GetItemText(cbTransmission.SelectedValue);

            var carMake = carDataEntities.ebLists
                .Where(cm => cm.drive == selectedDriveType && cm.trany == selectedTransmission)
                .Select(cm => new { make = cm.make })
                .OrderBy(cm => cm.make)
                .Distinct()
                .ToList();

            cbMake.DisplayMember = "make";
            cbMake.ValueMember = "id";
            cbMake.DataSource = carMake;




        }

        private void cbMake_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedDriveType = cbDriveType.GetItemText(cbDriveType.SelectedValue);
            var selectedTransmission = cbTransmission.GetItemText(cbTransmission.SelectedValue);
            var selectedMake = cbMake.GetItemText(cbMake.SelectedValue);

            var carList = carDataEntities.ebLists
              .Where(cl => cl.drive == selectedDriveType)
              .Where(cl => cl.trany == selectedTransmission) 
              .Where(cl => cl.make == selectedMake)
              .Distinct()
              .ToList();

            dgCarList.DataSource = carList;
            dgCarList.Columns["make"].DisplayIndex = 0;
            dgCarList.Columns["model"].DisplayIndex = 1;
            dgCarList.Columns["drive"].DisplayIndex = 2;
            dgCarList.Columns["trany"].DisplayIndex = 3;
            dgCarList.Columns["cylinders"].DisplayIndex = 4;
            dgCarList.Columns["displ"].DisplayIndex = 5;
        }


        //private void cbMake_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    ////MessageBox.Show("index changed");
        //    //string selectedMake = cbMake.GetItemText(cbMake.SelectedItem);

        //    ////MessageBox.Show($"{selectedMake}");

        //    //var carsModels = carDataEntities.ebLists
        //    //    .Where(m => m.make == selectedMake)
        //    //    .Select(m => new { model = m.model })
        //    //    .Distinct()
        //    //    .OrderBy(m => m.model)
        //    //    .ToList();

        //    //cbModel.DisplayMember = "model";
        //    //cbModel.DataSource = carsModels;

        //}

        //private void cbYear_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    //var selectedYear = cbYear.GetItemText(cbYear.SelectedValue);

        //    ////MessageBox.Show($"{selectedYear.GetType()}");

        //    //var carMakes = carDataEntities.ebLists
        //    //    .Where(y => y.year.ToString() == selectedYear)
        //    //    .Select(c => new { make = c.make })
        //    //    .Distinct()
        //    //    .OrderBy(c => c.make)
        //    //    .ToList();

        //    //cbMake.DisplayMember = "make";
        //    //cbMake.DataSource = carMakes;

        //}

        //private void cbTransmission_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //}
    }
}
