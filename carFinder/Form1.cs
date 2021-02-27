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
            var cars = carDataEntities.ebLists
              .Select(c => new { make = c.make })
             .Distinct()
             .OrderBy(c => c.make)
             .ToList();

            cbMake.DisplayMember = "make";
            
            cbMake.DataSource = cars;


        }


    }
}
