namespace _05_07.GenericList
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    internal class GenericList<T> where T : IComparable<T>
    {
        //Fields
        private T[] list;
        private int capacity;
        private int count = 0;

        //Constructor
        public GenericList(int capacity)
        {
            this.list = new T[capacity];
            this.capacity = capacity;
        }

        //Properties
        public T[] List
        {
            get { return this.list; }
        }

        public int Capacity
        {
            get { return this.capacity; }
        }

        //Methods
        public T this[int index]
        {
            get
            {
                return AccessByIndex(index);
            }
        }

        public void AddElement(T element)
        {
            this.list[count] = element;
            count++;

            if (this.capacity == this.count)
            {
                this.DoubleSize();
            }
        }

        private void DoubleSize()
        {
           int length = this.list.Length;
           T[] newList = new T[length * 2];
           this.capacity = length * 2;

           for (int i = 0; i < length; i++)
           {
               newList[i] = this.list[i]; 
           }

           this.list = newList;
        }

        public T AccessByIndex(int index)
        {
            if (index < 0 || index > this.list.Length - 1)
            {
                throw new IndexOutOfRangeException("The index is outside the boundaries of the GenericList!");
            }

            return this.list[index];
        }

        public void RemoveElement(int index)
        {
            if (index < 0 || index > this.list.Length - 1)
            {
                throw new IndexOutOfRangeException("The index is outside the boundaries of the GenericList!");
            }

            for (int i = index + 1; i < this.list.Length; i++)
            {
                this.list[i - 1] = this.list[i];
            }

            this.count--;
        }

        public void InsertElement(int index, T element)
        {
            if (index < 0 || index > this.list.Length - 1)
            {
                throw new IndexOutOfRangeException("The index is outside the boundaries of the GenericList!");
            }

            if (this.capacity <= this.count)
            {
                this.DoubleSize();
            }

            for (int i = count; i > index; i--)
            {
                this.list[i] = this.list[i - 1];
            }

            this.list[index] = element;
            this.count++;
        }

        public void ClearList()
        {
            int length = this.list.Length;
            T[] newList = new T[length];
            this.list = newList;
            this.count = 0;
        }

        public int FindElementByValue(T element)
        {
            int index = -1;

            for (int i = 0; i < this.list.Length; i++)
            {
                if (element.Equals(this.list[i]))
                {
                    index = i;
                    break;
                }
            }

            return index;
        }

        public T Min()
        {
            if (this.count == 0)
            {
                throw new NullReferenceException("There is no elements in the list!");
            }

            T min = this.list[0];

            for (int i = 0; i < this.count; i++)
            {
                if (this.list[i].CompareTo(min) == -1)
                {
                    min = this.list[i];
                }
            }
            return min;
        }

        public T Max()
        {
            if (this.count == 0)
            {
                throw new NullReferenceException("There is no elements in the list!");
            }

            T max = this.list[0];

            for (int i = 0; i < this.count; i++)
            {
                if (this.list[i].CompareTo(max) == 1)
                {
                    max = this.list[i];
                }
            }
            return max;
        }

        public override string ToString()
        {
            if (this.count == 0)
            {
                return "The GenericList is empty!";
            }

            StringBuilder result = new StringBuilder();

            for (int i = 0; i < this.count; i++)
            {
                result.Append(this.list[i] + " ");
            }

            return result.ToString();
        }
    }
}
