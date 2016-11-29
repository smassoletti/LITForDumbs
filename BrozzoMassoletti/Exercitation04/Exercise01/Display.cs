using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01
{
    public class Display
    {
        private float size = 0;
        private decimal colors = 0;

        public Display(float size, decimal colors)
        {
            this.size = size;
            this.colors = colors;
        }

        public float Size
        {
            get { return this.size; }
            set { this.size = value; }
        }

        public decimal Colors
        {
            get { return this.colors; }
            set { this.colors = value; }
        }
    }
}
