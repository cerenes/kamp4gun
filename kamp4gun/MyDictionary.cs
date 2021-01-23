using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kamp4gun
{
    class MyDictonary<TValue, TKey>
    {
        TValue[] values;
        TKey[] keys;

        public MyDictonary()
        {
            values = new TValue[0];
            keys = new TKey[0];
        }

        public void Add(TValue val, TKey key)
        {
            TValue[] tempVals = values;
            TKey[] tempKeys = keys;


            values = new TValue[values.Length + 1];
            keys = new TKey[keys.Length + 1];

            for (int i = 0; i < tempVals.Length; i++)
            {
                values[i] = tempVals[i];
                keys[i] = tempKeys[i];


            }
            
        }
        public int Count
        {
            get { return values.Length; }
        }
    }
}




