using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalProjectAAAGuide
{
    class FullSize : Vehicle
    {
        // Field
        private string customCarSpeaker;
        private string color;
        private int speed;


        // customCarSpeaker Constructor
        public FullSize()
        {
            customCarSpeaker = "";
        }

        // color constructor
        public FullSize(string _color)
            : base("Red")
        {
            color = _color;
        }

        // speed constructor
        public FullSize(int _speed)
            : base()
        {
            speed = _speed;
        }

        // CustomCarSpeaker property
        public string CustomCarSpeaker
        {
            get { return customCarSpeaker; }
            set { customCarSpeaker = value; }
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
                MessageBox.Show("Rev Rev");

            }
        }
    }
}

    
