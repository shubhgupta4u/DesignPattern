using System;
using System.Collections;
using System.Collections.Generic;

namespace DesignPattern.Demo.Entities.MasterData
{
    public class MasterDataList<T> : IList<T> where T : ICloneable
    {
        private readonly List<T> items;
        private bool _readOnly = false;

        public MasterDataList()
        {
            this.items = new List<T>();
        }
        public MasterDataList(IEnumerable<T> items, bool readOnly)
        {
            this.items = new List<T>(items);
            this._readOnly = readOnly;
        }
        #region IList<T>
        public T this[int index]
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

        public void Add(T item)
        {
            if (!this.IsReadOnly)
            {
                this.items.Add(item);
            }
        }

        public void Clear()
        {
            if (!this.IsReadOnly)
            {
                this.items.Clear();
            }
        }

        public bool Contains(T item)
        {
            return this.items.Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            this.items.CopyTo(array, arrayIndex);
        }

        public IEnumerator GetEnumerator()
        {
            return this.items.GetEnumerator();
        }
        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return this.items.GetEnumerator();
        }

        public int IndexOf(T item)
        {
            return this.items.IndexOf(item);
        }

        public void Insert(int index, T item)
        {
            if (!this.IsReadOnly)
            {
                this.items.Insert(index, item);
            }
        }

        public bool Remove(T item)
        {
            if (!this.IsReadOnly)
            {
                return this.items.Remove(item);
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

        public MasterDataList<T> Clone()
        {
            MasterDataList<T> cloneItems = new MasterDataList<T>();
            foreach (T item in this.items)
            {
                cloneItems.Add((T)item.Clone());
            }
            return cloneItems;
        }
    }
}
