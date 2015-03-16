using System;

namespace DefiningClasses
{
    class Call
    {
        //Call fields
        private DateTime date;
        private string number;
        private int duration;

        //Call constructor
        public Call(DateTime date, string number, int duration)
            : base()
        {
            this.Date = date;
            this.Number = number;
            this.Duration = duration;
        }

        //Call properties
        public DateTime Date
        {
            get 
            { 
                return this.date; 
            }
            set 
            { 
                this.date = value; 
            }
        }

        public string Number
        {
            get 
            { 
                return this.number; 
            }
            set 
            { 
                this.number = value; 
            }
        }

        public int Duration
        {
            get 
            { 
                return this.duration; 
            }
            set 
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The length of the call must be more than 0 seconds!");
                }

                this.duration = value; 
            }
        }

    }
}
