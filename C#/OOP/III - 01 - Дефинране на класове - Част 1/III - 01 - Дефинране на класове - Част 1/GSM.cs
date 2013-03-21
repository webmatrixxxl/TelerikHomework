using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace III___01___Дефинране_на_класове___Част_1
{
    class GSM
    {

        public Display Display = new Display();
        public Battery Battery = new Battery("");

        //<fields>
        private string model;
        private string manufacturer;
        private decimal? price;
        private string owner;
        
        private static GSM iphone4S;

        public List<Call> callHistory = new List<Call>();

        private const decimal pricePerMinet = 0.37M;

        //<fields>




        //<constructors>
        public GSM(string model, string manufacturer)
            : this(model, manufacturer, null, null, null, null)
        {

        }
        public GSM(string model, string manufacturer, decimal? price)
            : this(model, manufacturer, price, null, null, null)
        {

        }
        public GSM(string model, string manufacturer, decimal? price, string owner)
            : this(model, manufacturer, price, owner, null, null)
        {

        }
        public GSM(string model, string manufacturer, decimal? price, string owner, Battery Battery, Display Display)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner = owner;
            this.Battery = Battery;
            this.Display = Display;
        }

        static GSM()
        {
            iphone4S = new GSM("4S", "Apple");
        }
        //</constructors>

        //<properties>
        public string Model
        {
            get
            {
                return this.model;
            }

            set
            {
                if (value != null && value != string.Empty)
                {
                    this.model = value;
                }
                else
                {
                    throw new System.ArgumentException("Model value cannot be null or empty string", "Model");
                }
            }
        }
        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }

            set
            {
                if (value != null && value != string.Empty)
                {
                    this.manufacturer = value;
                }
                else
                {
                    throw new System.ArgumentException("Manufacturer value cannot be null or empty string", "Model");
                }
            }
        }
        public decimal? Price
        {
            get
            {
                return this.price;
            }

            set
            {
                this.price = value;
            }
        }
        public string Owner
        {
            get
            {
                return this.owner;
            }

            set
            {
                this.owner = value;
            }
        }

        public static GSM Iphone4S
        {
            get { return iphone4S; }
        }
        public List<Call> CallHistory
        {
            get
            {
                return this.callHistory;
            }
        }
        
        //</properties>

        //<methods>
        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.AppendLine("GSM Model: " + Model);
            str.AppendLine("GSM Manufacturer: " + Manufacturer);
            str.AppendLine("GSM Price: " + Price + " лв.");
            str.AppendLine();
            if (this.Battery != null)
            {
                str.AppendLine("Battery Model: " + Battery.Model);
                str.AppendLine("Battery Type: " + Battery.BatType);
                str.AppendLine("Battery Idle Time: " + Battery.Idle + " hours");
                str.AppendLine("Battery Talk Hours: " + Battery.Talk + " hours");
            }
            if (this.Display != null)
            {
                str.AppendLine();
                str.AppendLine("Display Width: " + Display.Width + "\"");
                str.AppendLine("Display Height: " + Display.Height + "\"");
                str.AppendLine("Display Colors: " + Display.Colors + "M");
                str.AppendLine();
            }

            str.AppendLine("GSM Owner: " + Owner);

            return str.ToString();
        }

        public void AddCall(string phoneNumber, int duration)
        {
            Call myCall = new Call(phoneNumber, duration);
            callHistory.Add(myCall);
        }

        public void RemoveCall(string phoneNumber)
        {
            for (int i = 0; i < callHistory.Count; i++)
            {
                if (callHistory[i].PhoneNumber == phoneNumber)
                {
                    callHistory.RemoveAt(i);
                    i--;
                }
            }
        }

        public void ClearHistory()
        {
            callHistory.Clear();
        }

        public decimal TotalPrice()
        {
            decimal wholeTime = 0;
            for (int i = 0; i < callHistory.Count; i++)
            {
                wholeTime = wholeTime + callHistory[i].Duration;
            }

            decimal price = pricePerMinet * (wholeTime / 60);
            return price;
        }
        //</methods>

    }
}
