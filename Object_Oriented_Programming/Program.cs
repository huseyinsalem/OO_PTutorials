using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Object_Oriented_Programming.Models;

namespace Object_Oriented_Programming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();


            car.Brand = "bmw";
            car.model = "2021";
            car.Color = "black";
            car.Speed = "200";
            car.Gear = "5";

            MessageBox.Show($"{car.model} model {car.Color} renkli {car.Brand} markalı arac {car.Gear} .vitesle e-5 uzerinde {car.Speed} ile seyahat etmektedir");
        }

    }
}
