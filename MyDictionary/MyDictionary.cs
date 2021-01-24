using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    public class MyDictionary<TKey, TValue>
    {
        TKey[] itemKeys;
        TValue[] itemValues;

        public MyDictionary()
        {
            itemKeys = new TKey[0];
            itemValues = new TValue[0];
        }

        public void Add(TKey key, TValue value)
        {
            TKey[] tempKeyArray = itemKeys;
            TValue[] tempValueArray = itemValues;

            itemKeys = new TKey[itemKeys.Length + 1];
            itemValues = new TValue[itemValues.Length + 1];

            for (int i = 0; i < tempKeyArray.Length; i++)
            {
                itemKeys[i] = tempKeyArray[i];
                itemValues[i] = tempValueArray[i];
            }
            itemKeys[itemKeys.Length - 1] = key;
            itemValues[itemValues.Length - 1] = value;

        }

        public void List()
        {
            for (int i = 0; i < itemKeys.Length; i++)
            {
                Console.WriteLine(itemKeys[i] + " , " + itemValues[i]);
            }
        }
        public int Count { get { return itemKeys.Length;} }
    
}

    
}
