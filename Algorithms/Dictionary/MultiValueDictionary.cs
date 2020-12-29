using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Dictionary
{
    public interface IMultiValueDictionary<TKey, TValue>
    {
        /// <summary>Adds a value into the dictionary</summary>
        /// <param name="key">Key the value will be stored under</param>
        /// <param name="value">Value that will be stored under the key</param>
        void Add(TKey key, TValue value);

        /// <summary>Determines the number of values stored under a key</summary>
        /// <param name="key">Key whose values will be counted</param>
        /// <returns>The number of values stored under the specified key</returns>
        int CountValues(TKey key);

        /// <summary>
        ///   Removes the item with the specified key and value from the dictionary
        /// </summary>
        /// <param name="key">Key of the item that will be removed</param>
        /// <param name="value">Value of the item that will be removed</param>
        /// <returns>True if the item was found and removed</returns>
        bool Remove(TKey key, TValue value);

        /// <summary>Removes all items of a key from the dictionary</summary>
        /// <param name="key">Key of the items that will be removed</param>
        /// <returns>The number of items that have been removed</returns>
        int RemoveKey(TKey key);

        IEnumerable<string> Get(TKey key);
    }

    public class MultiValueDictionary<TKey, TValue> : IMultiValueDictionary <TKey,TValue>
    {
        private readonly Dictionary<TKey, HashSet<TValue>> _dict;
        public MultiValueDictionary()
        {
            _dict = new Dictionary<TKey, HashSet<TValue>>();
        }
        public void Add(TKey key, TValue value)
        {
            if (_dict.ContainsKey(key))
            {
                HashSet<TValue> container = _dict[key];
                container.Add(value);
            }
            else
            {
                HashSet<TValue> container = new HashSet<TValue>();
                container.Add(value);
                _dict.Add(key, container);
            }
        }

        public int CountValues(TKey key)
        {
            var noOfItems = 0;
            if (_dict.ContainsKey(key))
            {
                HashSet<TValue> container = _dict[key];
                noOfItems = container.Count;
            }
            return noOfItems;
        }

        public bool Remove(TKey key, TValue value)
        {
            bool removed = false;
            
            if (_dict.ContainsKey(key))
            {
                HashSet<TValue> container = _dict[key];
                removed = container.Remove(value);
            }

            return removed;
        }

        public int RemoveKey(TKey key)
        {
            var count = 0;
            if (_dict.ContainsKey(key))
            {
                HashSet<TValue> container = _dict[key];
                count = container.Count;
                _dict.Remove(key);
            }
            return count;
        }

        public IEnumerable<string> Get(TKey key)
        {
            IEnumerable<string> values = new List<string>();

            if (_dict.ContainsKey(key))
            {
                values = (IEnumerable<string>)_dict[key];
            }

            return values;
        }
    }
}
