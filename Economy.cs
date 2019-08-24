using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalProjectAAAGuide
{
    class Economy : Vehicle
    {
        // Field
        private string hatchback;
        private string color;
        private int speed;
        

        // hatchback Constructor
        public Economy()
        {
            hatchback = "";
        }

        // color constructor
        public Economy(string _color)
            : base("White")
        {
            color = _color;
        }

        // speed constructor
        public Economy(int _speed)
            : base()
        {
            speed = _speed;
        }



        // HatchBack property
        public string HatchBack
        {
            get { return hatchback; }
            set { hatchback = value; }
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

        // VehicleTypeNoise method
        public override void vehicleTypeNoises()
        {
            base.vehicleTypeNoises();
            {
                MessageBox.Show("Putter Putter");
            }
        }


    }
        }

        
