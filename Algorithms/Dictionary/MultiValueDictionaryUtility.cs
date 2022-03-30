using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dictionary
{
    public class MultiValueDictionaryUtility
    {
        public static IList<string> GetList(MultiValueDictionary<string, string> mvd, string key)
        {
            return mvd.Get(key).ToList();
        }
    }
}
