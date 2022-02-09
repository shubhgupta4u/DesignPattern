using System;
using System.Collections;
using System.Collections.Generic;

namespace DesignPattern.Demo.Entities.Meal
{
    public class Meal : IList<IItem>,IMeal
    {
        private readonly List<IItem> items;
        private bool _readOnly = false;

        public Meal()
        {
            this.items = new List<IItem>();
        }
        public Meal(List<IItem> items, bool readOnly)
        {
            this.items = items;
            this._readOnly = readOnly;
        }
        public void MarkReadOnly()
        {
            this.IsReadOnly = true;
        }

        #region IMeal
        public float GetCost()
        {
            float cost = 0.0f;

            foreach (IItem item in this.items)
            {
                cost += item.Price;
            }
            return cost;
        }

        public void DisplayOrder()
        {

            foreach (IItem item in this.items)
            {
                Console.WriteLine("Item : " + item.Name);
                item.Packing.Pack();
                Console.WriteLine("Item : " + item.Price);
            }
        }

        #endregion

        #region IList<IItem>
        public IItem this[int index]
        {
            get { return this.items[index]; }
            set { this.items[index] = value; }
        }

        public bool IsReadOnly
        {
            get { return this._readOnly; }
            private set { this._readOnly = value; }
        }

        public int Count
        {
            get { return this.items.Count; }
        }

        public void Add(IItem value)
        {
            if (!this.IsReadOnly)
            {
                this.items.Add(value);
            }            
        }

        public void Clear()
        {
            if (!this.IsReadOnly)
            {
                this.items.Clear();
            }
        }

        public bool Contains(IItem value)
        {
            return this.items.Contains(value);
        }

        public void CopyTo(IItem[] array, int arrayIndex)
        {
            this.items.CopyTo(array,arrayIndex);
        }

        public IEnumerator GetEnumerator()
        {
            return this.items.GetEnumerator();
        }
        IEnumerator<IItem> IEnumerable<IItem>.GetEnumerator()
        {
            return this.items.GetEnumerator();
        }

        public int IndexOf(IItem value)
        {
            return this.items.IndexOf(value);
        }

        public void Insert(int index, IItem value)
        {
            if (!this.IsReadOnly)
            {
                this.items.Insert(index, value);
            }
        }

        public bool Remove(IItem value)
        {
            if (!this.IsReadOnly)
            {
                return this.items.Remove(value);
            }
            else
            {
                return false;
            }
        }

        public void RemoveAt(int index)
        {
            if (!this.IsReadOnly)
            {
                this.items.RemoveAt(index);
            }
        }
        #endregion
    }
}
