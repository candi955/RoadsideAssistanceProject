using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalProjectAAAGuide
{
    class Intermediate : Vehicle
    {
        // Field
        private string honkInKeysFAD;
        private string color;
        private int speed;



        // honkInKeysFAD Constructor
        public Intermediate()
        {
            honkInKeysFAD = "";
        }

        // color constructor
        public Intermediate(string _color)
            : base("Silver")
        {
            color = _color;
        }

        // speed constructor
        public Intermediate(int _speed)
            : base()
        {
            speed = _speed;
        }

        // HonkInKeysFAD property
        public string HonkInKeysFAD
        {
            get { return honkInKeysFAD; }
            set { honkInKeysFAD = value; }
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


        // vehicleTypeNoise method
        public override void vehicleTypeNoises()
        {
            base.vehicleTypeNoises();
            {
                MessageBox.Show("Sputter, Sputter");


            }
        }
    }
}


