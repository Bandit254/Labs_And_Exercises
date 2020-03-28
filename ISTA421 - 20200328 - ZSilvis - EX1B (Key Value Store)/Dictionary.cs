using System;
using System.Collections.Generic;
using System.Text;

namespace ISTA421___20200328___ZSilvis___EX1B__Key_Value_Store_
{
    public class MyDictionary
    {
        private KeyValue[] _dictionaryKV = new KeyValue[10];
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
        public object this [string indexKey]
        {
            get { return FindValue(indexKey); }
            set 
            {
                if (FindValue(indexKey) == null)
                {
                    PostNewValue(indexKey, value);
                    //KeyValue newKeyValue = new KeyValue(indexKey, value);
                }
                else
                {
                    UpdateValue(indexKey, value);
                }
            }
        }
        public object FindValue(string indexKey)
        {
            object Value=null;
            for (int i = 0; i < _dictionaryKV.Length; i++)
            {
                if (_dictionaryKV[i]._key==indexKey)
                {
                    Value = _dictionaryKV[i]._value;
                }
            }
            return Value;
        }
        public void PostNewValue(string indexKey, object value)
        {
            KeyValue newKeyValue = new KeyValue(indexKey, value);
            for (int i = 0; i < _dictionaryKV.Length; i++)
            {
                if (_dictionaryKV[i]._value==null)
                {
                    _dictionaryKV[i] = newKeyValue;
                    break;
                }
            }
        }
        public void UpdateValue(string indexKey, object value)
        {
            for (int i = 0; i < _dictionaryKV.Length; i++)
            {
                if (_dictionaryKV[i]._key == indexKey)
                {
                    KeyValue updatedKeyValue = new KeyValue(indexKey, value);
                    _dictionaryKV[i]= updatedKeyValue;
                    break;
                }
            }
        }
    }

}
