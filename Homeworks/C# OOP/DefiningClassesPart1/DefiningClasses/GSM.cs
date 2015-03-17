using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    class GSM
    {
        //Constant
        private const decimal callPrice = 0.37M;

        //GSM fields
        private static GSM iPhone4S = new GSM("iPhone4S", "Apple", 1300, "Pesho",
            new Battery("NonRemovable", 200, 14, BatteryType.LiIonPolymer),
            new Display(3.5, 16000000));
      
        private string model;
        private string manufacturer;
        private decimal? price;
        private string owner;
        private Battery battery;
        private Display display;
        private List<Call> calls = new List<Call>();

        //GSM constructors
        public GSM(string model, string manufacturer)
            : base()
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
        }

        public GSM(string model, string manufacturer, decimal price) 
            : this(model, manufacturer)
        {
            this.Price = price;
        }

        public GSM(string model, string manufacturer, decimal price, string owner) 
            : this(model, manufacturer, price)
        {
            this.Owner = owner;
        }

        public GSM(string model, string manufacturer, decimal price, string owner, Battery battery) 
            : this(model, manufacturer, price, owner)
        {
            this.battery = battery;
        }

        public GSM(string model, string manufacturer, decimal price, string owner, Battery battery, Display display)
            : this(model, manufacturer, price, owner, battery)
        {
            this.display = display;
        }

        //GSM properties
        public static GSM IPhone4S
        {
            get { return GSM.iPhone4S; }
        }

        public string Model
        {
            get
            {
                if (string.IsNullOrEmpty(this.model))
                {
                    throw new NullReferenceException("There is no GSM's model specified!");
                } 

                return this.model;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The GSM's model cannot be null or empty string!");
                }

                this.model = value; 
            }
        }

        public string Manufacturer
        {
            get
            {
                if (string.IsNullOrEmpty(this.manufacturer))
                {
                    throw new NullReferenceException("There is no GSM's manufacturer specified!");
                }

                return this.manufacturer;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The GSM's manufacturer cannot be null or empty string!");
                }

                this.manufacturer = value;
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
                if (price <= 0)
                {
                    throw new ArgumentOutOfRangeException("The price must be a positive value, larger than 0!");
                }

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

        public Battery Battery
        {
            get
            {
                return this.battery;
            }
        }

        public Display Display
        {
            get
            {
                return this.display;
            }
        }

        public List<Call> Calls
        {
            get 
            {
                return this.calls; 
            }
        }

        //GSM methods
        public override string ToString()
        {
            string owner = this.owner != null ? this.owner : "N/A";
            string price = this.price.HasValue ? this.price.Value.ToString() + " BGN" : "N/A";

            StringBuilder result = new StringBuilder();
            result.AppendLine("Detailed GSM's information: ");
            result.AppendLine("Model: " + this.model);
            result.AppendLine("Manufacturer: " + this.manufacturer);
            result.AppendLine("Price: " + price);
            result.AppendLine("Owner: " + owner);

            return result.ToString();
        }

        public void AddCalls(Call call)
        {
            this.calls.Add(call);
        }

        public void DeleteCalls(int index)
        {
            if (index < 0 || index > calls.Count - 1)
            {
                throw new ArgumentOutOfRangeException("The index of the call must be between 0 and calls.Count - 1!");
            }

            this.calls.RemoveAt(index);
        }

        public void ClearCallHistory()
        {
            this.calls.Clear();
        }

        public decimal CalculateTotalPrice()
        {
            decimal result = 1;

            foreach (Call call in this.calls)
            {
                result += call.Duration * callPrice;
            }

            return result;
        }
    }
}
