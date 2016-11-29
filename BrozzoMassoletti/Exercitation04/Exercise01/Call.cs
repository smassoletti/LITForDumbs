using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01
{
    public class Call
    {
        string numberCall;
        int durationCall;
        DateTime timeCall;

        public Call(string numberCall, int durationCall)
        {
            this.numberCall = numberCall;
            this.durationCall = durationCall;
            this.timeCall = DateTime.Now;
        }

        public string NumberCall
        {
            get { return this.numberCall; }
        }

        public int DurationCall
        {
            get { return this.durationCall; }
        }

        public DateTime TimeCall
        {
            get { return this.timeCall; }
        }

        public override string ToString()
        {
            StringBuilder strb = new StringBuilder();
            strb.Append(string.Format("Phone number: {0}", this.numberCall)).AppendLine();
            strb.Append(string.Format("Duration: {0}", this.durationCall)).AppendLine();
            strb.Append(string.Format("Time: {0}", this.timeCall.ToString())).AppendLine();
            return strb.ToString();
        }


    }
}
