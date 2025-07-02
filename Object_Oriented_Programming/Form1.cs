using Object_Oriented_Programming.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Object_Oriented_Programming
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Car car = new Car();


            car.Brand = "bmw";
            car.model = "2021";
            car.Color = "black";
            car.Speed = "200";
            car.Gear = "5";

            MessageBox.Show($"{car.Brand} markalı arac{car.Gear} vitesle e-5 uzerinde{car.Speed} ile seyahat etmektedir");
        }
    }
}
