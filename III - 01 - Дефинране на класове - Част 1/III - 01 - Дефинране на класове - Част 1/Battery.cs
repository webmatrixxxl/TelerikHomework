using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace III___01___Дефинране_на_класове___Част_1
{
    //<enum>
    public enum BatteryType
    {
        Null, LiIon, NiMH, NiCd
    }
    //</enum

    class Battery
    {
        //<fields>
        private string model;
        private int? hoursIdle;
        private int? hoursTalk;
        private BatteryType batteryType;
        //</fields>

        //<construcotrs>
        public Battery(string model)
            : this(model, null, null, BatteryType.Null)
        {
            
        }

        public Battery(string model, int? hoursIdle, int? hoursTalk, BatteryType batteryType)
        {
            this.model = model;
            this.hoursIdle = hoursIdle;
            this.hoursTalk = hoursTalk;
            this.batteryType = batteryType;
        }

        //</construcotrs>

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


        public int? Idle
        {
            get
            {
                return this.hoursIdle;
            }

            set
            {
                if (value > 0 || value == null)
                {
                    this.hoursIdle = value;
                }
                else
                {
                    throw new System.ArgumentException("Idle value must be larger than zero", "Idle");
                }
            }
        }

        public int? Talk
        {
            get
            {
                return this.hoursTalk;
            }

            set
            {
                if (value > 0 || value == null)
                {
                    this.hoursTalk = value;
                }
                else
                {
                    throw new System.ArgumentException("Talk value must be larger than zero", "Talk");
                }
            }
        }

        public BatteryType BatType
        {
            get { return this.batteryType; }
            set { this.batteryType = value; }
        }
        //</properties>

    }
}
