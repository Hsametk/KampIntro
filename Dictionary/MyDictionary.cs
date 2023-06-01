using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
   class MyDictionary<TKey,TValue>
    {
        TKey[] keys;
        TValue[] values;
        public MyDictionary()
        {
            keys = new TKey[0];
            values = new TValue[0];
        }

        public void Add(TKey key, TValue value)
        {
            TKey[] _tempKeys = keys;
            TValue[] _tempvalue = values;
            keys = new TKey[keys.Length+1];
            values = new TValue[values.Length+1];

            for (int i = 0; i < _tempKeys.Length; i++)
            {
                keys[i] = _tempKeys[i];
                values[i] = _tempvalue[i];
            }
            keys[keys.Length-1] = key;
            values[keys.Length - 1] = value;
        }
        public void see()
        {
            for (int i = 0;i < keys.Length;i++)
            {
                Console.WriteLine(keys[i]+ " : " + values[i]);
            }
        }
        public TKey[] Keys
        {
            get { return keys; }
        }

        public TValue[] Values
        {
            get { return values; }
        }


    }
}
