using System;

namespace DefiningClasses
{
    public class Battery
    {
        //Battery fields
        private string model;
        private short idleHours;
        private byte hoursTalk;
        private BatteryType batteryType;
        
        //Battery constructors
        public Battery()
            : base()
        {
        }

        public Battery(string model)
        {
            this.Model = model;
        }

        public Battery(string model, short idleHours) 
            : this(model)
        {
            this.IdleHours = idleHours;
        }

        public Battery(string model, short idleHours, byte hoursTalk)
            : this(model, idleHours)
        {
            this.HoursTalk = hoursTalk;
        }

        public Battery(string model, short idleHours, byte hoursTalk, BatteryType batteryType) 
            : this(model, idleHours, hoursTalk)
        {
            this.BatteryType = batteryType;
        }

        //Battery properties
        public string Model
        {
            get 
            { 
                return this.model; 
            }
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Model cannot be an empty string!");
                }

                this.model = value; 
            }
        }

        public short IdleHours
        {
            get 
            { 
                return this.idleHours; 
            }
            set 
            {
                if (value <= 0 || value > 1500)
                {
                    throw new ArgumentOutOfRangeException("Idle hours must be between 1 and 1500!");
                }

                this.idleHours = value; 
            }
        }

        public byte HoursTalk
        {
            get 
            { 
                return this.hoursTalk; 
            }
            set 
            {
                if (value <= 0 || value > 50)
                {
                    throw new ArgumentOutOfRangeException("Talk hours must be between 1 and 50!");
                }

                this.hoursTalk = value; 
            }
        }

        public BatteryType BatteryType
        {
            get 
            { 
                return this.batteryType; 
            }
            set 
            { 
                this.batteryType = value; 
            }
        }
    }
}
