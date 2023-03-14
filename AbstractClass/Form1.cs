using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractClass
{
    public partial class Form1 : Form
    {
        Car car = new Car();
        Bycicle bycicle = new Bycicle();
        Boat boat = new Boat();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(car.Go()) == DialogResult.OK)
            {
                MessageBox.Show(car.Trick());
            }
        }

        private void btnBycicle_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(bycicle.Go()) == DialogResult.OK)
            {
                MessageBox.Show(bycicle.Trick());
            }
        }

        private void btnBoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(boat.Go()) == DialogResult.OK)
            {
                MessageBox.Show(boat.Trick());
            }
        }
    }
}
