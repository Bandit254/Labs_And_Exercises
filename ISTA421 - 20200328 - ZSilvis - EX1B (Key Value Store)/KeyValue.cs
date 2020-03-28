using System;
using System.Collections.Generic;
using System.Text;

namespace ISTA421___20200328___ZSilvis___EX1B__Key_Value_Store_
{
    public struct  KeyValue
    {
        public readonly string _key;
        public readonly object _value;
        public KeyValue(string Key, object Value)
        {
            this._key = Key;
            this._value = Value;
        }
    }
   
}
