using System;

namespace ISTA421___20200404___ZSilvis___EX_2A__Key_Value_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Update a previous key-value dictionary to have a generic type parameter.\n");
        }

        public struct KeyValue<T>
        {
            public readonly string _key;
            public readonly T _value;
            public KeyValue(string Key, T Value)
            {
                this._key = Key;
                this._value = Value;
            }
        }
        public class MyDictionary<T>
        {
            private KeyValue<T>[] _dictionaryKV = new KeyValue<T>[10];
            private int _numItems;
            public int NumItems
            {
                get { return this._numItems; }
                private set { this._numItems = CountOfItems(); }
            }
            private int CountOfItems()
            {
                int countOfItems = _dictionaryKV.Length;
                return countOfItems;
            }
            public T this[string indexKey]
            {
                get { return FindValue(indexKey); }
                set
                {
                    if (FindValue(indexKey) == null)
                    {
                        PostNewValue(indexKey, value);
                    }
                    else
                    {
                        UpdateValue(indexKey, value);
                    }
                }
            }
            public T FindValue(string indexKey)
            {
                T Value = default(T);
                for (int i = 0; i < _dictionaryKV.Length; i++)
                {
                    if (_dictionaryKV[i]._key == indexKey)
                    {
                        Value = _dictionaryKV[i]._value;
                    }
                }
                return Value;
            }
            public void PostNewValue(string indexKey, T value)
            {
                KeyValue<T> newKeyValue = new KeyValue<T>(indexKey, value);
                for (int i = 0; i < _dictionaryKV.Length; i++)
                {
                    if (_dictionaryKV[i]._value == null)
                    {
                        _dictionaryKV[i] = newKeyValue;
                        break;
                    }
                }
            }
            public void UpdateValue(string indexKey, T value)
            {
                for (int i = 0; i < _dictionaryKV.Length; i++)
                {
                    if (_dictionaryKV[i]._key == indexKey)
                    {
                        KeyValue<T> updatedKeyValue = new KeyValue<T>(indexKey, value);
                        _dictionaryKV[i] = updatedKeyValue;
                        break;
                    }
                }
            }
        }
    }
}
