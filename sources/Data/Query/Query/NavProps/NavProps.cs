/*SFF*/
/************************************************
This class has been generated dynamically.
Any changes you make here will be overwritten.
************************************************/

using System;
using System.Collections.Generic;

namespace TheSharpFactory.Data.Query
{

    /// <summary>
    /// This class is a collection of Navigation Properties.
    /// </summary>
    public class NavProps:List<NavProp>
    {
        private readonly Dictionary<int, NavProp> _items;
        /// <summary>
        /// Returns the total count of the entire tree. Takes into account all sub navigation properties.
        /// </summary>
        /// <value>
        /// int
        /// </value>
        public int TotalCount { get{ return CalculateCount(this); }  }

        public NavProps() : base()
        {
            _items = new Dictionary<int, NavProp>();
        }
        public NavProps(int capacity) : base(capacity)
        {
            _items = new Dictionary<int, NavProp>(capacity);
        }
        public NavProp Get(NavProp item) 
        {
            if(!_items.ContainsKey(item.IntValue))
                throw new ArgumentException($"Navigation Property {item.ToString()} does not exist in the collection.");
            return _items[item.IntValue];
        }
        new public void Add(NavProp item) 
        {
            if(_items.ContainsKey(item.IntValue))
                throw new ArgumentException($"Navigation Property {item.ToString()} already exists in the collection.");
            _items.Add(item.IntValue, item);
            base.Add(item);
        }
        new public void Insert(int index, NavProp item) 
        {
            if(_items.ContainsKey(item.IntValue))
                throw new ArgumentException($"Navigation Property {item.ToString()} already exists in the collection.");
            _items.Add(item.IntValue, item);
            base.Insert(index, item);
        }
        new public bool Remove(NavProp item) 
        {
            _items.Remove(item.IntValue);
            return base.Remove(item);
        }
        new public void RemoveAt(int index) 
        {
            _items.Remove(this[index].IntValue);
            base.RemoveAt(index);
        }
        new public bool Contains(NavProp item) 
        {
            return _items.ContainsKey(item.IntValue);
        }
        new public void AddRange(IEnumerable<NavProp> collection) 
        {
            throw new NotSupportedException("This feature is not supported.");
        }
        new public void InsertRange(int index, IEnumerable<NavProp> collection) 
        {
            throw new NotSupportedException("This feature is not supported.");
        }
        new public void RemoveRange(int index, int count) 
        {
            throw new NotSupportedException("This feature is not supported.");
        }
        new public int RemoveAll(Predicate<NavProp> match) 
        {
            throw new NotSupportedException("This feature is not supported.");
        }
        private int CalculateCount(NavProps list) 
        {
            if(list == null)
                return 0;
            var totalCount = list.Count;
            foreach(var item in list)
                totalCount += CalculateCount(item.NavProps);
            return totalCount;
        }
    }

    /// <summary>
    /// This class is a collection of Navigation Properties.
    /// </summary>
    public sealed class NavProps<TNavPropEnum>:NavProps where TNavPropEnum : struct, IComparable, IFormattable, IConvertible
    {
        public NavProps() : base()
        {
        }
        public NavProps(int capacity) : base(capacity)
        {
        }
        public NavProp Get(TNavPropEnum item) 
        {
            return base.Get(new NavProp<TNavPropEnum>(item));
        }
        public void Add(TNavPropEnum item) 
        {
            base.Add(new NavProp<TNavPropEnum>(item));
        }
        public bool Remove(TNavPropEnum item) 
        {
            return base.Remove(new NavProp<TNavPropEnum>(item));
        }
        new public void RemoveAt(int index) 
        {
            base.RemoveAt(index);
        }
        public bool Contains(TNavPropEnum item) 
        {
            return base.Contains(new NavProp<TNavPropEnum>(item));
        }
    }
}
