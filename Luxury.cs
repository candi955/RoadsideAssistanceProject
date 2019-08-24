using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalProjectAAAGuide
{
    class Luxury : Vehicle
    {
        // Field
        private string backUpCamera;
        private string color;
        private int speed;


        // backUpCamera Constructor
        public Luxury()
        {
            backUpCamera = "";
        }

        public Luxury(string _color)
            : base("Black")
        {
            color = _color;
        }

        // speed constructor
        public Luxury(int _speed)
            : base()
        {
            speed = _speed;
        }

        // BackUpCamera property
        public string BackUpCamera
        {
            get { return backUpCamera; }
            set { backUpCamera = value; }

        }

        // Color property
        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        // Speed Limiter property
        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        // VehicleTypeNoises method
        public override void vehicleTypeNoises()
        {
            base.vehicleTypeNoises();
            {
                MessageBox.Show("Whirr!");

            }
        }
    }
}
