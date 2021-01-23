using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryIntro
{
    class MyDictionary<K,V>
    {
        K[] _key;
        K[] _tempKey;

        V[] _value;
        V[] _tempValue;


        public MyDictionary()
        {
            _key = new K[0];
            _value = new V[0];
        }

        public void Add(K key, V value)
        {
            _tempKey = _key;
            _key = new K[_key.Length + 1];
            for (int i = 0; i < _tempKey.Length; i++)
            {
                _key[i] = _tempKey[i];
            }
            _key[_key.Length - 1] = key;

            _tempValue = _value;
            _value = new V[_value.Length + 1];
            for (int i = 0; i < _tempValue.Length; i++)
            {
                _value[i] = _tempValue[i];
            }
            _value[_value.Length - 1] = value;
        }

        public void List()
        {
            for (int i = 0; i < _key.Length; i++)
            {
                Console.WriteLine("Key : " + _key[i] + " Value : " + _value[i]);
            }
        }


        public int Count
        {
            get { return _key.Length; }

        }
    }
}
