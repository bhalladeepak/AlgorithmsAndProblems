using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dictionary
{
    public static class MultiValueDictionaryExtensions
    {
        public static IList<String> GetList<TKey, TValue> (this MultiValueDictionary<TKey, TValue> mvd, TKey key)
        {
            return mvd.Get(key).ToList();
        }

        public static int GetHashCode<TKey, TValue>(this MultiValueDictionary<TKey, TValue> mvd, TKey key)
        {
            int hashCode = mvd.Get(key).GetHashCode();
            return hashCode;
        }
    }
}
