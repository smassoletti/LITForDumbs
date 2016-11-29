using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01
{
    public class GSM
    {
        private string model;
        private string manufacturer;
        private float price;
        private string owner;
        static private GSM SamsungGalaxyS7;
        private Display screen;
        private Battery battery;
        static GSM() { SamsungGalaxyS7 = new GSM("GalaxyS7", "Samsung", 449.99f, "Gianni", new Battery("BTC-SMG930SL", "diocane", 22, BatteryType.LiIon), new Display(5.1f, 16M)); }
        public List<Call> CallHistory = new List<Call>();

        public GSM(string model)
            : this(model, null) { }
        public GSM(string model, string manufacturer)
            : this(model, manufacturer, 0f) { }
        public GSM(string model, string manufacturer, float price)
            : this(model, manufacturer, price, null) { }
        public GSM(string model, string manufacturer, float price, string owner)
            : this(model, manufacturer, price, owner, new Battery(null, null, 0)) { }
        public GSM(string model, string manufacturer, float price, string owner, Battery battery)
            : this(model, manufacturer, price, owner, battery, null) { }
        public GSM(string model, string manufacturer, float price, string owner, Battery battery, Display screen)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner = owner;
            this.battery = battery;
            this.screen = screen;
        }

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }
        public string Manufacturer
        {
            get { return this.manufacturer; }
            set { this.manufacturer = value; }
        }
        public float Price
        {
            get { return this.price; }
            set
            {
                if (value >= 0)
                    this.price = value;
                else
                    throw new IndexOutOfRangeException("Negative prices are just a dream");
            }
        }
        public string Owner
        {
            get { return this.owner; }
            set { this.owner = value; }
        }
        public Battery Battery { get; set; }
        public Display Display { get; set; }
        public override string ToString()
        {
            StringBuilder strb = new StringBuilder();
            strb.Append(string.Format("Model: {0}", this.Model)).AppendLine();
            strb.Append(string.Format("Manufacturer: {0}", this.Manufacturer)).AppendLine();
            strb.Append(string.Format("Price: {0}", this.Price)).AppendLine();
            strb.Append(string.Format("Owner: {0}", this.Owner)).AppendLine();
            strb.Append(string.Format("Battery: {0}", this.battery)).AppendLine();
            strb.Append(string.Format("Display: {0}", this.screen)).AppendLine();
            return strb.ToString();
        }

        public void AddCall(string number, int duration )
        {
            this.CallHistory.Add(new Call(number, duration));
        }

        //3 tipi di rimuovi chiamate    
        public void DeleteCall(int duration)
        {
            this.CallHistory.RemoveAll(call => call.DurationCall == duration);
        }
        public void DeleteCall(string dialedNumber)
        {
            this.CallHistory.RemoveAll(call => call.NumberCall == dialedNumber);
        }
        public void DeleteCall(DateTime timeCall)
        {
            this.CallHistory.RemoveAll(call => call.TimeCall == timeCall);
        }
        public void DeleteCallList()
        {
            this.CallHistory.Clear();
        }
        public decimal PriceCall(decimal rate)
        {
            decimal price = 0;
            foreach (var item in this.CallHistory)
            {
                price += item.DurationCall * rate;
            }
            return price;
        }
        public string CallInfo()
        {
            if (this.CallHistory.Count > 0)
            {
                StringBuilder strb = new StringBuilder();
                foreach (var item in this.CallHistory)
                    strb.Append(item).AppendLine();
                return strb.ToString();
            }
            else
            {
                return "Current calls history is empty.\n";
            }
        }
    }
}
