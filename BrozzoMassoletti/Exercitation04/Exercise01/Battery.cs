using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01
{
    public enum BatteryType { LiIon, NiMH, NiCd }

    public class Battery
    {
        private string model = null;
        private string idle = null;
        private int talkhours = 0;
        private BatteryType type = BatteryType.LiIon;

        public Battery(string model, string idle, int talkhours)
        {
            this.model = model;
            this.idle = idle;
            this.talkhours = talkhours;
        }
        public Battery(string model, string idle, int talkhours, BatteryType type)
        {
            this.model = model;
            this.idle = idle;
            this.talkhours = talkhours;
            this.type = type;
        }

        public string Model { get; set; }
        public string Idle { get; set; }
        public int Talkhours { get; set; }
        public BatteryType Type { get; set; }


    }
}
