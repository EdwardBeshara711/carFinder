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

           //select * from ebLists
            var carsYear = carDataEntities.ebLists
                .Select(c => new { year = c.year })
                .Distinct()
                .OrderBy(c => c.year)
                .ToList();

            cbYear.DisplayMember = "year";
            cbYear.DataSource = carsYear;
                                  
        }

        private void cbMake_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("index changed");
            string selectedMake = cbMake.GetItemText(cbMake.SelectedItem);

            //MessageBox.Show($"{selectedMake}");

            var carsModels = carDataEntities.ebLists
                .Where(m => m.make == selectedMake)
                .Select(m => new { model = m.model })
                .Distinct()
                .OrderBy(m => m.model)
                .ToList();

            cbModel.DisplayMember = "model";
            cbModel.DataSource = carsModels;

        }

        private void cbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedYear = cbYear.GetItemText(cbYear.SelectedValue);

            //MessageBox.Show($"{selectedYear.GetType()}");

            var carMakes = carDataEntities.ebLists
                .Where(y => y.year.ToString() == selectedYear)
                .Select(c => new { make = c.make })
                .Distinct()
                .OrderBy(c => c.make)
                .ToList();

            cbMake.DisplayMember = "make";
            cbMake.DataSource = carMakes;

            
        }
    }
}
